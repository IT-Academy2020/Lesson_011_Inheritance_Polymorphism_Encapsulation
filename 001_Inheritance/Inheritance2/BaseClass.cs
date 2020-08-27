using System;

// Наслідування.

namespace Inheritance
{
    class BaseClass
    {
        // Поля

        public string publicField = "BaseClass.publicField";
        private string privateField = "BaseClass.privateField";
        protected string protectedField = "BaseClass.protectedField";

        // Методи

        public void Show()
        {
            Console.WriteLine(privateField);
        }
    }
}
