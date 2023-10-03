using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Entities
{
    internal class Post
    {
        public DateTime moment { get; set; }
        public string title { get; set; }
        public string cotent { get; set; }
        public int likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post() { }

        public Post(DateTime moment, string title, string cotent, int likes)
        {
            this.moment = moment;
            this.title = title;
            this.cotent = cotent;
            this.likes = likes;
        }

        public void AddComment(Comment comments)
        {
            Comments.Add(comments);
        }
        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(title);
            sb.AppendLine(likes + " - " + moment);
            sb.AppendLine(cotent);
            sb.AppendLine("Comments:");
            foreach (Comment item in Comments)
            {
                sb.AppendLine(item.text);
            }
            return sb.ToString();
        }
    }
}
