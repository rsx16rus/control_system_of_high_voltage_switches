namespace PowerSwitchProject
{
    partial class DispetcherInsertedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DispetcherInsertedForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Short_Circuit_Amperage = new System.Windows.Forms.TextBox();
            this.radioButton_A_Short_Circuit = new System.Windows.Forms.RadioButton();
            this.radioButton_B_Short_Circuit = new System.Windows.Forms.RadioButton();
            this.radioButton_C_Short_Circuit = new System.Windows.Forms.RadioButton();
            this.radioButton_BC_Short_Circuit = new System.Windows.Forms.RadioButton();
            this.radioButton_AB_Short_Circuit = new System.Windows.Forms.RadioButton();
            this.radioButton_AC_Short_Circuit = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_APV_Successfully = new System.Windows.Forms.Button();
            this.button_APV_Unsuccessfully = new System.Windows.Forms.Button();
            this.button_APV_Disabled = new System.Windows.Forms.Button();
            this.button_Planned = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(47, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фаза короткого       замыкания";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(284, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ток короткого     замыкания";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(373, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "кА";
            // 
            // textBox_Short_Circuit_Amperage
            // 
            this.textBox_Short_Circuit_Amperage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Short_Circuit_Amperage.Location = new System.Drawing.Point(287, 81);
            this.textBox_Short_Circuit_Amperage.Name = "textBox_Short_Circuit_Amperage";
            this.textBox_Short_Circuit_Amperage.Size = new System.Drawing.Size(80, 30);
            this.textBox_Short_Circuit_Amperage.TabIndex = 3;
            this.textBox_Short_Circuit_Amperage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // radioButton_A_Short_Circuit
            // 
            this.radioButton_A_Short_Circuit.AutoSize = true;
            this.radioButton_A_Short_Circuit.Location = new System.Drawing.Point(31, 105);
            this.radioButton_A_Short_Circuit.Name = "radioButton_A_Short_Circuit";
            this.radioButton_A_Short_Circuit.Size = new System.Drawing.Size(17, 16);
            this.radioButton_A_Short_Circuit.TabIndex = 4;
            this.radioButton_A_Short_Circuit.TabStop = true;
            this.radioButton_A_Short_Circuit.UseVisualStyleBackColor = true;
            // 
            // radioButton_B_Short_Circuit
            // 
            this.radioButton_B_Short_Circuit.AutoSize = true;
            this.radioButton_B_Short_Circuit.Location = new System.Drawing.Point(97, 105);
            this.radioButton_B_Short_Circuit.Name = "radioButton_B_Short_Circuit";
            this.radioButton_B_Short_Circuit.Size = new System.Drawing.Size(17, 16);
            this.radioButton_B_Short_Circuit.TabIndex = 5;
            this.radioButton_B_Short_Circuit.TabStop = true;
            this.radioButton_B_Short_Circuit.UseVisualStyleBackColor = true;
            // 
            // radioButton_C_Short_Circuit
            // 
            this.radioButton_C_Short_Circuit.AutoSize = true;
            this.radioButton_C_Short_Circuit.Location = new System.Drawing.Point(161, 105);
            this.radioButton_C_Short_Circuit.Name = "radioButton_C_Short_Circuit";
            this.radioButton_C_Short_Circuit.Size = new System.Drawing.Size(17, 16);
            this.radioButton_C_Short_Circuit.TabIndex = 6;
            this.radioButton_C_Short_Circuit.TabStop = true;
            this.radioButton_C_Short_Circuit.UseVisualStyleBackColor = true;
            // 
            // radioButton_BC_Short_Circuit
            // 
            this.radioButton_BC_Short_Circuit.AutoSize = true;
            this.radioButton_BC_Short_Circuit.Location = new System.Drawing.Point(97, 167);
            this.radioButton_BC_Short_Circuit.Name = "radioButton_BC_Short_Circuit";
            this.radioButton_BC_Short_Circuit.Size = new System.Drawing.Size(17, 16);
            this.radioButton_BC_Short_Circuit.TabIndex = 7;
            this.radioButton_BC_Short_Circuit.TabStop = true;
            this.radioButton_BC_Short_Circuit.UseVisualStyleBackColor = true;
            // 
            // radioButton_AB_Short_Circuit
            // 
            this.radioButton_AB_Short_Circuit.AutoSize = true;
            this.radioButton_AB_Short_Circuit.Location = new System.Drawing.Point(31, 167);
            this.radioButton_AB_Short_Circuit.Name = "radioButton_AB_Short_Circuit";
            this.radioButton_AB_Short_Circuit.Size = new System.Drawing.Size(17, 16);
            this.radioButton_AB_Short_Circuit.TabIndex = 8;
            this.radioButton_AB_Short_Circuit.TabStop = true;
            this.radioButton_AB_Short_Circuit.UseVisualStyleBackColor = true;
            // 
            // radioButton_AC_Short_Circuit
            // 
            this.radioButton_AC_Short_Circuit.AutoSize = true;
            this.radioButton_AC_Short_Circuit.Location = new System.Drawing.Point(161, 167);
            this.radioButton_AC_Short_Circuit.Name = "radioButton_AC_Short_Circuit";
            this.radioButton_AC_Short_Circuit.Size = new System.Drawing.Size(17, 16);
            this.radioButton_AC_Short_Circuit.TabIndex = 9;
            this.radioButton_AC_Short_Circuit.TabStop = true;
            this.radioButton_AC_Short_Circuit.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "А";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "АВ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "В";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "ВС";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "С";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(158, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "АС";
            // 
            // button_APV_Successfully
            // 
            this.button_APV_Successfully.Location = new System.Drawing.Point(509, 58);
            this.button_APV_Successfully.Name = "button_APV_Successfully";
            this.button_APV_Successfully.Size = new System.Drawing.Size(140, 50);
            this.button_APV_Successfully.TabIndex = 16;
            this.button_APV_Successfully.Text = "АПВ успешное";
            this.button_APV_Successfully.UseVisualStyleBackColor = true;
            this.button_APV_Successfully.Click += new System.EventHandler(this.button_APV_Successfully_Click);
            // 
            // button_APV_Unsuccessfully
            // 
            this.button_APV_Unsuccessfully.Location = new System.Drawing.Point(509, 124);
            this.button_APV_Unsuccessfully.Name = "button_APV_Unsuccessfully";
            this.button_APV_Unsuccessfully.Size = new System.Drawing.Size(140, 50);
            this.button_APV_Unsuccessfully.TabIndex = 17;
            this.button_APV_Unsuccessfully.Text = "АПВ неуспешное";
            this.button_APV_Unsuccessfully.UseVisualStyleBackColor = true;
            this.button_APV_Unsuccessfully.Click += new System.EventHandler(this.button_APV_Unsuccessfully_Click);
            // 
            // button_APV_Disabled
            // 
            this.button_APV_Disabled.Location = new System.Drawing.Point(670, 58);
            this.button_APV_Disabled.Name = "button_APV_Disabled";
            this.button_APV_Disabled.Size = new System.Drawing.Size(140, 50);
            this.button_APV_Disabled.TabIndex = 18;
            this.button_APV_Disabled.Text = "АПВ отключено";
            this.button_APV_Disabled.UseVisualStyleBackColor = true;
            this.button_APV_Disabled.Click += new System.EventHandler(this.button_APV_Disabled_Click);
            // 
            // button_Planned
            // 
            this.button_Planned.Location = new System.Drawing.Point(670, 124);
            this.button_Planned.Name = "button_Planned";
            this.button_Planned.Size = new System.Drawing.Size(140, 50);
            this.button_Planned.TabIndex = 19;
            this.button_Planned.Text = "Плановое отключение";
            this.button_Planned.UseVisualStyleBackColor = true;
            this.button_Planned.Click += new System.EventHandler(this.button_Planned_Click);
            // 
            // DispetcherInsertedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(846, 216);
            this.Controls.Add(this.button_Planned);
            this.Controls.Add(this.button_APV_Disabled);
            this.Controls.Add(this.button_APV_Unsuccessfully);
            this.Controls.Add(this.button_APV_Successfully);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton_AC_Short_Circuit);
            this.Controls.Add(this.radioButton_AB_Short_Circuit);
            this.Controls.Add(this.radioButton_BC_Short_Circuit);
            this.Controls.Add(this.radioButton_C_Short_Circuit);
            this.Controls.Add(this.radioButton_B_Short_Circuit);
            this.Controls.Add(this.radioButton_A_Short_Circuit);
            this.Controls.Add(this.textBox_Short_Circuit_Amperage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DispetcherInsertedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Short_Circuit_Amperage;
        private System.Windows.Forms.RadioButton radioButton_A_Short_Circuit;
        private System.Windows.Forms.RadioButton radioButton_B_Short_Circuit;
        private System.Windows.Forms.RadioButton radioButton_C_Short_Circuit;
        private System.Windows.Forms.RadioButton radioButton_BC_Short_Circuit;
        private System.Windows.Forms.RadioButton radioButton_AB_Short_Circuit;
        private System.Windows.Forms.RadioButton radioButton_AC_Short_Circuit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_APV_Successfully;
        private System.Windows.Forms.Button button_APV_Unsuccessfully;
        private System.Windows.Forms.Button button_APV_Disabled;
        private System.Windows.Forms.Button button_Planned;
    }
}