using System;

namespace Inheritance
{
    class DerivedClass : BaseClass
    {
        // Заміщення (приховування) методу базового класу.

        public void Method()
        {
            Console.WriteLine("Method from DerivedClass");
        }
    }
}
