using System;

namespace SmsSender
{
	public class SmsResponse
	{
		public static string REQUEST_FINISHED = "Запрос выполнен или сообщение находится в нашей очереди";
		
		public static string MESSAGE_SENDING_OPERATOR = "Сообщение передается оператору";
		public static string MESSAGE_SEND = "Сообщение отправлено (в пути)";
		public static string MESSAGE_DELIVERED = "Сообщение доставлено";
		
		public static string BAD_API_ID = "Неправильный api_id";
		public static string NO_MONEY = "Не хватает средств на лицевом счету";
		
		public static string BAD_PHONE_NUMBER = "Неправильно указан номер телефона получателя, либо на него нет маршрута";
		public static string EMPTY_MESSAGE = "Нет текста сообщения";
		public static string BAD_SENDER_NAME = "Имя отправителя не согласовано с администрацией";
		public static string MESSAGE_TOO_LONG = "Сообщение слишком длинное (превышает 8 СМС)";
		public static string EXCEED_LIMIT = "Будет превышен или уже превышен дневной лимит на отправку сообщений";
		
		public static string SERVICE_UNAVAILABLE = "Сервис временно недоступен, попробуйте чуть позже";
		public static string BAD_API_ID_OR_LOGIN_PASSWORD = "Неправильный api_id, либо логин/пароль";
		public static string SERVER_ERROR = "Ошибка на сервере. Повторите запрос.";
		
		public static string UNKNOWN_ERROR = "Неизвестная ошибка";
		
		string rawAnswer;
		
		int statusCode;
		
		string[] ids;
		
		public SmsResponse(string answer)
		{
			rawAnswer = answer;
			ParseAnswer();
		}
		
		private void ParseAnswer()
		{
			if(!String.IsNullOrEmpty(rawAnswer))
			{
				string[] rawResult = rawAnswer.Split('\n');
				
				if(rawResult.Length > 0)
				{
					statusCode = Convert.ToInt32(rawResult[0]);
				}
				
			}
		}
		
		public string GetStatus()
		{
			if(statusCode == 100)
			{
				return REQUEST_FINISHED;
			}
			else if(statusCode == 101)
			{
				return MESSAGE_SENDING_OPERATOR;
			}
			else if(statusCode == 102)
			{
				return MESSAGE_SEND;
			}
			else if(statusCode == 103)
			{
				return MESSAGE_DELIVERED;
			}
			else if(statusCode == 200)
			{
				return BAD_API_ID;
			}
			else if(statusCode == 201)
			{
				return NO_MONEY;
			}
			else if(statusCode == 202)
			{
				return BAD_PHONE_NUMBER;
			}
			else if(statusCode == 203)
			{
				return EMPTY_MESSAGE;
			}
			else if(statusCode == 204)
			{
				return BAD_SENDER_NAME;
			}
			else if(statusCode == 205)
			{
				return MESSAGE_TOO_LONG;
			}
			else if(statusCode == 206)
			{
				return EXCEED_LIMIT;
			}
			else if(statusCode == 220)
			{
				return SERVICE_UNAVAILABLE;
			}
			else if(statusCode == 301)
			{
				return BAD_API_ID_OR_LOGIN_PASSWORD;
			}
			else if(statusCode == 500)
			{
				return SERVER_ERROR;
			}
			else
			{
				return UNKNOWN_ERROR;
			}
		}
	}
}
