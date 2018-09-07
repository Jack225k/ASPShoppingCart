
namespace OnlineShopping.Models
{
    public partial class Product
    {

        public int ID { get; set; }

        public string Name { get; set; }


        public string Description { get; set; }
        public decimal Price { get; set; }
        //navigational properties
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }


    }
}