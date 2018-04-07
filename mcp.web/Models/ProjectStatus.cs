using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mcp.web.Models
{
    public class ProjectStatus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjectStatusID { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }
    }
}
