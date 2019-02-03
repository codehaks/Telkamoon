using AutoMapper;

namespace Portal.Application.Common.Mapping
{
    public class CommonMapping : Profile
    {
        public CommonMapping()
        {
            CreateMap<string, string>().ConvertUsing(new StringTrimmer());

        }
    }
}