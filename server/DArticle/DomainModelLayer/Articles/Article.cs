using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;

namespace DArticle.DomainModelLayer.Articles
{
    public class Article : IAggregateRoot
    {
        Guid Id { get; }
    }
}
