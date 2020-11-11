
// Наслідування.

namespace Inheritance
{
    class DerivedClass : BaseClass
    {
        public int derivedField;

        // Конструктор за замовчуванням.
        public DerivedClass()
        {
            System.Console.WriteLine("DerivedClass ctor");
        }

        // Користувацький конструктор.
        // Викликається користувацький конструктор базового класу, при цьому не потрібно,
        // присвоювати значення, успадкованим членам в конструкторі похідного класу.
        public DerivedClass(int number1, int number2)
            : base()
        {
            
            derivedField = number2;
        }
    }
}
