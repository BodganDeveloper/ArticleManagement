using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using DArticle.Helpers.Domain;

namespace DArticle.DomainModelLayer.Articles
{
    public class Article : IAggregateRoot
    {
        public virtual Guid Id { get; protected set; }

        public virtual string Title { get; protected set; }
        public virtual string Content { get; protected set; }
        public virtual DateTime CreatedAt { get; protected set; }
        public virtual DateTime UpdatedAt { get; protected set; }


        public static Article Create(string title, string content)
        {
            Article article = new Article()
            {
                Id = Guid.NewGuid(),
                Title = title,
                Content = content,
                CreatedAt = DateTime.Now
            };

            return article;
        }

        public virtual void Update(string title, string content)
        {
            this.Title = title;
            this.Content = content;
            this.UpdatedAt = DateTime.Now;
        }
    }
}
