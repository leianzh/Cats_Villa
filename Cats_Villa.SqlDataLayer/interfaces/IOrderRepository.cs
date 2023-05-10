using Cats_Villa.SqlDataLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats_Villa.SqlDataLayer.interfaces
{
	public interface IOrderRepository
	{
		void Create(OrderEntity entity);
		void Update(OrderEntity entity);
		void Delete(int orderId);
		OrderEntity Get(int userId);
		List<OrderEntity> Search(string roomType,int? orderPrice,DateTime? checkInDate, DateTime? checkOutDate, int? userId);
	}
}
