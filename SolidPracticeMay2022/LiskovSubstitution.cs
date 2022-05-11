using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPracticeMay2022
{
 
    public abstract class Fruit
    {
        public abstract string GetColor();
    }
    public class Apples : Fruit
    {
        public override string GetColor()
        {
            return "Red";
        }
    }
    public class Oranges : Fruit
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
}
