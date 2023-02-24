using AutoMapper;
using Teladoc.Application.Models;
using Teladoc.Domain.Entities;

namespace Teladoc.Application.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserModel>();
        }
    }
}
