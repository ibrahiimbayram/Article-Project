using AutoMapper;
using DataAcces.Interfaces;
using Entity.DTOS.ArticleDtos;
using Entity.DTOS.ArticleDtos.AddDtos;
using Entity.Tables;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class ArticleApiServices
    {

        private readonly IGenericDal<Article> _genericDal;
        private readonly IArticleDal _articleDal;

        IMapper _mapper;

        public ArticleApiServices(IGenericDal<Article> genericDal,IMapper mapper, IArticleDal articleDal)
        {
            _genericDal = genericDal;
            _mapper = mapper;
            _articleDal = articleDal;
        }


        public async Task<ArticleAddDto> PostAsync(ArticleAddDto article)
        {
            await _genericDal.AddAsync(_mapper.Map<Article>(article));
            return null;
        }

        public async Task<ArticleListDto> GetByName(string title)
        {
            return _mapper.Map<ArticleListDto>(await _articleDal.GetByName(title));
        }

        public async Task<List<ArticleListDto>> Get()
        {


            return _mapper.Map<List<ArticleListDto>>(await _genericDal.GetAllAsync());
        }


        public async Task<ArticleUpdateDto> PutAsync(ArticleUpdateDto article)
        {
            await _genericDal.UpdateAsync(_mapper.Map<Article>(article));
            return null;
        }

        public async Task<ArticleDeleteDto> DeleteAsync(int Id)
        {
            var deleteId =await _genericDal.GetByIdAsync(Id);

           await _articleDal.DeleteAsync(_mapper.Map<Article>(deleteId));
            return null;
        }

        public async Task<ArticleListDto> GetById(int Id)
        {
            return _mapper.Map<ArticleListDto>(await _genericDal.GetByIdAsync(Id));
        }

    }
}
