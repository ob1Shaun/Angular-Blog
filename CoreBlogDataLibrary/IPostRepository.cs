﻿using System.Collections.Generic;

namespace CoreBlogDataLibrary
{
    public interface IPostRepository
    {
        Post AddPost(Post newPost);
        void DeletePost(Post postToDelete);
        Post GetById(int id);
        Post GetByPermalink(string permalink);
        //List<Post> List();
        List<Post> ListAllPosts();
        void UpdatePost(Post updatePost);
    }
}