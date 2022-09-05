using AutoMapper;

namespace OnlineStore.Application.Profiles
{
    public class AutoMapperProfile : Profile
    {
        #region [- ctor -]
        public AutoMapperProfile()
        {
            #region [- PersonFlow(Schema) -]
            CreateMap<Domain.Aggregates.Person, Dtos.PersonDto>().ReverseMap();
            #endregion
        }
        #endregion
    }
}
