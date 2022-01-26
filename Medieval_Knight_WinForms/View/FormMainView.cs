using Medieval_Knight_WinForms.Model;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Medieval_Knight_WinForms.View
{
    public partial class FormMainView : Form
    {
        private FormInventory _formInventory;
        private FormShop _formShop;
        private FormChooseTarget _formChooseTarget;
        private readonly BindingSource _bindingSource;

        public FormMainView()
        {
            InitializeComponent();

            _bindingSource = new BindingSource();

            GameContoller.Player.EquipmentChange += UpdateInfo;
            GameContoller.Player.JewelSkillCasted += UpdateInfo;
            GameContoller.Player.Died += UpdateInfo;
            GameContoller.Player.AttackComplete += UpdateInfo;
        }

        private void UpdateInfo()
        {
            DGV_Hero.SetStatTable(_bindingSource, GameContoller.CombatantStatList, GameContoller.CombatantNamesList);
        }

        private void Bt_OpenInventory_Click(object sender, EventArgs e)
        {
            _formInventory = new FormInventory();
            _formInventory.ShowDialog();
        }

        private void Bt_OpenShop_Click(object sender, EventArgs e)
        {
            _formShop = new FormShop();
            _formShop.ShowDialog();
        }

        private void FormMainView_Load(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        private void Bt_CastJewelSkill_Click(object sender, EventArgs e)//self cast button click
        {
            GameContoller.CastSkill(GameContoller.Player.Name, GameContoller.Player.Name);
        }

        private void Bt_CombatAction_Click(object sender, EventArgs e)
        {
            _formChooseTarget = new FormChooseTarget();
            _formChooseTarget.ShowDialog();
        }

        private void Bt_AddEnemy_Click(object sender, EventArgs e)
        {
            GameContoller.CreateEnemy(DateTime.Now.ToLongTimeString(), UpdateInfo);         
            UpdateInfo();
        }
    }
}
