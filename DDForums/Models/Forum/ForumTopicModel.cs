using DDForums.Models.Posts;
using System.Collections;
using System.Collections.Generic;

namespace DDForums.Models.Forum
{
    public class ForumTopicModel
    {
        public ForumListingModel Forum { get; set; }
        public IEnumerable <PostListingModel> Posts { get; set; }

    }
}
