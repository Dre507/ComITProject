using System;
using System.ComponentModel.DataAnnotations;

namespace ComITProject.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string RecipeName { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }
    }
}