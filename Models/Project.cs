namespace WebApplication6.Models
{
    using System;

    public class Project
    {
        public int Project_Id { get; set; }
        public string Project_Name { get; set; }
        public int Emp_ID { get; set; }
        public decimal Workhours { get; set; }
        public DateTime Proj_date { get; set; }
        public string Manager_email { get; set; }
        public string SM_email { get; set; }
        public string Project_Category { get; set; }
        public string CEO_email { get; set; }

        // Navigation property to represent the relationship
        public Employee Employee { get; set; }
    }

}
