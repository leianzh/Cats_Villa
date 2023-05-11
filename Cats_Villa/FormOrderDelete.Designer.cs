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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrderDelete));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.修改訂單ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnEditOrder = new System.Windows.Forms.Button();
			this.btnDeleteOrder = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Linen;
			this.label1.Font = new System.Drawing.Font("新細明體-ExtB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.ForeColor = System.Drawing.Color.DimGray;
			this.label1.Location = new System.Drawing.Point(353, 115);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "房型";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Linen;
			this.label2.Font = new System.Drawing.Font("新細明體-ExtB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.ForeColor = System.Drawing.Color.DimGray;
			this.label2.Location = new System.Drawing.Point(353, 157);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "入住日期";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Linen;
			this.label3.Font = new System.Drawing.Font("新細明體-ExtB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.ForeColor = System.Drawing.Color.DimGray;
			this.label3.Location = new System.Drawing.Point(353, 211);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 19);
			this.label3.TabIndex = 2;
			this.label3.Text = "退房日期";
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Linen;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改訂單ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
			this.menuStrip1.Size = new System.Drawing.Size(1052, 24);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 修改訂單ToolStripMenuItem
			// 
			this.修改訂單ToolStripMenuItem.Name = "修改訂單ToolStripMenuItem";
			this.修改訂單ToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
			this.修改訂單ToolStripMenuItem.Text = "編輯訂單";
			// 
			// btnEditOrder
			// 
			this.btnEditOrder.BackColor = System.Drawing.Color.Linen;
			this.btnEditOrder.Font = new System.Drawing.Font("新細明體-ExtB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnEditOrder.ForeColor = System.Drawing.Color.DimGray;
			this.btnEditOrder.Location = new System.Drawing.Point(356, 328);
			this.btnEditOrder.Name = "btnEditOrder";
			this.btnEditOrder.Size = new System.Drawing.Size(131, 57);
			this.btnEditOrder.TabIndex = 3;
			this.btnEditOrder.Text = "修改訂單";
			this.btnEditOrder.UseVisualStyleBackColor = false;
			this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
			// 
			// btnDeleteOrder
			// 
			this.btnDeleteOrder.BackColor = System.Drawing.Color.Linen;
			this.btnDeleteOrder.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnDeleteOrder.ForeColor = System.Drawing.Color.DimGray;
			this.btnDeleteOrder.Location = new System.Drawing.Point(526, 328);
			this.btnDeleteOrder.Name = "btnDeleteOrder";
			this.btnDeleteOrder.Size = new System.Drawing.Size(131, 57);
			this.btnDeleteOrder.TabIndex = 4;
			this.btnDeleteOrder.Text = "取消訂單";
			this.btnDeleteOrder.UseVisualStyleBackColor = false;
			this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(458, 115);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 20);
			this.comboBox1.TabIndex = 0;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(458, 158);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
			this.dateTimePicker1.TabIndex = 1;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(458, 212);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
			this.dateTimePicker2.TabIndex = 2;
			// 
			// FormOrderDelete
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1052, 418);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.btnDeleteOrder);
			this.Controls.Add(this.btnEditOrder);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1096, 470);
			this.Name = "FormOrderDelete";
			this.Text = "編輯訂單";
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
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 修改訂單ToolStripMenuItem;
		private System.Windows.Forms.Button btnEditOrder;
		private System.Windows.Forms.Button btnDeleteOrder;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}