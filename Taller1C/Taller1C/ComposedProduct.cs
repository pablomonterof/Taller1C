using System.Text;

namespace Taller1C
{
    public class ComposedProduct : Product
    {


        public float Discount { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();

        decimal value = 0;
        string names = string.Empty;


        public override decimal ValueToPay()
        {
            foreach (Product product in Products)
            {

                value += product.ValueToPay();

            }
            return value - value * (decimal)Discount;

        }


        public override string ToString()
        {
            foreach (Product product in Products)
            {

                names += product.Description + ",";
            }

            return $"   {Id} {Description} " +
                $"\n\tProducts:  {$"{names}"} " +
                $"\n\tDiscount:      {$"{Discount:P2}",10}" +
                $"\n\tValue......:   {$"{ValueToPay():C2}",10}";
        }
    }
}
