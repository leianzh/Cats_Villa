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
	public class SqlRoomRepository : IRoomRepository
	{
		public void Create(RoomEntity entity)
		{
			string sql = "INSERT INTO Room(RoomType,RoomPrice, Title,Description,RoomsImage)VALUES(@RoomType,@RoomPrice, @Title,@Description,@RoomsImage)";

			var parameters = SqlParameterBuilder.Create()
				.AddNvarchar("@RoomType", 100, entity.RoomType)
				.AddInt("@RoomPrice", entity.RoomPrice)
				.AddNvarchar("@Title", 50, entity.Title)
				.AddNvarchar("@Description", 3000, entity.Description)
				.AddNvarchar("@RoomsImage", 100, entity.Description)
				.Build();

			SqlDb.Create(SqlDb.GetConnection, sql, parameters);
		}

		public void Delete(int roomId)
		{
			string sql = "DELETE FROM Room WHERE Id=" + roomId;

			SqlDb.UpdateOrDelete(SqlDb.GetConnection, sql, null);
		}

		public RoomEntity Get(int roomId)
		{
			string sql = "SELECT * FROM Room WHERE Id=" + roomId;

			Func<SqlDataReader, RoomEntity> funcAssembler = reader => {
				int id = reader.GetInt32("Id", 0);
				string roomType = reader.GetString("RoomType");
				int roomPrice = reader.GetInt32("RoomPrice", 0);
				string title = reader.GetString("Title");
				string description = reader.GetString("Description");
				string roomsImage = reader.GetString("RoomsImage");
				

				return new RoomEntity(roomType,roomPrice, title, description, roomsImage, id);
			};

			return SqlDb.Get<RoomEntity>(SqlDb.GetConnection, funcAssembler, sql, null);
		}

		public List<RoomEntity> Search(string roomType,int? roomPrice, string title, string description, string roomsImage, int? roomId)
		{
			List<SqlParameter> parameters = new List<SqlParameter>();

			string sql = "SELECT * FROM Room";

			#region 組合出 where 條件
			string where = string.Empty;
			if (string.IsNullOrEmpty(roomType) == false)
			{
				where += " AND RoomType=@RoomType";
				parameters.Add(new SqlParameter("@RoomType", System.Data.SqlDbType.NVarChar, 100) { Value = roomType });
			}

			if (roomPrice != null)
			{
				where += " AND RoomPrice=@RoomPrice";
				parameters.Add(new SqlParameter("@RoomPrice", System.Data.SqlDbType.Int) { Value = roomPrice });
			}

			if (string.IsNullOrEmpty(title) == false)
			{
				where += " AND Title=@Title";
				parameters.Add(new SqlParameter("@Title", System.Data.SqlDbType.NVarChar, 50) { Value = title });
			}

			if (string.IsNullOrEmpty(description) == false)
			{
				where += " AND Description=@Description";
				parameters.Add(new SqlParameter("@Description", System.Data.SqlDbType.NVarChar, 3000) { Value = description });
			}

			if (string.IsNullOrEmpty(roomsImage) == false)
			{
				where += " AND RoomsImage=@RoomsImage";
				parameters.Add(new SqlParameter("@RoomsImage", System.Data.SqlDbType.NVarChar, 100) { Value = roomsImage });
			}


			if (roomId.HasValue)
			{
				where += " AND id=" + roomId.Value;
			}

			where = string.IsNullOrEmpty(where) ? string.Empty : " WHERE " + where.Substring(5);
			sql += where;
			#endregion

			

			Func<SqlDataReader, RoomEntity> funcAssembler = reader => {
				int id = reader.GetInt32("Id", 0);
				string roomTypes = reader.GetString("RoomType");
				int roomPrices = reader.GetInt32("RoomPrice", 0);
				string titles = reader.GetString("Title");
				string descriptions = reader.GetString("Description");
				string roomsImages = reader.GetString("RoomsImage");
				

				return new RoomEntity(roomTypes, roomPrices, titles, descriptions, roomsImages, id);
			};

			return SqlDb.Search(SqlDb.GetConnection, funcAssembler, sql, parameters.ToArray());
		}

		public List<RoomEntity> Search(int? roomPrice, string title, string description, string roomsImage, int? roomId)
		{
			throw new NotImplementedException();
		}

		public void Update(RoomEntity entity)
		{
			string sql = "UPDATE Room SET RoomType=@RoomType, RoomPrice=@RoomPrice, Title = @Title,Description =@Description,RoomsImage=@RoomsImage WHERE Id=@Id";

			var parameters = SqlParameterBuilder.Create()
				.AddNvarchar("@RoomType", 100, entity.RoomType)
				.AddInt("@RoomPrice", entity.RoomPrice)
				.AddNvarchar("@Title", 50, entity.Title)
				.AddNvarchar("@Description", 3000, entity.Description)
				.AddNvarchar("@RoomsImage", 100, entity.Description)
				.Build();

			SqlDb.UpdateOrDelete(SqlDb.GetConnection, sql, parameters);
		}
	}
}
