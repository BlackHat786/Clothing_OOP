using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingBusiness.Models
{
   public class Inventory
    {
        public int StockId { get; set; }
        public string CompanyName { get; set; }
        public List<string> TypeOfClothes { get; set; }
        public string ClothesSize { get; set; }
        public double CompanyCost { get; set; }
        public double SumTotalPrice { get; set; }
        public double vat { get; set; }
        public int quantity { get; set; }
        
        public Inventory() 
        { }   




    }
}
