using AutoMapper;
using StudentAdminPortal.API.DomainModels;
using DataModel = StudentAdminPortal.API.DataModel;

namespace StudentAdminPortal.API.Profiles
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<DataModel.Student, Student>().ReverseMap();
            CreateMap<DataModel.Gender, Gender>().ReverseMap();
            CreateMap<DataModel.Address, Address>().ReverseMap();
        }
    }
}
