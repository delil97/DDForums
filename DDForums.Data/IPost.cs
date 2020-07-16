using DDForums.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DDForums.Data
{
    public interface IPost
    {
        Post GetById(int id);
        IEnumerable<Post> GetAll();
        //GetFilteredPosts method
        IEnumerable<Post> GetFilteredPosts(string searchQuery); // use to return result from some searchquery
        IEnumerable<Post> GetPostsByForum(int id); // to pass an id for a forum in our controller 

        //CRUD, we create task in order to support the forum with crud and other 
        Task Add(Post post);
        Task Delete(int id);
        Task EditPostContent(int id, string newContent);
        //Task AddReply(PostReply reply); future assignent?



    }
}
