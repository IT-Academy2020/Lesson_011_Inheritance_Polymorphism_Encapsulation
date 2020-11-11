
// Наслідування.

namespace Inheritance
{
    class BaseClass
    {
        public int baseNumber;

        // Конструктор за замовчуванням.
        public BaseClass() 
        {
            System.Console.WriteLine("BaseClass ctor");
        }

        // Користувацький конструктор.
        public BaseClass(int number)
        {
            this.baseNumber = number;
        }
    }
}
