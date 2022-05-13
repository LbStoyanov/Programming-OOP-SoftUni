﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismEx
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, int foodEaten, string livingRegion) 
            : base(name, weight, foodEaten, livingRegion)
        {
        }
        public override void ProducingSound()
        {
            Console.WriteLine("Squeak");
        }

        public override string ToString()
        {
            return base.ToString();
        }
        public override void Feed(string foodType)
        {
            this.Weight += FoodEaten * 0.10;
        }
    }
}