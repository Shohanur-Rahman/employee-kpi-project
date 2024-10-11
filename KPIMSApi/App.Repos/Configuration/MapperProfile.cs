using AutoMapper;
using KPIMS.Core.Models;

namespace KPIMS.Repos.Configuration
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<DbEmployee,DbEmployee>().ReverseMap();
            CreateMap<DbWorkItemLog, DbWorkItem>().ReverseMap();
        }
    }
}
