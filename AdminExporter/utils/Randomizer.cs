using System;
using AdminExporter.datatypes;
namespace AdminExporter.utils
{
    public class Randomizer
    {
        RandomValues randomValues = new RandomValues();
        
        private string getRandomCustomers()
        {
            string customers = "";
            for(int i = 0; i < 3; i++)
            {
                customers += new CustomerEntity(randomValues.getFirstName(), randomValues.getLastName(), randomValues.getPhone(), randomValues.getAddress()).ToString() + "\n";
            }

            return customers;
        }
        private string getRandomEmployees()
        {
            string employee = "";
            for (int i = 0; i < 3; i++)
            {
                employee += new EmployeeEntity(randomValues.getFirstName(), randomValues.getLastName(), randomValues.getPhone(), randomValues.getDivision()).ToString() + "\n";
            }

            return employee;
        }

        

        public string getData(String type)
        {
            string data = "";
            if (type.Equals("Customer"))
            {
                data = getRandomCustomers();
            }else if (type.Equals("Employee"))
            {
                data = getRandomEmployees();
            }
            return data;
        }
    }
}
