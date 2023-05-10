using Cats_Villa.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cats_Villa.ViewModels
{
	public class OrderVM
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public int RoomId { get; set; }

		[Display(Name = "房間類型")]
		[Required(ErrorMessage = "房型必填")]
		public string RoomType { get; set; }

        [Display(Name = "入住日期")]
		[Required(ErrorMessage = "入住日期必填")]
		[DataType(DataType.Date, ErrorMessage = "入住日期不小於退房日期")]
		public DateTime CheckInDate { get; set; }
		[Display(Name = "退房日期")]
		[Required(ErrorMessage = "退房日期必填")]
		public DateTime CheckOutDate { get; set; }
		
		[Display(Name = "訂單成立時間")]
		public DateTime OrderCreat_at { get; set; }
		[Display(Name = "房間價格")]
		[Required(ErrorMessage = "房間價格必填")]
		public int OrderPrice { get; set; }

	}
	public static class OrderDtoExts
	{
		public static OrderVM ToViewModel(this OrderDto dto)
		{
			return new OrderVM
			{
				Id = dto.Id,
				UserId = dto.UserId,
				RoomId = dto.RoomId,
				RoomType = dto.RoomType,
				CheckInDate = dto.CheckInDate,
				CheckOutDate = dto.CheckOutDate,
				OrderCreat_at = dto.OrderCreat_at,
				OrderPrice = dto.OrderPrice,
			};
		}
	}
	public class OrderAddVM
	{
		
		public int UserId { get; set; }
		//public int RoomId { get; set; }

		[Display(Name = "房間類型")]
		[Required(ErrorMessage = "房型必填")]
		public string RoomType { get; set; }

		[Display(Name = "入住日期")]
		[Required(ErrorMessage = "入住日期必填")]
		[DataType(DataType.Date, ErrorMessage = "入住日期不小於退房日期")]
		public DateTime CheckInDate { get; set; }
		[Display(Name = "退房日期")]
		[Required(ErrorMessage = "退房日期必填")]
		public DateTime CheckOutDate { get; set; }

		//[Display(Name = "訂單成立時間")]
		//public DateTime OrderCreat_at { get; set; }
		[Display(Name = "房間價格")]
		[Required(ErrorMessage = "房間價格必填")]
		public int OrderPrice { get; set; }

	}
	public static class OrderAddVMExts
	{
		public static OrderAddDto ToDto(this OrderAddVM vm)
		{
			return new OrderAddDto
			{
				UserId = vm.UserId,
				//RoomId = vm.RoomId,
				RoomType = vm.RoomType,
				CheckInDate = vm.CheckInDate,
				CheckOutDate = vm.CheckOutDate,
				//OrderCreat_at = vm.OrderCreat_at,
				OrderPrice = vm.OrderPrice,
			};
		}
	}

	public class OrderEditVM
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public int RoomId { get; set; }

		[Display(Name = "房間類型")]
		[Required(ErrorMessage = "房型必填")]
		public string RoomType { get; set; }

		[Display(Name = "入住日期")]
		[Required(ErrorMessage = "入住日期必填")]
		[DataType(DataType.Date, ErrorMessage = "入住日期不小於退房日期")]
		public DateTime CheckInDate { get; set; }
		[Display(Name = "退房日期")]
		[Required(ErrorMessage = "退房日期必填")]
		public DateTime CheckOutDate { get; set; }

		[Display(Name = "訂單成立時間")]
		public DateTime OrderCreat_at { get; set; }
		[Display(Name = "房間價格")]
		[Required(ErrorMessage = "房間價格必填")]
		public int OrderPrice { get; set; }

	}
	public static class OrderEditVMExts
	{
		public static OrderEditDto ToDto(this OrderEditVM vm)
		{
			return new OrderEditDto
			{
				Id = vm.Id,
				UserId = vm.UserId,
				RoomId = vm.RoomId,
				RoomType = vm.RoomType,
				CheckInDate = vm.CheckInDate,
				CheckOutDate = vm.CheckOutDate,
				OrderCreat_at = vm.OrderCreat_at,
				OrderPrice = vm.OrderPrice,
			};
		}
		public static OrderEditVM ToViewModel(this OrderEditDto dto)
		{
			return new OrderEditVM
			{
				Id = dto.Id,
				UserId = dto.UserId,
				RoomId = dto.RoomId,
				RoomType = dto.RoomType,
				CheckInDate = dto.CheckInDate,
				CheckOutDate = dto.CheckOutDate,
				OrderCreat_at = dto.OrderCreat_at,
				OrderPrice = dto.OrderPrice,
			};
		}
	}
}
