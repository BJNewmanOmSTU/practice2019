using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Domain
{
	public class IdGenerator
	{
		public static string GenerateId()
		{
			return Guid.NewGuid().ToString("N");
		}
	}
}
