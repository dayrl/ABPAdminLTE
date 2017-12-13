using Wing.ABPAdminLTE.EntityFrameworkCore;

namespace Wing.ABPAdminLTE.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly ABPAdminLTEDbContext _context;

        public TestDataBuilder(ABPAdminLTEDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}