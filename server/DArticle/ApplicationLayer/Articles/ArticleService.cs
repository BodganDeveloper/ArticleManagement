using AutoMapper;
using System;
using DArticle.Helpers.Repository;
using DArticle.DomainModelLayer.Articles;
using DArticle.InfrastructureLayer;

namespace DArticle.ApplicationLayer.Articles
{
    public class ArticleService : IArticleService
    {
        IArticleRepository articleRepository;
        public ArticleService(IArticleRepository articleRepository)
        {
            this.articleRepository = articleRepository;
        }
        public Article Add(Article articleDto)
        {
            Article article = Article.Create(articleDto.Title, articleDto.Content);
            this.articleRepository.Add(article);

            return article;
        }

        public Article Remove(Guid articleId)
        {

            Article article = this.articleRepository.FindById(articleId);

            this.articleRepository.Remove(article);

            return article;
        }

        public Article Get(Guid articleId)
        {
            Article article = this.articleRepository.FindById(articleId);

            return article;
        }

        public IEnumerable<Article> GetAll()
        {
            return this.articleRepository.GetAll();
        }
        public Article Update(Guid id, string title, string content)
        {

            Article article = this.articleRepository.FindById(id);

            article.Update(title, content);

            return article;
        }
    }
}
