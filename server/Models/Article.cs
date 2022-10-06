using System;
using System.Collections.Generic;

namespace longform.Models
{
    public class Article
    {
      public int Id { get; set; }
      public string Title { get; set; }
      public string DatePublished { get; set; } // Datetime format YYYY-MM-DDT-HH-MM-SS
      public string DateRevised { get; set; } // Datetime format YYYY-MM-DDTHH-MM-SS
      public string AuthorId { get; set; }
      public int PublicationId { get; set; }
      public int CoverImgID { get; set; }
      public string Body { get; set; }
    }
}