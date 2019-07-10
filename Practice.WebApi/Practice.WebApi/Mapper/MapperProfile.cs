using AutoMapper;
using Practice.Domain;
using Practice.WebApi.Contracts.ProductTemplatesContracts;
using Practice.WebApi.Contracts.StoreContracts;

namespace Practice.WebApi.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
			CreateMap<Store, StoreContract>();
			CreateMap<ProductTemplate, ProductTemplateContract>();
		}
    }
}
