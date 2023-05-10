using Cats_Villa.SqlDataLayer.Core;
using Cats_Villa.SqlDataLayer.interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Cats_Villa.SqlDataLayer.infra.SqlRepositories
{
	public class SqlOrderRepository : IOrderRepository
	{
		public void Create(OrderEntity entity)
		{
			string sql = "INSERT INTO [Order](RoomType,CheckInDate,CheckOutDate,OrderCreat_at,OrderPrice, UserId)VALUES(@RoomType,@CheckInDate,@CheckOutDate,@OrderCreat_at,@OrderPrice, @UserId)";

			var parameters = SqlParameterBuilder.Create()
				.AddNvarchar("@RoomType", 100, entity.RoomType)
				.AddDateTime("CheckInDate",entity.CheckInDate)
				.AddDateTime("CheckOutDate", entity.CheckOutDate)
				.AddDateTime("OrderCreat_at", DateTime.Now)
				.AddInt("OrderPrice",entity.OrderPrice)
				.AddInt("@UserId", entity.UserId)
				.Build();

			SqlDb.Create(SqlDb.GetConnection, sql, parameters);
		}

		public void Delete(int orderId)
		{
			string sql = "DELETE FROM Orders WHERE Id=" + orderId;

			SqlDb.UpdateOrDelete(SqlDb.GetConnection, sql, null);
		}

		public OrderEntity Get(int userId)
		{
			string sql = "SELECT * FROM Order WHERE Id=" + userId;

			Func<SqlDataReader, OrderEntity> funcAssembler = reader => {
				int id = reader.GetInt32("Id", 0);
				int usersId = reader.GetInt32("UserId", 0);
				int roomId = reader.GetInt32("RoomId", 0);
				string roomType = reader.GetString("RoomType");
				DateTime checkInDate = (DateTime)reader.GetDateTime("CheckInDate");
				DateTime checkOutDate = (DateTime)reader.GetDateTime("CheckOutDate");
				DateTime orderCreat_at = (DateTime)reader.GetDateTime("OrderCreat_at");
				int orderPrice =reader.GetInt32("OrderPrice", 0);

				return new OrderEntity(usersId, roomId, roomType, checkInDate, checkOutDate, orderCreat_at, orderPrice, id);
			};

			return SqlDb.Get<OrderEntity>(SqlDb.GetConnection, funcAssembler, sql, null);
		}

		

		public List<OrderEntity> Search(string roomType,int? orderPrice, DateTime? checkInDate, DateTime? checkOutDate, int? userId)
		{
			List<SqlParameter> parameters = new List<SqlParameter>();

			string sql = "SELECT * FROM [Order]";

			#region 組合出 where 條件
			string where = string.Empty;

			if (string.IsNullOrEmpty(roomType) == false)
			{
				where += " AND RoomType=@RoomType";
				parameters.Add(new SqlParameter("@RoomType", System.Data.SqlDbType.NVarChar, 100) { Value = roomType });
			}

			if (orderPrice != null)
			{
				where += " AND OrderPrice=@OrderPrice";
				parameters.Add(new SqlParameter("@OrderPrice", System.Data.SqlDbType.Int) { Value = orderPrice });
			}

			if (checkInDate.HasValue)
			{
				where += " AND CheckInDate=@CheckInDate";
				parameters.Add(new SqlParameter("@CheckInDate", System.Data.SqlDbType.DateTime) { Value = checkInDate });
			}


			if (checkOutDate.HasValue)
			{
				where += " AND CheckOutDate=@CheckOutDate";
				parameters.Add(new SqlParameter("@CheckOutDate", System.Data.SqlDbType.DateTime) { Value = checkOutDate });
			}

			if (userId.HasValue)
			{
				where += " AND id=" + userId.Value;
			}

			where = string.IsNullOrEmpty(where) ? string.Empty : " WHERE " + where.Substring(5);
			sql += where;
			#endregion

			Func<SqlDataReader, OrderEntity> funcAssembler = reader =>
			{
				int id = reader.GetInt32("Id", 0);
				int usersId = reader.GetInt32("UserId", 0);
				int roomId = reader.GetInt32("RoomId", 0);
				string roomTypes = reader.GetString("RoomType");
				DateTime checkInDates = (DateTime)reader.GetDateTime("CheckInDate");
				DateTime checkOutDates = (DateTime)reader.GetDateTime("CheckOutDate");
				DateTime orderCreat_at = (DateTime)reader.GetDateTime("OrderCreat_at");
				int orderPrices = reader.GetInt32("OrderPrice", 0);

				return new OrderEntity(usersId, roomId, roomType, checkInDates, checkOutDates, orderCreat_at, orderPrices, id);
			};

			return SqlDb.Search(SqlDb.GetConnection, funcAssembler, sql, parameters.ToArray());
		}

		public void Update(OrderEntity entity)
		{
			string sql = "UPDATE Order SET CheckInDate=@CheckInDate, CheckOutDate = @CheckOutDate WHERE Id=@UserId";

			var parameters = SqlParameterBuilder.Create()
				.AddInt("@UserId", entity.UserId)
				.AddDateTime("CheckInDate", entity.CheckInDate)
				.AddDateTime("CheckOutDate", entity.CheckOutDate)
				.Build();

			SqlDb.UpdateOrDelete(SqlDb.GetConnection, sql, parameters);
		}
	}
}
