using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mcp.web.Models
{
    public class ProjectStep
    {
        public int ProjectStepID { get; set; }

        public int ProjectID { get; set; }
        public Project Project { get; set; }

        [MaxLength(500)]
        public string Name { get; set; }
        [MaxLength(4000)]
        public string Description { get; set; }

        public int? StepNumber { get; set; }

        public List<ProjectItem> ProjectStepItems { get; set; }
    }
}
