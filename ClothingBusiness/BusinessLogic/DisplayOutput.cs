using ClothingBusiness.Interfaces;
using ClothingBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingBusiness.BusinessLogic
{
    public class DisplayOutput: iDisplay
    {
        private InventoryLogic _inventory = new InventoryLogic();
        private Branding _Branding = new Branding();
        private Inventory _in = new Inventory();

        public  void RunProgram()
        {
            _inventory.ClothesSize();
            _inventory.TypeCosting();

        }

        public void DisplayRecipt()
        {
           
            Console.WriteLine("Summary");
            Console.WriteLine($"Stock Code: "+_inventory.IdCode() +"\n"+
                $"Clothing Choice: "+_inventory.Choice+"\n" +
                $"Size: "+_inventory.sizes+"\n"                
                +$"Quantity: "+_inventory._quantity+"\n"
                +$"Cost: R"+_inventory.sum);
        }
    }
}
