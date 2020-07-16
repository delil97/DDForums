using System;


namespace DDForums.Data.Models
{
    public class PostReply
    {
        public int Id { get; set; }
        public string Context { get; set; }
        public DateTime Created { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual Post Post { get; set; }


    }
}
