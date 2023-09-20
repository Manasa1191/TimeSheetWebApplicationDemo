namespace WebApplication6.Models
{
    using System;

    public class Timesheet
    {
        public int Projectid { get; set; }
        public int L2_Id { get; set; }
        public string Loc_name { get; set; }
        public int L1_Id { get; set; }
        public int Emp_ID { get; set; }
        public decimal Total_hours { get; set; }
        public string Describes { get; set; }
        public DateTime Selected_date { get; set; }

        // Navigation properties to represent the relationships
        public Project Project { get; set; }
        public L2task L2task { get; set; }
        public L1task L1task { get; set; }
        public Employee Employee { get; set; }
    }

}
