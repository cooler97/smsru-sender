/*
 * Created by SharpDevelop.
 * User: Ilya
 * Date: 10.04.2020
 * Time: 21:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SmsSender
{
	partial class DeliveryMailingForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button CreateBtn;
		private System.Windows.Forms.Button CancelBtn;
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.CreateBtn = new System.Windows.Forms.Button();
			this.CancelBtn = new System.Windows.Forms.Button();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.richTextBox1.DetectUrls = false;
			this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.richTextBox1.Location = new System.Drawing.Point(194, 18);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ShortcutsEnabled = false;
			this.richTextBox1.Size = new System.Drawing.Size(338, 162);
			this.richTextBox1.TabIndex = 3;
			this.richTextBox1.Text = "Заказы %orderName% погружены. Доставка %deliveryDate%. Водитель %driverPhone%";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.CreateBtn);
			this.panel1.Controls.Add(this.CancelBtn);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 198);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(550, 48);
			this.panel1.TabIndex = 4;
			// 
			// CreateBtn
			// 
			this.CreateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CreateBtn.Location = new System.Drawing.Point(380, 11);
			this.CreateBtn.Name = "CreateBtn";
			this.CreateBtn.Size = new System.Drawing.Size(75, 23);
			this.CreateBtn.TabIndex = 0;
			this.CreateBtn.Text = "Создать";
			this.CreateBtn.UseVisualStyleBackColor = true;
			this.CreateBtn.Click += new System.EventHandler(this.CreateBtnClick);
			// 
			// CancelBtn
			// 
			this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CancelBtn.Location = new System.Drawing.Point(461, 11);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new System.Drawing.Size(75, 23);
			this.CancelBtn.TabIndex = 0;
			this.CancelBtn.Text = "Отмена";
			this.CancelBtn.UseVisualStyleBackColor = true;
			this.CancelBtn.Click += new System.EventHandler(this.CancelBtnClick);
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Location = new System.Drawing.Point(18, 18);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 6;
			// 
			// DeliveryMailingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(550, 246);
			this.ControlBox = false;
			this.Controls.Add(this.monthCalendar1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.richTextBox1);
			this.Name = "DeliveryMailingForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Создание новой рассылки";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
