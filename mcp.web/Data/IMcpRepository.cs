using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mcp.web.Data
{
    public interface IMcpRepository
    {

        T AddEntity<T>(T entity) where T : class;
        T AddOrUpdateEntity<T>(T obj) where T : class;
        void DeleteEntity<T>(T deleteObj) where T : class;
        T GetEntity<T>(object id) where T : class;
    }
}
