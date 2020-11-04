using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SmsSender;

namespace SmsSender{

	public partial class DeliveryMailingForm : Form
	{
		DataTable deliveryTable = new DataTable();
		
		List<SmsMail> mailingList;
		
		public DeliveryMailingForm(List<SmsMail> mailingList)
		{
			InitializeComponent();
			
			this.mailingList = mailingList;
			
			DataRow dr = deliveryTable.NewRow();
			deliveryTable.Rows.Add();
		}
		
		void CancelBtnClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void CreateBtnClick(object sender, EventArgs e)
		{
			mailingList.Clear();
			
			mailingList.Add(new SmsMail(new string[] {"79020923820", "jopa", "79023819131"}, "Заказы № 439014,016,017 погружены. Доставка 10.04.20. Водитель 89271545133"));
			mailingList.Add(new SmsMail(new string[] {"79023601945"}, "Заказы № 080044,045 погружены. Доставка 10.04.20 Водитель 89279182893"));
			mailingList.Add(new SmsMail(new string[] {"79023628354", "79023874041"}, "Заказы № 041055,058 погружены. Доставка 10.04.20 Водитель 89279182893"));
			mailingList.Add(new SmsMail(new string[] {"79023630303"}, "Заказы № 041055,058 погружены. Доставка 10.04.20 Водитель 89279182893"));
				
			this.DialogResult = DialogResult.OK;
			
			Close();
		}
	}
}
