using System;

namespace CreateThatCode.DesignPatterns.Factories
{
    public interface IFactoryObject
    {

    }

    public class FactoryObject1 : IFactoryObject
    {
        private String value = String.Empty;

        public FactoryObject1(String value)
        {
            this.value = value;
        }
    }

    public class FactoryObject2 : IFactoryObject
    {
        private String value = String.Empty;

        public FactoryObject2(String value)
        {
            this.value = value;
        }
    }

    public class FactoryObject3 : IFactoryObject
    {
        private String value = String.Empty;

        public FactoryObject3(String value)
        {
            this.value = value;
        }
    }

    public interface IFactoryMethod
    {
        IFactoryObject CreateObject(String value);
    }

    public class FactoryMethod1 : IFactoryMethod
    {
        public IFactoryObject CreateObject(String value)
        {
            switch (value)
            {
                case "basic":
                    return new FactoryObject1(value);
                default:
                    return new FactoryObject2(value);
            }
        }
    }

    public class FactoryMethod2 : IFactoryMethod
    {
        public IFactoryObject CreateObject(String value)
        {
            switch (value)
            {
                default:
                    return new FactoryObject3(value);
            }
        }
    }
}
