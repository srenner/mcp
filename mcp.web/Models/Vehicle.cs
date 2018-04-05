using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mcp.web.Models
{
    public class Vehicle
    {
        public int VehicleID { get; set; }
        public string Name { get; set; }

        public string OwnerID { get; set; }
        public ApplicationUser Owner { get; set; }
    }
}
