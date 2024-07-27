
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayankFirst
{
    class EncapsulationExample1
    {
        public class Bike
        {
            public int mileage = 65;
            public string color = "black";
            private string formula = "a*a";//Its public – so accessible outside class
            public int GetMileage()
            {
                return mileage;
            }//Its public – so accessible outside class
            public string GetColor()
            {
                return color;
            }
            //Its private – so not accessible outside class
            private string GetEngineMakeFormula()
            {
                return formula;
            }

            public string DisplayFormula()
            {
                return GetEngineMakeFormula();
            }
            class EncapsulationExample1
            {
                static void Main(string[] args)
                {
                    Bike objb = new Bike();

                    Console.WriteLine("display mileage:" + objb.GetMileage());

                    Console.WriteLine("display color:" + objb.GetColor());

                    //  Console.WriteLine("display mileage:" + objb.GetEngineMakeFormula());

                    Console.WriteLine("display formula :" + objb.DisplayFormula());

                    Console.ReadKey();

                }
            }
        }
    }
}
