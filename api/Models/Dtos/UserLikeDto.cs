using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models.Dtos
{
    public class UserLikeDto
    {
        public int UserId { get; set; }
        public string BookId { get; set; }
    }
}