using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats_Villa.SqlDataLayer.Core
{
	public class RoomEntity
	{
        public int Id { get; private set; }
        public string RoomType { get; private set; }
        public int RoomPrice { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string RoomsImage { get; private set; }
        public RoomEntity(string roomType, int roomPrice,string title,string description,string roomsImage, int id = 0) 
        {
            Id = id;
            RoomType = roomType;
			RoomPrice = roomPrice;
            Title = title;
            Description = description;
            RoomsImage = roomsImage;
        }
    }
}
