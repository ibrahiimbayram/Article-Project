using AutoMapper;
using Entity.DTOS.ArticleDtos;
using Entity.DTOS.ArticleDtos.AddDtos;
using Entity.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.AutoMapper
{
    public class Map : Profile
    {
        public Map()
        {
            CreateMap<Article, ArticleAddDto>();
            CreateMap<ArticleAddDto, Article>();

            CreateMap<Article, ArticleListDto>();
            CreateMap<ArticleListDto, Article>();


            CreateMap<Article, ArticleUpdateDto>();
            CreateMap<ArticleUpdateDto, Article>();


            CreateMap<Article, ArticleDeleteDto>();
            CreateMap<ArticleDeleteDto, Article>();
        }
    }
}
