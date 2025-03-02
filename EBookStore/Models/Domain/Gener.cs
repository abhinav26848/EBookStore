using System.ComponentModel.DataAnnotations;

namespace EBookStore.Models.Domain
{
    public class Gener
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
