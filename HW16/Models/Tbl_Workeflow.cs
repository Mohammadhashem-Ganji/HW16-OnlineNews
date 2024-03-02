namespace HW16.Models
{
    public class Tbl_Workeflow
    {
        public int Id { get; set; }
        public List<Tbl_Article> Articles { get; set; }
        public Tbl_User AdminId { get; set; }
        public Tbl_Status Status { get; set; }
        public string? Comment { get; set; }
    }
}
