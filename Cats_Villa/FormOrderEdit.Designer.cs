namespace Cats_Villa
{
	partial class FormOrderEdit
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnEditOrder = new System.Windows.Forms.Button();
			this.btnDeletOrder = new System.Windows.Forms.Button();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
			this.dataGridView1.Location = new System.Drawing.Point(25, 24);
			this.dataGridView1.MinimumSize = new System.Drawing.Size(836, 351);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(836, 351);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// btnEditOrder
			// 
			this.btnEditOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEditOrder.Location = new System.Drawing.Point(680, 422);
			this.btnEditOrder.Name = "btnEditOrder";
			this.btnEditOrder.Size = new System.Drawing.Size(75, 23);
			this.btnEditOrder.TabIndex = 1;
			this.btnEditOrder.Text = "修改訂單";
			this.btnEditOrder.UseVisualStyleBackColor = true;
			this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
			// 
			// btnDeletOrder
			// 
			this.btnDeletOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDeletOrder.Location = new System.Drawing.Point(802, 422);
			this.btnDeletOrder.Name = "btnDeletOrder";
			this.btnDeletOrder.Size = new System.Drawing.Size(75, 23);
			this.btnDeletOrder.TabIndex = 2;
			this.btnDeletOrder.Text = "取消訂單";
			this.btnDeletOrder.UseVisualStyleBackColor = true;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "Id";
			this.Column1.HeaderText = "編號";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "UserId";
			this.Column2.HeaderText = "使用者編號";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "RoomId";
			this.Column3.HeaderText = "房間編號";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "RoomType";
			this.Column4.HeaderText = "房型";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "CheckInDate";
			this.Column5.HeaderText = "入住日期";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column6
			// 
			this.Column6.DataPropertyName = "CheckOutDate";
			this.Column6.HeaderText = "退房日期";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			// 
			// Column7
			// 
			this.Column7.DataPropertyName = "OrderCreat_at";
			this.Column7.HeaderText = "訂單成立時間";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			// 
			// Column8
			// 
			this.Column8.DataPropertyName = "OrderPrice";
			this.Column8.HeaderText = "訂單價格";
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			// 
			// FormOrderEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(889, 457);
			this.Controls.Add(this.btnDeletOrder);
			this.Controls.Add(this.btnEditOrder);
			this.Controls.Add(this.dataGridView1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(905, 496);
			this.MinimumSize = new System.Drawing.Size(905, 496);
			this.Name = "FormOrderEdit";
			this.Text = "FormOrderEdit";
			this.Load += new System.EventHandler(this.FormOrderEdit_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnEditOrder;
		private System.Windows.Forms.Button btnDeletOrder;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
	}
}