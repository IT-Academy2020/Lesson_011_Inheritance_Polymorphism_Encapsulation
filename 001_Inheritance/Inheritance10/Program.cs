using System;

// Cast з використанням оператора as.

namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            DerivedClass instance = new DerivedClass();
            instance.Method();

            // UpCast
            BaseClass instanceUp = instance as BaseClass;
            instanceUp.Method();

            // DownCast
            DerivedClass instanceDown = instanceUp as DerivedClass;
            instanceDown.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}
