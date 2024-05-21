using System.Text;

namespace MyStringBuilder.Entities
{
    public class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        public List<Comment> comments { get; set; } = new List<Comment>();

        public Post()
        {
        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            return sb.Build()
        }
    }
}