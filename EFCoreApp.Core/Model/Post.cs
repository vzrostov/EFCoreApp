namespace EFCoreApp.Core.Model
{
    public class Post
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public Blog Blog { get; set; }
    }
}
