using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
         {  
            CustomsFee = customsFee;
           
        }

        public override string priceTag()
        {   
           StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name} $ {Price+CustomsFee} (customs fee $  { CustomsFee})");
            return sb.ToString();
        }


    }
}
