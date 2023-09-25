using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DArticle.DomainModelLayer.Articles;

namespace DArticle.ApplicationLayer.Articles
{
    public interface IArticleService
    {
        Article Add(Article article);
        Article Remove(Guid articleId);
        Article Update(Guid articleId, string title, string content);
        Article Get(Guid articleId);
        IEnumerable<Article> GetAll();
    }
}
