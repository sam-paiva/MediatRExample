﻿namespace MediatRExample.API.Models
{
    public class Post
    {
        public Post(string title, string content)
        {
            Id = Guid.NewGuid();
            Title = title;
            Content = content;
        }

        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public string Content { get; private set; }
    }
}
