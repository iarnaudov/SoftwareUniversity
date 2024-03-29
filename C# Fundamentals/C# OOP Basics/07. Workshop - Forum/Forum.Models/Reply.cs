﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Models
{
    public class Reply
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public int AuthorId { get; set; }

        public int PostId { get; set; }

        public Reply(int id, string content, int authorId, int post)
        {
            this.Id = id;
            this.Content = content;
            this.AuthorId = authorId;
            this.PostId = post;
        }
    }
}
