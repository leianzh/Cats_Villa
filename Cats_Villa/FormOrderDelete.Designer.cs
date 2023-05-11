namespace Cats_Villa
{
	partial class FormOrderDelete
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtRoomType = new System.Windows.Forms.TextBox();
			this.txtCheckIn = new System.Windows.Forms.TextBox();
			this.txtCheckOut = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.修改訂單ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnEditOrder = new System.Windows.Forms.Button();
			this.btnDeleteOrder = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(48, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "房型";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(48, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "入住日期";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(48, 150);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 12);
			this.label3.TabIndex = 2;
			this.label3.Text = "退房日期";
			// 
			// txtRoomType
			// 
			this.txtRoomType.Location = new System.Drawing.Point(137, 44);
			this.txtRoomType.Name = "txtRoomType";
			this.txtRoomType.Size = new System.Drawing.Size(100, 22);
			this.txtRoomType.TabIndex = 3;
			// 
			// txtCheckIn
			// 
			this.txtCheckIn.Location = new System.Drawing.Point(137, 93);
			this.txtCheckIn.Name = "txtCheckIn";
			this.txtCheckIn.Size = new System.Drawing.Size(100, 22);
			this.txtCheckIn.TabIndex = 4;
			// 
			// txtCheckOut
			// 
			this.txtCheckOut.Location = new System.Drawing.Point(137, 140);
			this.txtCheckOut.Name = "txtCheckOut";
			this.txtCheckOut.Size = new System.Drawing.Size(100, 22);
			this.txtCheckOut.TabIndex = 5;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改訂單ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 修改訂單ToolStripMenuItem
			// 
			this.修改訂單ToolStripMenuItem.Name = "修改訂單ToolStripMenuItem";
			this.修改訂單ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.修改訂單ToolStripMenuItem.Text = "修改訂單";
			// 
			// btnEditOrder
			// 
			this.btnEditOrder.Location = new System.Drawing.Point(247, 217);
			this.btnEditOrder.Name = "btnEditOrder";
			this.btnEditOrder.Size = new System.Drawing.Size(75, 23);
			this.btnEditOrder.TabIndex = 7;
			this.btnEditOrder.Text = "修改訂單";
			this.btnEditOrder.UseVisualStyleBackColor = true;
			this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
			// 
			// btnDeleteOrder
			// 
			this.btnDeleteOrder.Location = new System.Drawing.Point(366, 217);
			this.btnDeleteOrder.Name = "btnDeleteOrder";
			this.btnDeleteOrder.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteOrder.TabIndex = 8;
			this.btnDeleteOrder.Text = "取消訂單";
			this.btnDeleteOrder.UseVisualStyleBackColor = true;
			this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// FormOrderDelete
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnDeleteOrder);
			this.Controls.Add(this.btnEditOrder);
			this.Controls.Add(this.txtCheckOut);
			this.Controls.Add(this.txtCheckIn);
			this.Controls.Add(this.txtRoomType);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormOrderDelete";
			this.Text = "FormOrderDelete";
			this.Load += new System.EventHandler(this.FormOrderDelete_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtRoomType;
		private System.Windows.Forms.TextBox txtCheckIn;
		private System.Windows.Forms.TextBox txtCheckOut;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 修改訂單ToolStripMenuItem;
		private System.Windows.Forms.Button btnEditOrder;
		private System.Windows.Forms.Button btnDeleteOrder;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}