using System;
namespace AdminExporter.utils
{
    public class Headers
    {
        public string getHeaders(string type)
        {
            if (type.Equals("customer"))
            {
                return "\"First Name\",\"Last Name\",Phone,Id,Address\n";
            }else if (type.Equals("Employee"))
            {
                return "\"First Name\",\"Last Name\",Phone,Id,Division\n";
            }
            return "";
        }
    }
}
