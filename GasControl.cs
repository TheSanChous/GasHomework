using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class GasControl : UserControl
    {

        enum CountingTypeRadioButton
        {
            Liters,
            Summ
        }

        CountingTypeRadioButton countingTypeRadioButton;

        public GasControl()
        {
            InitializeComponent();
            GasListComboBox.Items.AddRange(GasInfo.GetGasInfos().ToArray());
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CountRadioButton.Checked)
            {
                countingTypeRadioButton = CountingTypeRadioButton.Liters;
                LitersCountTextBox.Enabled = true;
                SumTextBox.Enabled = false;
            }
            else
            {
                countingTypeRadioButton = CountingTypeRadioButton.Summ;
                LitersCountTextBox.Enabled = false;
                SumTextBox.Enabled = true;
            }
            CalculateGasSum();
        }

        private void GasListComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            GasPriceTextBox.Text = ((GasInfo)GasListComboBox.SelectedItem).Price.ToString();
            CalculateGasSum();
        }

        private void CalculateGasSum()
        {
            if (GasListComboBox.SelectedItem == null) return;
            if (countingTypeRadioButton == CountingTypeRadioButton.Liters)
            {
                GasSumNumLabel.Text = (decimal.Parse(LitersCountTextBox.Text) * decimal.Parse(GasPriceTextBox.Text)).ToString();
            }
        }

        private void LitersCountTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateGasSum();
        }
    }
}
