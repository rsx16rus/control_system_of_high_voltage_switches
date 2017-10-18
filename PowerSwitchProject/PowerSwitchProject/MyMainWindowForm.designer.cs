namespace PowerSwitchProject
{
    partial class MyMainWindowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyMainWindowForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выгрузкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_List_Electrical_Substation = new System.Windows.Forms.Label();
            this.label_Selected_PS = new System.Windows.Forms.Label();
            this.label_Switch1 = new System.Windows.Forms.Label();
            this.button_NumberOf_KZ = new System.Windows.Forms.Button();
            this.button_NumberOf_Mehiznos = new System.Windows.Forms.Button();
            this.flowLayoutPanel_PStancii = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel_110_more_kB = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel_10kB = new System.Windows.Forms.FlowLayoutPanel();
            this.label_Switch2 = new System.Windows.Forms.Label();
            this.label_Switch3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel_35kB = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.помощьToolStripMenuItem,
            this.выгрузкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1207, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(117, 29);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(142, 29);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // выгрузкиToolStripMenuItem
            // 
            this.выгрузкиToolStripMenuItem.Name = "выгрузкиToolStripMenuItem";
            this.выгрузкиToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.выгрузкиToolStripMenuItem.Text = "Отчеты";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(20, 63);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(400, 27);
            this.textBoxSearch.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(426, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label_List_Electrical_Substation
            // 
            this.label_List_Electrical_Substation.AutoSize = true;
            this.label_List_Electrical_Substation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_List_Electrical_Substation.Location = new System.Drawing.Point(20, 110);
            this.label_List_Electrical_Substation.Name = "label_List_Electrical_Substation";
            this.label_List_Electrical_Substation.Size = new System.Drawing.Size(272, 25);
            this.label_List_Electrical_Substation.TabIndex = 4;
            this.label_List_Electrical_Substation.Text = "Список электроподстанций";
            // 
            // label_Selected_PS
            // 
            this.label_Selected_PS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Selected_PS.Location = new System.Drawing.Point(400, 137);
            this.label_Selected_PS.Name = "label_Selected_PS";
            this.label_Selected_PS.Size = new System.Drawing.Size(600, 32);
            this.label_Selected_PS.TabIndex = 5;
            this.label_Selected_PS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Switch1
            // 
            this.label_Switch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Switch1.Location = new System.Drawing.Point(380, 180);
            this.label_Switch1.Name = "label_Switch1";
            this.label_Switch1.Size = new System.Drawing.Size(200, 25);
            this.label_Switch1.TabIndex = 6;
            this.label_Switch1.Text = "220/110кв";
            this.label_Switch1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_NumberOf_KZ
            // 
            this.button_NumberOf_KZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_NumberOf_KZ.Location = new System.Drawing.Point(880, 47);
            this.button_NumberOf_KZ.Name = "button_NumberOf_KZ";
            this.button_NumberOf_KZ.Size = new System.Drawing.Size(130, 80);
            this.button_NumberOf_KZ.TabIndex = 7;
            this.button_NumberOf_KZ.Text = "Количество ВВ    с пределом       КЗ = ";
            this.button_NumberOf_KZ.UseVisualStyleBackColor = true;
            // 
            // button_NumberOf_Mehiznos
            // 
            this.button_NumberOf_Mehiznos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_NumberOf_Mehiznos.Location = new System.Drawing.Point(1042, 47);
            this.button_NumberOf_Mehiznos.Name = "button_NumberOf_Mehiznos";
            this.button_NumberOf_Mehiznos.Size = new System.Drawing.Size(130, 80);
            this.button_NumberOf_Mehiznos.TabIndex = 8;
            this.button_NumberOf_Mehiznos.Text = "Количество ВВ с пределом износа = ";
            this.button_NumberOf_Mehiznos.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel_PStancii
            // 
            this.flowLayoutPanel_PStancii.AutoScroll = true;
            this.flowLayoutPanel_PStancii.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.flowLayoutPanel_PStancii.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel_PStancii.Location = new System.Drawing.Point(20, 150);
            this.flowLayoutPanel_PStancii.Name = "flowLayoutPanel_PStancii";
            this.flowLayoutPanel_PStancii.Size = new System.Drawing.Size(325, 520);
            this.flowLayoutPanel_PStancii.TabIndex = 9;
            // 
            // flowLayoutPanel_110_more_kB
            // 
            this.flowLayoutPanel_110_more_kB.AutoScroll = true;
            this.flowLayoutPanel_110_more_kB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel_110_more_kB.Location = new System.Drawing.Point(380, 210);
            this.flowLayoutPanel_110_more_kB.Name = "flowLayoutPanel_110_more_kB";
            this.flowLayoutPanel_110_more_kB.Size = new System.Drawing.Size(200, 460);
            this.flowLayoutPanel_110_more_kB.TabIndex = 10;
            // 
            // flowLayoutPanel_10kB
            // 
            this.flowLayoutPanel_10kB.AutoScroll = true;
            this.flowLayoutPanel_10kB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel_10kB.Location = new System.Drawing.Point(820, 210);
            this.flowLayoutPanel_10kB.Name = "flowLayoutPanel_10kB";
            this.flowLayoutPanel_10kB.Size = new System.Drawing.Size(365, 460);
            this.flowLayoutPanel_10kB.TabIndex = 12;
            // 
            // label_Switch2
            // 
            this.label_Switch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Switch2.Location = new System.Drawing.Point(600, 180);
            this.label_Switch2.Name = "label_Switch2";
            this.label_Switch2.Size = new System.Drawing.Size(200, 25);
            this.label_Switch2.TabIndex = 13;
            this.label_Switch2.Text = "35кв";
            this.label_Switch2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Switch3
            // 
            this.label_Switch3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Switch3.Location = new System.Drawing.Point(820, 180);
            this.label_Switch3.Name = "label_Switch3";
            this.label_Switch3.Size = new System.Drawing.Size(365, 25);
            this.label_Switch3.TabIndex = 14;
            this.label_Switch3.Text = "10кв";
            this.label_Switch3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel_35kB
            // 
            this.flowLayoutPanel_35kB.AutoScroll = true;
            this.flowLayoutPanel_35kB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel_35kB.Location = new System.Drawing.Point(600, 210);
            this.flowLayoutPanel_35kB.Name = "flowLayoutPanel_35kB";
            this.flowLayoutPanel_35kB.Size = new System.Drawing.Size(200, 460);
            this.flowLayoutPanel_35kB.TabIndex = 11;
            // 
            // MyMainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1207, 703);
            this.Controls.Add(this.label_Switch3);
            this.Controls.Add(this.label_Switch2);
            this.Controls.Add(this.flowLayoutPanel_10kB);
            this.Controls.Add(this.flowLayoutPanel_35kB);
            this.Controls.Add(this.flowLayoutPanel_110_more_kB);
            this.Controls.Add(this.flowLayoutPanel_PStancii);
            this.Controls.Add(this.button_NumberOf_Mehiznos);
            this.Controls.Add(this.button_NumberOf_KZ);
            this.Controls.Add(this.label_Switch1);
            this.Controls.Add(this.label_Selected_PS);
            this.Controls.Add(this.label_List_Electrical_Substation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MyMainWindowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Планировщик ТО";
            this.Load += new System.EventHandler(this.MyMainWindowForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выгрузкиToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_List_Electrical_Substation;
        private System.Windows.Forms.Label label_Selected_PS;
        private System.Windows.Forms.Label label_Switch1;
        private System.Windows.Forms.Button button_NumberOf_KZ;
        private System.Windows.Forms.Button button_NumberOf_Mehiznos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_PStancii;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_110_more_kB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_10kB;
        private System.Windows.Forms.Label label_Switch2;
        private System.Windows.Forms.Label label_Switch3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_35kB;
    }
}

