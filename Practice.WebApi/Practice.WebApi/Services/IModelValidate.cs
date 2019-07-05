using Practice.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.WebApi.Services
{
	public interface IModelValidate<T>
	{
		bool Get(out List<T> item);
		bool TryGetItem(string id, out T item);
	}
}
