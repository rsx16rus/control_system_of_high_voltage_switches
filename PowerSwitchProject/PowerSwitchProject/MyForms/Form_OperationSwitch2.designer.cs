namespace PowerSwitchProject
{
    partial class Form_OperationSwitch2
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_OperationSwitch2));
            this.label_Title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox_Location = new System.Windows.Forms.ComboBox();
            this.textBox_DispatchingName = new System.Windows.Forms.TextBox();
            this.comboBox_SwitchModel = new System.Windows.Forms.ComboBox();
            this.textBox_FactoryNumber = new System.Windows.Forms.TextBox();
            this.textBox_DateOfManufacture = new System.Windows.Forms.TextBox();
            this.textBox_DateOfComissioning = new System.Windows.Forms.TextBox();
            this.textBox_PoleWearA = new System.Windows.Forms.TextBox();
            this.textBox_PoleWearB = new System.Windows.Forms.TextBox();
            this.textBox_PoleWearC = new System.Windows.Forms.TextBox();
            this.textBox_NumberOfKZ = new System.Windows.Forms.TextBox();
            this.textBox_numberOfMex_Percent = new System.Windows.Forms.TextBox();
            this.textBox_DateOfMaintenance = new System.Windows.Forms.TextBox();
            this.textBox_DateOfOverhaul = new System.Windows.Forms.TextBox();
            this.button_Maintenance_event = new System.Windows.Forms.Button();
            this.button_Overhaul_event = new System.Windows.Forms.Button();
            this.button_Ok = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Delete_OperSw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Title.Location = new System.Drawing.Point(121, 20);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(482, 25);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Редактирование информации о выключателе";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(35, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Место расположения(ПС):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(35, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Диспетчерское наименование:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(35, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Модель выключателя:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(35, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Заводской номер:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(35, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Дата производства:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(406, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Коммутационный износ ф.А(%):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(406, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(234, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Коммутационный износ ф.В(%):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(406, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(235, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Коммутационный износ ф.С(%):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(406, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Количество отключений КЗ:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(406, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Механический износ(%):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(35, 420);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(157, 18);
            this.label13.TabIndex = 12;
            this.label13.Text = "Дата ввода в работу:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(406, 420);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(158, 18);
            this.label14.TabIndex = 13;
            this.label14.Text = "Дата последнего ТО:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(406, 490);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(157, 18);
            this.label15.TabIndex = 14;
            this.label15.Text = "Дата последнего КР:";
            // 
            // comboBox_Location
            // 
            this.comboBox_Location.FormattingEnabled = true;
            this.comboBox_Location.Location = new System.Drawing.Point(38, 91);
            this.comboBox_Location.Name = "comboBox_Location";
            this.comboBox_Location.Size = new System.Drawing.Size(270, 24);
            this.comboBox_Location.TabIndex = 15;
            // 
            // textBox_DispatchingName
            // 
            this.textBox_DispatchingName.Location = new System.Drawing.Point(38, 161);
            this.textBox_DispatchingName.Name = "textBox_DispatchingName";
            this.textBox_DispatchingName.Size = new System.Drawing.Size(270, 22);
            this.textBox_DispatchingName.TabIndex = 16;
            // 
            // comboBox_SwitchModel
            // 
            this.comboBox_SwitchModel.FormattingEnabled = true;
            this.comboBox_SwitchModel.Location = new System.Drawing.Point(38, 231);
            this.comboBox_SwitchModel.Name = "comboBox_SwitchModel";
            this.comboBox_SwitchModel.Size = new System.Drawing.Size(270, 24);
            this.comboBox_SwitchModel.TabIndex = 17;
            // 
            // textBox_FactoryNumber
            // 
            this.textBox_FactoryNumber.Location = new System.Drawing.Point(38, 301);
            this.textBox_FactoryNumber.Name = "textBox_FactoryNumber";
            this.textBox_FactoryNumber.Size = new System.Drawing.Size(270, 22);
            this.textBox_FactoryNumber.TabIndex = 18;
            // 
            // textBox_DateOfManufacture
            // 
            this.textBox_DateOfManufacture.Location = new System.Drawing.Point(38, 371);
            this.textBox_DateOfManufacture.Name = "textBox_DateOfManufacture";
            this.textBox_DateOfManufacture.Size = new System.Drawing.Size(270, 22);
            this.textBox_DateOfManufacture.TabIndex = 19;
            // 
            // textBox_DateOfComissioning
            // 
            this.textBox_DateOfComissioning.Location = new System.Drawing.Point(38, 443);
            this.textBox_DateOfComissioning.Name = "textBox_DateOfComissioning";
            this.textBox_DateOfComissioning.Size = new System.Drawing.Size(270, 22);
            this.textBox_DateOfComissioning.TabIndex = 21;
            // 
            // textBox_PoleWearA
            // 
            this.textBox_PoleWearA.Location = new System.Drawing.Point(409, 91);
            this.textBox_PoleWearA.Name = "textBox_PoleWearA";
            this.textBox_PoleWearA.Size = new System.Drawing.Size(270, 22);
            this.textBox_PoleWearA.TabIndex = 22;
            // 
            // textBox_PoleWearB
            // 
            this.textBox_PoleWearB.Location = new System.Drawing.Point(409, 161);
            this.textBox_PoleWearB.Name = "textBox_PoleWearB";
            this.textBox_PoleWearB.Size = new System.Drawing.Size(270, 22);
            this.textBox_PoleWearB.TabIndex = 23;
            // 
            // textBox_PoleWearC
            // 
            this.textBox_PoleWearC.Location = new System.Drawing.Point(409, 231);
            this.textBox_PoleWearC.Name = "textBox_PoleWearC";
            this.textBox_PoleWearC.Size = new System.Drawing.Size(270, 22);
            this.textBox_PoleWearC.TabIndex = 24;
            // 
            // textBox_NumberOfKZ
            // 
            this.textBox_NumberOfKZ.Location = new System.Drawing.Point(409, 301);
            this.textBox_NumberOfKZ.Name = "textBox_NumberOfKZ";
            this.textBox_NumberOfKZ.Size = new System.Drawing.Size(270, 22);
            this.textBox_NumberOfKZ.TabIndex = 25;
            // 
            // textBox_numberOfMex_Percent
            // 
            this.textBox_numberOfMex_Percent.Location = new System.Drawing.Point(409, 371);
            this.textBox_numberOfMex_Percent.Name = "textBox_numberOfMex_Percent";
            this.textBox_numberOfMex_Percent.Size = new System.Drawing.Size(270, 22);
            this.textBox_numberOfMex_Percent.TabIndex = 26;
            // 
            // textBox_DateOfMaintenance
            // 
            this.textBox_DateOfMaintenance.Location = new System.Drawing.Point(409, 443);
            this.textBox_DateOfMaintenance.Name = "textBox_DateOfMaintenance";
            this.textBox_DateOfMaintenance.Size = new System.Drawing.Size(270, 22);
            this.textBox_DateOfMaintenance.TabIndex = 27;
            // 
            // textBox_DateOfOverhaul
            // 
            this.textBox_DateOfOverhaul.Location = new System.Drawing.Point(409, 511);
            this.textBox_DateOfOverhaul.Name = "textBox_DateOfOverhaul";
            this.textBox_DateOfOverhaul.Size = new System.Drawing.Size(270, 22);
            this.textBox_DateOfOverhaul.TabIndex = 28;
            // 
            // button_Maintenance_event
            // 
            this.button_Maintenance_event.Enabled = false;
            this.button_Maintenance_event.Location = new System.Drawing.Point(38, 502);
            this.button_Maintenance_event.Name = "button_Maintenance_event";
            this.button_Maintenance_event.Size = new System.Drawing.Size(130, 40);
            this.button_Maintenance_event.TabIndex = 29;
            this.button_Maintenance_event.Text = "Проведено ТО";
            this.button_Maintenance_event.UseVisualStyleBackColor = true;
            this.button_Maintenance_event.Click += new System.EventHandler(this.button_Maintenance_event_Click);
            // 
            // button_Overhaul_event
            // 
            this.button_Overhaul_event.Enabled = false;
            this.button_Overhaul_event.Location = new System.Drawing.Point(178, 502);
            this.button_Overhaul_event.Name = "button_Overhaul_event";
            this.button_Overhaul_event.Size = new System.Drawing.Size(130, 40);
            this.button_Overhaul_event.TabIndex = 30;
            this.button_Overhaul_event.Text = "Проведен КР";
            this.button_Overhaul_event.UseVisualStyleBackColor = true;
            this.button_Overhaul_event.Click += new System.EventHandler(this.button_Overhaul_event_Click);
            // 
            // button_Ok
            // 
            this.button_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Ok.Location = new System.Drawing.Point(347, 591);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(130, 40);
            this.button_Ok.TabIndex = 31;
            this.button_Ok.Text = "Сохранить";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(570, 591);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(130, 40);
            this.button_Cancel.TabIndex = 32;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Delete_OperSw
            // 
            this.button_Delete_OperSw.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Delete_OperSw.Location = new System.Drawing.Point(109, 591);
            this.button_Delete_OperSw.Name = "button_Delete_OperSw";
            this.button_Delete_OperSw.Size = new System.Drawing.Size(130, 40);
            this.button_Delete_OperSw.TabIndex = 33;
            this.button_Delete_OperSw.Text = "Удалить";
            this.button_Delete_OperSw.UseVisualStyleBackColor = true;
            this.button_Delete_OperSw.Click += new System.EventHandler(this.button_Delete_OperSw_Click);
            // 
            // Form_OperationSwitch2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 653);
            this.Controls.Add(this.button_Delete_OperSw);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.button_Overhaul_event);
            this.Controls.Add(this.button_Maintenance_event);
            this.Controls.Add(this.textBox_DateOfOverhaul);
            this.Controls.Add(this.textBox_DateOfMaintenance);
            this.Controls.Add(this.textBox_numberOfMex_Percent);
            this.Controls.Add(this.textBox_NumberOfKZ);
            this.Controls.Add(this.textBox_PoleWearC);
            this.Controls.Add(this.textBox_PoleWearB);
            this.Controls.Add(this.textBox_PoleWearA);
            this.Controls.Add(this.textBox_DateOfComissioning);
            this.Controls.Add(this.textBox_DateOfManufacture);
            this.Controls.Add(this.textBox_FactoryNumber);
            this.Controls.Add(this.comboBox_SwitchModel);
            this.Controls.Add(this.textBox_DispatchingName);
            this.Controls.Add(this.comboBox_Location);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_OperationSwitch2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox_Location;
        private System.Windows.Forms.TextBox textBox_DispatchingName;
        private System.Windows.Forms.ComboBox comboBox_SwitchModel;
        private System.Windows.Forms.TextBox textBox_FactoryNumber;
        private System.Windows.Forms.TextBox textBox_DateOfManufacture;
        private System.Windows.Forms.TextBox textBox_DateOfComissioning;
        private System.Windows.Forms.TextBox textBox_PoleWearA;
        private System.Windows.Forms.TextBox textBox_PoleWearB;
        private System.Windows.Forms.TextBox textBox_PoleWearC;
        private System.Windows.Forms.TextBox textBox_NumberOfKZ;
        private System.Windows.Forms.TextBox textBox_numberOfMex_Percent;
        private System.Windows.Forms.TextBox textBox_DateOfMaintenance;
        private System.Windows.Forms.TextBox textBox_DateOfOverhaul;
        private System.Windows.Forms.Button button_Maintenance_event;
        private System.Windows.Forms.Button button_Overhaul_event;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Delete_OperSw;
    }
}

