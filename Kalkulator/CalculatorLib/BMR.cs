using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLib
{
    //Dziedziczenie BMI
    public class BMR : BMI
    {
        private string gender;
        private double activity;
        private int age;

        public double getActivity()
        {
            return activity;
        }
        public string getGender()
        {
            return gender;
        }
        public int getAge()
        {
            return age;
        }
        public void setActivity(double activity)
        {
            this.activity = activity;
        }
        public void setGender(string gender)
        {
            this.gender = gender;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
    }
}
