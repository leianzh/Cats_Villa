using Cats_Villa.SqlDataLayer.Core;
using Cats_Villa.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cats_Villa.SqlDataLayer.interfaces
{
	public interface IUserRepository
	{
		void Create(UserEntity entity);
		void Update(UserEntity entity);
		void UpdatePassword(UserEntity entity);
		void Delete(int userId);
		UserEntity Get(int userId);//查詢一筆所以不用list包
		List<UserEntity> Search(string userName, int? userId);//查詢多筆用list包
		User GetByAccount(string account);//供登入使用

		User Get2(int userId);//編輯紀錄時使用
	}
	public class User
	{
		public int Id { get; set; }
		public string Account { get; set; }
		public string Password { get; set; }
	}
}
