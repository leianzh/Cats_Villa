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
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cats_Villa
{
	public partial class FormEditBaseUser : Form
	{
		private readonly int _userID;
		public FormEditBaseUser(int userID)
		{
			InitializeComponent();
			_userID = userID;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string userName = txtUserName.Text;
			string catName = txtCatName.Text;
			DateTime catBirth = dateTimePicker1.Value.Date;
			string catGender = txtCatGender.Text;
			string catBreed = txtCatBreed.Text;
			string phone = txtUserPhone.Text;

			EditUserVM vm = new EditUserVM()
			{
				Id = _userID,
				UserName= userName,
				CatName= catName,
				CatBirth= catBirth,
				CatGender= catGender,
				CatBreed = catBreed,
				Phone= phone
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
				service.Update(dto);
			}
			catch (Exception ex) 
			{
				MessageBox.Show("更新失敗，錯誤原因:" + ex.Message);
				return;
			}
			

			MessageBox.Show("會員資料更新成功");
			this.DialogResult = DialogResult.OK;

		}
		private (bool isValid, List<ValidationResult> errors) Validate(EditUserVM vm)
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
				{"UserName", txtUserName},
				{"CatName", txtCatName},
				{"CatBirth",dateTimePicker1},
				{"CatGender", txtCatGender},
				{"CatBreed", txtCatBreed},
				{"Phone", txtUserPhone},
				
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

		private void FormEditBaseUser_Load(object sender, EventArgs e)
		{
			IUserRepository repo = new SqlUserRepository();
			UserService service = new UserService(repo);

			UserEditDto dto = service.Get(this._userID);
			EditUserVM vm = dto.ToViewModel();

			txtUserName.Text = vm.UserName;
			txtCatName.Text = vm.CatName;
			dateTimePicker1.Text = vm.CatBirth.ToString();
			txtCatGender.Text = vm.CatGender;
			txtCatBreed.Text = vm.CatBreed;
			txtUserPhone.Text = vm.Phone;
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			DateTime catBirth = dateTimePicker1.Value.Date;


			if (catBirth > DateTime.Today)
			{
				MessageBox.Show("貓咪生日不能大於今天日期。", "日期錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
				dateTimePicker1.Value = DateTime.Today;
				return;
			}
		}
	}
}
