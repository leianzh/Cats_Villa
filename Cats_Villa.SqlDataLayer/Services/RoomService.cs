using Cats_Villa.SqlDataLayer.Core;
using Cats_Villa.SqlDataLayer.Dtos;
using Cats_Villa.SqlDataLayer.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats_Villa.SqlDataLayer.Services
{
	public class RoomService
	{
		private readonly IRoomRepository _repo;

		public RoomService(IRoomRepository repo)
		{
			_repo = repo;
		}

		public void Create(RoomAddDto dto)
		{


			// 若名稱是唯一的, 允許新建記錄
			RoomEntity entity = dto.ToEntity();
			_repo.Create(entity);
		}

		public void Update(RoomEditDto dto)
		{


			// 若名稱是唯一的, 允許更新記錄
			RoomEntity entity = dto.ToEntity();
			_repo.Update(entity);
		}

		public void Delete(int roomId)
		{
			_repo.Delete(roomId);
		}

		public List<RoomDto> Search(string roomType,int? roomPrice, string title, string description, string roomsImage, int? roomId)
		{
			List<RoomEntity> data = _repo.Search(roomType,roomPrice, title, description, roomsImage, roomId);


			return data.Select(x => x.ToDto()).ToList();
		}

		public RoomEditDto Get(int roomId)
		{


			return _repo.Get(roomId).ToEditDto();
		}
	}
}
