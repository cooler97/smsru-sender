/*
 * Created by SharpDevelop.
 * User: Ilya
 * Date: 03.04.2020
 * Time: 0:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SmsSender
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.Panel bottomPanel;
		private System.Windows.Forms.Button CloseBtn;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripMenuItem доставкаToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.Button refreshBtn;
		private SmsSender.MailingListView mailingListView;
		
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
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.доставкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.bottomPanel = new System.Windows.Forms.Panel();
			this.refreshBtn = new System.Windows.Forms.Button();
			this.CloseBtn = new System.Windows.Forms.Button();
			this.mailingListView = new SmsSender.MailingListView();
			this.toolStrip1.SuspendLayout();
			this.bottomPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mailingListView)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripDropDownButton1,
			this.toolStripSeparator1,
			this.toolStripButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1051, 31);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.доставкаToolStripMenuItem});
			this.toolStripDropDownButton1.Image = global::SmsSender.Properties.icons.email;
			this.toolStripDropDownButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(134, 28);
			this.toolStripDropDownButton1.Text = "Новая рассылка";
			// 
			// доставкаToolStripMenuItem
			// 
			this.доставкаToolStripMenuItem.Image = global::SmsSender.Properties.icons.transportation;
			this.доставкаToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.доставкаToolStripMenuItem.Name = "доставкаToolStripMenuItem";
			this.доставкаToolStripMenuItem.Size = new System.Drawing.Size(160, 30);
			this.доставкаToolStripMenuItem.Text = "Доставка";
			this.доставкаToolStripMenuItem.Click += new System.EventHandler(this.ДоставкаToolStripMenuItemClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.Image = global::SmsSender.Properties.icons.email__1_;
			this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(130, 28);
			this.toolStripButton1.Text = "Начать рассылку";
			this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1Click);
			// 
			// bottomPanel
			// 
			this.bottomPanel.Controls.Add(this.refreshBtn);
			this.bottomPanel.Controls.Add(this.CloseBtn);
			this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bottomPanel.Location = new System.Drawing.Point(0, 519);
			this.bottomPanel.Name = "bottomPanel";
			this.bottomPanel.Size = new System.Drawing.Size(1051, 48);
			this.bottomPanel.TabIndex = 1;
			// 
			// refreshBtn
			// 
			this.refreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.refreshBtn.Location = new System.Drawing.Point(875, 13);
			this.refreshBtn.Name = "refreshBtn";
			this.refreshBtn.Size = new System.Drawing.Size(79, 23);
			this.refreshBtn.TabIndex = 0;
			this.refreshBtn.Text = "Обновить";
			this.refreshBtn.UseVisualStyleBackColor = true;
			// 
			// CloseBtn
			// 
			this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CloseBtn.Location = new System.Drawing.Point(960, 13);
			this.CloseBtn.Name = "CloseBtn";
			this.CloseBtn.Size = new System.Drawing.Size(79, 23);
			this.CloseBtn.TabIndex = 0;
			this.CloseBtn.Text = "Закрыть";
			this.CloseBtn.UseVisualStyleBackColor = true;
			// 
			// mailingListView
			// 
			this.mailingListView.AlternateRowBackColor = System.Drawing.Color.AliceBlue;
			this.mailingListView.AutoGenerateColumns = false;
			this.mailingListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.mailingListView.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
			this.mailingListView.CellEditUseWholeCell = false;
			this.mailingListView.Cursor = System.Windows.Forms.Cursors.Default;
			this.mailingListView.DataSource = null;
			this.mailingListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mailingListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.mailingListView.FullRowSelect = true;
			this.mailingListView.GridLines = true;
			this.mailingListView.Location = new System.Drawing.Point(0, 31);
			this.mailingListView.Name = "mailingListView";
			this.mailingListView.ShowGroups = false;
			this.mailingListView.Size = new System.Drawing.Size(1051, 488);
			this.mailingListView.TabIndex = 8;
			this.mailingListView.UseAlternatingBackColors = true;
			this.mailingListView.UseCompatibleStateImageBehavior = false;
			this.mailingListView.View = System.Windows.Forms.View.Details;
			this.mailingListView.VirtualMode = true;
			this.mailingListView.CellEditStarting += new BrightIdeasSoftware.CellEditEventHandler(this.MailingListViewCellEditStarting);
			this.mailingListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MailingListViewKeyDown);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1051, 567);
			this.Controls.Add(this.mailingListView);
			this.Controls.Add(this.bottomPanel);
			this.Controls.Add(this.toolStrip1);
			this.Name = "MainForm";
			this.Text = "SmsSender";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.bottomPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mailingListView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
