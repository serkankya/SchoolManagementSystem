namespace SchoolManagementSystem
{
	partial class frmStudentManagement
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentManagement));
			this.btnNewStudentReg = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnNewStudentReg
			// 
			this.btnNewStudentReg.Location = new System.Drawing.Point(12, 12);
			this.btnNewStudentReg.Name = "btnNewStudentReg";
			this.btnNewStudentReg.Size = new System.Drawing.Size(101, 40);
			this.btnNewStudentReg.TabIndex = 0;
			this.btnNewStudentReg.Text = "Yeni Öğrenci Kayıt";
			this.btnNewStudentReg.UseVisualStyleBackColor = true;
			this.btnNewStudentReg.Click += new System.EventHandler(this.btnNewStudentReg_Click);
			// 
			// frmStudentManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1134, 661);
			this.Controls.Add(this.btnNewStudentReg);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmStudentManagement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "OYS - Öğrenci Yönetimi";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnNewStudentReg;
	}
}