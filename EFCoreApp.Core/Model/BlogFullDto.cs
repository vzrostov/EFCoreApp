namespace EFCoreApp.Core.Model
{
    public class BlogFullDto
    {
        public string Url { get; set; }
        public int Rating { get; set; }
        public List<PostFullDto> Posts { get; set; }
    }
}
