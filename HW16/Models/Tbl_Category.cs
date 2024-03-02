namespace HW16.Models
{
    public class Tbl_Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Tbl_Article> Articles { get; set; }
    }
}
