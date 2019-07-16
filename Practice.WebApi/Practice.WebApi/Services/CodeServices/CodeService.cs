using Microsoft.EntityFrameworkCore;
using Practice.Domain;
using Practice.WebApi.Contracts.CodeContracts;
using Practice.WebApi.Mapper;
using Practice.WebApi.Services.ProductTemplatesServices;
using System.Collections.Generic;
using System.Linq;

namespace Practice.WebApi.Services.CodeServices
{
	/// <summary>
	/// Сервис для работы с Кодами
	/// </summary>
	public class CodeService : ICodeService
	{
		private DbSet<Code> _codes;
		private DbSet<Store> _stores;
		private DbSet<ProductTemplate> _productTemplates;

		private IContractMapper _mapper;
		private DomainContext _domainContext;

		/// <summary>
		/// Конструктор сервиса для работы с Кодами
		/// </summary>
		/// <param name="dc">Контекст базы данных</param>
		/// <param name="mapper">Mapper для сопоставления модели с контрактом</param>
		public CodeService(DomainContext domainContext, ContractMapper mapper)
		{
			_codes = domainContext.Set<Code>();
			_stores = domainContext.Set<Store>();
			_productTemplates = domainContext.Set<ProductTemplate>();

			_mapper = mapper;
			_domainContext = domainContext;
		}

		/// <summary>
		/// Функция создания Кода
		/// </summary>
		/// <param name="code">Код который нужно создать</param>
		/// <returns>Возвращает созданный Код в виде контракта</returns>
		public CodeContract CreateCode(CodeCreateContract newCode)
		{
			Code code;
			ProductTemplate productTemplate;
			Store store;

			if (newCode != null)
			{
				//Проверка существования магазина и шаблона продукта
				productTemplate = _productTemplates.Find(newCode.ProductTemplateId);
				if (productTemplate == null)
				{
					throw new NotFoundException($"Продукт с идентификатором '{newCode.ProductTemplateId}' не найден!");
				}

				store = _stores.Find(newCode.StoreId);
				if (store == null)
				{
					throw new NotFoundException($"Магазин с идентификатором '{newCode.StoreId}' не найден!");
				}

				code = _mapper.Map<CodeCreateContract, Code>(newCode);
				_codes.Add(code);
				_domainContext.SaveChanges();
			}
			else
			{
				throw new ModelValidationExсeption("Ошибка при создании записи");
			}

			//Преобразование из Code в CodeContract
			CodeContract codeContract = _mapper.Map<Code, CodeContract>(code);
			codeContract.StoreName = store.Name;
			codeContract.ProductTemplateTitle = productTemplate.Name;

			return codeContract;
		}

		/// <summary>
		/// Функция получения списка кодов
		/// </summary>
		/// <returns>Возвращает список кодов</returns>
		public List<CodeContract> GetListCodes()
		{
			List<CodeContract> codes = _mapper.Map<List<Code>, List<CodeContract>>(_codes.ToList());
			foreach(var code in codes)
			{
				
			}
			return codes;
		}
	}
}
