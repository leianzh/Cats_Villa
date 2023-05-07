using Cats_Villa.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cats_Villa.ViewModels
{
	public class UserVM
	{

		public int Id { get; set; }

		[Display(Name = "使用者名稱")]
		[Required(ErrorMessage = "使用者名稱必填")]
		public string UserName { get; set; }

		[Display(Name = "貓咪名字")]
		[Required(ErrorMessage = "貓咪名字必填")]
		public string CatName { get; set; }

		[Display(Name = "貓咪年齡")]
		[Required(ErrorMessage = "{0}貓咪年齡必填")]
		[Range(1, 25, ErrorMessage = "{0}必須介於1~25之間")]
		public int CatAge { get; set; }

		[Display(Name = "貓咪性別")]
		[Required(ErrorMessage = "貓咪性別必填")]
		public string CatGender { get; set; }

		[Display(Name = "貓咪品種")]
		[Required(ErrorMessage = "貓咪品種必填")]
		public string CatBreed { get; set; }

		[Display(Name = "帳號")]
		[Required(ErrorMessage = "帳號必填")]
		[RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[A-Za-z\d])[\w]{6,}$", ErrorMessage = "帳號必須包含英文和數字，且英文和數字同時都要有，長度至少為6個字元")]
		public string Account { get; set; }

		[Display(Name = "密碼")]
		[Required(ErrorMessage = "密碼必填")]
		[RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[A-Za-z\d])[\w]{8,}$", ErrorMessage = "密碼必須包含英文和數字，且英文和數字同時都要有，長度至少為8個字元")]
		public string Password { get; set; }

		[Display(Name = "再次輸入密碼")]
		[Required(ErrorMessage = "請再次輸入密碼")]
		[Compare("Password", ErrorMessage = "兩次輸入的密碼不一致")]
		public string ConfirmPassword { get; set; }

		[Display(Name = "電話號碼")]
		[Range(1, 10, ErrorMessage = "{0}必須介於1~10之間")]
		[MaxLength(10, ErrorMessage = "{0}長度不可大於10")]
		public string Phone { get; set; }

	}
	public static class UserDtoExs //針對dto轉VM的擴充方法
	{
		public static UserVM ToViewModel(this UserDto dto)
		{
			return new UserVM
			{
				Id = dto.Id,
				UserName = dto.UserName,
				CatName = dto.CatName,
				CatAge = dto.CatAge,
				CatGender = dto.CatGender,
				CatBreed = dto.CatBreed,
				Account = dto.Account,
				Password = dto.Password,
				ConfirmPassword = dto.ConfirmPassword,
				Phone = dto.Phone,
			};
		}
	}
	public class CreateUserVM
	{
		[Display(Name = "使用者名稱")]
		[Required(ErrorMessage = "使用者名稱必填")]
		public string UserName { get; set; }

		[Display(Name = "貓咪名字")]
		[Required(ErrorMessage = "貓咪名字必填")]
		public string CatName { get; set; }

		[Display(Name = "貓咪年齡")]
		[Required(ErrorMessage = "{0}貓咪年齡必填")]
		[Range(1, 25, ErrorMessage = "{0}必須介於1~25之間")]
		public int CatAge { get; set; }

		[Display(Name = "貓咪性別")]
		[Required(ErrorMessage = "貓咪性別必填")]
		public string CatGender { get; set; }

		[Display(Name = "貓咪品種")]
		[Required(ErrorMessage = "貓咪品種必填")]
		public string CatBreed { get; set; }

		[Display(Name = "帳號")]
		[Required(ErrorMessage = "帳號必填")]
		[RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[A-Za-z\d])[\w]{6,}$", ErrorMessage = "帳號必須包含英文和數字，且英文和數字同時都要有，長度至少為6個字元")]
		public string Account { get; set; }

		[Display(Name = "密碼")]
		[Required(ErrorMessage = "密碼必填")]
		[RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[A-Za-z\d])[\w]{8,}$", ErrorMessage = "密碼必須包含英文和數字，且英文和數字同時都要有，長度至少為8個字元")]
		public string Password { get; set; }

		[Display(Name = "再次輸入密碼")]
		[Required(ErrorMessage = "請再次輸入密碼")]
		[Compare("Password", ErrorMessage = "兩次輸入的密碼不一致")]
		public string ConfirmPassword { get; set; }

		[Display(Name = "電話號碼")]
		[Range(1, 10, ErrorMessage = "{0}必須介於1~10之間")]
		[MaxLength(10, ErrorMessage = "{0}長度不可大於10")]
		public string Phone { get; set; }
	}
	public static class CreateUserVMExs //針對VM轉dto的擴充方法
	{
		public static UserCreateDto ToDto(this CreateUserVM vm)
		{
			return new UserCreateDto
			{
				UserName = vm.UserName,
				CatName = vm.CatName,
				CatAge = vm.CatAge,
				CatGender = vm.CatGender,
				CatBreed = vm.CatBreed,
				Account = vm.Account,
				Password = vm.Password,
				ConfirmPassword = vm.ConfirmPassword,
				Phone = vm.Phone,


			};
		}
	}
	public class EditUserVM
	{
		public int Id { get; set; }

		[Display(Name = "使用者名稱")]
		[Required(ErrorMessage = "使用者名稱必填")]
		public string UserName { get; set; }

		[Display(Name = "貓咪名字")]
		[Required(ErrorMessage = "貓咪名字必填")]
		public string CatName { get; set; }

		[Display(Name = "貓咪年齡")]
		[Required(ErrorMessage = "{0}貓咪年齡必填")]
		[Range(1, 25, ErrorMessage = "{0}必須介於1~25之間")]
		public int CatAge { get; set; }

		[Display(Name = "貓咪性別")]
		[Required(ErrorMessage = "貓咪性別必填")]
		public string CatGender { get; set; }

		[Display(Name = "貓咪品種")]
		[Required(ErrorMessage = "貓咪品種必填")]
		public string CatBreed { get; set; }

		[Display(Name = "帳號")]
		[Required(ErrorMessage = "帳號必填")]
		[RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[A-Za-z\d])[\w]{6,}$", ErrorMessage = "帳號必須包含英文和數字，且英文和數字同時都要有，長度至少為6個字元")]
		public string Account { get; set; }

		[Display(Name = "密碼")]
		[Required(ErrorMessage = "密碼必填")]
		[RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[A-Za-z\d])[\w]{8,}$", ErrorMessage = "密碼必須包含英文和數字，且英文和數字同時都要有，長度至少為8個字元")]
		public string Password { get; set; }

		[Display(Name = "再次輸入密碼")]
		[Required(ErrorMessage = "請再次輸入密碼")]
		[Compare("Password", ErrorMessage = "兩次輸入的密碼不一致")]
		public string ConfirmPassword { get; set; }

		[Display(Name = "電話號碼")]
		[Range(1, 10, ErrorMessage = "{0}必須介於1~10之間")]
		[MaxLength(10, ErrorMessage = "{0}長度不可大於10")]
		public string Phone { get; set; }

	}
	public static class UserEditVMExs//針對VM,dto互轉的擴充方法
	{
		public static UserEditDto ToDto(this EditUserVM vm)
		{
			return new UserEditDto
			{
				Id = vm.Id,
				UserName = vm.UserName,
				CatName = vm.CatName,
				CatAge = vm.CatAge,
				CatGender = vm.CatGender,
				CatBreed = vm.CatBreed,
				Account = vm.Account,
				Password = vm.Password,
				ConfirmPassword = vm.ConfirmPassword,
				Phone = vm.Phone,
			};
		}
		public static EditUserVM ToViewModel(this UserEditDto dto)
		{
			return new EditUserVM
			{
				Id = dto.Id,
				UserName = dto.UserName,
				CatName = dto.CatName,
				CatAge = dto.CatAge,
				CatGender = dto.CatGender,
				CatBreed = dto.CatBreed,
				Account = dto.Account,
				Password = dto.Password,
				ConfirmPassword = dto.ConfirmPassword,
				Phone = dto.Phone,
			};
		}
	}
}
