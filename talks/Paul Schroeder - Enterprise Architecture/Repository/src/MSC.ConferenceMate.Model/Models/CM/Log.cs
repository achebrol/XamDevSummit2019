// <auto-generated> - Template:ModelsBackedByDto, Version:1.1, Id:f1539c0d-024f-4b1f-b346-132cdd9dd31f
using CodeGenHero.Logging;
using CodeGenHero.DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using MSC.ConferenceMate.API.Client.Interface;
using MSC.ConferenceMate.Model.CM.Interface;
using xDTO = MSC.ConferenceMate.DTO.CM;

namespace MSC.ConferenceMate.Model.CM
{

	public class LoadRequestLog : EventArgs
	{
		public LoadRequestLog(string propertyNameRequestingLoad)
		{
			PropertyNameRequestingLoad = propertyNameRequestingLoad;
		}

		public string PropertyNameRequestingLoad { get; set; }
	}


	public partial class Log : BaseModel<IWebApiDataServiceCM>, ILog
	{
		public event EventHandler<LoadRequestLog> OnLazyLoadRequest = delegate { }; // Empty delegate. Thus we are sure that value is always != null because no one outside of the class can change it.
		private xDTO.Log _dto = null;

		public Log(ILoggingService log, IDataService<IWebApiDataServiceCM> dataService) : base(log, dataService)
		{
			_dto = new xDTO.Log();
			OnLazyLoadRequest += HandleLazyLoadRequest;
		}

		public Log(ILoggingService log, IDataService<IWebApiDataServiceCM> dataService, xDTO.Log dto) : this(log, dataService)
		{
			_dto = dto;
		}


		public virtual string ClientIpAddress { get { return _dto.ClientIpAddress; } }
		public virtual System.DateTime Date { get { return _dto.Date; } }
		public virtual string Exception { get { return _dto.Exception; } }
		public virtual long? ExecutionTimeInMilliseconds { get { return _dto.ExecutionTimeInMilliseconds; } }
		public virtual string HttpResponseStatusCode { get { return _dto.HttpResponseStatusCode; } }
		public virtual int Id { get { return _dto.Id; } }
		public virtual string Level { get { return _dto.Level; } }
		public virtual string Logger { get { return _dto.Logger; } }
		public virtual System.Guid? LogGuid { get { return _dto.LogGuid; } }
		public virtual int? LogMessageTypeId { get { return _dto.LogMessageTypeId; } }
		public virtual string Message { get { return _dto.Message; } }
		public virtual string MethodName { get { return _dto.MethodName; } }
		public virtual string Thread { get { return _dto.Thread; } }
		public virtual string Url { get { return _dto.Url; } }
		public virtual string UserName { get { return _dto.UserName; } }





	}
}