using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}

		int wrongAttemptsCount = 5;

		void Login()
		{
			if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text) && txtUsername.TextLength > 3)
			{
				string username = txtUsername.Text;
				string password = txtPassword.Text;

				bool lockoutCheck = CheckLockouts();

				if (lockoutCheck)
				{
					using (SqlConnection con = Connection.Connect())
					{
						con.Open();
						string queryLogin = "SELECT * FROM Users inner join UserDetails on users.UsersID = UserDetails.UsersID WHERE Username = @username AND Password = @password";

						using (SqlCommand cmdLogin = new SqlCommand(queryLogin, con))
						{
							cmdLogin.Parameters.AddWithValue("@username", username);
							cmdLogin.Parameters.AddWithValue("@password", password);

							using (SqlDataReader dataReader = cmdLogin.ExecuteReader())
							{
								if (dataReader.Read())
								{
									string firstName = dataReader["FirstName"].ToString();
									string lastName = dataReader["LastName"].ToString();
									int userID = Convert.ToInt32(dataReader["UsersID"]);

									string queryRole = "SELECT UserRoles.UserRole, UserRoles.UserRolesID FROM UserDetails INNER JOIN Users ON Users.UsersID = UserDetails.UsersID INNER JOIN UserRoles ON UserRoles.UserRolesID = Users.UserRolesID WHERE Users.UsersID = @userID";
									using (SqlCommand cmdRole = new SqlCommand(queryRole, con))
									{
										cmdRole.Parameters.AddWithValue("@userID", userID);

										using (SqlDataReader dataReaderRole = cmdRole.ExecuteReader())
										{
											if (dataReaderRole.Read())
											{
												int roleID = Convert.ToInt32(dataReaderRole["UserRolesID"]);
												string role = dataReaderRole["UserRole"].ToString();

												MessageBox.Show("Sisteme hoş geldiniz " + firstName + " " + lastName, "OYS", MessageBoxButtons.OK, MessageBoxIcon.Information);

												//Çeşitli yerlerde kullanılacağı için userID ve roleID bilgilerini static bir class içerisinde tutuyorum
												KeepSession.UserID = userID;
												KeepSession.RoleID = roleID;

												frmMain main = new frmMain();
												main.Show();
												this.Hide();
											}
										}
									}
								}
								else
								{
									WrongAttemptsCounter();
								}
							}
						}
					}
				}
			}
			else
			{
				WrongAttemptsCounter();
			}
		}

		bool CheckLockouts() //Eğer ilgili mac adresi hala yasaklı değilse giriş gerçekleşecek, 
		{
			string macAddress = GetMacAddress();
			using (SqlConnection con = Connection.Connect())
			{
				con.Open();
				string Query = "SELECT MacAddress,StartDate,FinishDate FROM Lockouts WHERE FinishDate > GetDate() AND MacAddress = @macAddress";
				using (SqlCommand cmd = new SqlCommand(Query, con))
				{
					cmd.Parameters.AddWithValue("@macAddress", macAddress);
					using (SqlDataReader dataReader = cmd.ExecuteReader())
					{
						if (dataReader.Read()) //Tekrar engelle
						{
							MessageBox.Show("Girişiniz engellenmiştir.\n Lütfen birkaç dakika sonra tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							btnLogin.Enabled = false; 
							return false;
						}
						else
						{
							return true; //Yasaklı olmadığı için girişi serbest
						}
					}
				}
			}
		}

		//Gerekli engellemeler için Mac adresi alındı.
		static string GetMacAddress()
		{
			string macAddresses = "";
			foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
			{
				if (nic.OperationalStatus == OperationalStatus.Up)
				{
					macAddresses += nic.GetPhysicalAddress().ToString();
					break;
				}
			}
			return macAddresses;
		}

		void InsertMacAddress()
		{
			string macAddress = GetMacAddress();
			DateTime currentDate = DateTime.Now;

			using (SqlConnection con = Connection.Connect())
			{
				con.Open();

				string Query = "INSERT INTO Lockouts VALUES (@macAddress,@startDate,@finishDate)";
				using (SqlCommand cmd = new SqlCommand(Query, con))
				{
					cmd.Parameters.AddWithValue("@macAddress", macAddress);
					cmd.Parameters.AddWithValue("@startDate", currentDate);
					cmd.Parameters.AddWithValue("@finishDate", currentDate.AddMinutes(1));

					cmd.ExecuteNonQuery();
				}
			}
		}


		void WrongAttemptsCounter()
		{
			wrongAttemptsCount--;
			if (wrongAttemptsCount == 0)
			{

				InsertMacAddress();

				MessageBox.Show("Giriş hakkı denemeniz doldu. Lütfen 1 dakika sonra tekrar deneyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
				btnLogin.Enabled = false;
			}
			else
			{
				if (wrongAttemptsCount != 0)
					MessageBox.Show("Lütfen kullanıcı adı ve şifrenizi doğru şekilde giriniz! \nKalan deneme hakkınız : " + wrongAttemptsCount.ToString(), "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			Login();
		}
	}
}
