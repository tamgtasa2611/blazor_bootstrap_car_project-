using System.ComponentModel.DataAnnotations;

namespace BlazorBootstrap_Car.Data
{
    public class BrandQuantity
    {
 
        public string Name { get; set; }
        public int Quantity { get; set; }
      

        public BrandQuantity()
        {

        }

        public BrandQuantity(string Name, int Quantity)
        { 
            this.Name = Name;
            this.Quantity = Quantity;
        }
    }
}
