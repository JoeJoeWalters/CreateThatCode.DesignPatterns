using System;
using System.Collections.Generic;
using System.Text;

namespace CreateThatCode.DesignPatterns.Factories
{
    public class CreationObject
    {
        String value = String.Empty; 

        public CreationObject(String value)
        {
            this.value = value;
        }

        public static CreationObject GetInstance(String value)
        {
            return new CreationObject(value);
        }
    }
}
