using FluentValidation;

namespace WebApi.Types
{
  public class ArticleValidator : AbstractValidator<ArticleAggregate>
  {
    public ArticleValidator()
    {
      RuleFor(article => article.title).NotEmpty();
      RuleFor(article => article.content).NotEmpty();
    }
  }
}
