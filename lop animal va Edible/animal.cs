using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lop_animal_va_Edible
{
    internal abstract class animal
    {
        public abstract string makeSound();

    }

    public class Tiger : animal
    {
        public override string makeSound()
        {
            return "Tiger: Roarrrr";
        }
    }

}
