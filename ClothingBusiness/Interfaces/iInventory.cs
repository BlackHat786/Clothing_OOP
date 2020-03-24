using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingBusiness.Interfaces
{
    interface iInventory
    {
        int IdCode();
        double Cost();
        string ClothesSize();
        double TypeCosting();
        string TypeClothes();
    }
}
