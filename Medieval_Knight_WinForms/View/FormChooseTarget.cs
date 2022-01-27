using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Medieval_Knight_WinForms.Model;
namespace Medieval_Knight_WinForms.View
{
    public partial class FormChooseTarget : Form
    {
        private BindingSource _bindingSourceNames;
        public FormChooseTarget()
        {
            InitializeComponent();
            _bindingSourceNames = new BindingSource();
        }

        private void FormChooseTarget_Load(object sender, EventArgs e)
        {
            _bindingSourceNames.DataSource = GameContoller.CombatantNamesList;
            comboBox_Names.DataSource = _bindingSourceNames;
        }

        private void Bt_CastJewelSkillOnTarget_Click(object sender, EventArgs e)//кнопка каста
        {
            //игрок использует способность бижутерии на выбраного в выпадающем списке врага
            GameContoller.CastSkill(GameContoller.Player.Name, (comboBox_Names.SelectedItem ?? string.Empty).ToString());
            Close();
        }

        private void Bt_AttackTarget_Click(object sender, EventArgs e)//кнопка атаки
        {
            //игрок атакует выбраного в выпадающем списке врага
            GameContoller.Attack(GameContoller.Player.Name, (comboBox_Names.SelectedItem ?? string.Empty).ToString());
            Close();
        }
    }
}
