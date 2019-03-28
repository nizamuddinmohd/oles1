using AutoMapper;
using oles1.Controllers.Resources;
using oles1.Models;

namespace oles1.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
        }
    }
}