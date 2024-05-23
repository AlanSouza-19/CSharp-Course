using System.Text;

namespace MyStringBuilder.Entities
{
    public class Post(DateTime moment, string title, string content, int likes)
    {
        public DateTime Moment { get; set; } = moment;
        public string Title { get; set; } = title;
        public string Content { get; set; } = content;
        public int Likes { get; set; } = likes;

        public List<Comment> comments { get; set; } = new List<Comment>();

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
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");
            foreach (Comment c in comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}