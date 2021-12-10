using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module11Project
{
    public partial class frmXmenFirstClass : Form
    {
        public frmXmenFirstClass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResults.Text = " ";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtLeftOperand_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            if (radiobtnAdd.Checked)
            {
                int operand1 = Convert.ToInt32(txtLeftOperand.Text);
                int operand2 = Convert.ToInt32(txtRightOperand.Text);

                lblResults.Text = Convert.ToString(MathFirstClass.sum(operand1, operand2));
            }

            if (radiobtnSubtract.Checked)
            {
                int operand1 = Convert.ToInt32(txtLeftOperand.Text);
                int operand2 = Convert.ToInt32(txtRightOperand.Text);

                lblResults.Text = Convert.ToString(MathFirstClass.sub(operand1, operand2));
            }

            if (radiobtnMultiply.Checked)
            {
                int operand1 = Convert.ToInt32(txtLeftOperand.Text);
                int operand2 = Convert.ToInt32(txtRightOperand.Text);

                lblResults.Text = Convert.ToString(MathFirstClass.mul(operand1, operand2));
            }

            if (radiobtnDivide.Checked)
            {
                int operand1 = Convert.ToInt32(txtLeftOperand.Text);
                int operand2 = Convert.ToInt32(txtRightOperand.Text);

                lblResults.Text = Convert.ToString(MathFirstClass.div(operand1, operand2));
            }

            if (radiobtnModulus.Checked)
            {
                int operand1 = Convert.ToInt32(txtLeftOperand.Text);
                int operand2 = Convert.ToInt32(txtRightOperand.Text);

                lblResults.Text = Convert.ToString(MathFirstClass.mod(operand1, operand2));
            }
        }
    }
}
