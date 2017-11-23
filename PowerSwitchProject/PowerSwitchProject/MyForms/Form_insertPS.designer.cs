namespace PowerSwitchProject
{
    partial class Form_insertPS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_insertPS));
            this.textBox_PS_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_RES = new System.Windows.Forms.ComboBox();
            this.comboBox_GroupPS = new System.Windows.Forms.ComboBox();
            this.button_Create_PS = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_PS_Name
            // 
            this.textBox_PS_Name.Location = new System.Drawing.Point(337, 32);
            this.textBox_PS_Name.Name = "textBox_PS_Name";
            this.textBox_PS_Name.Size = new System.Drawing.Size(407, 22);
            this.textBox_PS_Name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите диспетчерское наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выберите обслуживащий РЭС";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Выберите обслуживающую группу ПС";
            // 
            // comboBox_RES
            // 
            this.comboBox_RES.FormattingEnabled = true;
            this.comboBox_RES.Location = new System.Drawing.Point(337, 84);
            this.comboBox_RES.Name = "comboBox_RES";
            this.comboBox_RES.Size = new System.Drawing.Size(407, 24);
            this.comboBox_RES.TabIndex = 4;
            // 
            // comboBox_GroupPS
            // 
            this.comboBox_GroupPS.FormattingEnabled = true;
            this.comboBox_GroupPS.Location = new System.Drawing.Point(337, 140);
            this.comboBox_GroupPS.Name = "comboBox_GroupPS";
            this.comboBox_GroupPS.Size = new System.Drawing.Size(407, 24);
            this.comboBox_GroupPS.TabIndex = 5;
            // 
            // button_Create_PS
            // 
            this.button_Create_PS.Location = new System.Drawing.Point(410, 187);
            this.button_Create_PS.Name = "button_Create_PS";
            this.button_Create_PS.Size = new System.Drawing.Size(130, 40);
            this.button_Create_PS.TabIndex = 6;
            this.button_Create_PS.Text = "Создать";
            this.button_Create_PS.UseVisualStyleBackColor = true;
            this.button_Create_PS.Click += new System.EventHandler(this.Button_Create_PS_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(614, 187);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(130, 40);
            this.button_Cancel.TabIndex = 7;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Form_insertPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 253);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Create_PS);
            this.Controls.Add(this.comboBox_GroupPS);
            this.Controls.Add(this.comboBox_RES);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_PS_Name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_insertPS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_insertPS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_PS_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_RES;
        private System.Windows.Forms.ComboBox comboBox_GroupPS;
        private System.Windows.Forms.Button button_Create_PS;
        private System.Windows.Forms.Button button_Cancel;
    }
}