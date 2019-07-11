using System;
using System.Runtime.Serialization;

namespace Practice.WebApi.Services.ProductTemplatesServices
{

	/// <summary>
	/// Определяет ошибку при неверных параметрах модели
	/// </summary>
	public class ModelValidationExeption : Exception
	{
		public ModelValidationExeption()
		{
		}

		public ModelValidationExeption(string message) : base(message)
		{
		}

		public ModelValidationExeption(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected ModelValidationExeption(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
