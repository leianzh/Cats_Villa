using Cats_Villa.SqlDataLayer.infra.SqlRepositories;
using Cats_Villa.SqlDataLayer.interfaces;
using Cats_Villa.SqlDataLayer.Services;
using Cats_Villa.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cats_Villa
{
	public partial class FormOrderEditBack : Form,IGrid
	{
		
		private List<OrderVM> vm;
		public FormOrderEditBack()
		{
			
			InitializeComponent();
		}

		public void Display()
		{
			IOrderRepository orderRepository = new SqlOrderRepository();
			OrderService service = new OrderService(orderRepository);
			vm = service.Search(null, null, null, null, null, null)
			   .Select(x => x.ToViewModel())
			   .ToList();





			dataGridView1.DataSource = vm;
		}

		private void FormOrderEditBack_Load(object sender, EventArgs e)
		{
			Display();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			int Id = vm[e.RowIndex].Id;

			var frm = new FormOrderDelete(Id);
			frm.Owner = this;
			frm.ShowDialog();
		}
	}
}
