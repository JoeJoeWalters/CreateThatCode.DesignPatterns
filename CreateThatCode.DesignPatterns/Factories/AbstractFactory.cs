using System;
using System.Collections.Generic;
using System.Text;

namespace CreateThatCode.DesignPatterns.Factories
{
    public abstract class Chasis { }
    public abstract class GearBox { }
    public abstract class Engine { }

    public interface IAbstractCarFactory
    {
        Chasis GetChasis();
        GearBox GetGearBox();
        Engine GetEngine();
    }

    public class BasicChasis : Chasis { }
    public class BasicGearBox : GearBox { }
    public class BasicEngine : Engine { }

    public class BasicCarFactory : IAbstractCarFactory
    {
        public Chasis GetChasis() => new BasicChasis();

        public GearBox GetGearBox() => new BasicGearBox();

        public Engine GetEngine() => new BasicEngine();
    }

    public class SuperChasis : Chasis { }
    public class SuperGearBox : GearBox { }
    public class SuperEngine : Engine { }

    public class SuperCarFactory : IAbstractCarFactory
    {
        public Chasis GetChasis() => new SuperChasis();

        public GearBox GetGearBox() => new SuperGearBox();

        public Engine GetEngine() => new SuperEngine();
    }
}
