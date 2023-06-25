using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Assignment_1
{
    internal class Patient
    {
        // create the variables and set setters and getters
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public double Weight { get; set; } = double.NaN;
        public double Height { get; set; }= double.NaN;
        public Patient(string FirstName,string LastName,double Weight,double Height) 
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Weight = Weight;
            this.Height = Height;
        }

        // Create a method named CalculateBlloodPressure
        public string CalculateBloodPressure(int sys,int diast)
        {
            // checking the conditions with the use of if and else statements
            if(sys<120 && diast<80)
            {
                return "Normal";
            }
            else if(sys>=120 && sys<=129 && diast<80)
            {
                return "Elevated";
            }
            else if((sys>=130 && sys<=139) || (diast>=80 && diast<=89))
            {
                return "High blood pressure Stage-1";
            }
            else if((sys>=140) ||  (diast>=90))
            {
                return "High blood pressure Stage-2";
            }
            else if(sys>180  ||  diast>120)
            {
                return "Hypertensive Crisis";
            }
            else
            {
                return "Invalid blood pressure values you have entered.";
            }
        }

        // create a method named calculateBMI
        public double calculateBMI()
        {
            //convert height into meter from cm
            double heightmeter = Height / 100;
            return Weight / (heightmeter * heightmeter); // it will return BMI
        }
        public void patientinfo()
        {
           Console.WriteLine("Full Name: {0} {1}",FirstName,LastName);
            Console.WriteLine("Weight in kg: {0}", Weight);
            Console.WriteLine("Height in cm: {0} ", Height);
            // create two variables and set the value
            int sys=150;
            int diast= 90;
            string bloodpressure=CalculateBloodPressure(sys,diast);
            Console.WriteLine("Blood Pressure: {0}",bloodpressure);
            double bmi=calculateBMI();
            Console.WriteLine("Bmi: {0}",bmi);
            if(bmi>=25)
            {
                Console.WriteLine("body status: overweight");
            }
            else if(bmi>=18.5 && bmi<=24.9)
            {
                Console.WriteLine("body status: normal");
            }
            else
            {
                Console.WriteLine("body status: underweight");
            }
        }
    }
}
