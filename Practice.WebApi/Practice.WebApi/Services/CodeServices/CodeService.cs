using Microsoft.EntityFrameworkCore;
using Practice.Domain;
using Practice.WebApi.Contracts.CodeContracts;
using Practice.WebApi.Contracts.ProductTemplatesContracts;
using Practice.WebApi.Contracts.StoreContracts;
using Practice.WebApi.Mapper;
using Practice.WebApi.Services.ProductTemplatesServices;
using System.Collections.Generic;

namespace Practice.WebApi.Services.CodeServices
{
	/// <summary>
	/// Сервис для работы с Кодами
	/// </summary>
	public class CodeService : ICodeService
	{
		private DbSet<Code> _codes;
		private IContractMapper _mapper;
		private DomainContext _domainContext;

		private IStoreService _storeService;
		private IProductTemplateService _productTemplateService;

		/// <summary>
		/// Конструктор сервиса для работы с Кодами
		/// </summary>
		/// <param name="dc">Контекст базы данных</param>
		/// <param name="mapper">Mapper для сопоставления модели с контрактом</param>
		/// <param name="storeService">Сервис для работы с моделью Store</param>
		/// <param name="productTemplateService">Сервис для работы с моделью ProductTemplate</param>
		public CodeService(DomainContext domainContext, ContractMapper mapper, StoreService storeService, ProductTemplateService productTemplateService)
		{
			_codes = domainContext.Set<Code>();
			_mapper = mapper;
			_domainContext = domainContext;
			_storeService = storeService;
			_productTemplateService = productTemplateService;
		}
		
		/// <summary>
		/// Функция создания Кода
		/// </summary>
		/// <param name="code">Код который нужно создать</param>
		/// <returns>Возвращает созданный Код в виде контракта</returns>
		public CodeContract CreateCode(CodeCreateContract newCode)
		{
			Code code;
			if (newCode != null)
			{
				//Проверка существования магазина и шаблона продукта
				_storeService.GetStore(newCode.StoreId);
				_productTemplateService.GetProductTemplate(newCode.ProductTemplateId);

				code = _mapper.Map<CodeCreateContract, Code>(newCode);
				_codes.Add(code);
				_domainContext.SaveChanges();
			}
			else
			{
				throw new ModelValidationExeption("Ошибка при создании записи");
			}

			//Преобразование из Code в CodeContract
			return _mapper.Map<Code, CodeContract>(code);
		}
	}
}
