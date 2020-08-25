using System;
namespace AdminExporter.utils
{
    public class RandomValues
    {
        Random random = new Random();
        public string getFirstName() {
            string[] firstnames = new string[] { "john", "newton", "thomsan", "linda", "charlie", "alan", "monica", "raj", "simran", "nicole", "jack", "tom" };
            
            int selector = random.Next(firstnames.Length);
            return firstnames[selector];
        }
        public string getLastName() {
            string[] lastname = new string[] {"doe","mile","book","harper","lake","daniel","tesla","snow","sharma","hanks" };
           
            int selector = random.Next(lastname.Length);
            return lastname[selector];
        }
        public long getPhone() {
            long number = 9876500000;
            
            int selector = random.Next(10000);
            number = number + selector;
            return number;

        }
        public string getDivision() {
            string[] division = new string[] { "rnd", "analytics", "saas", "operations", "cloud" };
            
            int selector = random.Next(division.Length);
            return division[selector];
        }
        public string getAddress() {
            string[] state = new string[] { "KA", "AP", "NYC", "PB", "SJ", "AB" };
            string[] country = new string[] { "IND","US","UK","SGP","AUS"};
            int stateSelector = random.Next(state.Length);
            int countrySelector = random.Next(country.Length);
            string address = "#" + random.Next(1000) + ", some area," + state[stateSelector] + ", " + country[countrySelector];
            return address;
           
        }
    }
}
