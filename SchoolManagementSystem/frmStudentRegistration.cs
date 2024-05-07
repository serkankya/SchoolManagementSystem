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
		int _userID, _roleID;
		public frmStudentRegistration()
		{
			InitializeComponent();
			_userID = KeepSession.UserID;
			_roleID = KeepSession.RoleID;
		}

		public bool InputChecker() //Veri ekleme sırasında herhangi bir boş alan var mı kontrolü yapılacak
		{
			List<GroupBox> groupBoxes = new List<GroupBox>
			{
				grpStudentData, grpSchoolData, grpFamilyData
			};

			foreach (GroupBox groupBox in groupBoxes)
			{
				foreach (Control control in groupBox.Controls)
				{
					if (control is TextBox textBox && (string.IsNullOrEmpty(textBox.Text) || string.IsNullOrWhiteSpace(textBox.Text)))
					{
						return true; // Boş alan varsa hata dönecek
					}
					else if (control is ComboBox comboBox && comboBox.SelectedIndex == -1)
					{
						return true; // Seçilmemiş bir ComboBox varsa hata dönecek
					}
					else if (!rbFemale.Checked && !rbMale.Checked)
					{
						return true; // Cinsiyet seçilmemişse hata dönecek
					}
					else if (control is DateTimePicker dateTimePicker && dateTimePicker.Value.Date == DateTime.Today)
					{
						return true; // Veri bugüne aitse hatalı dönecek
					}
				}
			}

			return false; // Herhangi bir sorun yoksa kayıt işlemi aşamasına geçilebilir.
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

				cmbCities.Text = "Lütfen şehir seçiniz...";

				cmbCities.DisplayMember = "Value";
				cmbCities.ValueMember = "Key";

				cmbCities.DataSource = cities.ToList();
			}
		}

		public void ListDistricts(int cityID)
		{
			cmbDistricts.Enabled = true;

			Dictionary<int, string> districts = new Dictionary<int, string>();
			string queryForDistricts = "SELECT * FROM Districts WHERE CityID = @cityID";

			using (SqlConnection connection = Connection.Connect())
			{
				connection.Open();
				using (SqlCommand commandDistrict = new SqlCommand(queryForDistricts, connection))
				{
					commandDistrict.Parameters.AddWithValue("@cityID", cityID);

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

				cmbDistricts.Text = "Lütfen ilçe seçiniz...";

				cmbDistricts.DisplayMember = "Value";
				cmbDistricts.ValueMember = "Key";

				cmbDistricts.DataSource = districts.ToList();
			}
		}

		private void btnCompelete_Click(object sender, EventArgs e)
		{
			if (!InputChecker())
			{
				try
				{
					InsertStudents();
					InsertFamilies();
					MessageBox.Show("Öğrenci bilgileri başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception exception)
				{
					MessageBox.Show("Bir hata oluştu. Hata :\n ", exception.Message);
				}
			}
			else
			{
				MessageBox.Show("Lütfen bütün alanları doldurduğunuzdan emin olun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void InsertStudents()
		{
			using (SqlConnection connection = Connection.Connect())
			{
				connection.Open();

				CreateIdentityNumber createIdentityNumber = new CreateIdentityNumber();
				string studentNumber = createIdentityNumber.CreateStudentNumber(dtStudentBirthDate.Value, Convert.ToInt32(cmbBranch.SelectedValue));

				string queryForStudentInsert = "INSERT INTO Students (ClassID,BranchID,CityID,DistrictID,InsertedByID,StudentNumber,StudentName,StudentSurname,IdentityNumber,BirthDate,Gender,Address) " +
					"VALUES (@classID,@branchID,@cityID,@districtID,@insertedByID,@studentNumber,@studentName,@studentSurname,@identityNumber,@birthDate,@gender,@address)";

				using (SqlCommand studentCommand = new SqlCommand(queryForStudentInsert, connection))
				{
					bool gender;

					if (rbFemale.Checked)
					{
						gender = true;
					}
					else
					{
						gender = false;
					}

					studentCommand.Parameters.AddWithValue("@classID", Convert.ToInt32(cmbClass.SelectedValue));
					studentCommand.Parameters.AddWithValue("@branchID", Convert.ToInt32(cmbBranch.SelectedValue));
					studentCommand.Parameters.AddWithValue("@cityID", Convert.ToInt32(cmbCities.SelectedValue));
					studentCommand.Parameters.AddWithValue("@districtID", Convert.ToInt32(cmbDistricts.SelectedValue));
					studentCommand.Parameters.AddWithValue("@insertedByID", Convert.ToInt32(_userID));
					studentCommand.Parameters.AddWithValue("@studentNumber", studentNumber);
					studentCommand.Parameters.AddWithValue("@studentName", txtStudentName.Text);
					studentCommand.Parameters.AddWithValue("@studentSurname", txtStudentSurname.Text);
					studentCommand.Parameters.AddWithValue("@identityNumber", txtStudentIdentityNumber.Text.ToString());
					studentCommand.Parameters.AddWithValue("@birthDate", Convert.ToDateTime(dtStudentBirthDate.Value));
					studentCommand.Parameters.AddWithValue("@gender", gender);
					studentCommand.Parameters.AddWithValue("@address", txtAddress.Text);

					studentCommand.ExecuteNonQuery();
				}
			}
		}

		public void InsertFamilies()
		{
			using (SqlConnection connection = Connection.Connect())
			{
				connection.Open();

				string queryForStudentID = "SELECT TOP 1 StudentID FROM Students ORDER BY StudentID DESC";
				int latestStudentID = 0;

				using (SqlCommand command = new SqlCommand(queryForStudentID, connection))
				{
					using (SqlDataReader reader = command.ExecuteReader())
					{
						if (reader.Read())
						{
							latestStudentID = Convert.ToInt32(reader["StudentID"]);
						}
						else
						{
							MessageBox.Show("Öğrenci ekleme işlemi başarısız! Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}

				string queryForFamilyInsert = "INSERT INTO Families (StudentID,MotherName,MotherSurname,MotherMaidenName,FatherName,FatherSurname) VALUES (@studentID,@motherName,@motherSurname,@motherMaidenName,@fatherName,@fatherSurname)";

				using (SqlCommand familyCommand = new SqlCommand(queryForFamilyInsert, connection))
				{
					familyCommand.Parameters.AddWithValue("@studentID", latestStudentID);
					familyCommand.Parameters.AddWithValue("@motherName", txtMotherName.Text);
					familyCommand.Parameters.AddWithValue("@motherSurname", txtMotherSurname.Text);
					familyCommand.Parameters.AddWithValue("@motherMaidenName", txtMaidenName.Text);
					familyCommand.Parameters.AddWithValue("@fatherName", txtFatherName.Text);
					familyCommand.Parameters.AddWithValue("@fatherSurname", txtFatherSurname.Text);

					familyCommand.ExecuteNonQuery();
				}
			}
		}

		public void ListBranches(int classID)
		{
			cmbBranch.Enabled = true;

			Dictionary<int, string> branches = new Dictionary<int, string>();

			using (SqlConnection connection = Connection.Connect())
			{
				connection.Open();

				string queryForBranches = "SELECT * FROM Branches WHERE ClassID = @classID";

				using (SqlCommand command = new SqlCommand(queryForBranches, connection))
				{
					command.Parameters.AddWithValue("@classID", classID);

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

				cmbBranch.Text = "Lütfen şube seçiniz...";

				cmbBranch.DisplayMember = "Value";
				cmbBranch.ValueMember = "Key";

				cmbBranch.DataSource = branches.ToList();
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

				cmbClass.Text = "Lütfen sınıf seçiniz...";

				cmbClass.DisplayMember = "Value";
				cmbClass.ValueMember = "Key";

				cmbClass.DataSource = classes.ToList();
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
