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
	public class OrderService
	{
		private readonly IOrderRepository _repo;

		public OrderService(IOrderRepository repo)
		{
			_repo = repo;
		}
		public void Create(OrderAddDto dto)
		{
			OrderEntity entity = dto.ToEntity();
			_repo.Create(entity);
		}

		public void Update(OrderEditDto dto)
		{
			OrderEntity entity = dto.ToEntity();
			_repo.Update(entity);
		}

		public void Delete(int orderId)
		{
			_repo.Delete(orderId);
		}

		public List<OrderDto> Search(string roomType,int? orderPrice,DateTime? checkInDate,DateTime? checkOutDate, int? userId,int? orderId)
		{
			List<OrderEntity> data = _repo.Search(roomType, orderPrice,checkInDate, checkOutDate, userId, orderId);
			return data.Select(x => x.ToDto()).ToList();
		}

		public OrderEditDto Get(int userId)
		{
			var entity = _repo.Get(userId);
			return entity.ToEditDto();
		}
	}
}
