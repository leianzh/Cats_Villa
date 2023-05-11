using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cats_Villa
{
	public partial class FormMain : Form
	{
		private readonly int _userID;
		public FormMain(int userID)
		{
			InitializeComponent();
			_userID = userID;
		}

		private void 登出系統ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
		}

		private void btnUpdateUser_Click(object sender, EventArgs e)
		{
			var frm = new FormEditBaseUser(_userID);
			frm.Owner = this;
			frm.ShowDialog();
		}

		private void btnPwdUpdate_Click(object sender, EventArgs e)
		{
			var frm = new FormEditPwdUser(_userID);
			frm.Owner = this;
			frm.ShowDialog();

		}

		private void btnOrder_Click(object sender, EventArgs e)
		{
			var frm = new FormOrder(_userID);
			frm.Owner = this;
			frm.ShowDialog();
		}

		private void btnSearchOrder_Click(object sender, EventArgs e)
		{
			
			var frm = new FormOrderEdit(_userID);
			frm.Owner = this;
			frm.ShowDialog();
		}
	}
}
