using System;

namespace DArticle.Helpers.Domain
{
  public interface IAggregateRoot
  {
    Guid Id { get; }
  }
}
