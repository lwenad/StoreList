using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreList.Inventory.Factory
{
    public class FruitFactory : ItemFactory
    {
        public override List<Item> Create()
        {
            List<Item> result = new List<Item>();
            result.Add(new Item { Checked = false, Category = ItemCategory.Fruit, Name = "Yellow draonfruit", ChineseName = "黄火龙果", Lbs = 0, Quanlity = 0 });
            result.Add(new Item { Checked = false, Category = ItemCategory.Fruit, Name = "Strawberry", ChineseName = "草莓", Lbs = 0, Quanlity = 0 });
            return result;
        }
    }
}
