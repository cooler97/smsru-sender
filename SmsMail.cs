using System;

namespace SmsSender
{
	public class SmsMail
	{
		string[] _to;
		string _msg;
		string _from;
		DateTime _dt;
		string _smsId;
		SmsResponse _response;
		
		public string[] To {
			get { return _to; }
			set { _to = value; }
		}
		
		public string ToAsString {
			get { return String.Join(",", _to); }
		}
		
		public string Msg {
			get { return _msg; }
			set { _msg = value; }
		}
		
		public string From {
			get { return _from; }
			set { _from = value; }
		}
		
		public string Id {
			get { return _smsId; }
			set { _smsId = value; }
		}
		
		public DateTime Dt {
			get { return _dt; }
			set { _dt = value; }
		}
		
		public string Status {
			get { 
				
				if(_response != null)
				{
					return _response.GetStatus();
				}
				
				return "";				
			}
		}
		
		public string Response {
			set { _response = new SmsResponse(value); }
		}
		
		public SmsMail(string[] To, string Msg)
		{
			this.To = To;
			this.Msg = Msg;
		}
	}
}
