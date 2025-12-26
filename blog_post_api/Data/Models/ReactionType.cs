namespace blog_post_api.Data.Models
{
    public enum ReactionType
    {
        Like =  1,
        Dislike  =  -1
    }
    public class BlogReaction
    {
        public int Id { get; set; }
        public ReactionType reactionType { get; set; }
        public Users Users { get; set; }
        public int BlogsId { get; set; }
        public Blogs Blogs { get; set; }

    }

    public class CommentReaction
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public Users users { get; set; }

        public int CommentId { get; set; }
        public Comments comments { get; set; }

        public ReactionType Reaction { get; set; }
    }

}
