using Meeting_6.DAL;
using Meeting_6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Meeting_6.Controllers
{
    public class NewsController : Controller
    {
        private readonly IRepository<News> newsRep;

        public NewsController(IRepository<News> newsRep)
        {
            this.newsRep = newsRep;
        }

        // Главная
        public ActionResult Index()
        {
            return View("News", newsRep.GetAll());
        }

        // Редактирование
        public ActionResult Editing()
        {
            return View(newsRep.GetAll());
        }

        // Изменение новости
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            IEnumerable<News> buf = newsRep.GetAll();
            ViewBag.news = buf.Where(n => n.Id == id).FirstOrDefault(); 
            return View();
        }
        [HttpPost]
        public ActionResult Edit(News news)
        {
            if (ModelState.IsValid)
            {
                newsRep.Update(news);
                return RedirectToAction("Index");
            }
            return View();
        }

        //Добавление новости
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(News news)
        {
            if (ModelState.IsValid)
            {
                newsRep.Create(news);
                return RedirectToAction("Index");
            }
            return View();
        }

        // Удаление новости
        public ActionResult Delete(int id)
        {
            newsRep.Delete(id);
            return RedirectToAction("Editing");
        }

        // Получение 1 новости
        public ActionResult OneNews(int id)
        {
            IEnumerable<News> buf = newsRep.GetAll();
            News bufNews = buf.Where(n => n.Id == id).FirstOrDefault();
            if (bufNews != null)
            {
                return View(bufNews);
            }
            return HttpNotFound("News with that Id is not found.");
        }
    }
}