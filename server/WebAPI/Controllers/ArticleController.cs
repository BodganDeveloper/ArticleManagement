using Microsoft.AspNetCore.Mvc;
using DArticle.ApplicationLayer.Articles;
using DArticle.DomainModelLayer.Articles;
using FluentValidation;
using FluentValidation.Results;
using WebApi.Types;

namespace WebApi.Controllers;


[Route("api/[controller]")]
[ApiController]
public class ArticleController : ControllerBase
{
  private readonly IArticleService articleService;

  public ArticleController(IArticleService _articleService)
  {
    articleService = _articleService;
  }

  [HttpGet]
  public ActionResult<IEnumerable<Article>> GetAll()
  {
    return Ok(articleService.GetAll());
  }

  [HttpGet("{id}")]
  public ActionResult<Article> GetById(Guid id)
  {
    try
    {
      Article article = articleService.Get(id);
      return Ok(article);
    }
    catch
    {
      return StatusCode(500);
    }
  }

  [HttpPost]
  public ActionResult<Article> Add([FromBody] ArticleAggregate article)
  {
    try
    {
      ArticleValidator validator = new ArticleValidator();

      ValidationResult result = validator.Validate(article);

      if (result.IsValid)
      {
        Article newArticle = articleService.Add(Article.Create(article.title, article.content));
        return Ok(newArticle);
      }
      else
      {
        return StatusCode(422, result.Errors);
      }
    }
    catch
    {
      return StatusCode(500);
    }
  }

  [HttpPut("{id}")]
  public ActionResult<Article> Update(Guid id, [FromBody] ArticleAggregate article)
  {
    try
    {
      ArticleValidator validator = new ArticleValidator();

      ValidationResult result = validator.Validate(article);

      if (result.IsValid)
      {
        Article newArticle = articleService.Update(id, article.title, article.content);
        return Ok(newArticle);
      }
      else
      {
        return StatusCode(422, result.Errors);
      }
    }
    catch
    {
      return StatusCode(500);
    }
  }

  [HttpDelete("{id}")]
  public ActionResult<Article> Delete(Guid id)
  {
    try
    {
      return Ok(articleService.Remove(id));
    }
    catch
    {
      return StatusCode(500);
    }
  }
}
