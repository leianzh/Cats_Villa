using Cats_Villa.SqlDataLayer.Dtos;
using Cats_Villa.SqlDataLayer.infra.SqlRepositories;
using Cats_Villa.SqlDataLayer.interfaces;
using Cats_Villa.SqlDataLayer.Services;
using Cats_Villa.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cats_Villa
{
	public partial class FormEditPwdUser : Form
	{
		private readonly int _userID;
		public FormEditPwdUser(int userID)
		{
			InitializeComponent();
			_userID = userID;
		}

		private void btnUpdatePwd_Click(object sender, EventArgs e)
		{
			string account = txtAccount.Text;
			string password = txtPassword.Text;

			EditUserPasswordVM vm = new EditUserPasswordVM()
			{
				Id = _userID,
				Account = account,
				Password = password
			};
			//驗證vm閃錯誤訊息
			(bool isValid, List<ValidationResult> errors) validationResult = Validate(vm);
			if (validationResult.isValid == false)
			{
				this.errorProvider1.Clear();
				DisplayErrors(validationResult.errors);
				return;
			}

			UserEditDto dto = vm.ToDto();
			IUserRepository repo = new SqlUserRepository();
			UserService service = new UserService(repo);

			try
			{
				service.UpdatePassword(dto);
			}
			catch (Exception ex)
			{
				MessageBox.Show("更新失敗，錯誤原因:" + ex.Message);
				return;
			}
			
			MessageBox.Show("會員帳號密碼更新成功");
			this.DialogResult = DialogResult.OK;
		}
		private (bool isValid, List<ValidationResult> errors) Validate(EditUserPasswordVM vm)
		{
			// 得知要驗證規則
			ValidationContext context = new ValidationContext(vm, null, null);

			// 用來存放錯誤的集合,因為可能有零到多個錯誤
			List<ValidationResult> errors = new List<ValidationResult>();

			// 驗證 model
			bool validateAllProperties = true; // 是否驗證所有規則,而非只驗證Required規則
			bool isValid = Validator.TryValidateObject(vm, context, errors, validateAllProperties);

			return (isValid, errors);
		}
		private void DisplayErrors(List<ValidationResult> errors)
		{

			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Account", txtAccount},
				{"Password", txtPassword},
				

		};

			this.errorProvider1.Clear();

			foreach (ValidationResult error in errors)
			{
				string propName = error.MemberNames.FirstOrDefault();
				if (propName != null && map.TryGetValue(propName, out Control ctrl))
				{
					this.errorProvider1.SetError(ctrl, error.ErrorMessage);
				}
			}
		}

		private void FormEditPwdUser_Load(object sender, EventArgs e)
		{
			IUserRepository repo = new SqlUserRepository();
			UserService service = new UserService(repo);

			UserEditDto dto = service.Get(this._userID);
			EditUserPasswordVM vm = dto.ToPWDViewModel();

			txtAccount.Text = vm.Account;
			txtPassword.Text = vm.Password;
		}
	}
}
