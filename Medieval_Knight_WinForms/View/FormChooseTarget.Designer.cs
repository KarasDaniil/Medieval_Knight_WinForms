
namespace Medieval_Knight_WinForms.View
{
    partial class FormChooseTarget
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
            this.comboBox_Names = new System.Windows.Forms.ComboBox();
            this.Bt_AttackTarget = new System.Windows.Forms.Button();
            this.Bt_CastJewelSkillOnTarget = new System.Windows.Forms.Button();
            this.label_Info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_Names
            // 
            this.comboBox_Names.FormattingEnabled = true;
            this.comboBox_Names.Location = new System.Drawing.Point(12, 41);
            this.comboBox_Names.Name = "comboBox_Names";
            this.comboBox_Names.Size = new System.Drawing.Size(187, 28);
            this.comboBox_Names.TabIndex = 0;
            // 
            // Bt_AttackTarget
            // 
            this.Bt_AttackTarget.Location = new System.Drawing.Point(12, 134);
            this.Bt_AttackTarget.Name = "Bt_AttackTarget";
            this.Bt_AttackTarget.Size = new System.Drawing.Size(187, 29);
            this.Bt_AttackTarget.TabIndex = 1;
            this.Bt_AttackTarget.Text = "Attack Target";
            this.Bt_AttackTarget.UseVisualStyleBackColor = true;
            this.Bt_AttackTarget.Click += new System.EventHandler(this.Bt_AttackTarget_Click);
            // 
            // Bt_CastJewelSkillOnTarget
            // 
            this.Bt_CastJewelSkillOnTarget.Location = new System.Drawing.Point(12, 99);
            this.Bt_CastJewelSkillOnTarget.Name = "Bt_CastJewelSkillOnTarget";
            this.Bt_CastJewelSkillOnTarget.Size = new System.Drawing.Size(187, 29);
            this.Bt_CastJewelSkillOnTarget.TabIndex = 2;
            this.Bt_CastJewelSkillOnTarget.Text = "Cast Jewel Skill On Target";
            this.Bt_CastJewelSkillOnTarget.UseVisualStyleBackColor = true;
            this.Bt_CastJewelSkillOnTarget.Click += new System.EventHandler(this.Bt_CastJewelSkillOnTarget_Click);
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.Location = new System.Drawing.Point(12, 10);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(105, 20);
            this.label_Info.TabIndex = 3;
            this.label_Info.Text = "Shoose Target:";
            // 
            // FormChooseTarget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 176);
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.Bt_CastJewelSkillOnTarget);
            this.Controls.Add(this.Bt_AttackTarget);
            this.Controls.Add(this.comboBox_Names);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormChooseTarget";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormChooseTarget";
            this.Load += new System.EventHandler(this.FormChooseTarget_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Names;
        private System.Windows.Forms.Button Bt_AttackTarget;
        private System.Windows.Forms.Button Bt_CastJewelSkillOnTarget;
        private System.Windows.Forms.Label label_Info;
    }
}