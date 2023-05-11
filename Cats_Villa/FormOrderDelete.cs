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
			string roomType = txtRoomType.Text;
			DateTime checkin;
			if (DateTime.TryParse(txtCheckIn.Text, out checkin) == false)
			{
				MessageBox.Show("請輸入正確的日期格式，例如：yyyy/MM/dd");
				return;
			}

			DateTime checkout;
			if (DateTime.TryParse(txtCheckOut.Text, out checkout) == false)
			{
				MessageBox.Show("請輸入正確的日期格式，例如：yyyy/MM/dd");
				return;
			}

			OrderEditVM vm = new OrderEditVM()
			{
				Id = _orderId,
				RoomType = roomType,
				CheckInDate = checkin,
				CheckOutDate = checkout
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
		private (bool isValid, List<ValidationResult> errors) Validate(OrderEditVM vm)
		{
			// 得知要驗證規則
			ValidationContext context = new ValidationContext(vm, null, null);

			// 用來存放錯誤的集合,因為可能有零到多個錯誤
			List<ValidationResult> errors = new List<ValidationResult>();

			// 驗證 model
			bool validateAllProperties = true; // 是否驗證所有規則,而非只驗證Required規則
			bool isValid = Validator.TryValidateObject(vm, context, errors, validateAllProperties);

			return (isValid, errors);
		}
		private void DisplayErrors(List<ValidationResult> errors)
		{
			// 大小寫不同仍視為相同的key
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"RoomType", txtRoomType},
				{"CheckInDate", txtCheckIn},
				{"CheckOutDate", txtCheckOut}
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

			txtRoomType.Text = vm.RoomType;
			txtCheckIn.Text = vm.CheckInDate.ToString();
			txtCheckOut.Text = vm.CheckOutDate.ToString();


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
