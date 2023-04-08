using System.ComponentModel.DataAnnotations;

namespace MyWebApiProject.Models
{
    public class MyEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

