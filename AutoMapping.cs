using System.Collections.Generic;
using AutoMapper;
using BlogApplication.Models;
using BlogApplication.ViewModel;

namespace BlogApplication
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<BlogDetail,BlogDetailViewModel>();
            CreateMap<List<BlogDetailViewModel>, List<BlogDetail>>();
            CreateMap<BlogDetailViewModel, BlogDetail>();
        }
    }

}
