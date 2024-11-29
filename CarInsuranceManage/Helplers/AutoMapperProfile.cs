using AutoMapper;
using CarInsuranceManage.Controllers;
using CarInsuranceManage.Models;
using CarInsuranceManage.ViewModels;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using System.Security.Cryptography;

namespace CarInsuranceManage.Helplers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<RegisterViewModel, User>();
            //    .ForMember(kh => kh.email, option => option.MapFrom(RegisterViewModel =>RegisterViewModel.email));
        }
    }
}
