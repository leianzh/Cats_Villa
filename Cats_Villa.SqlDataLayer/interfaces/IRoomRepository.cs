using Cats_Villa.SqlDataLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats_Villa.SqlDataLayer.interfaces
{
	public interface IRoomRepository
	{
		void Create(RoomEntity entity);
		void Update(RoomEntity entity);
		void Delete(int roomId);
		RoomEntity Get(int roomId);
		List<RoomEntity> Search(string roomType,int? roomPrice, string title,string description,string roomsImage, int? roomId);
	}
}
