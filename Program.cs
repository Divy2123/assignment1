namespace Csharp_Assignment_1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Age:");
            int age=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Pateint Information for further inquiry.");

            Console.WriteLine("Enter Your First Name:");
            string firstname=Console.ReadLine();

            Console.WriteLine("Enter Your Last Name: ");
            string lastname=Console.ReadLine();

            Console.WriteLine("Enter Your Weight in kg:");
            double weight=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Your Height in cm:");
            double height=Convert.ToDouble(Console.ReadLine());

            Patient patient=new Patient(firstname,lastname,height,weight);
            patient.patientinfo();
        }
    }
}