using Microsoft.AspNetCore.Mvc;
using DArticle.ApplicationLayer.Articles;
using DArticle.DomainModelLayer.Articles;
using FluentValidation;
using FluentValidation.Results;
using WebApi.Types;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
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
}
