using System;
using System.IO;
using System.Text;
using Atechnology.Components;
using Atechnology.Components.AtLogWatcher;

namespace SmsSender
{
	public class AtLogWriter : StringWriter
	{
		AtLogWatcher watcher = null;
		
		public override void WriteLine(string value)
		{
			if(watcher == null)
			{
				watcher = new AtLogWatcher();
				AtLog.LogWatcher = watcher;
				watcher.Show();
//				MdiManager.Add(watcher);
			}			
			
			AtLog.AddMessage(value);
		}

		public override Encoding Encoding
		{
			get { return Encoding.Default; }
		}
		
	}
}
