using mcp.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mcp.web.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if(!context.ProjectStatus.Any())
            {
                var statii = new List<ProjectStatus>
                {
                    new ProjectStatus
                    {
                        ProjectStatusID = 1,
                        Name = "Planning"
                    },
                    new ProjectStatus
                    {
                        ProjectStatusID = 2,
                        Name = "In Process",
                    },
                    new ProjectStatus
                    {
                        ProjectStatusID = 3,
                        Name = "Delayed"
                    },
                    new ProjectStatus
                    {
                        ProjectStatusID = 4,
                        Name = "Final Details"
                    },
                    new ProjectStatus
                    {
                        ProjectStatusID = 5,
                        Name = "Complete"
                    },
                    new ProjectStatus
                    {
                        ProjectStatusID = 6,
                        Name = "Canceled"
                    }
                };
                context.ProjectStatus.AddRange(statii);
                context.SaveChanges();

            }
        }
    }
}
