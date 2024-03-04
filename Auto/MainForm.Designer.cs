namespace Auto
{
    partial class MainForm
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
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.SelectFormBTN = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.RegButton = new System.Windows.Forms.Button();
            this.HelloLabel = new System.Windows.Forms.Label();
            this.AuthButton = new System.Windows.Forms.Button();
            this.FiltrPanel = new System.Windows.Forms.Panel();
            this.rolecomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FindButton = new System.Windows.Forms.Button();
            this.tipcomboBox = new System.Windows.Forms.ComboBox();
            this.pytecomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FiltrButton = new System.Windows.Forms.Button();
            this.UserPanel.SuspendLayout();
            this.FiltrPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewPanel
            // 
            this.ViewPanel.AutoScroll = true;
            this.ViewPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewPanel.Location = new System.Drawing.Point(0, 195);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(1032, 460);
            this.ViewPanel.TabIndex = 8;
            this.ViewPanel.Resize += new System.EventHandler(this.ViewPanel_Resize);
            // 
            // UserPanel
            // 
            this.UserPanel.BackColor = System.Drawing.Color.MediumBlue;
            this.UserPanel.Controls.Add(this.SelectFormBTN);
            this.UserPanel.Controls.Add(this.HelpButton);
            this.UserPanel.Controls.Add(this.RegButton);
            this.UserPanel.Controls.Add(this.HelloLabel);
            this.UserPanel.Controls.Add(this.AuthButton);
            this.UserPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserPanel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.UserPanel.Location = new System.Drawing.Point(0, 0);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(1032, 55);
            this.UserPanel.TabIndex = 9;
            // 
            // SelectFormBTN
            // 
            this.SelectFormBTN.Location = new System.Drawing.Point(547, 12);
            this.SelectFormBTN.Name = "SelectFormBTN";
            this.SelectFormBTN.Size = new System.Drawing.Size(156, 37);
            this.SelectFormBTN.TabIndex = 4;
            this.SelectFormBTN.Text = "Избранное";
            this.SelectFormBTN.UseVisualStyleBackColor = true;
            this.SelectFormBTN.Click += new System.EventHandler(this.SelectFormBTN_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(892, 12);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(129, 37);
            this.HelpButton.TabIndex = 3;
            this.HelpButton.Text = "Помощь";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // RegButton
            // 
            this.RegButton.Location = new System.Drawing.Point(724, 12);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(156, 37);
            this.RegButton.TabIndex = 2;
            this.RegButton.Text = "Регистрация";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Location = new System.Drawing.Point(170, 18);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(51, 20);
            this.HelloLabel.TabIndex = 1;
            this.HelloLabel.Text = "label1";
            // 
            // AuthButton
            // 
            this.AuthButton.Location = new System.Drawing.Point(3, 10);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(136, 37);
            this.AuthButton.TabIndex = 0;
            this.AuthButton.Text = "Войти";
            this.AuthButton.UseVisualStyleBackColor = true;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // FiltrPanel
            // 
            this.FiltrPanel.BackColor = System.Drawing.Color.Black;
            this.FiltrPanel.Controls.Add(this.rolecomboBox);
            this.FiltrPanel.Controls.Add(this.label4);
            this.FiltrPanel.Controls.Add(this.FindButton);
            this.FiltrPanel.Controls.Add(this.tipcomboBox);
            this.FiltrPanel.Controls.Add(this.pytecomboBox);
            this.FiltrPanel.Controls.Add(this.label2);
            this.FiltrPanel.Controls.Add(this.label1);
            this.FiltrPanel.Controls.Add(this.FiltrButton);
            this.FiltrPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FiltrPanel.Location = new System.Drawing.Point(0, 55);
            this.FiltrPanel.Name = "FiltrPanel";
            this.FiltrPanel.Size = new System.Drawing.Size(1032, 140);
            this.FiltrPanel.TabIndex = 10;
            // 
            // rolecomboBox
            // 
            this.rolecomboBox.FormattingEnabled = true;
            this.rolecomboBox.Items.AddRange(new object[] {
            "",
            "DD",
            "SapDD",
            "SapDD or DD",
            "Sap",
            "Hiler",
            "Defens",
            "Debaffer"});
            this.rolecomboBox.Location = new System.Drawing.Point(134, 40);
            this.rolecomboBox.Name = "rolecomboBox";
            this.rolecomboBox.Size = new System.Drawing.Size(156, 28);
            this.rolecomboBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(8, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Стихия";
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(920, 46);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(100, 66);
            this.FindButton.TabIndex = 7;
            this.FindButton.Text = "Найти";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // tipcomboBox
            // 
            this.tipcomboBox.FormattingEnabled = true;
            this.tipcomboBox.Items.AddRange(new object[] {
            "",
            "Физический",
            "Леденой",
            "Ветреной",
            "Электрический",
            "Огненый",
            "Квантовый",
            "Мнимый"});
            this.tipcomboBox.Location = new System.Drawing.Point(134, 102);
            this.tipcomboBox.Name = "tipcomboBox";
            this.tipcomboBox.Size = new System.Drawing.Size(156, 28);
            this.tipcomboBox.TabIndex = 6;
            // 
            // pytecomboBox
            // 
            this.pytecomboBox.FormattingEnabled = true;
            this.pytecomboBox.Items.AddRange(new object[] {
            "",
            "Разрушение",
            "Гармония",
            "Изобилие",
            "Охота",
            "Эрудикция",
            "Небытие",
            "Сохранение"});
            this.pytecomboBox.Location = new System.Drawing.Point(134, 71);
            this.pytecomboBox.Name = "pytecomboBox";
            this.pytecomboBox.Size = new System.Drawing.Size(156, 28);
            this.pytecomboBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(8, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Путь";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(8, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Роль в отряде";
            // 
            // FiltrButton
            // 
            this.FiltrButton.Location = new System.Drawing.Point(0, 0);
            this.FiltrButton.Name = "FiltrButton";
            this.FiltrButton.Size = new System.Drawing.Size(125, 33);
            this.FiltrButton.TabIndex = 0;
            this.FiltrButton.Text = "Фильтр";
            this.FiltrButton.UseVisualStyleBackColor = true;
            this.FiltrButton.Click += new System.EventHandler(this.FiltrButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1032, 655);
            this.Controls.Add(this.ViewPanel);
            this.Controls.Add(this.FiltrPanel);
            this.Controls.Add(this.UserPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.UserPanel.ResumeLayout(false);
            this.UserPanel.PerformLayout();
            this.FiltrPanel.ResumeLayout(false);
            this.FiltrPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ViewPanel;
        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.Panel FiltrPanel;
        private System.Windows.Forms.Button AuthButton;
        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button FiltrButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.ComboBox tipcomboBox;
        private System.Windows.Forms.ComboBox pytecomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SelectFormBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox rolecomboBox;
    }
}

