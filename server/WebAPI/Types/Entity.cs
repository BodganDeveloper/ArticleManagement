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
  public abstract class Entity
  {
    public int Id { get; set; }
  }
}
