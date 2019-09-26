using System;
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



        public int CatId { get; set; }
        public string Name { get; set; }

        // Later, create 1-to-many relationship to Species table
        //public string Species { get; set; }

        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }

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
