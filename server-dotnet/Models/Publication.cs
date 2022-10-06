using System;
using System.Collections.Generic;

namespace longform.Models
{
  public class Publication
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public int CoverImgId { get; set; }
    public string Description { get; set; }
  }
}