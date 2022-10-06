using System;
using System.Collections.Generic;

namespace longform.Models
{
  public class Subscription
  {
    public string ReaderId { get; set; }
    public string AuthorId { get; set; }
    public int PublicationId { get; set; }
    public string TagName { get; set; } // SQL column is named 'tag'
  }
}