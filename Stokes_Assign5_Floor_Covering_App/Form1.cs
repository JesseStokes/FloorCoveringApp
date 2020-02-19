using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Jesse Stokes
// 3/31/19
// Floor covering App

namespace Stokes_Assign5_Floor_Covering_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            tbWidthFt.Text = "";
            tbWidthInches.Text = "";
            tbLengthFt.Text = "";
            tbLengthInches.Text = "";
            listBoxCarpet.ClearSelected();
            listBoxHardwood.ClearSelected();
            listBoxLaminate.ClearSelected();
        }

        private void ClearIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxCarpet.ClearSelected();
            listBoxHardwood.ClearSelected();
            listBoxLaminate.ClearSelected();
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            
            float [] fCarpetCost = { 21.95f, 22.95f, 29.95f, 21.95f, 34.95f, 35.95f };
            float [] fHardwoodCost = { 41.95f, 38.95f, 34.95f, 33.95f, 30.95f };
            float[] fLaminateCost = { 19.95f, 15.95f, 17.95f, 21.95f };

            float fCost = 0.00f;
            string sSelection = "";
            double dSqYds = 0.0;

            double dWidthFt;
            double dWidthInches;
            double dLengthFt;
            double dLengthInches;
            
            if(double.TryParse(tbWidthFt.Text, out dWidthFt) == false)
            {
                MessageBox.Show("Enter a valid number!", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(double.TryParse(tbWidthInches.Text, out dWidthInches) == false)
            {
                MessageBox.Show("Enter a valid number!", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (double.TryParse(tbLengthFt.Text, out dLengthFt) == false)
            {
                MessageBox.Show("Enter a valid number!", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (double.TryParse(tbLengthInches.Text, out dLengthInches) == false)
            {
                MessageBox.Show("Enter a valid number!", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            double dWidth = dWidthFt + (dWidthInches / 12);
            double dLength = dLengthFt + (dWidthInches / 12);
            dSqYds = (dWidth * dLength) / 9;
            float fSqYds = Convert.ToSingle(dSqYds);

            

            if (this.listBoxCarpet.SelectedIndex == 0)
            {
                sSelection = listBoxCarpet.SelectedItem.ToString();
                fCost += 21.95f * fSqYds;
            }
            if (this.listBoxCarpet.SelectedIndex == 1)
            {
                sSelection = listBoxCarpet.SelectedItem.ToString();
                fCost += 22.95f * fSqYds;
            }
            if (this.listBoxCarpet.SelectedIndex == 2)
            {
                sSelection = listBoxCarpet.SelectedItem.ToString();
                fCost += 29.95f * fSqYds;
            }
            if (this.listBoxCarpet.SelectedIndex == 3)
            {
                sSelection = listBoxCarpet.SelectedItem.ToString();
                fCost += 21.95f * fSqYds;
            }
            if (this.listBoxCarpet.SelectedIndex == 4)
            {
                sSelection = listBoxCarpet.SelectedItem.ToString();
                fCost += 34.95f * fSqYds;
            }
            if (this.listBoxCarpet.SelectedIndex == 5)
            {
                sSelection = listBoxCarpet.SelectedItem.ToString();
                fCost += 35.95f * fSqYds;
            }
            if (this.listBoxHardwood.SelectedIndex == 0)
            {
                sSelection = listBoxHardwood.SelectedItem.ToString();
                fCost += 41.95f * fSqYds;
            }
            if (this.listBoxHardwood.SelectedIndex == 1)
            {
                sSelection = listBoxHardwood.SelectedItem.ToString();
                fCost += 38.95f * fSqYds;
            }
            if (this.listBoxHardwood.SelectedIndex == 2)
            {
                sSelection = listBoxHardwood.SelectedItem.ToString();
                fCost += 34.95f * fSqYds;
            }
            if (this.listBoxHardwood.SelectedIndex == 3)
            {
                sSelection = listBoxHardwood.SelectedItem.ToString();
                fCost += 33.95f * fSqYds;
            }
            if (this.listBoxHardwood.SelectedIndex == 4)
            {
                sSelection = listBoxHardwood.SelectedItem.ToString();
                fCost += 30.95f * fSqYds;
            }
            if (this.listBoxLaminate.SelectedIndex == 0)
            {
                sSelection = listBoxLaminate.SelectedItem.ToString();
                fCost += 19.95f * fSqYds;
            }
            if (this.listBoxLaminate.SelectedIndex == 1)
            {
                sSelection = listBoxLaminate.SelectedItem.ToString();
                fCost += 15.95f * fSqYds;
            }
            if (this.listBoxLaminate.SelectedIndex == 2)
            {
                sSelection = listBoxLaminate.SelectedItem.ToString();
                fCost += 17.95f * fSqYds;
            }
            if (this.listBoxLaminate.SelectedIndex == 3)
            {
                sSelection = listBoxLaminate.SelectedItem.ToString();
                fCost += 21.95f * fSqYds;
            }
            

            MessageBox.Show("Selection: " + sSelection + "\n" + 
                "Square Yards Needed: " + String.Format("{0:0.##}",dSqYds) + 
                "\n" + "Cost: $" + fCost, "Flooring App");
        }
    }
}
