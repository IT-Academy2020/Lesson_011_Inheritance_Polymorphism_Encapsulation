using System;

namespace Inheritance
{
    class DerivedClass : BaseClass
    {
        // Перевизначення методу базового класу.

        public override void Method()
        {
            Console.WriteLine("Method from DerivedClass");
        }
    }
}
