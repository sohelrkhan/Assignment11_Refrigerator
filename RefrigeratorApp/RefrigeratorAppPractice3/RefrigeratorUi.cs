using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorAppPractice3
{
    public partial class RefrigeratorUi : Form
    {
        Refrigerator refrigerator = new Refrigerator();
        public RefrigeratorUi()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            refrigerator.MaximumWeight = Convert.ToInt32(maxWeightTakeTextBox.Text);
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            refrigerator.NoOfItems = Convert.ToInt32(itemTextBox.Text);
            refrigerator.UnitOfWeight = Convert.ToInt32(weightTextBox.Text);


            int currentWeight = refrigerator.GetCurrentWeight();
            currentWeightTextBox.Text = currentWeight.ToString();

            int remainingWeight = refrigerator.GetRemainingWeight();
            remainingWeightTextBox.Text = remainingWeight.ToString();

        }
    }
}
