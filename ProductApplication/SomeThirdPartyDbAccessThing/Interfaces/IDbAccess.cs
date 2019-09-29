using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeThirdPartyDbAccessThing.Interfaces
{
    public interface IDbAccess
    {
        /// <summary>
        /// Executes a stored procedure call to the database, 
        /// and returns a DataTable with the result set
        /// </summary>
        /// <param name="name">Name of the stored procedure.</param>
        /// <param name="parameters">Collection of key-value pairs to be passed to the procedure</param>
        /// <returns>A DataTable with the resultset.</returns>
        DataTable ExecuteStoredProcedure(string name, Dictionary<string, object> parameters);

    }
}
