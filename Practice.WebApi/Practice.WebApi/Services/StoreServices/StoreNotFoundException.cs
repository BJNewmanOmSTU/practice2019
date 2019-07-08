using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Practice.WebApi.Services.StoreServices
{
	public class StoreNotFoundException : SystemException
	{
		public StoreNotFoundException()
		{
		}

		public StoreNotFoundException(string message) : base(message)
		{
		}

		public StoreNotFoundException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected StoreNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
