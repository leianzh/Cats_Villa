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
		public DateTime CatBirth { get; private set; }
		public string CatGender { get; private set; }
		public string CatBreed { get; private set; }
		public string Account { get; private set; }
		public string Password { get; private set; }
		public string Phone { get; private set; }
		public UserEntity(string userName, string catName, DateTime catBirth, string catGender, string catBreed, string account, string password, string phone, int id = 0)
		{
			// todo 在這裡,需要檢查各傳入值的正確性

			this.Id = id;
			this.UserName = userName;
			this.CatName= catName;
			this.CatBirth = CatBirth;
			this.CatGender = catGender;
			this.CatBreed = catBreed;
			this.Account = account;
			this.Password = password;
			this.Phone = phone;
	}
	}
	
}
