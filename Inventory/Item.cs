using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreList.Inventory
{
    public class Item
    {
        public bool Checked { get; set; }
        public ItemCategory Category { get; set; }
        public string Name { get; set; }
        public string ChineseName { get; set; }
        public double? Lbs { get; set; }
        public int? Quanlity { get; set; }
    }
}
