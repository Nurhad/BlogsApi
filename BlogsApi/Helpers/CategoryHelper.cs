﻿using BlogsApi.Entities;
using BlogsApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogsApi.Helpers
{
    public class CategoryHelper
    {
        public static List<CategoryModel> ConvertCategories(List<Category> categories)
        {
            var categoryModels = categories.ConvertAll(category => new CategoryModel
            {
                Id = category.Id,
                Name = category.Name,
            });

            return categoryModels;
        }
    }
}
