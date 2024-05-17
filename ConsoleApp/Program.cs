using System;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

namespace ProgramaNS { 
    public class Calculator
    {
        /*

         * C1: p1, p6, p7, p13
         * C2: p1, p2, p3, p8, p13
         * C3: p1, p4, p5, p7, p13
         * C4: p1, p10, p12, p13

         */
        public static double calculateTotalPrice(double basePrice, String shippingType, int numItems)
        {
            if (basePrice >= 0) { //p1
                if (numItems > 10){ //p2
                    shippingType = "express"; //p3
                }
                else if(numItems < 0){ //p4
                    numItems = 0; //p5
                }
            } else {
                basePrice = 0; //p6
            }
            switch (shippingType)
            {
                case "standard":
                    basePrice += 5.0; //p7
                    break;
                case "express":
                    basePrice += 10.0; //p8
                    break;
                case "overnight":
                    basePrice += 20.0; //p9
                    break;
            }

            for (double i = basePrice; i > 50; i-=50) //p10
            {
                basePrice -= 10; // p12
            }

            return basePrice; //p13
        }
        static void Main(string[] args)
        {
        }
    }
}