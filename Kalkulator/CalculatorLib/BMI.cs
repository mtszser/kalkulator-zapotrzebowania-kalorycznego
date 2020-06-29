using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLib
{
    //Sety i gety do wykorzystania dla BMI i BMR
    public class BMI
    {
        private double weight;
        private double height;
        private string sex;
        private double result;



        public double getWeight()
        {
            return weight;
        }
        public double getHeight()
        {
            return height;
        }
        public string getSex()
        {
            return sex;
        }
        public double getResult()
        {
            return result;
        }
        public void setWeight(double weight)
        {
            this.weight = weight;
        }
        public void setHeight(double height)
        {
            this.height = height;
        }
        public void setSex(string sex)
        {
            this.sex = sex;
        }
        public void setResult(double result)
        {
            this.result = result;
        }
        public string getInfo()
        {
            return "Niedowaga: poniżej 18,5" + "\nPrawidłowa masa ciała: 18,5-24,9" + "\nNadwaga: 25,0-29,9" + "\notyłość I stopnia: 30,0-34,9" + "\notyłość II stopnia: 35,0-39,9"
                    + "\notyłość III stopnia: powyżej 40";
        }
    }
}
