using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
	public partial class frmStudentManagement : Form
	{
		public frmStudentManagement()
		{
			InitializeComponent();
		}

		private void btnNewStudentReg_Click(object sender, EventArgs e)
		{
			frmStudentRegistration frmStudentRegistration = new frmStudentRegistration();
			frmStudentRegistration.ShowDialog();
		}

		private void ListStudents()
		{
			using (SqlConnection connection = Connection.Connect())
			{
				connection.Open();

				string queryForListing = "SELECT * FROM Students";

				using (SqlCommand command = new SqlCommand(queryForListing, connection))
				{
					SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
					DataSet dataSet = new DataSet();
					dataAdapter.Fill(dataSet);

					dgwStudents.DataSource = dataSet.Tables[0];
				}
			}
		}

		private void SearchStudent()
		{
			using (SqlConnection connection = Connection.Connect())
			{
				connection.Open();
				string queryForSearching = "SELECT * FROM Students WHERE StudentName LIKE @word OR StudentSurname LIKE @word OR StudentNumber LIKE @word OR IdentityNumber LIKE @word";

				using (SqlCommand command = new SqlCommand(queryForSearching, connection))
				{
					command.Parameters.AddWithValue("@word", '%' + txtSearch.Text + '%');

					SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
					DataSet dataSet = new DataSet();
					dataAdapter.Fill(dataSet);

					dgwStudents.DataSource = dataSet.Tables[0];
				}
			}
		}

		private void frmStudentManagement_Load(object sender, EventArgs e)
		{
			ListStudents();
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			SearchStudent();
		}
	}
}
