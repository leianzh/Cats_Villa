﻿using Cats_Villa.SqlDataLayer.Dtos;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cats_Villa
{
	public partial class FormCreateUser : Form
	{
		public FormCreateUser()
		{
			InitializeComponent();
		}

		private void btnAddUser_Click(object sender, EventArgs e)
		{
			string userName = txtUserName.Text;
			string catName = txtCatName.Text;
			DateTime catBirth = DateTime.Parse(txtCatBirth.Text);
			string catGender = txtCatGender.Text;
			string catBreed = txtCatBreed.Text;
			string phone = txtUserPhone.Text;
			string account = txtAccount.Text;
			string password = txtPassword.Text;

			CreateUserVM vm = new CreateUserVM()
			{
				UserName = userName,
				CatName = catName,
				CatBirth = catBirth,
				CatGender = catGender,
				CatBreed = catBreed,
				Phone = phone,
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
			// 將 vm轉換成 dto
			UserCreateDto dto = vm.ToDto();
			IUserRepository repo = new SqlUserRepository();
			UserService service = new UserService(repo);

			service.Create(dto);
			var frm = new FormLogin();
			frm.Owner = this;
			this.Close();


		}
		private (bool isValid, List<ValidationResult> errors) Validate(CreateUserVM vm)
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
				{"CatBirth",txtCatBirth},
				{"CatGender", txtCatGender},
				{"CatBreed", txtCatBreed},
				{"Phone", txtUserPhone},
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

		

		private void FormCreateUser_Load(object sender, EventArgs e)
		{
			
		}

		private void FormCreateUser_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
		}
	}
	
}
