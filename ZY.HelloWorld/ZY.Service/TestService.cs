using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WS.Sqlsugar;

namespace ZY.Service
{
    public class TestService:Repository<DbFactory,ITestRepostory>, ITestService
    {
        public TestService(DbFactory factory, ITestRepostory iRepostory) : base(factory)
        {

        }

        public async void TestMethod()
        {
            //查询(非事务)
            List<CodeModel> codes = DbContext.Queryable<CodeModel>().Where(c => c.TypeCode == "").ToList();

            //事务
            using (var db = Factory.GetDbContext())
            {
                db.BeginTran();

                db.Insertable(new CodeModel());

                db.CommitTran();
            }
        }


    }
}
