
namespace Medieval_Knight_WinForms.View
{
    partial class FormMainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bt_OpenInventory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Hero = new System.Windows.Forms.DataGridView();
            this.Bt_OpenShop = new System.Windows.Forms.Button();
            this.label_Info = new System.Windows.Forms.Label();
            this.Bt_CastJewelSkill = new System.Windows.Forms.Button();
            this.Bt_AddEnemy = new System.Windows.Forms.Button();
            this.Bt_CombatAction = new System.Windows.Forms.Button();
            this.CombatantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Hero)).BeginInit();
            this.SuspendLayout();
            // 
            // Bt_OpenInventory
            // 
            this.Bt_OpenInventory.Location = new System.Drawing.Point(844, 12);
            this.Bt_OpenInventory.Name = "Bt_OpenInventory";
            this.Bt_OpenInventory.Size = new System.Drawing.Size(120, 29);
            this.Bt_OpenInventory.TabIndex = 0;
            this.Bt_OpenInventory.Text = "Open Inventory";
            this.Bt_OpenInventory.UseVisualStyleBackColor = true;
            this.Bt_OpenInventory.Click += new System.EventHandler(this.Bt_OpenInventory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1030, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // DGV_Hero
            // 
            this.DGV_Hero.AllowUserToAddRows = false;
            this.DGV_Hero.AllowUserToDeleteRows = false;
            this.DGV_Hero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Hero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CombatantName});
            this.DGV_Hero.Location = new System.Drawing.Point(2, 32);
            this.DGV_Hero.Name = "DGV_Hero";
            this.DGV_Hero.ReadOnly = true;
            this.DGV_Hero.RowHeadersWidth = 51;
            this.DGV_Hero.RowTemplate.Height = 29;
            this.DGV_Hero.Size = new System.Drawing.Size(786, 418);
            this.DGV_Hero.TabIndex = 4;
            // 
            // Bt_OpenShop
            // 
            this.Bt_OpenShop.Location = new System.Drawing.Point(844, 48);
            this.Bt_OpenShop.Name = "Bt_OpenShop";
            this.Bt_OpenShop.Size = new System.Drawing.Size(120, 29);
            this.Bt_OpenShop.TabIndex = 9;
            this.Bt_OpenShop.Text = "Open Shop";
            this.Bt_OpenShop.UseVisualStyleBackColor = true;
            this.Bt_OpenShop.Click += new System.EventHandler(this.Bt_OpenShop_Click);
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.Location = new System.Drawing.Point(2, 9);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(293, 20);
            this.label_Info.TabIndex = 10;
            this.label_Info.Text = "To see stats details hover mouse over them";
            // 
            // Bt_CastJewelSkill
            // 
            this.Bt_CastJewelSkill.Location = new System.Drawing.Point(844, 212);
            this.Bt_CastJewelSkill.Name = "Bt_CastJewelSkill";
            this.Bt_CastJewelSkill.Size = new System.Drawing.Size(120, 57);
            this.Bt_CastJewelSkill.TabIndex = 11;
            this.Bt_CastJewelSkill.Text = "Self Cast Jewel Skill ";
            this.Bt_CastJewelSkill.UseVisualStyleBackColor = true;
            this.Bt_CastJewelSkill.Click += new System.EventHandler(this.Bt_CastJewelSkill_Click);
            // 
            // Bt_AddEnemy
            // 
            this.Bt_AddEnemy.Location = new System.Drawing.Point(844, 142);
            this.Bt_AddEnemy.Name = "Bt_AddEnemy";
            this.Bt_AddEnemy.Size = new System.Drawing.Size(120, 29);
            this.Bt_AddEnemy.TabIndex = 12;
            this.Bt_AddEnemy.Text = "Add Enemy";
            this.Bt_AddEnemy.UseVisualStyleBackColor = true;
            this.Bt_AddEnemy.Click += new System.EventHandler(this.Bt_AddEnemy_Click);
            // 
            // Bt_CombatAction
            // 
            this.Bt_CombatAction.Location = new System.Drawing.Point(844, 177);
            this.Bt_CombatAction.Name = "Bt_CombatAction";
            this.Bt_CombatAction.Size = new System.Drawing.Size(120, 29);
            this.Bt_CombatAction.TabIndex = 13;
            this.Bt_CombatAction.Text = "Combat Action";
            this.Bt_CombatAction.UseVisualStyleBackColor = true;
            this.Bt_CombatAction.Click += new System.EventHandler(this.Bt_CombatAction_Click);
            // 
            // CombatantName
            // 
            this.CombatantName.HeaderText = "Name";
            this.CombatantName.MinimumWidth = 6;
            this.CombatantName.Name = "CombatantName";
            this.CombatantName.ReadOnly = true;
            this.CombatantName.Width = 125;
            // 
            // FormMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 450);
            this.Controls.Add(this.Bt_CombatAction);
            this.Controls.Add(this.Bt_AddEnemy);
            this.Controls.Add(this.Bt_CastJewelSkill);
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.Bt_OpenShop);
            this.Controls.Add(this.DGV_Hero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bt_OpenInventory);
            this.Name = "FormMainView";
            this.Text = "FormMainView";
            this.Load += new System.EventHandler(this.FormMainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Hero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_OpenInventory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_Hero;
        private System.Windows.Forms.Button Bt_OpenShop;
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.Button Bt_CastJewelSkill;
        private System.Windows.Forms.Button Bt_AddEnemy;
        private System.Windows.Forms.Button Bt_CombatAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn CombatantName;
    }
}