using System;
using BrightIdeasSoftware;

namespace SmsSender
{

	public class MailingListView : FastDataListView
	{
		public MailingListView()
		{
			this.generateColumns();
		}
		
		private string GetImageKey(object row)
		{
			Type type = row.GetType();
//			if(type == typeof(ManufactViewOrder)){
//				return "order";
//			}
			return "";
		}
		
		public void generateColumns() {
			OLVColumn col = new OLVColumn();

			col = new OLVColumn();
			col.Text = "Получатель";
			col.AspectName = "ToAsString";
			col.Width = 200;
			this.Columns.Add(col);
			
			col = new OLVColumn();
			col.Text = "Сообщение";
			col.AspectName = "Msg";
			col.Width = 600;
			this.Columns.Add(col);
			
			col = new OLVColumn();
			col.Text = "Статус";
			col.AspectName = "Status";
			col.Width = 400;
			
			/*col.ImageGetter = delegate(object row) {
				return this.GetImageKey(row);
			};*/
			
			this.Columns.Add(col);

		}

	}

}
