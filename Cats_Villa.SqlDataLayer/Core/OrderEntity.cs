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
        public DateTime CheckInDate { get; private set; }
        public DateTime CheckOutDate { get; private set; }
        public int StayDuration { get; private set; }
        public DateTime OrderCreat_at { get; private set; }
        public int Price { get; private set; }  
        public OrderEntity(int userId, int roomId, DateTime checkInDate, DateTime checkOutDate, int stayDuration, DateTime orderCreat_at, int price,int id = 0)
		{
			Id = id;
			UserId = userId;
			RoomId = roomId;
			CheckInDate = checkInDate;
			CheckOutDate = checkOutDate;
			StayDuration = stayDuration;
			OrderCreat_at = orderCreat_at;
			Price = price;
		}
	}
}
