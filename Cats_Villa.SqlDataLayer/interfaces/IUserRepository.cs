using Cats_Villa.SqlDataLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats_Villa.SqlDataLayer.interfaces
{
	public interface IUserRepository
	{
		void Create(UserEntity entity);
		void Update(UserEntity entity);
		void Delete(int userId);
		UserEntity Get(int userId);//查詢一筆所以不用list包
		List<UserEntity> Search(string userName, int? userId);//查詢多筆用list包
	}
}
