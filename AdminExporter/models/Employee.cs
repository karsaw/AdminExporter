using System;
using AdminExporter.utils;
using AdminExporter.@interface;
namespace AdminExporter.models
{
    public class Employee : ExportFile
    {
        public void export()
        {
            Randomizer randomizer = new Randomizer();
            WriteToFile writeToFile = new WriteToFile();
            writeToFile.write("employee.csv", randomizer.getData("Employee"),"employee");
            
        }
    }
}
