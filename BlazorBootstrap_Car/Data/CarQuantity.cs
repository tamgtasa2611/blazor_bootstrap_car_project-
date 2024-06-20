using System.ComponentModel.DataAnnotations;

namespace BlazorBootstrap_Car.Data
{
    public class CarQuantity
    {
 
        public string Name { get; set; }
        public int Quantity { get; set; }
      

        public CarQuantity()
        {

        }

        public CarQuantity(string Name, int Quantity)
        { 
            this.Name = Name;
            this.Quantity = Quantity;
        }
    }
}
