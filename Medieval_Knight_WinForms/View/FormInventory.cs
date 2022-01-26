using Medieval_Knight_WinForms.Model;
using System;
using System.Windows.Forms;
namespace Medieval_Knight_WinForms.View
{
    public partial class FormInventory : Form
    {
        private readonly BindingSource _bindingSource;
        public FormInventory()
        {
            InitializeComponent();
            _bindingSource = new BindingSource();
        }

        private void DGV_Inventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                if (!(bool)DGV_Inventory.Rows[e.RowIndex].Cells[0].Value)
                    GameContoller.Player.EquipItem(e.RowIndex);
                else
                    GameContoller.Player.UnequipItem(e.RowIndex);
            }
        }

        private void FormInventory_Load(object sender, EventArgs e)
        {
            DGV_Inventory.SetItemTable(_bindingSource, GameContoller.Player.Inventory.ItemsList);
        }

        private void DGV_Inventory_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
