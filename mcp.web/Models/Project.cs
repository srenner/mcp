using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mcp.web.Models
{
    public class Project
    {
        public int ProjectID { get; set; }
        public int VehicleID { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
