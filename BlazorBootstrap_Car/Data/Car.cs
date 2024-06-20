using System.ComponentModel.DataAnnotations;

namespace BlazorBootstrap_Car.Data
{
    public class Car
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(0, Int32.MaxValue, ErrorMessage = "The min quantity is 0!")]
        public int Quantity { get; set; }
        [Required]
        [Range(1, Int32.MaxValue, ErrorMessage = "The min price is 1!")]

        public float Price { get; set; }
        [Required]
        [Range(1, Int32.MaxValue, ErrorMessage = "Please select a brand!")]
        public int BrandId { get; set; }
        public string Image { get; set; }
        [Required]
        [Range(0, 1)]
        public int IsDeleted { get; set; }

        public Car()
        {

        }

        public Car(int Id, string Name, int Quantity, float Price, int BrandId, string Image, int IsDeleted)
        {
            this.Id = Id;
            this.Name = Name;
            this.Quantity = Quantity;
            this.Price = Price;
            this.BrandId = BrandId;
            this.Image = Image;
            this.IsDeleted = IsDeleted;
        }
    }
}
