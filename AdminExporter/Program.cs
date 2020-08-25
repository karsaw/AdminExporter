using System;
using AdminExporter.utils;
using AdminExporter.factory;
using AdminExporter.@interface;

namespace AdminExporter
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Options options = new Options();
            int option = options.getOptions();
            bool flag = true;
            ExportFactory exportFactory = new ExportFactory();
            while (flag)
            {
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Exporting Customer Data in customer.csv file");
                        Console.WriteLine("Your file will be avaliable at desktop");
                        ExportFile customerFile = exportFactory.exportToFile("Customer");
                        customerFile.export();
                        if (options.doYouWantToContinue())
                        {
                            option = options.getOptions();
                        }
                        else
                        {
                            Console.WriteLine("Your file will be avaliable at desktop");
                            Console.WriteLine("Bye Bye");
                            flag = false;
                        }

                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Exporting Employee Data in employee.csv file");
                        Console.WriteLine("Your file will be avaliable at desktop");
                        ExportFile  employeeFile = exportFactory.exportToFile("Employee");
                        employeeFile.export();
                        if (options.doYouWantToContinue())
                        {
                            option = options.getOptions();
                        }
                        else
                        {
                            Console.WriteLine("Your file will be avaliable at desktop");
                            Console.WriteLine("Bye Bye");
                            flag = false;
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Bye Bye");
                        flag = false;
                        break;
                }
            }
        }
    }
}
