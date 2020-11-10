using System;

namespace Inheritance
{
    class DerivedClass : BaseClass
    {
        public new void Method()
        {
            Console.WriteLine("Replaced method from DerivedClass");
        }
    }
}
