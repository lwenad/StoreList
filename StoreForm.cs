using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreList.Inventory.Factory;
using StoreList.Inventory;
namespace StoreList
{
    public partial class StoreForm : Form
    {

        private ItemFactories _ItemFactory; 

        public StoreForm()
        {
            InitializeComponent();

            List<ItemFactory> itemFactoryList = new List<ItemFactory>();
            itemFactoryList.Add(new VegtableFactory());
            itemFactoryList.Add(new MeatFactory());
            itemFactoryList.Add(new PackageFoodFactory());
            itemFactoryList.Add(new SnackFactory());
            itemFactoryList.Add(new FruitFactory());


            ItemFactories itemFactories = new ItemFactories(itemFactoryList);
        }

        private void StoreForm_Load(object sender, EventArgs e)
        {

            try
            {
                LoadGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           

        }

        public void LoadGrid()
        {

           
           
          
           

            DataGridViewVegetable.DataSource = itemFactories.Create();

            this.DataGridViewVegetable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DataGridViewVegetable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DataGridViewVegetable.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DataGridViewVegetable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DataGridViewVegetable.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
       
        }




        private void ButtonGenerateList_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();

                foreach (DataGridViewRow dr in DataGridViewVegetable.Rows)
                {
                    bool isChecked = Convert.ToBoolean(dr.Cells["Checked"].Value);
                    if (isChecked)
                    {
                        stringBuilder.Append(dr.Cells["ChineseName"].Value);
                        stringBuilder.Append(" ");

                        if(Convert.ToDouble(dr.Cells["Lbs"].Value) > 0 )
                        {
                            stringBuilder.Append(dr.Cells["Lbs"].Value + " 磅");
                            stringBuilder.Append(" ");
                        }
                        if (Convert.ToInt32(dr.Cells["Quanlity"].Value) > 0)
                        {
                            stringBuilder.Append(dr.Cells["Quanlity"].Value + " 个");
                            
                        }
                        stringBuilder.Append("; ");
                    }
                    
                }

                ItemTextBox.Text = stringBuilder.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }
    }
}
