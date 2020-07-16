﻿using DDForums.Data;
using DDForums.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDForums.Service
{
    public class PostService : IPost
    {
        private readonly ApplicationDbContext _context; // pass to contructure

        public PostService(ApplicationDbContext context) // contructure
        {
            _context = context; 

        }

        public Task Add(Post post)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditPostContent(int id, string newContent)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAll()
        {
            throw new NotImplementedException();
        }

        public Post GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetFilteredPosts(string searchQuery)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetPostsByForum(int id)
        {
            return  _context.Forums
                .Where(forum => forum.Id == id).First()
                .Posts;
        }
    }
}
