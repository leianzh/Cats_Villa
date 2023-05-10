using Cats_Villa.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cats_Villa.ViewModels
{
	public class RoomVM
	{
		public int Id { get; set; }
		[Display(Name = "房間類型")]
		[Required(ErrorMessage = "房型必填")]
		public string RoomType { get; set; }

        [Display(Name = "房間價格")]
		public int RoomPrice { get; set; }

		[Display(Name = "名稱")]
		public string Title { get; set; }

		[Display(Name = "房型描述")]
		public string Description { get; set; }
		[Display(Name = "房型照片")]
		public string RoomsImage { get; set; }
	}
	public static class RoomDtoExts
	{
		public static RoomVM ToViewModel(this RoomDto dto)
		{
			return new RoomVM
			{
				Id = dto.Id,
				RoomType = dto.RoomType,
				RoomPrice = dto.RoomPrice,
				Title = dto.Title,
				Description = dto.Description,
				RoomsImage = dto.RoomsImage
			};
		}
	}

	public class RoomAddVM 
	{
		[Display(Name = "房間類型")]
		[Required(ErrorMessage = "房型必填")]
		public string RoomType { get; set; }

		[Display(Name = "房間價格")]
		public int RoomPrice { get; set; }
		[Display(Name = "名稱")]
		public string Title { get; set; }
		[Display(Name = "房型描述")]
		public string Description { get; set; }
		[Display(Name = "房型照片")]
		public string RoomsImage { get; set; }

	}
	public static class RoomAddVMExts
	{
		public static RoomAddDto ToDto(this RoomAddVM vm)
		{
			return new RoomAddDto
			{
				RoomType = vm.RoomType,
				RoomPrice = vm.RoomPrice,
				Title = vm.Title,
				Description = vm.Description,
				RoomsImage = vm.RoomsImage
				
			};
		}
	}

	public class RoomEditVM 
	{

		public int Id { get; set; }
		[Display(Name = "房間類型")]
		[Required(ErrorMessage = "房型必填")]
		public string RoomType { get; set; }
		[Display(Name = "房間價格")]
		public int RoomPrice { get; set; }
		[Display(Name = "名稱")]
		public string Title { get; set; }
		[Display(Name = "房型描述")]
		public string Description { get; set; }
		[Display(Name = "房型照片")]
		public string RoomsImage { get; set; }

	}
	public static class RoomEditVMExts
	{
		public static RoomEditDto ToDto(this RoomEditVM vm)
		{
			return new RoomEditDto
			{
				Id = vm.Id,
				RoomType = vm.RoomType,
				RoomPrice = vm.RoomPrice,
				Title = vm.Title,
				Description = vm.Description,
				RoomsImage = vm.RoomsImage,
			};
		}
		public static RoomEditVM ToViewModel(this RoomEditDto dto)
		{
			return new RoomEditVM
			{
				Id = dto.Id,
				RoomType = dto.RoomType,
				RoomPrice = dto.RoomPrice,
				Title = dto.Title,
				Description = dto.Description,
				RoomsImage = dto.RoomsImage
			};
		}
	}
}
