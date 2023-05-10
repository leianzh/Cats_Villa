using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats_Villa.SqlDataLayer.Core
{
	public class OrderEntity
	{
		public int Id { get; private set; }
        public int UserId { get; private set; }
        public int RoomId { get; private set; }
        public string RoomType { get; private set; }
        public DateTime CheckInDate { get; private set; }
        public DateTime CheckOutDate { get; private set; }
        public DateTime OrderCreat_at { get; private set; }
        public int OrderPrice { get; private set; }  
        public OrderEntity(int userId, int roomId,string roomType, DateTime checkInDate, DateTime checkOutDate, DateTime orderCreat_at, int orderPrice,int id = 0)
		{
			Id = id;
			UserId = userId;
			RoomId = roomId;
			RoomType = roomType;
			CheckInDate = checkInDate;
			CheckOutDate = checkOutDate;
			OrderCreat_at = orderCreat_at;
			OrderPrice = orderPrice;
		}
	}
}
