using Cats_Villa.SqlDataLayer.Core;
using Cats_Villa.SqlDataLayer.interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats_Villa.SqlDataLayer.infra.SqlRepositories
{
	public class SqlUserRepository : IUserRepository
	{
		public void Create(UserEntity entity)
		{
			string sql = "INSERT INTO Users (UserName, CatName,CatAge,CatGender,CatBreed,Account,Password,ConfirmPassword,Phone) \r\nVALUES (@UserName, @CatName,@CatAge,@CatGender,@CatBreed,@Account,@Password,@ConfirmPassword,@Phone)";

			var parameters = SqlParameterBuilder.Create()
				.AddNvarchar("@UserName",100, entity.UserName)
				.AddNvarchar("@CatName", 100, entity.CatName)
				.AddInt("@CatAge",entity.CatAge)
				.AddNvarchar("@CatGender",100,entity.CatGender)
				.AddNvarchar("@CatBreed", 100, entity.CatBreed)
				.AddNvarchar("@CatGender", 100, entity.CatGender)
				.AddNvarchar("@CatGender", 100, entity.CatGender)
				.AddNvarchar("@CatGender", 100, entity.CatGender)
				.AddNvarchar("@CatGender", 100, entity.CatGender)


			SqlDb.Create(SqlDb.GetConnection, sql, parameters);
		}

		public void Delete(int userId)
		{
			string sql = "DELETE FROM Categories WHERE Id=" + userId;

			SqlDb.UpdateOrDelete(SqlDb.GetConnection, sql, null);
		}

		public UserEntity Get(int userId)
		{
			string sql = "SELECT * FROM Categories WHERE Id=" + userId;
			Func<SqlDataReader, UserEntity> funcAssembler = reader =>
			{
				int id = reader.GetInt32("Id", 0);
				string name = reader.GetString("Name");
				int displayOrder = reader.GetInt32("DisplayOrder", 0);

				return new UserEntity(name, displayOrder, id);
			};
			return SqlDb.Get<UserEntity>(SqlDb.GetConnection, funcAssembler, sql, null);
		}

		public List<UserEntity> Search(string userName, int? userId)
		{
			List<SqlParameter> parameters = new List<SqlParameter>();
			string sql = "SELECT * FROM Categories";
			#region 組出where條件
			string where = string.Empty;
			if (string.IsNullOrEmpty(categoryName) == false)
			{
				where += " AND name =@name";
				parameters.Add(new SqlParameter("@name", System.Data.SqlDbType.NVarChar, 20) { Value = categoryName });

			}
			if (userId.HasValue)
			{
				where += " AND Id=" + userId.Value;
			}
			where = string.IsNullOrEmpty(where) ? string.Empty : " WHERE " + where.Substring(5);
			//5是扣掉AND和前後空白
			sql += where;
			#endregion

			sql += " ORDER BY DisplayOrder";
			Func<SqlDataReader, UserEntity> funcAssembler = reader =>
			{
				int id = reader.GetInt32("Id", 0);
				string name = reader.GetString("Name");
				int displayOrder = reader.GetInt32("DisplayOrder", 0);

				return new UserEntity(name, displayOrder, id);
			};
			return SqlDb.Search(SqlDb.GetConnection, funcAssembler, sql, parameters.ToArray());


		}

		public void Update(UserEntity entity)
		{
			string sql = "UPDATE Categories SET name=@name,DisplayOrder = @DisplayOrder WHERE Id=@Id";
			var parameters = SqlParameterBuilder.Create()
				.AddInt("@Id", entity.Id)
				.AddNvarchar("@Name", 20, entity.Name)
				.AddInt("@DisplayOrder", entity.DisplayOrder)
				.Build();
			SqlDb.UpdateOrDelete(SqlDb.GetConnection, sql, parameters);
		}
	}
}
