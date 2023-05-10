using Cats_Villa.SqlDataLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats_Villa.SqlDataLayer.Dtos
{
	public class RoomDto
	{
		public int Id { get;  set; }

		public string RoomType { get; set; }
		public int RoomPrice { get;  set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string RoomsImage { get; set; }
	}
	public static class RoomEntityExts
	{
		public static RoomDto ToDto(this RoomEntity entity)
		{
			return new RoomDto
			{
				Id = entity.Id,
				RoomType = entity.RoomType,
				RoomPrice = entity.RoomPrice,
				Title = entity.Title,
				Description = entity.Description,
				RoomsImage = entity.RoomsImage
			};
		}
	}
	public class RoomAddDto
	{
		public string RoomType { get;  set; }

		public int RoomPrice { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string RoomsImage { get; set; }
	}
	public static class RoomAddDtoExts
	{
		public static RoomEntity ToEntity(this RoomAddDto dto)
		{
			return new RoomEntity(dto.RoomType,dto.RoomPrice, dto.Title,dto.Description,dto.RoomsImage);
		}
	}
	public class RoomEditDto
	{
		public int Id { get; set; }
		public string RoomType { get; set; }
		public int RoomPrice { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string RoomsImage { get; set; }
	}
	public static class RoomEditDtoExts
	{
		public static RoomEditDto ToEditDto(this RoomEntity entity)
		{
			return new RoomEditDto
			{
				Id = entity.Id,
				RoomType = entity.RoomType,
				RoomPrice = entity.RoomPrice,
				Title = entity.Title,
				Description = entity.Description,
				RoomsImage = entity.RoomsImage
			};
		}
		public static RoomEntity ToEntity(this RoomEditDto dto)
		{
			return new RoomEntity(dto.RoomType,dto.RoomPrice, dto.Title, dto.Description, dto.RoomsImage, dto.Id);
		}
	}
}
