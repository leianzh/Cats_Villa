﻿using Cats_Villa.SqlDataLayer.Core;
using Cats_Villa.SqlDataLayer.interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Cats_Villa.SqlDataLayer.infra.SqlRepositories
{
	public class SqlUserRepository : IUserRepository
	{
		public void Create(UserEntity entity)
		{
			string sql = "INSERT INTO Users (UserName, CatName,CatBirth,CatGender,CatBreed,Account,Password,Phone) \r\nVALUES (@UserName, @CatName,@CatBirth,@CatGender,@CatBreed,@Account,@Password,@Phone)";

			var parameters = SqlParameterBuilder.Create()
				.AddNvarchar("@UserName", 100, entity.UserName)
				.AddNvarchar("@CatName", 100, entity.CatName)
				.AddDateTime("@CatBirth", entity.CatBirth)
				.AddNvarchar("@CatGender", 100, entity.CatGender)
				.AddNvarchar("@CatBreed", 100, entity.CatBreed)
				.Addvarchar("@Account", 100, entity.Account)
				.Addvarchar("@Password", 100, entity.Password)
				.Addvarchar("@Phone", 100, entity.Phone)
				.Build();


			SqlDb.Create(SqlDb.GetConnection, sql, parameters);
		}

		public void Delete(int userId)
		{
			string sql = "DELETE FROM Users WHERE Id=" + userId;

			SqlDb.UpdateOrDelete(SqlDb.GetConnection, sql, null);
		}

		public UserEntity Get(int userId)
		{
			string sql = "SELECT * FROM Users WHERE Id = " + userId;
			Func<SqlDataReader, UserEntity> funcAssembler = reader =>
			{
				int id = reader.GetInt32("Id", 0);
				string userName = reader.GetString("UserName");
				string catName = reader.GetString("CatName");
				DateTime catBirth = (DateTime)reader.GetDateTime("CatBirth");
				string catGender = reader.GetString("CatGender");
				string catBreed = reader.GetString("CatBreed");
				string account = reader.GetString("Account");
				string password = reader.GetString("Password");
				string phone = reader.GetString("Phone");



				return new UserEntity(userName, catName, catBirth, catGender, catBreed, account, password, phone, id);
			};
			return SqlDb.Get<UserEntity>(SqlDb.GetConnection, funcAssembler, sql);
		}

		public User Get2(int userId)
		{
			throw new NotImplementedException();
		}

		public User GetByAccount(string account)
		{
			string sql = "SELECT * FROM Users WHERE Account=@Account";
			SqlParameter parameter = new SqlParameter("@Account", System.Data.SqlDbType.VarChar, 100) { Value = account };
			Func<SqlDataReader, User> funcAssembler = reader =>
			{
				int id = reader.GetInt32("Id", 0);
				string acc = reader.GetString("Account");
				string password = reader.GetString("Password");
				return new User() { Id = id, Account = acc, Password = password };
			};
			return SqlDb.Get<User>(SqlDb.GetConnection, funcAssembler, sql, parameter);
		}

		public List<UserEntity> Search(string userName, int? userId)
		{
			List<SqlParameter> parameters = new List<SqlParameter>();
			string sql = "SELECT * FROM Users";
			#region 組出where條件
			string where = string.Empty;
			if (string.IsNullOrEmpty(userName) == false)
			{
				where += " AND UserName =@UserName";
				parameters.Add(new SqlParameter("@UserName", System.Data.SqlDbType.NVarChar, 100) { Value = userName });

			}
			if (userId.HasValue)
			{
				where += " AND Id=" + userId.Value;
			}
			where = string.IsNullOrEmpty(where) ? string.Empty : " WHERE " + where.Substring(5);
			//5是扣掉AND和前後空白
			sql += where;
			#endregion

			
			Func<SqlDataReader, UserEntity> funcAssembler = reader =>
			{
				int id = reader.GetInt32("Id", 0);
				string userName2 = reader.GetString("UserName");
				string catName = reader.GetString("CatName");
				DateTime catBirth = (DateTime)reader.GetDateTime("CatBirth");
				string catGender = reader.GetString("CatGender");
				string catBreed = reader.GetString("CatBreed");
				string account = reader.GetString("Account");
				string password = reader.GetString("Password");
				string phone = reader.GetString("Phone");

				return new UserEntity(userName2, catName, catBirth, catGender, catBreed, account, password, phone, id);
			};
			return SqlDb.Search(SqlDb.GetConnection, funcAssembler, sql, parameters.ToArray());


		}

		public void Update(UserEntity entity)
		{
			string sql = @"UPDATE Users SET  
UserName=@UserName,
CatName = @CatName,
CatBirth = @CatBirth, 
CatGender=@CatGender,
CatBreed=@CatBreed,
Phone=@Phone WHERE Id=@Id";
			var parameters = SqlParameterBuilder.Create()
				.AddInt("@Id", entity.Id)
				.AddNvarchar("@UserName", 100, entity.UserName)
				.AddNvarchar("@CatName", 100, entity.CatName)
				.AddDateTime("@CatBirth", entity.CatBirth)
				.AddNvarchar("@CatGender", 100, entity.CatGender)
				.AddNvarchar("@CatBreed", 100, entity.CatBreed)
				.Addvarchar("@Phone", 100, entity.Phone)
				.Build();
			SqlDb.UpdateOrDelete(SqlDb.GetConnection, sql, parameters);
			
		}

		public void UpdatePassword(UserEntity entity)
		{
			string sql = "UPDATE Users SET Account=@Account,Password = @Password WHERE Id=@Id";
			var parameters = SqlParameterBuilder.Create()
				.AddInt("@Id", entity.Id)
				.Addvarchar("@Account", 100, entity.Account)
				.Addvarchar("@Password", 100, entity.Password)
				.Build();
			SqlDb.UpdateOrDelete(SqlDb.GetConnection, sql, parameters);

		}
	}
}
