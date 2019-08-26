using System;
using System.Collections.Generic;
using System.Text;
using WS.Sqlsugar;

namespace ZY.Service
{
    public class TestService:Repository<DbFactory,ITestRepostory>, ITestService
    {
        public TestService(DbFactory factory, ITestRepostory iRepostory) : base(factory)
        {

        }


    }
}
