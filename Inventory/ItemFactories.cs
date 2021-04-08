using StoreList.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreList.Inventory
{
    public class ItemFactories
    {
        private List<ItemFactory> _itemFactories;

        public ItemFactories(List<ItemFactory> itemFactories)
        {
            _itemFactories = itemFactories;
        }


        public List<Item> Create()
        {
            List<Item> result = new List<Item>();

            foreach(var factory in _itemFactories)
            {
                result.Concat(factory.Create());
            }

            return result;
        }

    }
}
