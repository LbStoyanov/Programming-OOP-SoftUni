﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace OnlineShop.Models.Products.Components
{
    public class CentralProcessingUnit : Component
    {
        private  double multiplier = 1.25;
        public CentralProcessingUnit(int id, string manufacturer, string model, decimal price, double overallPerformance, int generation)
            : base(id, manufacturer, model, price, overallPerformance, generation)
        {
            overallPerformance *= multiplier;
        }
        
    }
}