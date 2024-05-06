using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
	public partial class frmStudentRegistration : Form
	{
		public frmStudentRegistration()
		{
			InitializeComponent();
		}

		public bool InputChecker() //Veri ekleme sırasında herhangi bir boş alan var mı kontrolü yapılacak
		{
			List<GroupBox> groupBoxes = new List<GroupBox>
			{
				grpStudentData, grpSchoolData, grpFamilyData
			};

			foreach (GroupBox groupBox in groupBoxes)
			{
				foreach (Control control in Controls)
				{
					if (control is TextBox textBox && string.IsNullOrEmpty(textBox.Text) && string.IsNullOrWhiteSpace(textBox.Text))
					{
						return true; //Eğer boş ise hatalı dönecek
					}
					else if (control is ComboBox comboBox && comboBox.SelectedIndex == -1)
					{
						return true; //Eğer seçilmemiş ise hatalı dönecek
					}
					else if (control is RadioButton radioButton && !radioButton.Checked)
					{
						return true; //Eğer seçilmemiş ise hatalı dönecek
					}
					else if (control is DateTimePicker dateTimePicker && dateTimePicker.Value == DateTime.Today)
					{
						return true; //Eğer veri bugüne aitse hatalı dönecek
					}
				}
			}

			return false; //Herhangi bir sorun yok ise kayıt işlemi aşamasına geçilebilir.
		}

		public void ListCities()
		{
			Dictionary<int, string> cities = new Dictionary<int, string>();

			using (SqlConnection connection = Connection.Connect())
			{
				connection.Open();

				string queryForCities = "SELECT * FROM Cities";

				using (SqlCommand commandCity = new SqlCommand(queryForCities, connection))
				{
					using (SqlDataReader dataReader = commandCity.ExecuteReader())
					{
						while (dataReader.Read())
						{
							int cityID = Convert.ToInt32(dataReader["CityID"]);
							string cityName = dataReader["CityName"].ToString();
							cities.Add(cityID, cityName);
						}
					}
				}

				foreach (var city in cities)
				{
					cmbCities.Items.Add(new KeyValuePair<int, string>(city.Key, city.Value));
				}

				cmbCities.Text = "Lütfen şehir seçiniz...";

				cmbCities.DisplayMember = "Value";
				cmbCities.ValueMember = "Key";


			}
		}

		public void ListDistricts(int cityID)
		{
			cmbDistricts.Items.Clear();
			cmbDistricts.Enabled = true;

			Dictionary<int, string> districts = new Dictionary<int, string>();
			string queryForDistricts = "SELECT * FROM Districts WHERE CityID = @cityID";

			using (SqlConnection connection = Connection.Connect())
			{
				connection.Open();
				using (SqlCommand commandDistrict = new SqlCommand(queryForDistricts, connection))
				{
					commandDistrict.Parameters.AddWithValue("@cityID", cityID);

					commandDistrict.ExecuteNonQuery();

					using (SqlDataReader dataReader = commandDistrict.ExecuteReader())
					{
						while (dataReader.Read())
						{
							int districtID = Convert.ToInt32(dataReader["DistrictID"]);
							string districtName = dataReader["DistrictName"].ToString();
							districts.Add(districtID, districtName);
						}
					}
				}

				foreach (var district in districts)
				{
					cmbDistricts.Items.Add(new KeyValuePair<int, string>(district.Key, district.Value));
				}

				cmbDistricts.Text = "Lütfen ilçe seçiniz...";

				cmbDistricts.DisplayMember = "Value";
				cmbDistricts.ValueMember = "Key";
			}
		}

		private void btnCompelete_Click(object sender, EventArgs e)
		{
			if (InputChecker())
			{
				using (SqlConnection connection = Connection.Connect())
				{
					connection.Open();
					SqlTransaction sqlTransaction = connection.BeginTransaction(); //Toplu bir işlem gerçekleştireceğim için(student ve family bilgilerinin eklenmesi) transaction kullanıyorum

					try
					{
						string queryForStudentInsert = "INSERT INTO Students VALUES(@classID,@branchID,@cityID,@districtID,@insertedByID,@studentName,@studentSurname,@identityNumber,@birthDate,@gender,@address)";

						using (SqlCommand studentCommand = new SqlCommand(queryForStudentInsert, connection, sqlTransaction))
						{
							//studentCommand.Parameters.AddWithValue("@classID",);
							//studentCommand.Parameters.AddWithValue("@branchID",);
							//studentCommand.Parameters.AddWithValue("@cityID",);
							//studentCommand.Parameters.AddWithValue("@districtID",);
							//studentCommand.Parameters.AddWithValue("@insertedByID",);
							//studentCommand.Parameters.AddWithValue("@studentName",);
							//studentCommand.Parameters.AddWithValue("@studentSurname",);
							//studentCommand.Parameters.AddWithValue("@identityNumber",);
							//studentCommand.Parameters.AddWithValue("@birthDate",);
							//studentCommand.Parameters.AddWithValue("@gender",);
							//studentCommand.Parameters.AddWithValue("@address",);

							int insertedStudentID = Convert.ToInt32(studentCommand.ExecuteScalar()); //Son eklenen öğrencinin ID'sini alıyorum. Ayrıca execute işlemi de burada.

							studentCommand.ExecuteNonQuery();

							string queryForFamilyInsert = "INSERT INTO Families VALUES (@studentID,@motherName,@motherSurname,@motherMaidenName,@fatherName,@fatherSurname)";

							using (SqlCommand familyCommand = new SqlCommand(queryForFamilyInsert, connection, sqlTransaction))
							{
								//familyCommand.Parameters.AddWithValue("@studentID",);
								//familyCommand.Parameters.AddWithValue("@motherName",);
								//familyCommand.Parameters.AddWithValue("@motherSurname",);
								//familyCommand.Parameters.AddWithValue("@motherMaidenName",);
								//familyCommand.Parameters.AddWithValue("@fatherName",);
								//familyCommand.Parameters.AddWithValue("@fatherSurname",);

								familyCommand.ExecuteNonQuery();

								sqlTransaction.Commit(); //İşlem tamamlandı.
							}
						}
					}
					catch (Exception exception)
					{
						MessageBox.Show("Bir hata oluştu. Hata :\n ", exception.Message);
						sqlTransaction.Rollback(); //Herhangi bir hata olması durumunda işlemleri geri alıyorum.
					}
				}
			}
			else
			{
				MessageBox.Show("Lütfen bütün alanları doldurduğunuzdan emin olun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void ListBranches(int classID)
		{
			cmbBranch.Items.Clear();
			cmbBranch.Enabled = true;

			Dictionary<int, string> branches = new Dictionary<int, string>();

			using (SqlConnection connection = Connection.Connect())
			{
				connection.Open();

				string queryForBranches = "SELECT * FROM Branches WHERE ClassID = @classID";

				using (SqlCommand command = new SqlCommand(queryForBranches,connection))
				{
					command.Parameters.AddWithValue("@classID", classID);

					command.ExecuteNonQuery();

					using (SqlDataReader dataReader = command.ExecuteReader())
					{
						while (dataReader.Read())
						{
							int branchID = Convert.ToInt32(dataReader["BranchID"]);
							string branchName = dataReader["BranchName"].ToString();

							branches.Add(branchID, branchName);
						}
					}
				}

				foreach (var branch in branches)
				{
					cmbBranch.Items.Add(new KeyValuePair<int, string>(branch.Key, branch.Value));
				}

				cmbBranch.Text = "Lütfen şube seçiniz...";

				cmbBranch.DisplayMember = "Value";
				cmbBranch.ValueMember = "Key";
			}
		}

		public void ListClasses()
		{
			Dictionary<int, string> classes = new Dictionary<int, string>();

			using (SqlConnection connection = Connection.Connect())
			{
				connection.Open();

				string queryForClasses = "SELECT * FROM Classes";
				using (SqlCommand command = new SqlCommand(queryForClasses, connection))
				{
					using (SqlDataReader dataReader = command.ExecuteReader())
					{
						while (dataReader.Read())
						{
							int classID = Convert.ToInt32(dataReader["ClassID"]);
							string className = dataReader["Class"].ToString();

							classes.Add(classID, className);
						}
					}
				}

				foreach (var item in classes)
				{
					cmbClass.Items.Add(new KeyValuePair<int,string>(item.Key, item.Value));
				}

				cmbClass.Text = "Lütfen sınıf seçiniz...";

				cmbClass.DisplayMember = "Value";
				cmbClass.ValueMember = "Key";
			}
		}

		private void frmStudentRegistration_Load(object sender, EventArgs e)
		{
			ListCities();
			cmbDistricts.Enabled = false;
			cmbDistricts.Text = "Lütfen önce ili seçiniz...";

			cmbBranch.Enabled = false;
			cmbBranch.Text = "Lütfen önce sınıfı seçiniz...";

			ListClasses();
		}

		private void cmbCities_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbCities.SelectedIndex != -1)
			{
				KeyValuePair<int, string> selectedCity = (KeyValuePair<int, string>)cmbCities.SelectedItem;
				int selectedCityID = Convert.ToInt32(selectedCity.Key);

				ListDistricts(selectedCityID);
			}
			else
			{
				MessageBox.Show("Bir hata oluştu. Lütfen tekrar şehir seçimi yapınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbClass.SelectedIndex != -1)
			{
				KeyValuePair<int, string> selectedClass = (KeyValuePair<int, string>)cmbClass.SelectedItem;
				int selectedClassID = Convert.ToInt32(selectedClass.Key);

				ListBranches(selectedClassID);
			}
			else
			{
				MessageBox.Show("Bir hata oluştu. Lütfen tekrar sınıf seçimi yapınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
