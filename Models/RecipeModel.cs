using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace App.Models
{
    public class RecipeModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string RecipeId { get; set; }
        public string Title { get; set; }
        public bool IsPublic { get; set; }
        public string Excerpt { get; set; }
        public string CoverImagePath { get; set; }
        public string Content { get; set; }
        public string Ingredients { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Updated { get; set; } = DateTime.Now;
        public bool Deleted { get; set; } = false;
    }
}