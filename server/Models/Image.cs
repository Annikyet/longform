using System;
using System.Collections.Generic;

namespace longform.Models
{
  public class Image
  {
    public int Id { get; set; }
    public string OwnerId { get; set; }
    public string Title { get; set; }
    public bool Protected { get; set; }
    public string Url { get; set; }
  }
}