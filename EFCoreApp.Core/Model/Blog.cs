namespace EFCoreApp.Core.Model
{
    public class Blog
    {
        public string Url { get; set; }
        public int Rating { get; set; }
        public List<Post> Posts { get; set; }
    }
}
