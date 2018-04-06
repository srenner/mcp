using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mcp.web.Models
{
    public class ProductHyperlink
    {
        public int ProductHyperlinkID { get; set; }
        public string URL { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
