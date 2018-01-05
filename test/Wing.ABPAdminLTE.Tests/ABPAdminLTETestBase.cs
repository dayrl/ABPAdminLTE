using System;
using System.Threading.Tasks;
using Abp.TestBase;
using Wing.ABPAdminLTE.EntityFrameworkCore;
using Wing.ABPAdminLTE.Tests.TestDatas;

namespace Wing.ABPAdminLTE.Tests
{
    public class ABPAdminLTETestBase : AbpIntegratedTestBase<ABPAdminLTETestModule>
    {
        public ABPAdminLTETestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<ABPAdminLTEDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<ABPAdminLTEDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<ABPAdminLTEDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<ABPAdminLTEDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<ABPAdminLTEDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<ABPAdminLTEDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<ABPAdminLTEDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<ABPAdminLTEDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
