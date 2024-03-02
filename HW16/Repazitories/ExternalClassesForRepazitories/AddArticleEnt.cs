namespace HW16.Repazitories.ExternalClassesForRepazitories
{
    public class AddArticleEnt
    {
        public string title { get; set; }
        public string content { get; set; }
        public int categoryId { get; set; }
        public int userId { get; set; }
        public int workflowId { get; set; }
        public IFormFile image { get; set; }
    }
}
// string title, string content, int categoryId, int userId, int workflowId ,IFormFile image