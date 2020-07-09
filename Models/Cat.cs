using System;
using System.ComponentModel.DataAnnotations;

namespace catapi.Models
{
    public class Cat
    {
        public string Id { get; set; }

        [Required]
        [MaxLength(14)]
        [MinLength(2)]
        public string Name { get; set; }
        [Range(0, int.MaxValue)]
        public int Age { get; set; }
        [Range(0, 9)]
        public int Lives { get; set; }


        public Cat(string name, int age, int lives)
        {
            Name = name;
            Age = age;
            Lives = lives;
            Id = Guid.NewGuid().ToString();
        }
        public Cat()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}