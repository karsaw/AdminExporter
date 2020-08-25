using System;
namespace AdminExporter.datatypes
{
    public class CustomerEntity
    {
       
        
        public CustomerEntity() { }
        public CustomerEntity(string firstName,string lastName,long phone,string address) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
            this.Address = address;
            this.Id = DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Phone { get; set; }
        public string Id { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"{FirstName},{LastName},{Phone},\"{Id}\",\"{Address}\"";
        }
    }
}
