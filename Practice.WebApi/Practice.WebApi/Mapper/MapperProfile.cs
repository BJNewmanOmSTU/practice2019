using AutoMapper;
using Practice.Domain;
using Practice.WebApi.Contracts.CodeContracts;
using Practice.WebApi.Contracts.ProductTemplatesContracts;
using Practice.WebApi.Contracts.StoreContracts;

namespace Practice.WebApi.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
			CreateMap<Store, StoreContract>();
			CreateMap<StoreContract, Store >();
			CreateMap<ProductTemplate, ProductTemplateContract>();
			CreateMap<ProductTemplateContract, ProductTemplate>();

			CreateMap<Code, CodeContract>()
				.ForMember(x => x.ProductTemplateTitle, x => x.MapFrom(m => m.ProductTemplate.Name))
				.ForMember(x => x.StoreName, x => x.MapFrom(m => m.Store.Name));

			CreateMap<CodeCreateContract, Code>();
		}
    }
}
