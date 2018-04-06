using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mcp.web.Models
{
    public class ProjectStatusHistory
    {
        public int ProjectStatusHistoryID { get; set; }

        public int ProjectStatusID { get; set; }
        public ProjectStatus ProjectStatus { get; set; }

        public int ProjectID { get; set; }
        public Project Project { get; set; }

        public DateTime StatusDate { get; set; }
        [MaxLength(4000)]
        public string StatusNote { get; set; }
    }
}
