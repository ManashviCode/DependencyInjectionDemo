﻿using DependencyInjectionDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.Shared
{
    public interface IBlogService
    {
        public List<Post> GetAllPosts();
        public Post GetPost(int id);
    }
}
