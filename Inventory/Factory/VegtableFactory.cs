using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreList.Inventory.Factory
{
    public class VegtableFactory : ItemFactory
    {
        public override List<Item> Create()
        {
            List<Item> result = new List<Item>();
            result.Add(new Item { Checked = false, Category = ItemCategory.Vegetable, Name = "Chinse brocoli", ChineseName = "油菜", Lbs = 0, Quanlity = 0 });
            result.Add(new Item { Checked = false, Category = ItemCategory.Vegetable, Name = "Garlic", ChineseName = "大蒜", Lbs = 0, Quanlity = 0 });
            result.Add(new Item { Checked = false, Category = ItemCategory.Vegetable, Name = "Bean sprout", ChineseName = "绿豆芽", Lbs = 0, Quanlity = 0 });
            result.Add(new Item { Checked = false, Category = ItemCategory.Vegetable, Name = "Ginger", ChineseName = "姜", Lbs = 0, Quanlity = 0 });
            result.Add(new Item { Checked = false, Category = ItemCategory.Vegetable, Name = "Green onion", ChineseName = "葱", Lbs = 0, Quanlity = 0 });
            result.Add(new Item { Checked = false, Category = ItemCategory.Vegetable, Name = "Snow Pea", ChineseName = "雪豆", Lbs = 0, Quanlity = 0 });
            result.Add(new Item { Checked = false, Category = ItemCategory.Vegetable, Name = "Chinese chives", ChineseName = "韭菜", Lbs = 0, Quanlity = 0 });
            result.Add(new Item { Checked = false, Category = ItemCategory.Vegetable, Name = "Bok choy", ChineseName = "上海菜", Lbs = 0, Quanlity = 0 });
            result.Add(new Item { Checked = false, Category = ItemCategory.Vegetable, Name = "Green Pepper", ChineseName = "青椒", Lbs = 0, Quanlity = 0 });

            return result;
        }
    }
}
