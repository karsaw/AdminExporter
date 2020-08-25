using System;
namespace AdminExporter.datatypes
{
    public class EmployeeEntity
    {
        public EmployeeEntity()
        {
        }
        public EmployeeEntity(string firstName, string lastName, long phone, string division)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
            this.Division = division;
            this.Id = DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Phone { get; set; }
        public string Id { get; set; }
        public string Division { get; set; }

        public override string ToString()
        {
            return $"{FirstName},{LastName},{Phone},\"{Id}\",\"{Division}\"";
        }
    }
}
