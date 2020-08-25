using System;
using AdminExporter.models;
using AdminExporter.@interface;
namespace AdminExporter.factory
{
    public class ExportFactory
    {
        public ExportFile exportToFile(String type)
        {
            if (type.Equals("Customer"))
            {
                return new Customer();

            }else if (type.Equals("Employee"))
            {
                return new Employee();
            }
            return null;
        }
    }
}
