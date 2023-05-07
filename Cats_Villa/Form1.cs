using Cats_Villa.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cats_Villa
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SqlDb.ApplicationName = "LEIAN";
			string connStr = SqlDb.GetConnectString("default");
			label1.Text = connStr;
		}

		private void btnGetConnection_Click(object sender, EventArgs e)
		{
			SqlDb.Pooling = checkBoxPooling.Checked;
			SqlConnection conn = SqlDb.GetConnection("default");
			conn.Open();

			string sql = "SELECT ID FROM Users";
			SqlCommand command = new SqlCommand(sql, conn);//SqlCommand 下CRUD指令

			SqlDataReader reader = command.ExecuteReader();//ExecuteReader 執行完之後放到SqlDataReader
			reader.Close();
			conn.Close();//記得一定要關
		}

		private void btnUsing_Click(object sender, EventArgs e)
		{
			SqlDb.Pooling = checkBoxPooling.Checked;
			using (SqlConnection conn = SqlDb.GetConnection("default"))
			{
				conn.Open();
				string sql = "SELECT ID FROM Users";
				using (SqlCommand command = new SqlCommand(sql, conn))
				{
					SqlDataReader reader = command.ExecuteReader();
					reader.Close();

				}

			}
		}
	}
}
