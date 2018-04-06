using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mcp.web.Models
{
    public class Project
    {
        public int ProjectID { get; set; }

        public int VehicleID { get; set; }
        public Vehicle Vehicle { get; set; }

        public DateTime CreationDate { get; set; }
        public DateTime? TargetStartDate { get; set; }
        public DateTime? TargetEndDate { get; set; }

        [MaxLength(500)]
        public string Name { get; set; }
        [MaxLength(4000)]
        public string Description { get; set; }

        
        public int ProjectStatusID { get; set; }
        public ProjectStatus ProjectStatus { get; set; }

        public bool IsPublic { get; set; }
        public bool IsArchived { get; set; }

        public List<ProjectStatus> StatusHistory { get; set; }
        public List<ProjectItem> ProjectItems { get; set; }
        public List<ProjectStep> ProjectSteps { get; set; }

    }
}
