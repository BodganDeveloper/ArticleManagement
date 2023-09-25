using DArticle.Helpers.Domain;
using DArticle.DomainModelLayer.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DArticle.Helpers.Repository
{
    public interface IArticleRepository
    {
        Article FindById(Guid id);


        void Add(Article entity);

        void Remove(Article entity);

        IEnumerable<Article> GetAll();
    }
}
