using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xunit;
using Xunit.Abstractions;

namespace XUnitPriorityOrderer
{
    public class CollectionPriorityOrderer : ITestCollectionOrderer
    {
        public const string AssembyName = "XUnitPriorityOrderer";
        public const string TypeName = "XUnitPriorityOrderer.CollectionPriorityOrderer";
        public IEnumerable<ITestCollection> OrderTestCollections(IEnumerable<ITestCollection> testCollections)
        {
            return testCollections.OrderBy(GetOrder);
        }

        private static int GetOrder(ITestCollection testCollection)
        {
            var i = testCollection.DisplayName.LastIndexOf(' ');
            if (i <= -1)
                return 0;
    
            var className = testCollection.DisplayName.Substring(i + 1);
            var type = Type.GetType(className);
            if (type == null)
                return 0;
    
            var attr = type.GetCustomAttribute<OrderAttribute>();
            return attr?.Priority ?? 0;
        }
    }
}
