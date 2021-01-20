using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Business.Services;
using Entity.DTOS.ArticleDtos;
using Entity.DTOS.ArticleDtos.AddDtos;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ArticleServices _articleServices;
        IMapper _mapper;

        public HomeController(ArticleServices articleServices, IMapper mapper)
        {
            _articleServices = articleServices;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _articleServices.List());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ArticleAddDto articleAddDto)
        {
            await _articleServices.CreateAsync(articleAddDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> ArticleDetails(string id)
        {
            return View(await _articleServices.GetArticleDetails(id));
        }

        public async Task<IActionResult> ArticleDelete(ArticleDeleteDto articleDeleteDto)
        {
            await _articleServices.Delete(articleDeleteDto.Id);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int Id)
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Update(ArticleUpdateDto articleUpdateDto)
        {
            await _articleServices.Update(articleUpdateDto);
            return RedirectToAction("Index");
        }

        public IActionResult Search(string search)
        {
            TempData["search"] = search;
            return RedirectToAction("SearchList");
        }

        public async Task<IActionResult> SearchList()
        {
            string search = TempData["search"].ToString();
            return View(await _articleServices.GetSearch(search));
        }
    }
}
