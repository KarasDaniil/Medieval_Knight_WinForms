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

            //подписка на делегаты, чтобы вовремя обновлять UI
            GameContoller.Player.EquipmentChange += UpdateInfo;
            GameContoller.Player.JewelSkillCasted += UpdateInfo;
            GameContoller.Player.Died += UpdateInfo;
            GameContoller.Player.AttackComplete += UpdateInfo;
        }

        private void UpdateInfo()
        {
            //метод задавание/обновления таблиц (внутри проверка чтобы "создать" только один раз)
            DGV_Hero.SetStatTable(_bindingSource, GameContoller.CombatantStatList, GameContoller.CombatantNamesList);
        }

        private void Bt_OpenInventory_Click(object sender, EventArgs e)//открывает окно инвентаря
        {
            _formInventory = new FormInventory();
            _formInventory.ShowDialog();
        }

        private void Bt_OpenShop_Click(object sender, EventArgs e)//открывает окно магазина
        {
            _formShop = new FormShop();
            _formShop.ShowDialog();
        }

        private void FormMainView_Load(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        private void Bt_CastJewelSkill_Click(object sender, EventArgs e)//self cast button click, чтобы использовать способность бижутерии на себя (хилл)
        {
            GameContoller.CastSkill(GameContoller.Player.Name, GameContoller.Player.Name);
        }

        private void Bt_CombatAction_Click(object sender, EventArgs e)//вызывает окно выбора цели и действия
        {
            _formChooseTarget = new FormChooseTarget();
            _formChooseTarget.ShowDialog();
        }

        private void Bt_AddEnemy_Click(object sender, EventArgs e)
        {
            //Имя врага - текущее время, чтобы упросить отладку(не создавать механизмы задание имени вручную)
            GameContoller.CreateEnemy(DateTime.Now.ToLongTimeString(), 2, UpdateInfo);         
            UpdateInfo();
        }
    }
}
