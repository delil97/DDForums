﻿using DDForums.Models.Reply;
using System;
using System.Collections.Generic;

namespace DDForums.Models.Posts
{
    public class PostIndexModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorId { get; set; }
        public string AuthorName { get; set; } 
        public string AuthorImageUrl { get; set; } 
        public int AuthorRating { get; set; } 
        public DateTime Created { get; set; } 
        public string PostContent { get; set; } 

        public IEnumerable <PostReplyModel> Replies { get; set; }

    }
}
