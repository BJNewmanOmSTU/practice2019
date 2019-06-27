using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Domain
{
	/// <summary>
	/// Модель ProductTemolate. 
	/// </summary>
	public class ProductTemplate
	{
		/// <summary>
		/// Идентификатор ProductTemplate
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Название ProductTemplate
		/// </summary>
		public string Title { get; set; }

		public ProductTemplate()
		{
			Id = Guid.NewGuid().ToString("N");
		}
	}


}
