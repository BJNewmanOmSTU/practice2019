namespace Practice.Domain
{
	/// <summary>
	/// Список статусов кодов
	/// </summary>
	public enum CodeStatus
	{
		/// <summary>
		/// Код был создан и активен
		/// </summary>
		Active = 1,

		/// <summary>
		///  Код был введён пользователем, ордер создан
		/// </summary>
		Redeemed = 2,

		/// <summary>
		/// Был проведён ивент, который пользователь выбрал
		/// </summary>
		Completed = 3
	}
}
