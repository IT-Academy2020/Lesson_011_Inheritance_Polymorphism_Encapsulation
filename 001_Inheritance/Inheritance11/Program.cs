using System;

// Герметизовані класи.

namespace Inheritance
{
    sealed class SealedClass
    {
        public int x;
        public int y;
    }

    // Спроба наслідувати клас SealedClass призводить до помилки рівня компілятора.

    class DerivedClass //: SealedClass   // Error
    {
    }    

    class Program
    {
        static void Main()
        {
            SealedClass instance = new SealedClass();
            instance.x = 100;
            instance.y = 200;

            Console.WriteLine("x = {0}, y = {1}", instance.x, instance.y);

            // Delay.
            Console.ReadKey();
        }
    }
}
