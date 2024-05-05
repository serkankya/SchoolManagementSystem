using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
	}
}
