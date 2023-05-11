using Cats_Villa.SqlDataLayer.Dtos;
using Cats_Villa.SqlDataLayer.infra.SqlRepositories;
using Cats_Villa.SqlDataLayer.interfaces;
using Cats_Villa.SqlDataLayer.Services;
using Cats_Villa.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cats_Villa
{
	public partial class FormOrderDelete : Form
	{
		private List<OrderVM> vm;
		private readonly int _orderId;
		public FormOrderDelete(int orderId)
		{
			InitializeComponent();
			_orderId = orderId;
		}

		private void btnEditOrder_Click(object sender, EventArgs e)
		{
			RoomDto room = new RoomDto();
			if (comboBox1.SelectedItem == null)
			{
				room.RoomType = "";
			}
			else
			{
				room.RoomType = ((RoomDto)comboBox1.SelectedItem).RoomType;
			}

			OrderEditVM vm = new OrderEditVM()
			{
				Id = _orderId,
				RoomType = room.RoomType,
				CheckInDate = dateTimePicker1.Value,
				CheckOutDate = dateTimePicker2.Value,
			};
			//驗證vm閃錯誤訊息
			(bool isValid, List<ValidationResult> errors) validationResult = Validate(vm);
			if (validationResult.isValid == false)
			{
				this.errorProvider1.Clear();
				DisplayErrors(validationResult.errors);
				return;
			}
			OrderEditDto dto = vm.ToDto();
			IOrderRepository repo = new SqlOrderRepository();
			OrderService service = new OrderService(repo);

			try
			{
				service.Update(dto);
			}
			catch (Exception ex)
			{
				MessageBox.Show("修改訂單失敗，原因:" + ex.Message);
				return;
			}


			IGrid owner = this.Owner as IGrid;
			if(owner == null) 
			{
				MessageBox.Show("忘了把owner實作");
			}
			else 
			{
				owner.Display();
			}

			MessageBox.Show("更新成功");

		}
		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			DateTime checkInDate = dateTimePicker1.Value.Date;
			DateTime checkOutDate = dateTimePicker2.Value.Date;

			if (checkInDate < DateTime.Today)
			{
				MessageBox.Show("入住日期不能小於今天日期。", "日期錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
				dateTimePicker1.Value = DateTime.Today;
				return;
			}

			if (checkInDate < checkOutDate)
			{
				MessageBox.Show("入住日期不可以小於退房日期。", "日期錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
				dateTimePicker1.Value = checkInDate;
			}

			dateTimePicker2.MinDate = dateTimePicker1.Value.AddDays(1);
		}
		private (bool isValid, List<ValidationResult> errors) Validate(OrderEditVM vm)
		{
			
			ValidationContext context = new ValidationContext(vm, null, null);

			
			List<ValidationResult> errors = new List<ValidationResult>();

			// 驗證 model
			bool validateAllProperties = true; 
			bool isValid = Validator.TryValidateObject(vm, context, errors, validateAllProperties);

			return (isValid, errors);
		}
		private void DisplayErrors(List<ValidationResult> errors)
		{
			
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"RoomType", comboBox1},
				{"CheckInDate", dateTimePicker1},
				{"CheckOutDate", dateTimePicker2}
			};

			this.errorProvider1.Clear();

			foreach (ValidationResult error in errors)
			{
				string propName = error.MemberNames.FirstOrDefault();
				if (propName != null && map.TryGetValue(propName, out Control ctrl))
				{
					this.errorProvider1.SetError(ctrl, error.ErrorMessage);
				}
			}
		}

		private void FormOrderDelete_Load(object sender, EventArgs e)
		{
			IOrderRepository repo = new SqlOrderRepository();
			OrderService service = new OrderService(repo);

			OrderEditDto dto = service.Get(this._orderId);
			OrderEditVM vm = dto.ToViewModel();

			IRoomRepository repo2 = new SqlRoomRepository();
			RoomService service2 = new RoomService(repo2);

			var rooms = service2.Search(null, null, string.Empty, string.Empty, string.Empty, null);
			comboBox1.Items.AddRange(rooms.ToArray());
			comboBox1.DisplayMember = "RoomType";


		}

		private void btnDeleteOrder_Click(object sender, EventArgs e)
		{
			IOrderRepository repo = new SqlOrderRepository();
			OrderService service = new OrderService(repo);
			var result = MessageBox.Show("你確定要刪除嗎?", "確定嗎????", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				var result2 = MessageBox.Show("確定嗎??刪了回不去喔?!", "REALLY??", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
				if (result2 == DialogResult.Yes)
				{
					try
					{
						service.Delete(_orderId);
					}
					catch (Exception ex)
					{
						MessageBox.Show("刪除失敗，原因:" + ex.Message);
						return;
					}

				}
			}

			 MessageBox.Show("刪除成功");

			IGrid owner = this.Owner as IGrid;
			if (owner == null)
			{
				MessageBox.Show("忘了把owner實作");
			}
			else
			{
				owner.Display();
			}
		}

		
	}
}
