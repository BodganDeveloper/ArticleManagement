using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Types
{
  /// <summary>
  /// Aggregate of Fire Reports corresponding to a certain
  ///  location name, in a certain county.
  /// </summary>    

  public class ArticleAggregate : Entity
  {
    public string title { get; set; }
    public string content { get; set; }

    public ArticleAggregate(string title, string content)
    {
      this.title = title;
      this.content = content;
    }

    /// <summary>
    /// To be used by the de-serializer
    /// </summary>
    public ArticleAggregate() { }

  }
}
