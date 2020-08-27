
// Наслідування.

namespace Inheritance
{
    class DerivedClass : BaseClass
    {
        public int derivedField;

        // Конструктор за замовчуванням.
        public DerivedClass()
        {
        }

        // Користувацький конструктор.
        // Викликається користувацький конструктор базового класу, при цьому не потрібно,
        // присвоювати значення, успадкованим членам в конструкторі похідного класу.
        public DerivedClass(int number1, int number2)
            : base(number1)
        {            
            derivedField = number2;
        }
    }
}
