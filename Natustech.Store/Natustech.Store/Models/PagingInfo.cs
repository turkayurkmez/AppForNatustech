using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Natustech.Store.Models
{
    public class PagingInfo
    {
        public int TotalItemsCount { get; set; }
        public int PageSize { get; set; }
        public int TotalPages
        {
            get
            {
                return (int)Math.Ceiling((decimal)TotalItemsCount / PageSize);
            }
        }
        public int CurrentPage { get; set; }

    }
}
