using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
	public partial class frmMain : Form
	{
		int _userID, _roleID; //roleID ile kontroller yapılacak
		public frmMain()
		{
			InitializeComponent();
			_userID = KeepSession.UserID;
			_roleID = KeepSession.RoleID;
		}

		void BringUserDatas()
		{
			using (SqlConnection con = Connection.Connect())
			{
				con.Open();

				string Query = "SELECT UserDetails.FirstName , UserDetails.LastName , UserRoles.UserRole FROM users INNER JOIN UserRoles ON Users.UsersID = UserRoles.UserRolesID INNER JOIN UserDetails ON UserDetails.UsersID = Users.UsersID WHERE Users.UsersID = @userID";
				using (SqlCommand cmd = new SqlCommand(Query, con))
				{
					cmd.Parameters.AddWithValue("@userID", _userID);

					using (SqlDataReader dataReader = cmd.ExecuteReader())
					{
						if (dataReader.Read())
						{
							string firstName = dataReader["FirstName"].ToString();
							string lastName = dataReader["LastName"].ToString();
							string roleName = dataReader["UserRole"].ToString();

							lblUser.Text = firstName + " " + lastName;
							lblRole.Text = roleName;
						}
					}
				}
			}
		}

		void CheckUserRole()
		{
			if(_roleID != -1)
			{
				switch (_roleID)
				{
					case 1:
						{
							//STMT - Müdür
							break;
						}
					case 2:
						{
							//STMT - Müdür Yardımcısı
							break;
						}
					case 3:
						{
							//STMT - Memur
							break;
						}
					case 4:
						{
							//STMT - Öğretmen
							break;
						}
					case 5:
						{
							//STMT - Psk Danışman
							break;
						}
				}
			}
			else
			{
				//Hata durumunda gerçekleşecekler eklenecek
			}
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			lblDate.Text = CallTimer.Start(); //Eklenecek
		}

		private void btnStudentManagement_Click(object sender, EventArgs e)
		{
			frmStudentManagement frmStudentManagement = new frmStudentManagement();
			frmStudentManagement.Show();
			this.Hide();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			BringUserDatas();
			timer.Enabled = true;
		}
	}
}
