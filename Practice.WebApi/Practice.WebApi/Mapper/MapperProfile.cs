using AutoMapper;
using Practice.Domain;
using Practice.WebApi.Contracts.ProductTemplatesContracts;


namespace Practice.WebApi.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
			CreateMap<ProductTemplate, ProductTemplateContract>();
		}
    }
}
