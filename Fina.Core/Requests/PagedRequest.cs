using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fina.Core.Requests
{
    public abstract class PagedRequest:Request
    {
        public int PageSize { get; set; } = Configuration.DefaultPagenumber;
        public int PageNumber { get; set; } = Configuration.DefaultPageSize;
    }
}