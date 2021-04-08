using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreList.Inventory.Factory
{
    public class MeatFactory : ItemFactory
    {
        public override List<Item> Create()
        {
            List<Item> VegetableList = new List<Item>();

            return VegetableList;
        }
    }
}
