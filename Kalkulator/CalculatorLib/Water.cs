using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CalculatorLib
{
    public class Water : BMR
    {
        private double water;
        private double workout;

        public double getWater()
        {
            return water;
        }
        public double getWorkout()
        {
            return workout;
        }
        public void setWater(double water)
        {
            this.water = water;
        }
        public void setWorkout(double workout)
        {
            this.workout = workout;
        }
    }
}
