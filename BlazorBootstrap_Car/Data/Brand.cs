using System.ComponentModel.DataAnnotations;

namespace BlazorBootstrap_Car.Data
{
    public class Brand
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(0, 1)]
        public int IsDeleted { get; set; }

        public Brand()
        {

        }

        public Brand(int Id, string Name, int IsDeleted)
        {
            this.Id = Id;
            this.Name = Name;
            this.IsDeleted = IsDeleted;
        }
    }
}
