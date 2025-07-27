using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models.Dtos
{
    public class BookApiResponse
    {
        public string Error { get; set; }
        public string Total { get; set; }
        public List<BookDto> Books { get; set; }
    }
}