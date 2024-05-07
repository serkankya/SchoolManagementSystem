using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
	public class CreateIdentityNumber
	{
		Random _random = new Random();

		#region Öğrenci için gerçekleşen alan
		public bool CheckStudentNumber(string studentNumber)
		{
			using (SqlConnection connection = Connection.Connect())
			{
				connection.Open();

				string queryForStudentNumber = "SELECT StudentNumber FROM Students WHERE StudentNumber = @studentNumber";
				using (SqlCommand command = new SqlCommand(queryForStudentNumber,connection))
				{
					command.Parameters.AddWithValue("@studentNumber", studentNumber);
					command.ExecuteNonQuery();

					using (SqlDataReader dataReader = command.ExecuteReader())
					{
						if (dataReader.Read())
						{
							return false; //Eğer böyle bir numara mevcut ise işlem tekrarlanmak üzere false dönecek.
						}
						else
						{
							return true; //Eğer böyle bir numara yok ise sonuç başarılı olacak.
						}
					}
				}
			}
		}

		public string CreateStudentNumber(DateTime birthYear, int branch)
		{
			int randomNumber = _random.Next(1, 300);
			string finalNumber = birthYear.Year.ToString() + branch.ToString() + randomNumber.ToString();
			if (CheckStudentNumber(finalNumber))
			{
				return finalNumber;
			}
			else
			{
				return CreateStudentNumber(birthYear,branch);
			}
		}
		#endregion


		#region Öğretmen için gerçekleşen alan
		//Eklenecek
		#endregion
	}
}
