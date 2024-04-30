using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
	public static class Connection
	{
		private static string ConnectionString = "Data Source=SERKANKAYA;Initial Catalog=dbo_OYS;Integrated Security=True;MultipleActiveResultSets=True";

		public static SqlConnection Connect()
		{
			return new SqlConnection(ConnectionString);
		}
	}
}
