using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mcp.web.Models
{
    public class ProjectItem
    {
        public int ProjectItemID { get; set; }
        [MaxLength(500)]
        public string Name { get; set; }
        [MaxLength(4000)]
        public string Description { get; set; }

        public int? ProductHyperlinkID { get; set; }
        public ProductHyperlink ProductHyperlink { get; set; }

        public int? SortOrder { get; set; }

        public List<ProductHyperlink> AlternativeProductHyperlinks { get; set; }
    }
}
