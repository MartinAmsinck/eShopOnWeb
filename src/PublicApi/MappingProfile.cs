using AutoMapper;
using Effektiv.ApplicationCore.Entities;
using Effektiv.PublicApi.CatalogItemEndpoints;

namespace Effektiv.PublicApi
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CatalogItem, CatalogItemDto>();
        }
    }
}
