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
			this.dgwStudents = new System.Windows.Forms.DataGridView();
			this.txtSearch = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).BeginInit();
			this.SuspendLayout();
			// 
			// btnNewStudentReg
			// 
			this.btnNewStudentReg.Location = new System.Drawing.Point(12, 30);
			this.btnNewStudentReg.Name = "btnNewStudentReg";
			this.btnNewStudentReg.Size = new System.Drawing.Size(101, 40);
			this.btnNewStudentReg.TabIndex = 0;
			this.btnNewStudentReg.Text = "Yeni Öğrenci Kayıt";
			this.btnNewStudentReg.UseVisualStyleBackColor = true;
			this.btnNewStudentReg.Click += new System.EventHandler(this.btnNewStudentReg_Click);
			// 
			// dgwStudents
			// 
			this.dgwStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgwStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwStudents.Location = new System.Drawing.Point(12, 101);
			this.dgwStudents.Name = "dgwStudents";
			this.dgwStudents.Size = new System.Drawing.Size(1098, 179);
			this.dgwStudents.TabIndex = 1;
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(446, 26);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(100, 20);
			this.txtSearch.TabIndex = 2;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// frmStudentManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1134, 661);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.dgwStudents);
			this.Controls.Add(this.btnNewStudentReg);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmStudentManagement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "OYS - Öğrenci Yönetimi";
			this.Load += new System.EventHandler(this.frmStudentManagement_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnNewStudentReg;
		private System.Windows.Forms.DataGridView dgwStudents;
		private System.Windows.Forms.TextBox txtSearch;
	}
}