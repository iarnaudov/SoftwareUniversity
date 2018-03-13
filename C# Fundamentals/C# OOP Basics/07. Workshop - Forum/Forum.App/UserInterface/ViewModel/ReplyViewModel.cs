using Forum.App.Services;
using Forum.Models;
using System.Collections.Generic;
using System.Linq;

namespace Forum.App.UserInterface.ViewModel
{
    public class ReplyViewModel
    {
        private const int LINE_HEIGHT = 37;

        public string Author { get; set; }

        public IList<string> Content { get; set; }

        private IList<string> GetLines(string content)
        {
            char[] contentChars = content.ToCharArray();
            IList<string> lines = new List<string>();

            for (int i = 0; i < content.Length; i += LINE_HEIGHT)
            {
                char[] row = contentChars.Skip(i).Take(LINE_HEIGHT).ToArray();
                string rowString = string.Join("", row);
                lines.Add(rowString);
            }

            return lines;
        }

        public ReplyViewModel()
        {

        }

        public ReplyViewModel(Reply reply)
        {
            this.Author = UserService.GetUser(reply.AuthorId).Username;
            this.Content = GetLines(reply.Content);
        }
    }
}
