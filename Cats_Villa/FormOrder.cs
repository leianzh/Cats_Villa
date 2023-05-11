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
	public partial class FormOrder : Form
	{
		private readonly int _userId;

		public FormOrder(int userId)
		{
			_userId = userId;
			InitializeComponent();
		}

		private void btnOrder_Click(object sender, EventArgs e)
		{
			RoomDto room = new RoomDto();
			
			if(comboBox1.SelectedItem == null) 
			{
				room.RoomType="";
			}
			else 
			{
				room.RoomType = ((RoomDto)comboBox1.SelectedItem).RoomType;
			}
			if(comboBox2.SelectedItem == null) 
			{
				room.RoomPrice = 0;
			}
			else 
			{
				room.RoomPrice = ((RoomDto)comboBox2.SelectedItem).RoomPrice;
			}
			OrderAddVM vm = new OrderAddVM()
			{
				UserId = _userId,
				RoomType = room.RoomType,
				CheckInDate = dateTimePicker1.Value,
				CheckOutDate = dateTimePicker2.Value,
				OrderPrice = room.RoomPrice

			};

			//驗證vm閃錯誤訊息
			(bool isValid, List<ValidationResult> errors) validationResult = Validate(vm);
			if (validationResult.isValid == false)
			{
				this.errorProvider1.Clear();
				DisplayErrors(validationResult.errors);
				return;
			}



			OrderAddDto dto = vm.ToDto();
			IOrderRepository repo = new SqlOrderRepository();
			OrderService service2 = new OrderService(repo);
			service2.Create(dto);

			var frm = new FormMain(_userId);
			frm.Owner = this;
			MessageBox.Show("訂房成功");
			this.Hide();
			frm.ShowDialog();
			
			

		}

		private void FormOrder_Load(object sender, EventArgs e)
		{
			IRoomRepository repo = new SqlRoomRepository();
			RoomService service = new RoomService(repo);

			var rooms = service.Search(null,null, string.Empty, string.Empty, string.Empty, null);
			comboBox1.Items.AddRange(rooms.ToArray());
			comboBox1.DisplayMember = "RoomType";

			var roomPrice = service.Search(null,null, string.Empty, string.Empty, string.Empty, null);
			comboBox2.Items.AddRange(roomPrice.ToArray());
			comboBox2.DisplayMember = "RoomPrice";

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
				dateTimePicker1.Value = checkOutDate;
			}

			dateTimePicker2.MinDate = dateTimePicker1.Value.AddDays(1);
		}
		private (bool isValid, List<ValidationResult> errors) Validate(OrderAddVM vm)
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
				{"CheckInDate", dateTimePicker1},
				{"CheckOutDate", dateTimePicker2},
				{"OrderPrice",comboBox2 },
				{"RoomType", comboBox1}
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
	}
}
