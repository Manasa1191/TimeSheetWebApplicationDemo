namespace WebApplication6.Models
{
    public class L1task
    {
        public int L1_Id { get; set; }
        public int Projectid { get; set; }
        public string L1_Taskname { get; set; }
        public decimal L1_hours { get; set; }
        public bool L1_Task_Status { get; set; }

        // Navigation property to represent the relationship
        public Project Project { get; set; }
    }

}
