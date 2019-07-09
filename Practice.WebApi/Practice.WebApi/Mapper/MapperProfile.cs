using AutoMapper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Practice.Domain;
using Practice.WebApi.Contracts.ProductTemplatesContracts;
using System;

namespace Practice.WebApi.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
			CreateMap<ProductTemplate, ProductTemplateContractModel>();
		}
    }
}
