
namespace Medieval_Knight_WinForms.View
{
    partial class FormShop
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
            this.DGV_PlayerInventory = new System.Windows.Forms.DataGridView();
            this.ColumnSellCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DGV_ShopInventory = new System.Windows.Forms.DataGridView();
            this.ColumnBuyCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label_PlayerInventory = new System.Windows.Forms.Label();
            this.label_ShopInventory = new System.Windows.Forms.Label();
            this.Bt_BuySelected = new System.Windows.Forms.Button();
            this.Bt_SellSelected = new System.Windows.Forms.Button();
            this.label_YourCurrentGold = new System.Windows.Forms.Label();
            this.label_YourCurrentGoldNum = new System.Windows.Forms.Label();
            this.label_ShopCurrentGold = new System.Windows.Forms.Label();
            this.label_ShopCurrentGoldNum = new System.Windows.Forms.Label();
            this.label_YourCurrentGoldNetto = new System.Windows.Forms.Label();
            this.label_ShopCurrentGoldNetto = new System.Windows.Forms.Label();
            this.label_Info = new System.Windows.Forms.Label();
            this.Bt_PlusGold = new System.Windows.Forms.Button();
            this.Bt_MinusGold = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PlayerInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ShopInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_PlayerInventory
            // 
            this.DGV_PlayerInventory.AllowUserToAddRows = false;
            this.DGV_PlayerInventory.AllowUserToDeleteRows = false;
            this.DGV_PlayerInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PlayerInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSellCheck});
            this.DGV_PlayerInventory.Location = new System.Drawing.Point(2, 30);
            this.DGV_PlayerInventory.Name = "DGV_PlayerInventory";
            this.DGV_PlayerInventory.ReadOnly = true;
            this.DGV_PlayerInventory.RowHeadersWidth = 51;
            this.DGV_PlayerInventory.RowTemplate.Height = 29;
            this.DGV_PlayerInventory.Size = new System.Drawing.Size(675, 327);
            this.DGV_PlayerInventory.TabIndex = 0;
            this.DGV_PlayerInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_PlayerInventory_CellContentClick);
            // 
            // ColumnSellCheck
            // 
            this.ColumnSellCheck.HeaderText = "Sell this item?";
            this.ColumnSellCheck.MinimumWidth = 6;
            this.ColumnSellCheck.Name = "ColumnSellCheck";
            this.ColumnSellCheck.ReadOnly = true;
            this.ColumnSellCheck.Width = 128;
            // 
            // DGV_ShopInventory
            // 
            this.DGV_ShopInventory.AllowUserToAddRows = false;
            this.DGV_ShopInventory.AllowUserToDeleteRows = false;
            this.DGV_ShopInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ShopInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnBuyCheck});
            this.DGV_ShopInventory.Location = new System.Drawing.Point(693, 30);
            this.DGV_ShopInventory.Name = "DGV_ShopInventory";
            this.DGV_ShopInventory.ReadOnly = true;
            this.DGV_ShopInventory.RowHeadersWidth = 51;
            this.DGV_ShopInventory.RowTemplate.Height = 29;
            this.DGV_ShopInventory.Size = new System.Drawing.Size(662, 327);
            this.DGV_ShopInventory.TabIndex = 1;
            this.DGV_ShopInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_ShopInventory_CellContentClick);
            // 
            // ColumnBuyCheck
            // 
            this.ColumnBuyCheck.HeaderText = "Buy this item? ";
            this.ColumnBuyCheck.MinimumWidth = 6;
            this.ColumnBuyCheck.Name = "ColumnBuyCheck";
            this.ColumnBuyCheck.ReadOnly = true;
            this.ColumnBuyCheck.Width = 125;
            // 
            // label_PlayerInventory
            // 
            this.label_PlayerInventory.AutoSize = true;
            this.label_PlayerInventory.Location = new System.Drawing.Point(2, 7);
            this.label_PlayerInventory.Name = "label_PlayerInventory";
            this.label_PlayerInventory.Size = new System.Drawing.Size(106, 20);
            this.label_PlayerInventory.TabIndex = 2;
            this.label_PlayerInventory.Text = "Your Inventory:";
            // 
            // label_ShopInventory
            // 
            this.label_ShopInventory.AutoSize = true;
            this.label_ShopInventory.Location = new System.Drawing.Point(693, 7);
            this.label_ShopInventory.Name = "label_ShopInventory";
            this.label_ShopInventory.Size = new System.Drawing.Size(162, 20);
            this.label_ShopInventory.TabIndex = 3;
            this.label_ShopInventory.Text = "Shop Keeper Inventory:";
            // 
            // Bt_BuySelected
            // 
            this.Bt_BuySelected.Location = new System.Drawing.Point(693, 363);
            this.Bt_BuySelected.Name = "Bt_BuySelected";
            this.Bt_BuySelected.Size = new System.Drawing.Size(139, 29);
            this.Bt_BuySelected.TabIndex = 4;
            this.Bt_BuySelected.Text = "Buy Selected";
            this.Bt_BuySelected.UseVisualStyleBackColor = true;
            this.Bt_BuySelected.Click += new System.EventHandler(this.Bt_BuySelected_Click);
            // 
            // Bt_SellSelected
            // 
            this.Bt_SellSelected.Location = new System.Drawing.Point(2, 363);
            this.Bt_SellSelected.Name = "Bt_SellSelected";
            this.Bt_SellSelected.Size = new System.Drawing.Size(139, 29);
            this.Bt_SellSelected.TabIndex = 5;
            this.Bt_SellSelected.Text = "Sell Selected";
            this.Bt_SellSelected.UseVisualStyleBackColor = true;
            this.Bt_SellSelected.Click += new System.EventHandler(this.Bt_SellSelected_Click);
            // 
            // label_YourCurrentGold
            // 
            this.label_YourCurrentGold.AutoSize = true;
            this.label_YourCurrentGold.Location = new System.Drawing.Point(147, 367);
            this.label_YourCurrentGold.Name = "label_YourCurrentGold";
            this.label_YourCurrentGold.Size = new System.Drawing.Size(129, 20);
            this.label_YourCurrentGold.TabIndex = 6;
            this.label_YourCurrentGold.Text = "Your Current Gold:";
            // 
            // label_YourCurrentGoldNum
            // 
            this.label_YourCurrentGoldNum.AutoSize = true;
            this.label_YourCurrentGoldNum.Location = new System.Drawing.Point(282, 367);
            this.label_YourCurrentGoldNum.Name = "label_YourCurrentGoldNum";
            this.label_YourCurrentGoldNum.Size = new System.Drawing.Size(0, 20);
            this.label_YourCurrentGoldNum.TabIndex = 7;
            // 
            // label_ShopCurrentGold
            // 
            this.label_ShopCurrentGold.AutoSize = true;
            this.label_ShopCurrentGold.Location = new System.Drawing.Point(838, 367);
            this.label_ShopCurrentGold.Name = "label_ShopCurrentGold";
            this.label_ShopCurrentGold.Size = new System.Drawing.Size(134, 20);
            this.label_ShopCurrentGold.TabIndex = 8;
            this.label_ShopCurrentGold.Text = "Shop Current Gold:";
            // 
            // label_ShopCurrentGoldNum
            // 
            this.label_ShopCurrentGoldNum.AutoSize = true;
            this.label_ShopCurrentGoldNum.Location = new System.Drawing.Point(978, 367);
            this.label_ShopCurrentGoldNum.Name = "label_ShopCurrentGoldNum";
            this.label_ShopCurrentGoldNum.Size = new System.Drawing.Size(0, 20);
            this.label_ShopCurrentGoldNum.TabIndex = 9;
            // 
            // label_YourCurrentGoldNetto
            // 
            this.label_YourCurrentGoldNetto.AutoSize = true;
            this.label_YourCurrentGoldNetto.Location = new System.Drawing.Point(359, 367);
            this.label_YourCurrentGoldNetto.Name = "label_YourCurrentGoldNetto";
            this.label_YourCurrentGoldNetto.Size = new System.Drawing.Size(0, 20);
            this.label_YourCurrentGoldNetto.TabIndex = 10;
            // 
            // label_ShopCurrentGoldNetto
            // 
            this.label_ShopCurrentGoldNetto.AutoSize = true;
            this.label_ShopCurrentGoldNetto.Location = new System.Drawing.Point(1049, 367);
            this.label_ShopCurrentGoldNetto.Name = "label_ShopCurrentGoldNetto";
            this.label_ShopCurrentGoldNetto.Size = new System.Drawing.Size(0, 20);
            this.label_ShopCurrentGoldNetto.TabIndex = 11;
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.Location = new System.Drawing.Point(861, 7);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(338, 20);
            this.label_Info.TabIndex = 12;
            this.label_Info.Text = "To view items stats hover mouse over their name! ";
            // 
            // Bt_PlusGold
            // 
            this.Bt_PlusGold.Location = new System.Drawing.Point(147, 390);
            this.Bt_PlusGold.Name = "Bt_PlusGold";
            this.Bt_PlusGold.Size = new System.Drawing.Size(60, 32);
            this.Bt_PlusGold.TabIndex = 13;
            this.Bt_PlusGold.Text = "Plus";
            this.Bt_PlusGold.UseVisualStyleBackColor = true;
            this.Bt_PlusGold.Click += new System.EventHandler(this.Bt_PlusGold_Click);
            // 
            // Bt_MinusGold
            // 
            this.Bt_MinusGold.Location = new System.Drawing.Point(213, 390);
            this.Bt_MinusGold.Name = "Bt_MinusGold";
            this.Bt_MinusGold.Size = new System.Drawing.Size(60, 32);
            this.Bt_MinusGold.TabIndex = 14;
            this.Bt_MinusGold.Text = "Minus";
            this.Bt_MinusGold.UseVisualStyleBackColor = true;
            this.Bt_MinusGold.Click += new System.EventHandler(this.Bt_MinusGold_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "To view items stats hover mouse over their name! ";
            // 
            // FormShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 448);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bt_MinusGold);
            this.Controls.Add(this.Bt_PlusGold);
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.label_ShopCurrentGoldNetto);
            this.Controls.Add(this.label_YourCurrentGoldNetto);
            this.Controls.Add(this.label_ShopCurrentGoldNum);
            this.Controls.Add(this.label_ShopCurrentGold);
            this.Controls.Add(this.label_YourCurrentGoldNum);
            this.Controls.Add(this.label_YourCurrentGold);
            this.Controls.Add(this.Bt_SellSelected);
            this.Controls.Add(this.Bt_BuySelected);
            this.Controls.Add(this.label_ShopInventory);
            this.Controls.Add(this.label_PlayerInventory);
            this.Controls.Add(this.DGV_ShopInventory);
            this.Controls.Add(this.DGV_PlayerInventory);
            this.Name = "FormShop";
            this.Text = "FormShop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormShop_FormClosed);
            this.Load += new System.EventHandler(this.FormShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PlayerInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ShopInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_PlayerInventory;
        private System.Windows.Forms.DataGridView DGV_ShopInventory;
        private System.Windows.Forms.Label label_PlayerInventory;
        private System.Windows.Forms.Label label_ShopInventory;
        private System.Windows.Forms.Button Bt_BuySelected;
        private System.Windows.Forms.Button Bt_SellSelected;
        private System.Windows.Forms.Label label_YourCurrentGold;
        private System.Windows.Forms.Label label_YourCurrentGoldNum;
        private System.Windows.Forms.Label label_ShopCurrentGold;
        private System.Windows.Forms.Label label_ShopCurrentGoldNum;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnBuyCheck;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnSellCheck;
        private System.Windows.Forms.Label label_YourCurrentGoldNetto;
        private System.Windows.Forms.Label label_ShopCurrentGoldNetto;
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.Button Bt_PlusGold;
        private System.Windows.Forms.Button Bt_MinusGold;
        private System.Windows.Forms.Label label1;
    }
}