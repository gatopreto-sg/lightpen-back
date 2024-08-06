namespace Lightpen.Api
{
    public class Note
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public bool Starred { get; set; } = false;
        public bool Trashed { get; set; } = false;
    }
}
