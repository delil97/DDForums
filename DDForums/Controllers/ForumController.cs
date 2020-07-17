using DDForums.Data;
using DDForums.Data.Models;
using DDForums.Models.Forum;
using DDForums.Models.Posts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace DDForums.Controllers
{
    public class ForumController : Controller
    {
        private readonly IForum _forumService; // interface
     // we build interface for IPost in our DDForums.Data
        private readonly IPost _postService; // service
        public ForumController(IForum forumService) // pasing in Iforum interface
        {
            _forumService = forumService;
        }
        public IActionResult Index()
        {
            // forumservice, we get all the forums from our db
            var forums = _forumService.GetAll() // a list of forums in the forumlisting model
                .Select(forum => new ForumListingModel { 
                    Id = forum.Id,
                    Name = forum.Tittle,
                    Description = forum.Descprition
                });
            //new instance of forumIndexModel
            var model = new ForumIndexModel // we are passing the whole to Index view model
            {
                ForumList = forums
            };

            return View(model);
        }

        public IActionResult Topic (int id)
         {
            var forum = _forumService.GetById(id);

            var posts = forum.Posts;

            var postListings = posts.Select(post => new PostListingModel
            {
                Id = post.Id,
                AuthorId = post.User.Id,
                AuthorRating = post.User.Rating,
                Title = post.Tittle,
                DatePosted = post.Created.ToString(),
                RepliesCount = post.Replies.Count(),
                Forum = BuildForumListing(post)  
            });

            var model = new ForumTopicModel
            {
                Posts = postListings,
                Forum = BuildForumListing(forum)
            };

            return View(model);
        }

        private ForumListingModel BuildForumListing(Post post)
        {
            var forum = post.Forum;
            return BuildForumListing(forum);
        }

        private ForumListingModel BuildForumListing(Forum forum)
        {
            return new ForumListingModel
            {
                Id = forum.Id,
                Name = forum.Tittle,
                Description = forum.Descprition,
                ImageUrl = forum.ImageUrl
            };
        }
    }
}
