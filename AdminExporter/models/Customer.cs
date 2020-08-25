using System;
using AdminExporter.utils;
using AdminExporter.@interface;

namespace AdminExporter.models
{
    public class Customer : ExportFile
    {
        public void export()
        {
            Randomizer randomizer = new Randomizer();
            
            WriteToFile writeToFile = new WriteToFile();
            writeToFile.write("customer.csv",randomizer.getData("Customer"),"customer");
        }
    }
}
