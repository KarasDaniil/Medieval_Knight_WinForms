
namespace Medieval_Knight_WinForms.View
{
    partial class FormInventory
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
            this.DGV_Inventory = new System.Windows.Forms.DataGridView();
            this.label_Info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Inventory)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Inventory
            // 
            this.DGV_Inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Inventory.Location = new System.Drawing.Point(1, 29);
            this.DGV_Inventory.Name = "DGV_Inventory";
            this.DGV_Inventory.RowHeadersWidth = 51;
            this.DGV_Inventory.RowTemplate.Height = 29;
            this.DGV_Inventory.Size = new System.Drawing.Size(583, 409);
            this.DGV_Inventory.TabIndex = 0;
            this.DGV_Inventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Inventory_CellContentClick);
            this.DGV_Inventory.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DGV_Inventory_DataError);
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.Location = new System.Drawing.Point(1, 6);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(338, 20);
            this.label_Info.TabIndex = 1;
            this.label_Info.Text = "To view items stats hover mouse over their name! ";
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.DGV_Inventory);
            this.Name = "FormInventory";
            this.Text = "FormInventory";
            this.Load += new System.EventHandler(this.FormInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Inventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Inventory;
        private System.Windows.Forms.Label label_Info;
    }
}