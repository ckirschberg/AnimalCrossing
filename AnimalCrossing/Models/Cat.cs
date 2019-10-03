using System;
using System.ComponentModel.DataAnnotations;

namespace AnimalCrossing.Models
{
    public class Cat
    {
        // C# properties = java attribute and public get and set.
        //private int JavaCatId;

        //public int getJavaCatId()
        //{
        //    return this.JavaCatId;
        //}
        //public void setJavaCatId(int catId)
        //{
        //    this.JavaCatId = catId;
        //}


        // If the name is *class_name*Id
        public int CatId { get; set; }

        
        [Required(ErrorMessage = "All cats must have a name to be a pet")]
        public string Name { get; set; }

        // Later, create 1-to-many relationship to Species table
        //public string Species { get; set; }

        public Gender? Gender { get; set; }

        [Display(Name="Birth Date")]
        public DateTime? BirthDate { get; set; }

        public string ProfilePicture { get; set; }
        public string Description { get; set; }

        // Ratings..Comments, Reviews
        // 
        
        public Cat()
        {
        }


    }

    public enum Gender { Male, Female, Other };
}
