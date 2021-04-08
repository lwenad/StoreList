using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreList.Inventory.Factory
{
    public class SnackFactory : ItemFactory
    {
        public override List<Item> Create()
        {
            List<Item> result = new List<Item>();
            result.Add(new Item { Checked = false, Category = ItemCategory.Snack, Name = "spicy peanuts with dried shrimps", ChineseName = "黄飞红小虾麻辣花生", Lbs = 0, Quanlity = 0 });
           

            return result;
        }

    }
}
