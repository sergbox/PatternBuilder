﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternBuilder.DBCon;

namespace PatternBuilder.BuilderBurger
{
    public interface IBurgerBuilder
    {
        IBurgerBuilder AddCheese();
        IBurgerBuilder AddBacon();
        IBurgerBuilder AddLetuce();
        IBurgerBuilder AddTomato();
        IBurgerBuilder AddPickles();
        Burgers GetBurgers();
    }
}
