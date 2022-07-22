namespace EFCoreApp.Core.Model
{
    public class PostFullDto
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public BlogFullDto Blog { get; set; }
    }
}
