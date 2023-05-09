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
			throw new NotImplementedException();
		}

		public void Delete(int orderId)
		{
			string sql = "DELETE FROM Orders WHERE Id=" + orderId;

			SqlDb.UpdateOrDelete(SqlDb.GetConnection, sql, null);
		}

		public OrderEntity Get(int orderId)
		{
			throw new NotImplementedException();
		}

		public List<OrderEntity> Search(DateTime? checkInDate, DateTime? checkOutDate, int? orderId)
		{
			throw new NotImplementedException();
		}

		public void Update(OrderEntity entity)
		{
			throw new NotImplementedException();
		}
	}
}
