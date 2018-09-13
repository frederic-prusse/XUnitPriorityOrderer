using System;
namespace XUnitPriorityOrderer
{  
    public class OrderAttribute : Attribute
    {
        public OrderAttribute(int priority)
        {
            Priority = priority;
        }

        public int Priority { get; private set; }
    }
}
