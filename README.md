# XUnitPriorityOrderer
Order test cases and collections using xunit (ITestCaseOrderer, ITestCollectionOrderer)

Based in the [guideline of tomdupont](http://www.tomdupont.net/2016/04/how-to-order-xunit-tests-and-collections.html)
with some minor changes to get the collection order in project's assemblies that import the nuget

## How to use
Add/Download the package [XUnitPriorityOrderer](https://www.nuget.org/packages/XUnitPriorityOrderer/1.0.3) from [nuget.org](https://www.nuget.org)

```dotnet add package XUnitPriorityOrderer --version 1.0.3```

set a base test class adding the required parameters (TestCollectionOrderer and TestCaseOrderer) following the sample:

```c#
using Xunit;
using XUnitPriorityOrderer;

// set to be sequential execution
[assembly: CollectionBehavior(DisableTestParallelization = true)]
// addset the custom test's collection orderer
[assembly: TestCollectionOrderer(CollectionPriorityOrderer.TypeName, CollectionPriorityOrderer.AssembyName)]

namespace MyTestsNameSpace
{
    // set the custom test's case orderer
    [TestCaseOrderer(CasePriorityOrderer.TypeName, CasePriorityOrderer.AssembyName)]
    public class MyBaseTestClass { }
}
```

And set the order of your tests, following the sample

```c#
using Xunit;
using XUnitPriorityOrderer;

namespace MyTestsNameSpace
{
    // Set collection order
    [Order(5)]
    public class MyTestClass : MyBaseTestClass
    {
        // Set case order
        [Fact, Order(2)]
        public void Test2() {}

        // Set case order
        [Fact, Order(1)]
        public void Test1() {}
    }
}
```
