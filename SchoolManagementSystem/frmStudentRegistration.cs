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
					if(control is TextBox textBox && string.IsNullOrEmpty(textBox.Text) && string.IsNullOrWhiteSpace(textBox.Text))
					{
						return true; //Eğer boş ise hatalı dönecek
					}
					else if(control is ComboBox comboBox && comboBox.SelectedIndex == -1)
					{
						return true; //Eğer seçilmemiş ise hatalı dönecek
					}
					else if(control is RadioButton radioButton && !radioButton.Checked)
					{
						return true; //Eğer seçilmemiş ise hatalı dönecek
					}
					else if(control is DateTimePicker dateTimePicker && dateTimePicker.Value == DateTime.Today)
					{
						return true; //Eğer veri bugüne aitse hatalı dönecek
					}
				}
			}

			return false; //Herhangi bir sorun yok ise kayıt işlemi aşamasına geçilebilir.
		}

		private void btnCompelete_Click(object sender, EventArgs e)
		{
			if(InputChecker())
			{
				//Doğru halde gerçekleşecek kodlar buraya eklenecek.
				//...
				//...
			}
			else
			{
				MessageBox.Show("Lütfen bütün alanları doldurduğunuzdan emin olun!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
	}
}
