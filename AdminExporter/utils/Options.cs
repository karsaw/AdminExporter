using System;
namespace AdminExporter.utils
{
    public class Options
    {
        
        public int getOptions()
        {
            Console.WriteLine("Please select one option");
            Console.WriteLine("1. Export Customer Data");
            Console.WriteLine("2. Export Employee Data");
            Console.WriteLine("3. Exit");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Enter option");
            int option = Convert.ToInt32(Console.ReadLine());
            return option;

        }

        public bool doYouWantToContinue()
        {
            Console.Write("Do You Want To Continue? y/n : ");
            string answer = Console.ReadLine();
            if (answer.Equals("y"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
