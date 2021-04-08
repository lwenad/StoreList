using StoreList.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreList.Inventory
{
    public abstract class ItemFactory
    {
        public abstract List<Item> Create();
    }
}
