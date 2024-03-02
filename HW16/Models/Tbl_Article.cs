namespace HW16.Models
{
    public class Tbl_Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublicationDate { get; set; }
        public int CategoryId { get; set; }
        public Tbl_Category Category { get; set; }
        public int UserID { get; set; }
        public Tbl_User User { get; set; }
        public bool IsPublished { get; set; }
        public byte[] image { get; set; }
        public int WorkflowId { get; set; }
        public Tbl_Workeflow Workeflow { get; set; }

    }
}
