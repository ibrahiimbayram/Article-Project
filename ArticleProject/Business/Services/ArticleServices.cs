using Entity.DTOS.ArticleDtos;
using Entity.DTOS.ArticleDtos.AddDtos;
using Entity.Tables;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class ArticleServices
    {
        HttpClient httpClient = new HttpClient();
        public async Task<List<ArticleListDto>> List()
        {

            var stringmessage = await httpClient.GetAsync("https://localhost:44355/api/article");
            var json =await stringmessage.Content.ReadAsStringAsync();
            var content = JsonConvert.DeserializeObject<List<ArticleListDto>>(json);



            return content;
        }


        public async Task<ArticleAddDto> CreateAsync(ArticleAddDto articleAddDto)
        {
            articleAddDto.Date = DateTime.Now;
           var content= JsonConvert.SerializeObject(articleAddDto);

            StringContent stringContent = new StringContent(content, Encoding.UTF8, "application/json");

            await httpClient.PostAsync("https://localhost:44355/api/article", stringContent);

            return null;
        }

   
        public async Task<List<ArticleListDto>> GetArticleDetails(string id)
        {
            var stringmessage = await httpClient.GetAsync("https://localhost:44355/api/article/title?title="+ id);
            var json = await stringmessage.Content.ReadAsStringAsync();
            var content = JsonConvert.DeserializeObject<ArticleListDto>(json);


            var veri = content;

            List<ArticleListDto> list = new List<ArticleListDto>();
            ArticleListDto model = new ArticleListDto();
            model.Id = veri.Id;
            model.Title = veri.Title;
            model.ShortDescription = veri.ShortDescription;
            model.Description = veri.Description;
            model.Writer = veri.Writer;
            model.Date = veri.Date;

            list.Add(model);

            return list;
        }

        public async Task<ArticleDeleteDto> Delete(int articleDeleteDto)
        {

            await httpClient.DeleteAsync("https://localhost:44355/api/article/"+ articleDeleteDto);

            return null;
        }

        public async Task<ArticleUpdateDto> Update(ArticleUpdateDto articleUpdateDto)
        {
            articleUpdateDto.Date = DateTime.Now;
            var content = JsonConvert.SerializeObject(articleUpdateDto);

            StringContent stringContent = new StringContent(content, Encoding.UTF8, "application/json");
            await  httpClient.PutAsync("https://localhost:44355/api/article",stringContent);



            return null;
        }


        public async Task<List<ArticleListDto>> GetSearch(string search)
        {
            var stringmessage = await httpClient.GetAsync("https://localhost:44355/api/article/title?title=" + search);
            var json = await stringmessage.Content.ReadAsStringAsync();
            var content = JsonConvert.DeserializeObject<ArticleListDto>(json);


            var veri = content;

            List<ArticleListDto> list = new List<ArticleListDto>();
            ArticleListDto model = new ArticleListDto();
            model.Id = veri.Id;
            model.Title = veri.Title;
            model.ShortDescription = veri.ShortDescription;
            model.Description = veri.Description;
            model.Writer = veri.Writer;
            model.Date = veri.Date;

            list.Add(model);

            return list;
        }
    }
}
