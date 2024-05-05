namespace SchoolManagementSystem
{
	partial class frmStudentRegistration
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentRegistration));
			this.grpStudentData = new System.Windows.Forms.GroupBox();
			this.rbFemale = new System.Windows.Forms.RadioButton();
			this.rbMale = new System.Windows.Forms.RadioButton();
			this.dtStudentBirthDate = new System.Windows.Forms.DateTimePicker();
			this.txtStudentDistrict = new System.Windows.Forms.ComboBox();
			this.txtStudentCity = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtStudentSurname = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.txtStudentIdentityNumber = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtStudentName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.grpFamilyData = new System.Windows.Forms.GroupBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.txtFatherSurname = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtFatherName = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtMotherSurname = new System.Windows.Forms.TextBox();
			this.txtMaidenName = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtMotherName = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.grpSchoolData = new System.Windows.Forms.GroupBox();
			this.lblBirthDate = new System.Windows.Forms.Label();
			this.cmbBranch = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.cmbClass = new System.Windows.Forms.ComboBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.btnCompelete = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.pbLogo = new System.Windows.Forms.PictureBox();
			this.btnMainForm = new System.Windows.Forms.Button();
			this.grpStudentData.SuspendLayout();
			this.grpFamilyData.SuspendLayout();
			this.grpSchoolData.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// grpStudentData
			// 
			this.grpStudentData.Controls.Add(this.rbFemale);
			this.grpStudentData.Controls.Add(this.rbMale);
			this.grpStudentData.Controls.Add(this.dtStudentBirthDate);
			this.grpStudentData.Controls.Add(this.txtStudentDistrict);
			this.grpStudentData.Controls.Add(this.txtStudentCity);
			this.grpStudentData.Controls.Add(this.label6);
			this.grpStudentData.Controls.Add(this.label5);
			this.grpStudentData.Controls.Add(this.label4);
			this.grpStudentData.Controls.Add(this.txtStudentSurname);
			this.grpStudentData.Controls.Add(this.label16);
			this.grpStudentData.Controls.Add(this.txtStudentIdentityNumber);
			this.grpStudentData.Controls.Add(this.label2);
			this.grpStudentData.Controls.Add(this.label3);
			this.grpStudentData.Controls.Add(this.txtStudentName);
			this.grpStudentData.Controls.Add(this.label1);
			this.grpStudentData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.grpStudentData.Location = new System.Drawing.Point(12, 12);
			this.grpStudentData.Name = "grpStudentData";
			this.grpStudentData.Size = new System.Drawing.Size(372, 281);
			this.grpStudentData.TabIndex = 0;
			this.grpStudentData.TabStop = false;
			this.grpStudentData.Text = "ÖĞRENCİ BİLGİLERİ";
			// 
			// rbFemale
			// 
			this.rbFemale.AutoSize = true;
			this.rbFemale.Location = new System.Drawing.Point(177, 249);
			this.rbFemale.Name = "rbFemale";
			this.rbFemale.Size = new System.Drawing.Size(65, 22);
			this.rbFemale.TabIndex = 6;
			this.rbFemale.TabStop = true;
			this.rbFemale.Text = "Erkek";
			this.rbFemale.UseVisualStyleBackColor = true;
			// 
			// rbMale
			// 
			this.rbMale.AutoSize = true;
			this.rbMale.Location = new System.Drawing.Point(114, 249);
			this.rbMale.Name = "rbMale";
			this.rbMale.Size = new System.Drawing.Size(47, 22);
			this.rbMale.TabIndex = 6;
			this.rbMale.TabStop = true;
			this.rbMale.Text = "Kız";
			this.rbMale.UseVisualStyleBackColor = true;
			// 
			// dtStudentBirthDate
			// 
			this.dtStudentBirthDate.Location = new System.Drawing.Point(114, 214);
			this.dtStudentBirthDate.Name = "dtStudentBirthDate";
			this.dtStudentBirthDate.Size = new System.Drawing.Size(234, 24);
			this.dtStudentBirthDate.TabIndex = 5;
			// 
			// txtStudentDistrict
			// 
			this.txtStudentDistrict.FormattingEnabled = true;
			this.txtStudentDistrict.Location = new System.Drawing.Point(114, 176);
			this.txtStudentDistrict.Name = "txtStudentDistrict";
			this.txtStudentDistrict.Size = new System.Drawing.Size(234, 26);
			this.txtStudentDistrict.TabIndex = 4;
			// 
			// txtStudentCity
			// 
			this.txtStudentCity.FormattingEnabled = true;
			this.txtStudentCity.Location = new System.Drawing.Point(114, 140);
			this.txtStudentCity.Name = "txtStudentCity";
			this.txtStudentCity.Size = new System.Drawing.Size(234, 26);
			this.txtStudentCity.TabIndex = 4;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(10, 215);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(109, 18);
			this.label6.TabIndex = 2;
			this.label6.Text = "Doğum Tarihi : ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 179);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(106, 18);
			this.label5.TabIndex = 2;
			this.label5.Text = "Doğduğu İlçe : ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(29, 143);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 18);
			this.label4.TabIndex = 2;
			this.label4.Text = "Doğduğu İl : ";
			// 
			// txtStudentSurname
			// 
			this.txtStudentSurname.Location = new System.Drawing.Point(114, 69);
			this.txtStudentSurname.Name = "txtStudentSurname";
			this.txtStudentSurname.Size = new System.Drawing.Size(234, 24);
			this.txtStudentSurname.TabIndex = 3;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(47, 249);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(72, 18);
			this.label16.TabIndex = 2;
			this.label16.Text = "Cinsiyet : ";
			// 
			// txtStudentIdentityNumber
			// 
			this.txtStudentIdentityNumber.Location = new System.Drawing.Point(114, 105);
			this.txtStudentIdentityNumber.Name = "txtStudentIdentityNumber";
			this.txtStudentIdentityNumber.Size = new System.Drawing.Size(234, 24);
			this.txtStudentIdentityNumber.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(57, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "Soyad : ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(108, 18);
			this.label3.TabIndex = 0;
			this.label3.Text = "TC Kimlik No : ";
			// 
			// txtStudentName
			// 
			this.txtStudentName.Location = new System.Drawing.Point(114, 33);
			this.txtStudentName.Name = "txtStudentName";
			this.txtStudentName.Size = new System.Drawing.Size(234, 24);
			this.txtStudentName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(82, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ad : ";
			// 
			// grpFamilyData
			// 
			this.grpFamilyData.Controls.Add(this.richTextBox1);
			this.grpFamilyData.Controls.Add(this.txtFatherSurname);
			this.grpFamilyData.Controls.Add(this.label11);
			this.grpFamilyData.Controls.Add(this.label10);
			this.grpFamilyData.Controls.Add(this.txtFatherName);
			this.grpFamilyData.Controls.Add(this.label12);
			this.grpFamilyData.Controls.Add(this.txtMotherSurname);
			this.grpFamilyData.Controls.Add(this.txtMaidenName);
			this.grpFamilyData.Controls.Add(this.label7);
			this.grpFamilyData.Controls.Add(this.label8);
			this.grpFamilyData.Controls.Add(this.txtMotherName);
			this.grpFamilyData.Controls.Add(this.label9);
			this.grpFamilyData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.grpFamilyData.Location = new System.Drawing.Point(12, 299);
			this.grpFamilyData.Name = "grpFamilyData";
			this.grpFamilyData.Size = new System.Drawing.Size(372, 327);
			this.grpFamilyData.TabIndex = 1;
			this.grpFamilyData.TabStop = false;
			this.grpFamilyData.Text = "AİLE BİLGİLERİ";
			// 
			// richTextBox1
			// 
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.richTextBox1.Location = new System.Drawing.Point(114, 212);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(234, 100);
			this.richTextBox1.TabIndex = 16;
			this.richTextBox1.Text = "";
			// 
			// txtFatherSurname
			// 
			this.txtFatherSurname.Location = new System.Drawing.Point(114, 177);
			this.txtFatherSurname.Name = "txtFatherSurname";
			this.txtFatherSurname.Size = new System.Drawing.Size(234, 24);
			this.txtFatherSurname.TabIndex = 15;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(30, 213);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(90, 18);
			this.label11.TabIndex = 14;
			this.label11.Text = "Açık Adres : ";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(17, 180);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(103, 18);
			this.label10.TabIndex = 14;
			this.label10.Text = "Baba Soyadı : ";
			// 
			// txtFatherName
			// 
			this.txtFatherName.Location = new System.Drawing.Point(114, 141);
			this.txtFatherName.Name = "txtFatherName";
			this.txtFatherName.Size = new System.Drawing.Size(234, 24);
			this.txtFatherName.TabIndex = 13;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(42, 144);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(78, 18);
			this.label12.TabIndex = 11;
			this.label12.Text = "Baba Adı : ";
			// 
			// txtMotherSurname
			// 
			this.txtMotherSurname.Location = new System.Drawing.Point(114, 70);
			this.txtMotherSurname.Name = "txtMotherSurname";
			this.txtMotherSurname.Size = new System.Drawing.Size(234, 24);
			this.txtMotherSurname.TabIndex = 9;
			// 
			// txtMaidenName
			// 
			this.txtMaidenName.Location = new System.Drawing.Point(114, 106);
			this.txtMaidenName.Name = "txtMaidenName";
			this.txtMaidenName.Size = new System.Drawing.Size(234, 24);
			this.txtMaidenName.TabIndex = 6;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(18, 73);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(102, 18);
			this.label7.TabIndex = 8;
			this.label7.Text = "Anne Soyadı : ";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(16, 109);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(104, 18);
			this.label8.TabIndex = 4;
			this.label8.Text = "Kızlık Soyadı : ";
			// 
			// txtMotherName
			// 
			this.txtMotherName.Location = new System.Drawing.Point(114, 34);
			this.txtMotherName.Name = "txtMotherName";
			this.txtMotherName.Size = new System.Drawing.Size(234, 24);
			this.txtMotherName.TabIndex = 7;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(43, 37);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(77, 18);
			this.label9.TabIndex = 5;
			this.label9.Text = "Anne Adı : ";
			// 
			// grpSchoolData
			// 
			this.grpSchoolData.Controls.Add(this.lblBirthDate);
			this.grpSchoolData.Controls.Add(this.cmbBranch);
			this.grpSchoolData.Controls.Add(this.label13);
			this.grpSchoolData.Controls.Add(this.cmbClass);
			this.grpSchoolData.Controls.Add(this.label14);
			this.grpSchoolData.Controls.Add(this.label15);
			this.grpSchoolData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.grpSchoolData.Location = new System.Drawing.Point(415, 12);
			this.grpSchoolData.Name = "grpSchoolData";
			this.grpSchoolData.Size = new System.Drawing.Size(327, 218);
			this.grpSchoolData.TabIndex = 2;
			this.grpSchoolData.TabStop = false;
			this.grpSchoolData.Text = "OKUL BİLGİLERİ";
			// 
			// lblBirthDate
			// 
			this.lblBirthDate.BackColor = System.Drawing.Color.Coral;
			this.lblBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBirthDate.Location = new System.Drawing.Point(6, 72);
			this.lblBirthDate.Name = "lblBirthDate";
			this.lblBirthDate.Size = new System.Drawing.Size(315, 40);
			this.lblBirthDate.TabIndex = 0;
			this.lblBirthDate.Text = "*Öğrenci bilgileri girildikten sonra yaşı ve doğum tarihi burada görüntülenecekti" +
    "r.";
			this.lblBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmbBranch
			// 
			this.cmbBranch.FormattingEnabled = true;
			this.cmbBranch.Location = new System.Drawing.Point(71, 171);
			this.cmbBranch.Name = "cmbBranch";
			this.cmbBranch.Size = new System.Drawing.Size(234, 26);
			this.cmbBranch.TabIndex = 4;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.SystemColors.ControlDark;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label13.Location = new System.Drawing.Point(6, 21);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(315, 40);
			this.label13.TabIndex = 0;
			this.label13.Text = "*Öğrenci kaydı tamamlandıktan sonra \r\nokul numarası oluşturulacaktır.";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmbClass
			// 
			this.cmbClass.FormattingEnabled = true;
			this.cmbClass.Location = new System.Drawing.Point(71, 135);
			this.cmbClass.Name = "cmbClass";
			this.cmbClass.Size = new System.Drawing.Size(234, 26);
			this.cmbClass.TabIndex = 4;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(26, 138);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(48, 18);
			this.label14.TabIndex = 2;
			this.label14.Text = "Sınıf : ";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(20, 174);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(54, 18);
			this.label15.TabIndex = 2;
			this.label15.Text = "Şube : ";
			// 
			// btnCompelete
			// 
			this.btnCompelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCompelete.Location = new System.Drawing.Point(415, 236);
			this.btnCompelete.Name = "btnCompelete";
			this.btnCompelete.Size = new System.Drawing.Size(327, 57);
			this.btnCompelete.TabIndex = 3;
			this.btnCompelete.Text = "Öğrenci Kaydını Tamamla";
			this.btnCompelete.UseVisualStyleBackColor = true;
			this.btnCompelete.Click += new System.EventHandler(this.btnCompelete_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCancel.Location = new System.Drawing.Point(415, 307);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(327, 58);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "İptal Et";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// pbLogo
			// 
			this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
			this.pbLogo.Location = new System.Drawing.Point(415, 419);
			this.pbLogo.Name = "pbLogo";
			this.pbLogo.Size = new System.Drawing.Size(327, 205);
			this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbLogo.TabIndex = 4;
			this.pbLogo.TabStop = false;
			// 
			// btnMainForm
			// 
			this.btnMainForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnMainForm.Location = new System.Drawing.Point(511, 372);
			this.btnMainForm.Name = "btnMainForm";
			this.btnMainForm.Size = new System.Drawing.Size(153, 41);
			this.btnMainForm.TabIndex = 5;
			this.btnMainForm.Text = "Ana Menü";
			this.btnMainForm.UseVisualStyleBackColor = true;
			// 
			// frmStudentRegistration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(773, 636);
			this.Controls.Add(this.btnMainForm);
			this.Controls.Add(this.pbLogo);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnCompelete);
			this.Controls.Add(this.grpSchoolData);
			this.Controls.Add(this.grpFamilyData);
			this.Controls.Add(this.grpStudentData);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmStudentRegistration";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "OYS - Öğrenci Kayıt";
			this.grpStudentData.ResumeLayout(false);
			this.grpStudentData.PerformLayout();
			this.grpFamilyData.ResumeLayout(false);
			this.grpFamilyData.PerformLayout();
			this.grpSchoolData.ResumeLayout(false);
			this.grpSchoolData.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpStudentData;
		private System.Windows.Forms.DateTimePicker dtStudentBirthDate;
		private System.Windows.Forms.ComboBox txtStudentDistrict;
		private System.Windows.Forms.ComboBox txtStudentCity;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtStudentSurname;
		private System.Windows.Forms.TextBox txtStudentIdentityNumber;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtStudentName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox grpFamilyData;
		private System.Windows.Forms.GroupBox grpSchoolData;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.TextBox txtFatherSurname;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtFatherName;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtMotherSurname;
		private System.Windows.Forms.TextBox txtMaidenName;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtMotherName;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lblBirthDate;
		private System.Windows.Forms.ComboBox cmbBranch;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox cmbClass;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.RadioButton rbFemale;
		private System.Windows.Forms.RadioButton rbMale;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Button btnCompelete;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.PictureBox pbLogo;
		private System.Windows.Forms.Button btnMainForm;
	}
}