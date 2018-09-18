using Xunit;
using XUnitPriorityOrderer;

[assembly: CollectionBehavior(DisableTestParallelization = true)]
[assembly: TestCollectionOrderer(CollectionPriorityOrderer.TypeName, CollectionPriorityOrderer.AssembyName)]

namespace Tests.XUnitPriorityOrderer
{
    public class BaseTest : BaseOrderedTest
    {
        protected static int _lastTestPriority = 0;
    }


}