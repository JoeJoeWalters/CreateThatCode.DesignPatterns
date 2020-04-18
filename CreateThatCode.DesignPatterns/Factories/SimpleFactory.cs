using System;

namespace CreateThatCode.DesignPatterns.Factories
{
    public interface ISimpleObject
    {
        
    }

    public class SimpleObject1 : ISimpleObject
    {
        private String value = String.Empty;

        public SimpleObject1(String value)
        {
            this.value = value;
        }
    }

    public class SimpleObject2 : ISimpleObject
    {
        private String value = String.Empty;

        public SimpleObject2(String value)
        {
            this.value = value;
        }
    }

    public class SimpleFactory
    {
        public ISimpleObject CreateObject(String value) 
        {
            switch (value)
            {
                case "basic":
                    return new SimpleObject1(value);
                default:
                    return new SimpleObject2(value);
            }
        }
    }
}
