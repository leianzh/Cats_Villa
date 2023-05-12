using Cats_Villa.SqlDataLayer.infra.SqlRepositories;
using Cats_Villa.SqlDataLayer.interfaces;
using Cats_Villa.SqlDataLayer.Services;
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
	public partial class FormBackLogin : Form
	{
		public FormBackLogin()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			IUserRepository userRepository = new SqlUserRepository();
			UserService service = new UserService(userRepository);

			try
			{
				bool validationResult = service.IsVaild(txtAccount.Text, txtPassword.Text);
				if (validationResult == false)
				{
					MessageBox.Show("帳號或密碼有誤，請再試一次");
					return;
				}
				User user = service.GetByAccount(txtAccount.Text);


				txtAccount.Text = string.Empty;
				txtPassword.Text = string.Empty;


				var frm = new FormOrderEditBack();
				frm.Owner = this;
				frm.ShowDialog();

				this.Hide();


				frm.ShowDialog();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

		}
		

	}
}

