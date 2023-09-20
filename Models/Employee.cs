namespace WebApplication6.Models
{
    public class Employee
    {
        public int Emp_ID { get; set; }
        public string Email_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Emp_Role { get; set; }
        public string Emp_pwd { get; set; }
        public string Location_name { get; set; }

        // Navigation property to represent the relationship
        public Timezone Location { get; set; }
    }

}
