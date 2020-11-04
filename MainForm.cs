using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Atechnology.Components;

namespace SmsSender
{
	public partial class MainForm : Form
	{
		List<SmsMail> mailingList = new List<SmsMail>();
		
		public MainForm()
		{
			InitializeComponent();
			
			mailingListView.DataSource = mailingList;
		}
		
		void ДоставкаToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form deliveryForm = new DeliveryMailingForm(mailingList);
			if(deliveryForm.ShowDialog() == DialogResult.OK)
			{
				mailingListView.ClearObjects();
				mailingListView.UpdateObjects(mailingList);
			}
		}
		
		void ToolStripButton1Click(object sender, EventArgs e)
		{
			if(mailingList.Count == 0)
				return;
			
			SmsRuManager smsManager = new SmsRuManager("+79272265008", "damir", "A434A9FE-FBCF-5514-B2DC-3B5E097F5629", true);
			
			smsManager.Send(mailingList);
		}
		
		void MailingListViewKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				foreach(object obj in mailingListView.SelectedObjects)
				{
					SmsMail sms = obj as SmsMail;
					
					string msg = String.Format("Удалить сообщение '{0}' абоненту {1}?", sms.Msg, sms.ToAsString);
					
					DialogResult dialogResult = AtMessageBox.Show(msg, "Удаление сообщения", MessageBoxButtons.YesNoCancel);
					
					if(dialogResult == DialogResult.Yes)
					{						
						mailingList.Remove(sms);
						mailingListView.RemoveObject(obj);
					}
					else if(dialogResult == DialogResult.Cancel)
					{
						return;
					}
				}
				
				e.Handled = true;
			}
		}
		
		void MailingListViewCellEditStarting(object sender, BrightIdeasSoftware.CellEditEventArgs e)
		{
			e.Control.Bounds = e.CellBounds;
		}		

	}
}
