using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLib
{
    //Dziedziczenie BMI i ustawianie setów i getów
    public class BMR : BMI
    {
        double activity;
        private int age;

        public double getActivity()
        {
            return activity;
        }
        public int getAge()
        {
            return age;
        }
        public void setActivity(double activity)
        {
            this.activity = activity;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
    }
}
