using Microsoft.EntityFrameworkCore;
using Practice.Domain;
using Practice.WebApi.Contracts.CodeContracts;
using Practice.WebApi.Contracts.ProductTemplatesContracts;
using Practice.WebApi.Contracts.StoreContracts;
using Practice.WebApi.Mapper;
using Practice.WebApi.Services.ProductTemplatesServices;

namespace Practice.WebApi.Services.CodeServices
{
	/// <summary>
	/// Сервис для работы с Кодами
	/// </summary>
	public class CodeService : ICodeService
	{
		private DbSet<Code> _codes;
		private IContractMapper _mapper;
		private DomainContext _dc;

		private IStoreService _storeService;
		private IProductTemplateService _productTemplateService;

		/// <summary>
		/// Конструктор сервиса для работы с Кодами
		/// </summary>
		/// <param name="dc">Контекст базы данных</param>
		/// <param name="mapper">Mapper для сопоставления модели с контрактом</param>
		/// <param name="storeService">Сервис для работы с моделью Store</param>
		/// <param name="productTemplateService">Сервис для работы с моделью ProductTemplate</param>
		public CodeService(DomainContext dc, ContractMapper mapper, StoreService storeService, ProductTemplateService productTemplateService)
		{
			_codes = dc.Set<Code>();
			_mapper = mapper;
			_dc = dc;
			_storeService = storeService;
			_productTemplateService = productTemplateService;
		}
		
		/// <summary>
		/// Функция создания Кода
		/// </summary>
		/// <param name="code">Код который нужно создать</param>
		/// <returns>Возвращает созданный Код в виде контракта</returns>
		public CodeContract CreateCode(Code code)
		{
			if(code != null)
			{
				//Данная процедура нужна для формирования поля StoreName
				code.Store = _mapper.Map<StoreContract, Store>(_storeService.GetStore(code.StoreId));

				//Данная процедура нужна для формирования поля ProductTemplateTitle
				code.ProductTemplate = _mapper.Map<ProductTemplateContract, ProductTemplate>(_productTemplateService.GetProductTemplate(code.ProductTemplateId));
				_codes.Add(code);
				_dc.SaveChanges();
			}
			else
			{
				throw new DatabaseException("Ошибка при создании записи");
			}

			//Преобразование из Code в CodeContract
			return _mapper.Map<Code, CodeContract>(code);
		}
	}
}
