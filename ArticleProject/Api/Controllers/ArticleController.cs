using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Services;
using Entity.DTOS.ArticleDtos;
using Entity.DTOS.ArticleDtos.AddDtos;
using Entity.Tables;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly ArticleApiServices _articleServices;

        public ArticleController(ArticleApiServices articleServices)
        {
            _articleServices = articleServices;
        }

        [HttpPost]
        public async Task<IActionResult> Post(ArticleAddDto article)
        {

            await _articleServices.PostAsync(article);

            return NoContent();
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {

            return Ok(await _articleServices.Get());
        }

        [HttpPut]
        public async Task<IActionResult> Put(ArticleUpdateDto article)
        {
            await _articleServices.PutAsync(article);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            await _articleServices.DeleteAsync(Id);
            return NoContent();
        }

        [HttpGet("/api/article/title")]
        public async Task<IActionResult> GetByName(string title)
        {
            return Ok(await _articleServices.GetByName(title));
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            return Ok(await _articleServices.GetById(Id));
        }
    }
}
