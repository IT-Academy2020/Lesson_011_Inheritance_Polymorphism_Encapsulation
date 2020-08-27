
// Наслідування.

namespace Inheritance
{
    class DerivedClass : BaseClass
    {
        // Конструктор.
        public DerivedClass()
        {
            // Змінюємо всі доступні поля успадковані від базового класу.

            publicField = "DerivedClass.publicField";
            protectedField = "DerivedClass.protectedField";            
        }
    }
}
