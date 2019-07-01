using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Domain
{
	/// <summary>
	/// Интерфейс репозитория
	/// </summary>
	/// <typeparam name="T">Обобщение класса</typeparam>
	public interface IRepository<T>
		where T : class
	{
		/// <summary>
		/// Возвращает все элементы содержащиеся в данной таблице
		/// </summary>
		IEnumerable<T> GetAll();
		/// <summary>
		/// Возвращает элемент по заданному идентификатору
		/// </summary>
		/// <param name="id">Идентификатор записи</param>
		T Get(string id);
		/// <summary>
		/// Создает запись
		/// </summary>
		/// <param name="item">Элемент</param>
		void Create(T item);
		/// <summary>
		/// Обновляет объект
		/// </summary>
		/// <param name="item">Элемент</param>
		void Update(T item);
		/// <summary>
		/// Удаляет объект
		/// </summary>
		/// <param name="id">Идентификатор записи<</param>
		void Delete(string id);
	}
}
