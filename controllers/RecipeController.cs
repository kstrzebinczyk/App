using System.Linq;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using App.Models;
namespace App.Controllers
{
    public class RecipeController : Controller{
        
        [Route("/{recipeTitle}")]
        public IActionResult Index([FromRoute] string recipeTitle){
            List<App.Models.RecipeModel> recipes = new List<App.Models.RecipeModel>();

            using(var db = new App.Models.AppDbContext())
            {
                recipes = db.Recipes.ToList();
            }
            return View(
                recipes.AsQueryable().FirstOrDefault(r => r.Title ==recipeTitle.Replace("-", " "))
            );
        }
    }
}