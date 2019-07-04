using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Practice.Domain.Repository
{
	/// <summary>
	/// Реализация репозитория для Store
	/// </summary>
	public class StoreRepository : IRepository<Store>
	{
		private DomainContext _Dc;

		public StoreRepository(DomainContext dc)
		{
			_Dc = dc;
		}
		/// <summary>
		/// Создает запись
		/// </summary>
		/// <param name="item">Элемент</param>
		public void Create(Store item)
		{
			_Dc.Stores.Add(item);
		}
		/// <summary>
		/// Удаляет объект
		/// </summary>
		/// <param name="id">Идентификатор записи<</param>
		public void Delete(string id)
		{
			throw new NotImplementedException();
		}
		/// <summary>
		/// Возвращает элемент по заданному идентификатору
		/// </summary>
		/// <param name="id">Идентификатор записи</param>
		public Store Get(string id)
		{
			return _Dc.Stores.Find(id);
		}
		/// <summary>
		/// Возвращает все элементы содержащиеся в данной таблице
		/// </summary>
		public IEnumerable<Store> GetAll()
		{			
			return _Dc.Stores;
		}
		/// <summary>
		/// Обновляет объект
		/// </summary>
		/// <param name="item">Элемент</param>
		public void Update(Store item)
		{
			throw new NotImplementedException();
		}
	}
}
