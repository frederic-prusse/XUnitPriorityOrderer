using Xunit;
using XUnitPriorityOrderer;

[assembly: CollectionBehavior(DisableTestParallelization = true)]
[assembly: TestCollectionOrderer(CollectionPriorityOrderer.TypeName, CollectionPriorityOrderer.AssembyName)]

namespace XUnitPriorityOrderer
{
    [TestCaseOrderer(
    CasePriorityOrderer.TypeName, 
    CasePriorityOrderer.AssembyName)]
    public class BaseOrderedTest { }
}