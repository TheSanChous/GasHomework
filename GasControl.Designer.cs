namespace WindowsForms
{
    partial class GasControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.GasStationGroupBox = new System.Windows.Forms.GroupBox();
            this.GasSumGroupBox = new System.Windows.Forms.GroupBox();
            this.GasSumGrnLabel = new System.Windows.Forms.Label();
            this.GasSumNumLabel = new System.Windows.Forms.Label();
            this.CountlitersLabel = new System.Windows.Forms.Label();
            this.PriseGrnLabel2 = new System.Windows.Forms.Label();
            this.PriseGrnLabel1 = new System.Windows.Forms.Label();
            this.SumTextBox = new System.Windows.Forms.TextBox();
            this.LitersCountTextBox = new System.Windows.Forms.TextBox();
            this.SwitchRadioButtonPanel = new System.Windows.Forms.Panel();
            this.SumRadioButton = new System.Windows.Forms.RadioButton();
            this.CountRadioButton = new System.Windows.Forms.RadioButton();
            this.GasPriceTextBox = new System.Windows.Forms.TextBox();
            this.GasPriceLabel = new System.Windows.Forms.Label();
            this.GasListComboBox = new System.Windows.Forms.ComboBox();
            this.GasLabel = new System.Windows.Forms.Label();
            this.GasStationGroupBox.SuspendLayout();
            this.GasSumGroupBox.SuspendLayout();
            this.SwitchRadioButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GasStationGroupBox
            // 
            this.GasStationGroupBox.Controls.Add(this.GasSumGroupBox);
            this.GasStationGroupBox.Controls.Add(this.CountlitersLabel);
            this.GasStationGroupBox.Controls.Add(this.PriseGrnLabel2);
            this.GasStationGroupBox.Controls.Add(this.PriseGrnLabel1);
            this.GasStationGroupBox.Controls.Add(this.SumTextBox);
            this.GasStationGroupBox.Controls.Add(this.LitersCountTextBox);
            this.GasStationGroupBox.Controls.Add(this.SwitchRadioButtonPanel);
            this.GasStationGroupBox.Controls.Add(this.GasPriceTextBox);
            this.GasStationGroupBox.Controls.Add(this.GasPriceLabel);
            this.GasStationGroupBox.Controls.Add(this.GasListComboBox);
            this.GasStationGroupBox.Controls.Add(this.GasLabel);
            this.GasStationGroupBox.Location = new System.Drawing.Point(4, 3);
            this.GasStationGroupBox.Name = "GasStationGroupBox";
            this.GasStationGroupBox.Size = new System.Drawing.Size(223, 250);
            this.GasStationGroupBox.TabIndex = 1;
            this.GasStationGroupBox.TabStop = false;
            this.GasStationGroupBox.Text = "Автозаправка";
            // 
            // GasSumGroupBox
            // 
            this.GasSumGroupBox.Controls.Add(this.GasSumGrnLabel);
            this.GasSumGroupBox.Controls.Add(this.GasSumNumLabel);
            this.GasSumGroupBox.Location = new System.Drawing.Point(7, 144);
            this.GasSumGroupBox.Name = "GasSumGroupBox";
            this.GasSumGroupBox.Size = new System.Drawing.Size(210, 100);
            this.GasSumGroupBox.TabIndex = 10;
            this.GasSumGroupBox.TabStop = false;
            this.GasSumGroupBox.Text = "К оплате:";
            // 
            // GasSumGrnLabel
            // 
            this.GasSumGrnLabel.AutoSize = true;
            this.GasSumGrnLabel.Location = new System.Drawing.Point(177, 61);
            this.GasSumGrnLabel.Name = "GasSumGrnLabel";
            this.GasSumGrnLabel.Size = new System.Drawing.Size(27, 13);
            this.GasSumGrnLabel.TabIndex = 11;
            this.GasSumGrnLabel.Text = "грн.";
            // 
            // GasSumNumLabel
            // 
            this.GasSumNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GasSumNumLabel.Location = new System.Drawing.Point(0, 28);
            this.GasSumNumLabel.Name = "GasSumNumLabel";
            this.GasSumNumLabel.Size = new System.Drawing.Size(173, 55);
            this.GasSumNumLabel.TabIndex = 0;
            this.GasSumNumLabel.Text = "0.00";
            // 
            // CountlitersLabel
            // 
            this.CountlitersLabel.AutoSize = true;
            this.CountlitersLabel.Location = new System.Drawing.Point(186, 95);
            this.CountlitersLabel.Name = "CountlitersLabel";
            this.CountlitersLabel.Size = new System.Drawing.Size(16, 13);
            this.CountlitersLabel.TabIndex = 9;
            this.CountlitersLabel.Text = "л.";
            // 
            // PriseGrnLabel2
            // 
            this.PriseGrnLabel2.AutoSize = true;
            this.PriseGrnLabel2.Location = new System.Drawing.Point(186, 116);
            this.PriseGrnLabel2.Name = "PriseGrnLabel2";
            this.PriseGrnLabel2.Size = new System.Drawing.Size(27, 13);
            this.PriseGrnLabel2.TabIndex = 8;
            this.PriseGrnLabel2.Text = "грн.";
            // 
            // PriseGrnLabel1
            // 
            this.PriseGrnLabel1.AutoSize = true;
            this.PriseGrnLabel1.Location = new System.Drawing.Point(186, 60);
            this.PriseGrnLabel1.Name = "PriseGrnLabel1";
            this.PriseGrnLabel1.Size = new System.Drawing.Size(27, 13);
            this.PriseGrnLabel1.TabIndex = 7;
            this.PriseGrnLabel1.Text = "грн.";
            // 
            // SumTextBox
            // 
            this.SumTextBox.Enabled = false;
            this.SumTextBox.Location = new System.Drawing.Point(100, 113);
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.Size = new System.Drawing.Size(80, 20);
            this.SumTextBox.TabIndex = 6;
            // 
            // LitersCountTextBox
            // 
            this.LitersCountTextBox.Location = new System.Drawing.Point(100, 91);
            this.LitersCountTextBox.Name = "LitersCountTextBox";
            this.LitersCountTextBox.Size = new System.Drawing.Size(80, 20);
            this.LitersCountTextBox.TabIndex = 5;
            this.LitersCountTextBox.Text = "10,00";
            this.LitersCountTextBox.TextChanged += new System.EventHandler(this.LitersCountTextBox_TextChanged);
            // 
            // SwitchRadioButtonPanel
            // 
            this.SwitchRadioButtonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SwitchRadioButtonPanel.Controls.Add(this.SumRadioButton);
            this.SwitchRadioButtonPanel.Controls.Add(this.CountRadioButton);
            this.SwitchRadioButtonPanel.Location = new System.Drawing.Point(6, 87);
            this.SwitchRadioButtonPanel.Name = "SwitchRadioButtonPanel";
            this.SwitchRadioButtonPanel.Size = new System.Drawing.Size(90, 50);
            this.SwitchRadioButtonPanel.TabIndex = 4;
            // 
            // SumRadioButton
            // 
            this.SumRadioButton.AutoSize = true;
            this.SumRadioButton.Location = new System.Drawing.Point(3, 26);
            this.SumRadioButton.Name = "SumRadioButton";
            this.SumRadioButton.Size = new System.Drawing.Size(59, 17);
            this.SumRadioButton.TabIndex = 1;
            this.SumRadioButton.Text = "Сумма";
            this.SumRadioButton.UseVisualStyleBackColor = true;
            this.SumRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // CountRadioButton
            // 
            this.CountRadioButton.AutoSize = true;
            this.CountRadioButton.Checked = true;
            this.CountRadioButton.Location = new System.Drawing.Point(3, 3);
            this.CountRadioButton.Name = "CountRadioButton";
            this.CountRadioButton.Size = new System.Drawing.Size(84, 17);
            this.CountRadioButton.TabIndex = 0;
            this.CountRadioButton.TabStop = true;
            this.CountRadioButton.Text = "Количество";
            this.CountRadioButton.UseVisualStyleBackColor = true;
            this.CountRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // GasPriceTextBox
            // 
            this.GasPriceTextBox.Location = new System.Drawing.Point(59, 57);
            this.GasPriceTextBox.Name = "GasPriceTextBox";
            this.GasPriceTextBox.ReadOnly = true;
            this.GasPriceTextBox.Size = new System.Drawing.Size(121, 20);
            this.GasPriceTextBox.TabIndex = 3;
            // 
            // GasPriceLabel
            // 
            this.GasPriceLabel.AutoSize = true;
            this.GasPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GasPriceLabel.Location = new System.Drawing.Point(7, 60);
            this.GasPriceLabel.Name = "GasPriceLabel";
            this.GasPriceLabel.Size = new System.Drawing.Size(39, 13);
            this.GasPriceLabel.TabIndex = 2;
            this.GasPriceLabel.Text = "Цена: ";
            // 
            // GasListComboBox
            // 
            this.GasListComboBox.FormattingEnabled = true;
            this.GasListComboBox.Location = new System.Drawing.Point(59, 30);
            this.GasListComboBox.Name = "GasListComboBox";
            this.GasListComboBox.Size = new System.Drawing.Size(121, 21);
            this.GasListComboBox.TabIndex = 1;
            this.GasListComboBox.SelectedValueChanged += new System.EventHandler(this.GasListComboBox_SelectedValueChanged);
            // 
            // GasLabel
            // 
            this.GasLabel.AutoSize = true;
            this.GasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GasLabel.Location = new System.Drawing.Point(7, 30);
            this.GasLabel.Name = "GasLabel";
            this.GasLabel.Size = new System.Drawing.Size(47, 13);
            this.GasLabel.TabIndex = 0;
            this.GasLabel.Text = "Бензин:";
            // 
            // GasControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GasStationGroupBox);
            this.Name = "GasControl";
            this.Size = new System.Drawing.Size(233, 258);
            this.GasStationGroupBox.ResumeLayout(false);
            this.GasStationGroupBox.PerformLayout();
            this.GasSumGroupBox.ResumeLayout(false);
            this.GasSumGroupBox.PerformLayout();
            this.SwitchRadioButtonPanel.ResumeLayout(false);
            this.SwitchRadioButtonPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GasStationGroupBox;
        private System.Windows.Forms.GroupBox GasSumGroupBox;
        private System.Windows.Forms.Label GasSumGrnLabel;
        private System.Windows.Forms.Label GasSumNumLabel;
        private System.Windows.Forms.Label CountlitersLabel;
        private System.Windows.Forms.Label PriseGrnLabel2;
        private System.Windows.Forms.Label PriseGrnLabel1;
        private System.Windows.Forms.TextBox SumTextBox;
        private System.Windows.Forms.TextBox LitersCountTextBox;
        private System.Windows.Forms.Panel SwitchRadioButtonPanel;
        private System.Windows.Forms.RadioButton SumRadioButton;
        private System.Windows.Forms.RadioButton CountRadioButton;
        private System.Windows.Forms.TextBox GasPriceTextBox;
        private System.Windows.Forms.Label GasPriceLabel;
        private System.Windows.Forms.ComboBox GasListComboBox;
        private System.Windows.Forms.Label GasLabel;
    }
}
