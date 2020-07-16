using System;
using System.Collections.Generic;

namespace DDForums.Data.Models
{
    public class Forum
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string Descprition { get; set; }
        public DateTime Created { get; set; }
        public string ImageUrl { get; set; }

        public virtual IEnumerable<Post> Posts { get; set; }

    }
}
