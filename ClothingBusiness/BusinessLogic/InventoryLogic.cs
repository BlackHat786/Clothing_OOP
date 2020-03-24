using ClothingBusiness.Interfaces;
using ClothingBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingBusiness.BusinessLogic
{
    public class InventoryLogic : iInventory
    {
        Inventory inventory = new Inventory();
        enum size
        {
            small,
            medium,
            large
        }

        enum Type_of_Clothing
        {
            Jeans,
            TShirt,
            Dress,
            Shirt,
            Underwear
        }

        private double[] DefaultPrice = { 150,75,100,95,35};
        public string sizes = "";
        public string ClothesSize()
        {
            Console.Write("Pick a Size: S, M, L\n" +
                "Choose a size: ");
            inventory.ClothesSize = Console.ReadLine().ToUpper();
            if (inventory.ClothesSize.Contains("S"))
            {
                Console.WriteLine(size.small);
            }
            else if (inventory.ClothesSize.Contains("M"))
            {
                Console.WriteLine(size.medium);
            }
            else if(inventory.ClothesSize.Contains("L"))
            {
                Console.WriteLine(size.large);
            }
            else
            {
                Console.WriteLine("Choose the correct Letter ");
                ClothesSize();
            }
            sizes = inventory.ClothesSize;
            return sizes;
           
        }
         public string Choice = "";
        public string TypeClothes()
        {

            inventory.TypeOfClothes = new List<string>();
            Console.WriteLine("Pick an item:");
            Console.WriteLine("===================");
            inventory.TypeOfClothes.Add(Type_of_Clothing.Jeans+"");
            inventory.TypeOfClothes.Add(Type_of_Clothing.TShirt+"");
            inventory.TypeOfClothes.Add(""+Type_of_Clothing.Dress);
            inventory.TypeOfClothes.Add(""+Type_of_Clothing.Shirt);
            inventory.TypeOfClothes.Add(""+Type_of_Clothing.Underwear);
           // await Task.Delay(1);
            foreach (var item in inventory.TypeOfClothes)
            {
                Console.Write(item + "\n");
                Console.WriteLine("____________");
            }
            Console.Write("Choose a type of Clothing: ");
            Choice = Console.ReadLine().ToUpper();
            Console.WriteLine("____________");

            return Choice;
        }
        public int _quantity = 0;

        public int ClothesQuantity()
        {
            Console.Write("Enter quantity: ");
            inventory.quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("____________");
            _quantity = inventory.quantity;
            return _quantity;
        }

        public double Cost()
        {
            inventory.SumTotalPrice = 15;
            return inventory.SumTotalPrice;
        }

        public int IdCode()
        {
            Random rand = new Random();
            inventory.StockId = rand.Next(600000, 699999);            
            return inventory.StockId;
        }
        private Branding _Branding = new Branding();
        public double sum = 0.0;
        public double TypeCosting()
        {
            TypeClothes();
            try
            {                
                if (Choice.Contains("JEANS"))
                {
                    inventory.SumTotalPrice = (DefaultPrice[0]* ClothesQuantity())+(DefaultPrice[0] * _Branding.BrandPercentage());
                }
                else if (Choice.Contains("TSHIRT"))
                {
                    inventory.SumTotalPrice = (DefaultPrice[1] * ClothesQuantity()) + (DefaultPrice[1] * _Branding.BrandPercentage());
                }
                else if (Choice.Contains("DRESS"))
                {
                    inventory.SumTotalPrice = (DefaultPrice[2] * ClothesQuantity()) + (DefaultPrice[2] * _Branding.BrandPercentage());
                }
                else if (Choice.Contains("SHIRT"))
                {
                    inventory.SumTotalPrice = (DefaultPrice[3] * ClothesQuantity()) + (DefaultPrice[3] * _Branding.BrandPercentage());
                }
                else if (Choice.Contains("UNDERWEAR"))
                {
                    inventory.SumTotalPrice = (DefaultPrice[4] * ClothesQuantity()) + (DefaultPrice[4] * _Branding.BrandPercentage());
                }

                else
                {
                    TypeClothes();
                }

                
            }
            catch (Exception )
            {
                Console.WriteLine("System Failed to compulate price for: "+Choice);
            }
            sum = inventory.SumTotalPrice;
            return sum;
        }
    }
}
