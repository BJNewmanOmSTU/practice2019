using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Practice.Domain;
using Practice.WebApi.Contracts.AttributeContracts;
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
				.ForMember(x => x.Status, x => x.MapFrom(m => m.Status.ToString()));
			CreateMap<CodeCreateContract, Code>();

			CreateMap<AttributeContract, Attribute>();
		}
    }
}
