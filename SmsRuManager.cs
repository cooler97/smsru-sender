using System;
using System.Collections.Generic;
using System.Threading;
using SmsRu;
using SmsRu.Enumerations;

namespace SmsSender
{
	public class SmsRuManager
	{
		SmsRuProvider provider = new SmsRuProvider();
		
		Thread mailingThread;
		
		public SmsRuManager(string login, string password, string apiId, bool test)
		{
			provider.login = login;
			provider.password = password;
			provider.apiId = apiId;
			provider.test = test;
		}
		
		public void Send(List<SmsMail> mailingList)
		{
			mailingThread = new Thread(new ParameterizedThreadStart(SendSms));
			mailingThread.Start(mailingList);
		}
		
		public void SendSms(object mailingList)
		{
			List<SmsMail> list = mailingList as List<SmsMail>;
			
			string response;
			
			foreach(SmsMail sms in list)
			{
				lock(provider)
				{
					response = provider.Send(sms.From, sms.To, sms.Msg, EnumAuthenticationTypes.StrongApi);
					
					sms.Response = response;
					sms.Dt = DateTime.Now;
				}
			}
		}
	}
}
