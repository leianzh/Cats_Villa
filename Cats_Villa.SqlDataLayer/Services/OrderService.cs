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

		public void Delete(int categoryId)
		{
			_repo.Delete(categoryId);
		}

		public List<OrderDto> Search(DateTime? checkInDate,DateTime? checkOutDate, int? orderId)
		{
			List<OrderEntity> data = _repo.Search(checkInDate, checkOutDate, orderId);


			return data.Select(x => x.ToDto()).ToList();
		}

		public OrderEditDto Get(int orderId)
		{

			return _repo.Get(orderId).ToEditDto();
		}
	}
}
