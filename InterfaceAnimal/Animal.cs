using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAnimal
{
    public abstract class Animal
    {
        public abstract string MakeSound();
    }

    public abstract class Fruit : Edible
    {
        public abstract string HowToEat();
    }

    public interface Edible
    {
        string HowToEat();
    }

    public class Tiger : Animal
    {
        public override string MakeSound()
        {
            return "Tiger: roarrrr!";
        }
    }

    public class Chicken : Animal, Edible
    {
        public override string MakeSound()
        {
            return "Chicken: Pok pok";
        }

        public string HowToEat()
        {
            return "Could be frided";
        }
    }

    public class Apple : Fruit
    {
        public override string HowToEat()
        {
            return "Apple could be slided";
        }
    }

    public class Orange : Fruit
    {
        public override string HowToEat()
        {
            return "Orange could be juiced";
        }
    }
}
