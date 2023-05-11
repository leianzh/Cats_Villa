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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.DarkGoldenrod;
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.登出系統ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1556, 31);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 登出系統ToolStripMenuItem
			// 
			this.登出系統ToolStripMenuItem.Name = "登出系統ToolStripMenuItem";
			this.登出系統ToolStripMenuItem.Size = new System.Drawing.Size(62, 27);
			this.登出系統ToolStripMenuItem.Text = "登出";
			this.登出系統ToolStripMenuItem.Click += new System.EventHandler(this.登出系統ToolStripMenuItem_Click);
			// 
			// btnUpdateUser
			// 
			this.btnUpdateUser.BackColor = System.Drawing.Color.DarkKhaki;
			this.btnUpdateUser.Font = new System.Drawing.Font("新細明體-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnUpdateUser.Location = new System.Drawing.Point(57, 301);
			this.btnUpdateUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnUpdateUser.Name = "btnUpdateUser";
			this.btnUpdateUser.Size = new System.Drawing.Size(224, 118);
			this.btnUpdateUser.TabIndex = 0;
			this.btnUpdateUser.Text = "會員資料更新";
			this.btnUpdateUser.UseVisualStyleBackColor = false;
			this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
			// 
			// btnPwdUpdate
			// 
			this.btnPwdUpdate.BackColor = System.Drawing.Color.DarkKhaki;
			this.btnPwdUpdate.Font = new System.Drawing.Font("新細明體-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnPwdUpdate.Location = new System.Drawing.Point(321, 301);
			this.btnPwdUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnPwdUpdate.Name = "btnPwdUpdate";
			this.btnPwdUpdate.Size = new System.Drawing.Size(224, 118);
			this.btnPwdUpdate.TabIndex = 1;
			this.btnPwdUpdate.Text = "會員密碼更新";
			this.btnPwdUpdate.UseVisualStyleBackColor = false;
			this.btnPwdUpdate.Click += new System.EventHandler(this.btnPwdUpdate_Click);
			// 
			// btnOrder
			// 
			this.btnOrder.BackColor = System.Drawing.Color.DarkKhaki;
			this.btnOrder.Font = new System.Drawing.Font("新細明體-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnOrder.Location = new System.Drawing.Point(584, 301);
			this.btnOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnOrder.Name = "btnOrder";
			this.btnOrder.Size = new System.Drawing.Size(224, 118);
			this.btnOrder.TabIndex = 2;
			this.btnOrder.Text = "線上訂房";
			this.btnOrder.UseVisualStyleBackColor = false;
			this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
			// 
			// btnSearchOrder
			// 
			this.btnSearchOrder.BackColor = System.Drawing.Color.DarkKhaki;
			this.btnSearchOrder.Font = new System.Drawing.Font("新細明體-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnSearchOrder.Location = new System.Drawing.Point(848, 301);
			this.btnSearchOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSearchOrder.Name = "btnSearchOrder";
			this.btnSearchOrder.Size = new System.Drawing.Size(224, 118);
			this.btnSearchOrder.TabIndex = 3;
			this.btnSearchOrder.Text = "查詢訂房紀錄";
			this.btnSearchOrder.UseVisualStyleBackColor = false;
			this.btnSearchOrder.Click += new System.EventHandler(this.btnSearchOrder_Click);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.DarkGray;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.textBox1.ForeColor = System.Drawing.Color.White;
			this.textBox1.Location = new System.Drawing.Point(57, 56);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(142, 35);
			this.textBox1.TabIndex = 5;
			this.textBox1.Text = "蚵仔貓咪旅館";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkKhaki;
			this.BackgroundImage = global::Cats_Villa.Properties.Resources.main1;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(1556, 909);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnSearchOrder);
			this.Controls.Add(this.btnOrder);
			this.Controls.Add(this.btnPwdUpdate);
			this.Controls.Add(this.btnUpdateUser);
			this.Controls.Add(this.menuStrip1);
			this.ForeColor = System.Drawing.Color.Snow;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(1578, 965);
			this.Name = "FormMain";
			this.Text = "蚵仔貓咪旅館";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.Load += new System.EventHandler(this.FormMain_Load);
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
		private System.Windows.Forms.TextBox textBox1;
	}
}