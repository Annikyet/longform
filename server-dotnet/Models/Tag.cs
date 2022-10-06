using System;
using System.Collections.Generic;

namespace longform.Models
{
  public class Tag
  {
    public int ArticleId { get; set; }
    public string TagName { get; set; } // SQL column is named 'tag'
  }
}