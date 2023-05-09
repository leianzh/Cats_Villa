using Cats_Villa.SqlDataLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cats_Villa.SqlDataLayer.Dtos
{
	public class OrderDto
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public int RoomId { get; set; }
		
		public DateTime CheckInDate { get; set; }
		
		public DateTime CheckOutDate { get; set; }
		
		public int StayDuration { get; set; }
		
		public DateTime OrderCreat_at { get; set; }
		
		public int Price { get; set; }
	}
	public static class OrderEntityExts
	{
		public static OrderDto ToDto(this OrderEntity entity)
		{
			return new OrderDto
			{
				Id = entity.Id,
				UserId = entity.UserId,
				RoomId = entity.RoomId,
				CheckInDate = entity.CheckInDate,
				CheckOutDate = entity.CheckOutDate,
				StayDuration = entity.StayDuration,
				OrderCreat_at = entity.OrderCreat_at,
				Price = entity.Price,
			};
		}
	}
	public class OrderAddDto
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public int RoomId { get; set; }

		public DateTime CheckInDate { get; set; }

		public DateTime CheckOutDate { get; set; }

		public int StayDuration { get; set; }

		public DateTime OrderCreat_at { get; set; }

		public int Price { get; set; }
	}
	public static class OrderAddDtoExts
	{
		public static OrderEntity ToEntity(this OrderAddDto dto)
		{
			return new OrderEntity(dto.UserId, dto.RoomId , dto.CheckInDate ,dto.CheckOutDate ,dto.StayDuration , dto.OrderCreat_at ,dto.Price,dto.Id);
		}
	}
	public class OrderEditDto
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public int RoomId { get; set; }

		public DateTime CheckInDate { get; set; }

		public DateTime CheckOutDate { get; set; }

		public int StayDuration { get; set; }

		public DateTime OrderCreat_at { get; set; }

		public int Price { get; set; }
	}
	public static class OrderEditDtoExts
	{
		public static OrderEditDto ToEditDto(this OrderEntity entity)
		{
			return new OrderEditDto
			{
				Id = entity.Id,
				UserId = entity.UserId,
				RoomId = entity.RoomId,
				CheckInDate = entity.CheckInDate,
				CheckOutDate = entity.CheckOutDate,
				StayDuration = entity.StayDuration,
				OrderCreat_at = entity.OrderCreat_at,
				Price = entity.Price
			};
		}
		public static OrderEntity ToEntity(this OrderEditDto dto)
		{
			return new OrderEntity(dto.UserId, dto.RoomId, dto.CheckInDate, dto.CheckOutDate, dto.StayDuration, dto.OrderCreat_at, dto.Price, dto.Id);
		}
	}
}
