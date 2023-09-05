namespace BlogRealApp.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public String? ShortDescription { get; set; }
        // relation
        public string? ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public String Description { get; set; }
        public String Slug { get; set; } 
    }
}
