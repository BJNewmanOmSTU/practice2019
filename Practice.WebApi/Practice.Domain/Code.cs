using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Domain
{
	public class Code
	{
		public int CodeId { get; set; }
		public int ProductTemplateId { get; set; }
		public List<Attribute> Attributes { get; set; }
		public String SellSource { get; set; }
		public String StoreId { get; set; }
		public Int32 Amount { get; set; }
		public String Symbol { get; set; }
	}
}
