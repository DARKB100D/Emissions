namespace Emissions
{
    partial class Calc
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.NextTab = new System.Windows.Forms.Button();
            this.PrevTab = new System.Windows.Forms.Button();
            this.Compleate = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(751, 304);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(743, 278);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(743, 278);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // NextTab
            // 
            this.NextTab.Location = new System.Drawing.Point(571, 310);
            this.NextTab.Name = "NextTab";
            this.NextTab.Size = new System.Drawing.Size(75, 23);
            this.NextTab.TabIndex = 0;
            this.NextTab.Text = "button1";
            this.NextTab.UseVisualStyleBackColor = true;
            this.NextTab.Click += new System.EventHandler(this.NextTab_Click);
            // 
            // PrevTab
            // 
            this.PrevTab.Location = new System.Drawing.Point(474, 310);
            this.PrevTab.Name = "PrevTab";
            this.PrevTab.Size = new System.Drawing.Size(75, 23);
            this.PrevTab.TabIndex = 1;
            this.PrevTab.Text = "button2";
            this.PrevTab.UseVisualStyleBackColor = true;
            this.PrevTab.Click += new System.EventHandler(this.PrevTab_Click);
            // 
            // Compleate
            // 
            this.Compleate.Location = new System.Drawing.Point(665, 310);
            this.Compleate.Name = "Compleate";
            this.Compleate.Size = new System.Drawing.Size(75, 23);
            this.Compleate.TabIndex = 2;
            this.Compleate.Text = "button3";
            this.Compleate.UseVisualStyleBackColor = true;
            // 
            // CalcParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 338);
            this.Controls.Add(this.Compleate);
            this.Controls.Add(this.NextTab);
            this.Controls.Add(this.PrevTab);
            this.Controls.Add(this.tabControl1);
            this.Name = "CalcParams";
            this.Text = "Рачет вредных выбросов";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button NextTab;
        private System.Windows.Forms.Button PrevTab;
        private System.Windows.Forms.Button Compleate;
    }
}

