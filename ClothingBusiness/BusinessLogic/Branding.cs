using ClothingBusiness.Interfaces;
using ClothingBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingBusiness.BusinessLogic
{
   public class Branding: iBranding
    {
        public static Dictionary<int, string> BrandName()
        {
            var names = new Dictionary<int, string>
            {
                {1,"Nike" },
                {2,"Puma" },
                {3,"Adidas"}
            };
            return names;
        }
       
        private Inventory _inventory = new Inventory();
        public string _companyName = "";
        public string pName = "";
        public string BrandChoice()
        {
            foreach (var item in BrandName())
            {
                Console.WriteLine("Code: {0} Company: {1}",item.Key.ToString(), item.Value);
            }
            Console.WriteLine($"Choose a Clothing Brand Code: ");
            _inventory.CompanyName = Console.ReadLine();          
            _companyName = _inventory.CompanyName;
            return _companyName;
          
        }
        
        public double _Cost ;
        public double BrandPercentage()
        {
            BrandChoice();

            if (_companyName.Contains("1")) {_inventory.CompanyName="Nike"; return _inventory.CompanyCost = 0.4; }

            else if (_companyName.Contains("2")) { _companyName = "Puma"; return _inventory.CompanyCost = 0.55; }

            else if (_companyName.Contains("3")) { _companyName = "Adidas"; return _inventory.CompanyCost = 0.6; }

            return _inventory.CompanyCost;
        }
    }
}
