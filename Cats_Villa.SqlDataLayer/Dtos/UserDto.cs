using Cats_Villa.SqlDataLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cats_Villa.SqlDataLayer.Dtos
{
	public class UserDto
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public string CatName { get; set; }
		public DateTime CatBirth { get; set; }
		public string CatGender { get; set; }
		public string CatBreed { get; set; }
		public string Account { get; set; }
		public string Password { get; set; }
		public string Phone { get; set; }
	}
	public static class UserEntityExts//針對傳入Entity,傳出Dto的擴充方法
	{
		public static UserDto ToDto(this UserEntity entity)
		{
			return new UserDto
			{
				Id = entity.Id,
				UserName = entity.UserName,
				CatName = entity.CatName,
				CatBirth = entity.CatBirth,
				CatGender = entity.CatGender,
				Account = entity.Account,
				Password = entity.Password,
				Phone = entity.Phone,
			};
		}
	}
	public class UserCreateDto
	{
		
		public string UserName { get; set; }
		public string CatName { get; set; }
		public DateTime CatBirth { get; set; }
		public string CatGender { get; set; }
		public string CatBreed { get; set; }
		public string Account { get; set; }
		public string Password { get; set; }
		public string Phone { get; set; }
	}
	public static class UserCreateDtoExts//針對傳入Dto,傳出Entity的擴充方法
	{
		public static UserEntity ToEntity(this UserCreateDto dto)
		{
			return new UserEntity(dto.UserName, dto.CatName,dto.CatBirth, dto.CatGender,dto.CatBreed,dto.Account,dto.Password,dto.Phone);
		}
	}
	public class UserEditDto
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public string CatName { get; set; }
		public DateTime CatBirth { get; set; }
		public string CatGender { get; set; }
		public string CatBreed { get; set; }
		public string Account { get; set; }
		public string Password { get; set; }
		public string Phone { get; set; }
	}
	public static class UserEditDtoExts//針對傳入Entity,傳出Dto的擴充方法
	{
		public static UserEditDto ToEditDto(this UserEntity entity)
		{
			return new UserEditDto
			{
				Id = entity.Id,
				UserName = entity.UserName,
				CatName = entity.CatName,
				CatBirth = entity.CatBirth,
				CatGender = entity.CatGender,
				CatBreed = entity.CatBreed,
				Account = entity.Account,
				Password = entity.Password,
				Phone = entity.Phone
			};
		}
		public static UserEntity ToEntity(this UserEditDto dto)//針對傳入EditDto,傳出Entity的擴充方法
		{
			return new UserEntity(dto.UserName, dto.CatName, dto.CatBirth, dto.CatGender, dto.CatBreed, dto.Account, dto.Password,  dto.Phone, dto.Id);
		}
	}
}
