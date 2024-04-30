namespace SchoolManagementSystem
{
	partial class frmMain
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.lblUser = new System.Windows.Forms.Label();
			this.lblRole = new System.Windows.Forms.Label();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.lblDate = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.Location = new System.Drawing.Point(71, 39);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(35, 13);
			this.lblUser.TabIndex = 0;
			this.lblUser.Text = "label1";
			// 
			// lblRole
			// 
			this.lblRole.AutoSize = true;
			this.lblRole.Location = new System.Drawing.Point(71, 131);
			this.lblRole.Name = "lblRole";
			this.lblRole.Size = new System.Drawing.Size(35, 13);
			this.lblRole.TabIndex = 1;
			this.lblRole.Text = "label2";
			// 
			// timer
			// 
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.Location = new System.Drawing.Point(427, 77);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(35, 13);
			this.lblDate.TabIndex = 2;
			this.lblDate.Text = "label1";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1134, 661);
			this.Controls.Add(this.lblDate);
			this.Controls.Add(this.lblRole);
			this.Controls.Add(this.lblUser);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "OYS - Ana Menü";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblUser;
		private System.Windows.Forms.Label lblRole;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Label lblDate;
	}
}