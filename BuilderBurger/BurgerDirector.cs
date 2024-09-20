﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using PatternBuilder.DBCon;

namespace PatternBuilder.BuilderBurger
{
    public class BurgerDirector
    {
        private readonly IBurgerBuilder _builder;

        public BurgerDirector(IBurgerBuilder builder) 
        {
            _builder = builder;
        }
        public void BuildDefault()
        {
            _builder
                .AddCheese()
                .AddTomato().
                AddPickles();
        }
        public void BuildWithBeacon()
        {
            _builder
                .AddTomato()
                .AddBacon()
                .AddLetuce();
        }
    }
}
