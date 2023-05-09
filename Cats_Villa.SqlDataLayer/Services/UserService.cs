using Cats_Villa.SqlDataLayer.Core;
using Cats_Villa.SqlDataLayer.Dtos;
using Cats_Villa.SqlDataLayer.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats_Villa.SqlDataLayer.Services
{
	public class UserService
	{
		private readonly IUserRepository _repo;
		public UserService(IUserRepository repo)//建構函數傳了ICategoryRepository
														//所以fom去呼叫它
		{
			_repo = repo;
		}
		public bool IsVaild(string account, string password)
		{
			//precondition checks
			//account,password 必填
			if (string.IsNullOrEmpty(account)) { throw new ArgumentNullException(nameof(account), "帳號必填"); }
			if (string.IsNullOrEmpty(password)) { throw new ArgumentNullException(nameof(password), "密碼必填"); }
			//取得單一使用者
			User user = _repo.GetByAccount(account);
			if (user == null) { return false; }
			//判斷密碼是否正確
			string passwordInDb = user.Password;//正確密碼
												//如果不拘大小寫
			return (passwordInDb.ToLower() == password.ToLower());
			

		}
		public User GetByAccount(string account)
		{
			return _repo.GetByAccount(account);
		}
		public void Create(UserCreateDto dto)
		{
			// 檢查 name是否己存在
			var data = _repo.Search(dto.UserName, null);
			if (data != null && data.Count > 0) throw new Exception("名稱已存在");

			// 若名稱是唯一的, 允許新建記錄
			UserEntity entity = dto.ToEntity();
			_repo.Create(entity);
		}
		public void UpdatePassword(UserEditDto dto)
		{
			// 若名稱是唯一的, 允許更新記錄
			UserEntity entity = dto.ToEntity();
			_repo.UpdatePassword(entity);
		}

		public void Update(UserEditDto dto)
		{
			// 檢查 name是否己存在
			List<UserEntity> data = _repo.Search(dto.UserName, null);

			if (data != null && data.Count > 0)
			{
				if (data[0].Id != dto.Id) throw new Exception("名稱已存在,不允許更新");
			}

			// 若名稱是唯一的, 允許更新記錄
			UserEntity entity = dto.ToEntity();
			_repo.Update(entity);
		}

		public void Delete(int userId)
		{
			_repo.Delete(userId);
		}

		public List<UserDto> Search(string userName, int? userId)
		{
			List<UserEntity> data = _repo.Search(userName, userId);

			

			return data.Select(x => x.ToDto()).ToList();
		}

		public UserEditDto Get(int userId)
		{
			

			return _repo.Get(userId).ToEditDto();
		}
	}
}
