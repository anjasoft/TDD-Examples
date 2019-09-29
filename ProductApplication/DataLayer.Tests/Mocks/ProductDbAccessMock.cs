using SomeThirdPartyDbAccessThing.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Tests.Mocks
{
    class ProductDbAccessMock : IDbAccess
    {
        public bool ExecuteProcedureWasCalled { get; private set; }
        public Dictionary<string, object> PassedParameters { get; private set; }
        public DataTable ToReturnDataTable { get;  set; }
        

        public DataTable ExecuteStoredProcedure(string name, Dictionary<string, object> parameters)
        {
            PassedParameters = parameters;
            ExecuteProcedureWasCalled = true;
            return ToReturnDataTable;
        }
    }
}
