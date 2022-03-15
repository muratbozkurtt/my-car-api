using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyCar.Infrastructure.Request
{
    public class PaginationRequest
    {
        public PaginationRequest()
        {
            PageNumber = PageNumber <= 0 ? 1 : PageNumber;
            PageSize = 10;
        }
        [Required]
        public int PageNumber { get; set; }

        [Required]
        public int PageSize { get; set; }
    }
}
