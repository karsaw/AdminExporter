using System;
using System.IO;
namespace AdminExporter.utils
{
    public class WriteToFile
    {
        public void write(string fileName,string data,string type)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string file = Path.Combine(path, fileName);
            Headers headers = new Headers();
            if (File.Exists(file))
            {
                
                File.AppendAllText(file,data);
            }
            else
            {
                data = headers.getHeaders(type) + data;
                File.WriteAllText(file, data);
            }
        }
    }
}
