namespace WebApplication6.Models
{
    public class L2task
    {
        public int L2_Id { get; set; }
        public int L1_Id { get; set; }
        public string L2_Taskname { get; set; }
        public decimal L2_hours { get; set; }
        public bool L2_Task_Status { get; set; }
        public string L2_category { get; set; }

        // Navigation property to represent the relationship
        public L1task L1task { get; set; }
    }

}
