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
		public UserEntity(string userName, string catName, DateTime catBirth, string catGender, string catBreed, string account, string password, string phone, int id =0)
		{
			// todo 在這裡,需要檢查各傳入值的正確性
			//if (string.IsNullOrEmpty(userName))
			//{
			//	throw new ArgumentException("姓名不得為空", nameof(userName));
			//}

			//if (string.IsNullOrEmpty(catName))
			//{
			//	throw new ArgumentException("貓咪姓名必填", nameof(catName));
			//}

			//if (catBirth > DateTime.Now)
			//{
			//	throw new ArgumentException("貓咪生日必填", nameof(catBirth));
			//}
			//if (string.IsNullOrEmpty(catGender)) 
			//{
			//	throw new ArgumentException("貓咪性別必填", nameof(catGender));
			//}
			//if (string.IsNullOrEmpty(catBreed))
			//{
			//	throw new ArgumentException("貓咪品種必填", nameof(catBreed));
			//}

			//if (string.IsNullOrEmpty(account))
			//{
			//	throw new ArgumentException("帳號必填", nameof(account));
			//}

			//if (string.IsNullOrEmpty(password))
			//{
			//	throw new ArgumentException("密碼必填", nameof(password));
			//}
			//if (string.IsNullOrEmpty(phone))
			//{
			//	throw new ArgumentException("電話必填", nameof(phone));
			//}


			this.Id = id;
			this.UserName = userName;
			this.CatName = catName;
			this.CatBirth = catBirth;
			this.CatGender = catGender;
			this.CatBreed = catBreed;
			this.Account = account;
			this.Password = password;
			this.Phone = phone;
		}
	}

}
