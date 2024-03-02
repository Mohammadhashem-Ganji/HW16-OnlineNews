using HW16.Models;
using HW16.Repazitories;
using HW16.Repazitories.ExternalClassesForRepazitories;
using Microsoft.AspNetCore.Mvc;

namespace HW16.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult ShowListOfArticles()
        {
            ArticleRipazitory articleRipazitory = new ArticleRipazitory();
            List<Tbl_Article> articles = articleRipazitory.GetAllArticles();
            ViewData["articles"] = articles;
            return View();
        }
        public IActionResult AddArticle() => View();
        public IActionResult AddConfirmArticle(AddArticleEnt addArticleEnt)
        {
            ArticleRipazitory articleRipazitory = new ArticleRipazitory();
            articleRipazitory.AddArticle(addArticleEnt);
            return RedirectToAction("AddArticle");
        }
        public IActionResult DelleteArticle(int id)
        {
            ArticleRipazitory articleRipazitory = new ArticleRipazitory();
            articleRipazitory.DeleteArticle(id);
            return RedirectToAction("ShowListOfArticles");
        }
        public IActionResult EditArticle(int id)
        {
            ArticleRipazitory articleRipazitory = new ArticleRipazitory();
            articleRipazitory.EditArticle(id);
            return RedirectToAction("UpdateArticle");
        }
        public IActionResult UpdateArticle(UpdateArticleEnt updateArticleEnt)
        {
            ArticleRipazitory articleRipazitory = new ArticleRipazitory();
            articleRipazitory.UpdateArticle(updateArticleEnt);
            return View("ShowListOfArticle");
        }
    }
}
