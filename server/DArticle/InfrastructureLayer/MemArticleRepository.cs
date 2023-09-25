using DArticle.Helpers.Domain;
using DArticle.Helpers.Repository;
using DArticle.DomainModelLayer.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DArticle.InfrastructureLayer
{
    public class ArticleRepository : IArticleRepository
    {
        protected static List<Article> entities = new List<Article>();

        public Article FindById(Guid id)
        {
            return entities.Where(x => x.Id == id).FirstOrDefault();
        }

        public void Add(Article entity)
        {
            entities.Add(entity);
        }

        public void Remove(Article entity)
        {
            entities.Remove(entity);
        }

        public IEnumerable<Article> GetAll()
        {
            return entities;
        }
    }
}
