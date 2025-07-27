using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models.Dtos
{
    public class BookDto
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Isbn13 { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }
    }
}