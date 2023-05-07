namespace Cats_Villa
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnGetConnection = new System.Windows.Forms.Button();
			this.checkBoxPooling = new System.Windows.Forms.CheckBox();
			this.btnUsing = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(51, 32);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(153, 33);
			this.button1.TabIndex = 0;
			this.button1.Text = "取得連線字串";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(58, 96);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "連線字串:";
			// 
			// btnGetConnection
			// 
			this.btnGetConnection.Location = new System.Drawing.Point(61, 143);
			this.btnGetConnection.Name = "btnGetConnection";
			this.btnGetConnection.Size = new System.Drawing.Size(112, 37);
			this.btnGetConnection.TabIndex = 2;
			this.btnGetConnection.Text = "連結到Db";
			this.btnGetConnection.UseVisualStyleBackColor = true;
			this.btnGetConnection.Click += new System.EventHandler(this.btnGetConnection_Click);
			// 
			// checkBoxPooling
			// 
			this.checkBoxPooling.AutoSize = true;
			this.checkBoxPooling.Location = new System.Drawing.Point(200, 151);
			this.checkBoxPooling.Name = "checkBoxPooling";
			this.checkBoxPooling.Size = new System.Drawing.Size(85, 22);
			this.checkBoxPooling.TabIndex = 3;
			this.checkBoxPooling.Text = "Pooling";
			this.checkBoxPooling.UseVisualStyleBackColor = true;
			// 
			// btnUsing
			// 
			this.btnUsing.Location = new System.Drawing.Point(61, 205);
			this.btnUsing.Name = "btnUsing";
			this.btnUsing.Size = new System.Drawing.Size(89, 45);
			this.btnUsing.TabIndex = 4;
			this.btnUsing.Text = "Using";
			this.btnUsing.UseVisualStyleBackColor = true;
			this.btnUsing.Click += new System.EventHandler(this.btnUsing_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnUsing);
			this.Controls.Add(this.checkBoxPooling);
			this.Controls.Add(this.btnGetConnection);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnGetConnection;
		private System.Windows.Forms.CheckBox checkBoxPooling;
		private System.Windows.Forms.Button btnUsing;
	}
}

