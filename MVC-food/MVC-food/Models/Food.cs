using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_food.Models
{
    public class Food
    {
        [Key]
        public int FoodID { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Description ="Food Description ")]
        [StringLength(30,ErrorMessage ="error exceso de caracteres",MinimumLength =5)]
        public string Description { get; set; }
    }
}