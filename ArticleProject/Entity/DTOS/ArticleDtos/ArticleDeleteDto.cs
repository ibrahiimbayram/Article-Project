using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.DTOS.ArticleDtos
{
    public class ArticleDeleteDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Writer { get; set; }
        public DateTime Date { get; set; }
    }
}
