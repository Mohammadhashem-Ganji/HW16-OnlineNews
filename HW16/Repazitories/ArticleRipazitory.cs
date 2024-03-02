using HW16.Models;
using HW16.Repazitories.ExternalClassesForRepazitories;
using System;
namespace HW16.Repazitories
{
    public class ArticleRipazitory
    {
        public List<Tbl_Article> GetAllArticles()
        {
            Models.OnlineNews onlineNews = new Models.OnlineNews();
            return onlineNews.Tbl_Articles.ToList();
        }
        public void AddArticle(AddArticleEnt addArticleEnt)
        {
            OnlineNews onlineNews = new OnlineNews();
            Tbl_Article newArticle = new Tbl_Article()
            {
                Title = addArticleEnt.title, // string
                Content = addArticleEnt.content, // string
                IsPublished = false, // bool
                PublicationDate = DateTime.Now, // dattime
                CategoryId = addArticleEnt.categoryId, // int ...,
                WorkflowId = addArticleEnt.workflowId,
            };
            if (addArticleEnt.image != null)
            {
                string ext = System.IO.Path.GetExtension(addArticleEnt.image.FileName);
                if (ext.ToLower() == ".jpg" && ext.ToLower() == ".png")
                {
                    if (addArticleEnt.image.Length <= 2 * System.Math.Pow(1024, 2))
                    {
                        byte[] b = new byte[addArticleEnt.image.Length];
                        addArticleEnt.image.OpenReadStream().Read(b, 0, b.Length);
                        newArticle.image = b;
                    }
                }
            }
            onlineNews.Add(newArticle);
            onlineNews.SaveChanges();
        }
        public void DeleteArticle(int id)
        {
            Models.OnlineNews onlineNews = new Models.OnlineNews();
            Tbl_Article article = onlineNews.Find<Tbl_Article>(id);
            onlineNews.Remove(article);
        }
        public Tbl_Article EditArticle(int id)
        {
            using(Models.OnlineNews onlineNews = new OnlineNews())
            {
                Models.Tbl_Article tbl_Article = onlineNews.Find<Tbl_Article>(id);
                return tbl_Article;
            }
        }
        public void UpdateArticle(UpdateArticleEnt updateArticleEnt)
        {
            using (Models.OnlineNews onlineNews = new OnlineNews())
            {
                Models.Tbl_Article tbl_Article = onlineNews.Find<Tbl_Article>(updateArticleEnt.id);
                tbl_Article.Title = updateArticleEnt.title;
                tbl_Article.WorkflowId = updateArticleEnt.workflowId;
                tbl_Article.Content = updateArticleEnt.content;
                tbl_Article.CategoryId = updateArticleEnt.categoryId;
                tbl_Article.PublicationDate = DateTime.Now;
                tbl_Article.IsPublished = false;
                if (updateArticleEnt.image != null)
                {
                    string ext = System.IO.Path.GetExtension(updateArticleEnt.image.FileName);
                    if (ext.ToLower() == ".jpg" && ext.ToLower() == ".png")
                    {
                        if (updateArticleEnt.image.Length <= 2 * System.Math.Pow(1024, 2))
                        {
                            byte[] b = new byte[updateArticleEnt.image.Length];
                            updateArticleEnt.image.OpenReadStream().Read(b, 0, b.Length);
                            tbl_Article.image = b;
                        }
                    }
                }
                onlineNews.Update(tbl_Article);
                onlineNews.SaveChanges();
            }
        }
    }
}





