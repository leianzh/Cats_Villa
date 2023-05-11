namespace Cats_Villa
{
	partial class FormMain
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.登出系統ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnUpdateUser = new System.Windows.Forms.Button();
			this.btnPwdUpdate = new System.Windows.Forms.Button();
			this.btnOrder = new System.Windows.Forms.Button();
			this.btnSearchOrder = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.登出系統ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
			this.menuStrip1.Size = new System.Drawing.Size(533, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 登出系統ToolStripMenuItem
			// 
			this.登出系統ToolStripMenuItem.Name = "登出系統ToolStripMenuItem";
			this.登出系統ToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
			this.登出系統ToolStripMenuItem.Text = "登出系統";
			this.登出系統ToolStripMenuItem.Click += new System.EventHandler(this.登出系統ToolStripMenuItem_Click);
			// 
			// btnUpdateUser
			// 
			this.btnUpdateUser.Location = new System.Drawing.Point(26, 102);
			this.btnUpdateUser.Name = "btnUpdateUser";
			this.btnUpdateUser.Size = new System.Drawing.Size(93, 23);
			this.btnUpdateUser.TabIndex = 1;
			this.btnUpdateUser.Text = "會員資料更新";
			this.btnUpdateUser.UseVisualStyleBackColor = true;
			this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
			// 
			// btnPwdUpdate
			// 
			this.btnPwdUpdate.Location = new System.Drawing.Point(139, 101);
			this.btnPwdUpdate.Name = "btnPwdUpdate";
			this.btnPwdUpdate.Size = new System.Drawing.Size(90, 23);
			this.btnPwdUpdate.TabIndex = 2;
			this.btnPwdUpdate.Text = "會員密碼更新";
			this.btnPwdUpdate.UseVisualStyleBackColor = true;
			this.btnPwdUpdate.Click += new System.EventHandler(this.btnPwdUpdate_Click);
			// 
			// btnOrder
			// 
			this.btnOrder.Location = new System.Drawing.Point(267, 101);
			this.btnOrder.Name = "btnOrder";
			this.btnOrder.Size = new System.Drawing.Size(75, 23);
			this.btnOrder.TabIndex = 3;
			this.btnOrder.Text = "線上訂房";
			this.btnOrder.UseVisualStyleBackColor = true;
			this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
			// 
			// btnSearchOrder
			// 
			this.btnSearchOrder.Location = new System.Drawing.Point(383, 101);
			this.btnSearchOrder.Name = "btnSearchOrder";
			this.btnSearchOrder.Size = new System.Drawing.Size(91, 23);
			this.btnSearchOrder.TabIndex = 4;
			this.btnSearchOrder.Text = "查詢訂房紀錄";
			this.btnSearchOrder.UseVisualStyleBackColor = true;
			this.btnSearchOrder.Click += new System.EventHandler(this.btnSearchOrder_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(533, 300);
			this.Controls.Add(this.btnSearchOrder);
			this.Controls.Add(this.btnOrder);
			this.Controls.Add(this.btnPwdUpdate);
			this.Controls.Add(this.btnUpdateUser);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormMain";
			this.Text = "FormMain";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 登出系統ToolStripMenuItem;
		private System.Windows.Forms.Button btnUpdateUser;
		private System.Windows.Forms.Button btnPwdUpdate;
		private System.Windows.Forms.Button btnOrder;
		private System.Windows.Forms.Button btnSearchOrder;
	}
}