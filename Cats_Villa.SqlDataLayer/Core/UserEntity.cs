using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats_Villa.SqlDataLayer.Core
{
	public class UserEntity
	{
		public int Id { get; private set; }
		public string UserName { get; private set; }
		public string CatName { get; private set; }
		public int CatAge { get; private set; }
		public string CatGender { get; private set; }
		public string CatBreed { get; private set; }
		public string Account { get; private set; }
		public string Password { get; private set; }
		public string ConfirmPassword { get; private set; }
		public string Phone { get; private set; }
		public UserEntity(string userName, string catName, int catAge, string catGender, string catBreed, string account, string password, string confirmPassword, string phone, int id = 0)
		{
			// todo 在這裡,需要檢查各傳入值的正確性

			this.Id = id;
			this.UserName = userName;
			this.CatName= catName;
			this.CatAge = catAge;
			this.CatGender = catGender;
			this.CatBreed = catBreed;
			this.Account = account;
			this.Password = password;
			this.ConfirmPassword = confirmPassword;
			this.Phone = phone;
	}
	}
	
}
