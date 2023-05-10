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
		public int Id { get;  set; }
		public int UserId { get; set; }
		public int RoomId { get;  set; }
		public string RoomType { get; set; }
		public DateTime CheckInDate { get;  set; }
		public DateTime CheckOutDate { get;  set; }
		public DateTime OrderCreat_at { get;  set; }
		public int OrderPrice { get;  set; }
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
				RoomType = entity.RoomType,
				CheckInDate = entity.CheckInDate,
				CheckOutDate = entity.CheckOutDate,
				OrderCreat_at = entity.OrderCreat_at,
				OrderPrice = entity.OrderPrice,
			};
		}
	}
	public class OrderAddDto
	{
		
		public int UserId { get; set; }
		public int RoomId { get; set; }
		public string RoomType { get; set; }
		public DateTime CheckInDate { get; set; }
		public DateTime CheckOutDate { get; set; }
		public DateTime OrderCreat_at { get; set; }
		public int OrderPrice { get; set; }
	}
	public static class OrderAddDtoExts
	{
		public static OrderEntity ToEntity(this OrderAddDto dto)
		{
			return new OrderEntity(dto.UserId, dto.RoomId ,dto.RoomType, dto.CheckInDate ,dto.CheckOutDate  , dto.OrderCreat_at ,dto.OrderPrice);
		}
	}
	public class OrderEditDto
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public int RoomId { get; set; }
		public string RoomType { get; set; }
		public DateTime CheckInDate { get; set; }
		public DateTime CheckOutDate { get; set; }
		public DateTime OrderCreat_at { get; set; }
		public int OrderPrice { get; set; }
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
				RoomType = entity.RoomType,
				CheckInDate = entity.CheckInDate,
				CheckOutDate = entity.CheckOutDate,
				OrderCreat_at = entity.OrderCreat_at,
				OrderPrice = entity.OrderPrice
			};
		}
		public static OrderEntity ToEntity(this OrderEditDto dto)
		{
			return new OrderEntity(dto.UserId, dto.RoomId, dto.RoomType, dto.CheckInDate, dto.CheckOutDate, dto.OrderCreat_at, dto.OrderPrice, dto.Id);
		}
	}
}
