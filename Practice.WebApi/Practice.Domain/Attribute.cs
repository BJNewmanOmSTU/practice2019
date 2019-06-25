using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Domain
{
	public class Attribute
	{
		public int AttributeId { get; set; }
		public int title { get; set; }
		public object value { get; set; }
		public String comment { get; set; }
		public String TypeId { get; set; }
	}
}
