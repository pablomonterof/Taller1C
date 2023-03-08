using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1C
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }

        public float Quantity { get; set; }


        public override decimal ValueToPay()
        {
            return  (Price * (decimal)Tax + Price ) * (decimal)Quantity;
        }

        public override string ToString()
        {
            return $"   {Id} {Description} " +  
                $"\n\tMeasurement:   {$"{Measurement:C2}",10}" +
                $"\n\tQuantity...:   {$"{Quantity:F2}",10}" +
                $"\n\tPrice......:   {$"{Price:C2}",10}" +
                $"\n\tTax:........   {$"{Tax:P2}",12}" +
                $"\n\tValue......:   {$"{ValueToPay():C2}",10}";
        }
    }
}
