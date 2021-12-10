
namespace Module11Project
{
    partial class frmXmenFirstClass
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
            this.btnByte = new System.Windows.Forms.Button();
            this.btnShort = new System.Windows.Forms.Button();
            this.btnInt = new System.Windows.Forms.Button();
            this.btnLong = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnFloat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtRightOperand = new System.Windows.Forms.TextBox();
            this.txtLeftOperand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLeftOperand = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radiobtnAdd = new System.Windows.Forms.RadioButton();
            this.radiobtnSubtract = new System.Windows.Forms.RadioButton();
            this.radiobtnMultiply = new System.Windows.Forms.RadioButton();
            this.radiobtnDivide = new System.Windows.Forms.RadioButton();
            this.radiobtnModulus = new System.Windows.Forms.RadioButton();
            this.btnCompute = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnByte
            // 
            this.btnByte.BackColor = System.Drawing.Color.AliceBlue;
            this.btnByte.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnByte.Location = new System.Drawing.Point(36, 42);
            this.btnByte.Name = "btnByte";
            this.btnByte.Size = new System.Drawing.Size(118, 60);
            this.btnByte.TabIndex = 0;
            this.btnByte.Text = "&Byte";
            this.btnByte.UseVisualStyleBackColor = false;
            // 
            // btnShort
            // 
            this.btnShort.BackColor = System.Drawing.Color.AliceBlue;
            this.btnShort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnShort.Location = new System.Drawing.Point(36, 240);
            this.btnShort.Name = "btnShort";
            this.btnShort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnShort.Size = new System.Drawing.Size(118, 60);
            this.btnShort.TabIndex = 3;
            this.btnShort.Text = "&Short";
            this.btnShort.UseVisualStyleBackColor = false;
            // 
            // btnInt
            // 
            this.btnInt.BackColor = System.Drawing.Color.AliceBlue;
            this.btnInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnInt.Location = new System.Drawing.Point(36, 108);
            this.btnInt.Name = "btnInt";
            this.btnInt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnInt.Size = new System.Drawing.Size(118, 60);
            this.btnInt.TabIndex = 1;
            this.btnInt.Text = "&Int";
            this.btnInt.UseVisualStyleBackColor = false;
            // 
            // btnLong
            // 
            this.btnLong.BackColor = System.Drawing.Color.AliceBlue;
            this.btnLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnLong.Location = new System.Drawing.Point(36, 174);
            this.btnLong.Name = "btnLong";
            this.btnLong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLong.Size = new System.Drawing.Size(118, 60);
            this.btnLong.TabIndex = 2;
            this.btnLong.Text = "&Long";
            this.btnLong.UseVisualStyleBackColor = false;
            this.btnLong.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnDouble.Location = new System.Drawing.Point(662, 233);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDouble.Size = new System.Drawing.Size(159, 74);
            this.btnDouble.TabIndex = 6;
            this.btnDouble.Text = "&Double";
            this.btnDouble.UseVisualStyleBackColor = false;
            // 
            // btnDecimal
            // 
            this.btnDecimal.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnDecimal.Location = new System.Drawing.Point(662, 134);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDecimal.Size = new System.Drawing.Size(159, 74);
            this.btnDecimal.TabIndex = 5;
            this.btnDecimal.Text = "&Decimal";
            this.btnDecimal.UseVisualStyleBackColor = false;
            // 
            // btnFloat
            // 
            this.btnFloat.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnFloat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnFloat.Location = new System.Drawing.Point(662, 42);
            this.btnFloat.Name = "btnFloat";
            this.btnFloat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFloat.Size = new System.Drawing.Size(159, 74);
            this.btnFloat.TabIndex = 4;
            this.btnFloat.Text = "&Float";
            this.btnFloat.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Location = new System.Drawing.Point(514, 552);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 80);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnExit.Location = new System.Drawing.Point(178, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExit.Size = new System.Drawing.Size(118, 55);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnClear.Location = new System.Drawing.Point(24, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClear.Size = new System.Drawing.Size(118, 55);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtRightOperand
            // 
            this.txtRightOperand.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtRightOperand.Location = new System.Drawing.Point(254, 575);
            this.txtRightOperand.Name = "txtRightOperand";
            this.txtRightOperand.Size = new System.Drawing.Size(179, 44);
            this.txtRightOperand.TabIndex = 8;
            // 
            // txtLeftOperand
            // 
            this.txtLeftOperand.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtLeftOperand.Location = new System.Drawing.Point(36, 575);
            this.txtLeftOperand.Name = "txtLeftOperand";
            this.txtLeftOperand.Size = new System.Drawing.Size(179, 44);
            this.txtLeftOperand.TabIndex = 7;
            this.txtLeftOperand.TextChanged += new System.EventHandler(this.txtLeftOperand_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(263, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Right Operand";
            // 
            // lblLeftOperand
            // 
            this.lblLeftOperand.AutoSize = true;
            this.lblLeftOperand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLeftOperand.Location = new System.Drawing.Point(48, 516);
            this.lblLeftOperand.Name = "lblLeftOperand";
            this.lblLeftOperand.Size = new System.Drawing.Size(153, 29);
            this.lblLeftOperand.TabIndex = 12;
            this.lblLeftOperand.Text = "Left Operand";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCompute);
            this.groupBox2.Controls.Add(this.radiobtnModulus);
            this.groupBox2.Controls.Add(this.radiobtnDivide);
            this.groupBox2.Controls.Add(this.radiobtnMultiply);
            this.groupBox2.Controls.Add(this.radiobtnSubtract);
            this.groupBox2.Controls.Add(this.radiobtnAdd);
            this.groupBox2.Location = new System.Drawing.Point(293, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 266);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // radiobtnAdd
            // 
            this.radiobtnAdd.AutoSize = true;
            this.radiobtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radiobtnAdd.Location = new System.Drawing.Point(50, 27);
            this.radiobtnAdd.Name = "radiobtnAdd";
            this.radiobtnAdd.Size = new System.Drawing.Size(111, 33);
            this.radiobtnAdd.TabIndex = 9;
            this.radiobtnAdd.TabStop = true;
            this.radiobtnAdd.Text = "Add(+)";
            this.radiobtnAdd.UseVisualStyleBackColor = true;
            this.radiobtnAdd.CheckedChanged += new System.EventHandler(this.btnAdd_CheckedChanged);
            // 
            // radiobtnSubtract
            // 
            this.radiobtnSubtract.AutoSize = true;
            this.radiobtnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radiobtnSubtract.Location = new System.Drawing.Point(50, 66);
            this.radiobtnSubtract.Name = "radiobtnSubtract";
            this.radiobtnSubtract.Size = new System.Drawing.Size(150, 33);
            this.radiobtnSubtract.TabIndex = 10;
            this.radiobtnSubtract.TabStop = true;
            this.radiobtnSubtract.Text = "Subtract(-)";
            this.radiobtnSubtract.UseVisualStyleBackColor = true;
            // 
            // radiobtnMultiply
            // 
            this.radiobtnMultiply.AutoSize = true;
            this.radiobtnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radiobtnMultiply.Location = new System.Drawing.Point(50, 141);
            this.radiobtnMultiply.Name = "radiobtnMultiply";
            this.radiobtnMultiply.Size = new System.Drawing.Size(146, 33);
            this.radiobtnMultiply.TabIndex = 12;
            this.radiobtnMultiply.TabStop = true;
            this.radiobtnMultiply.Text = "Multiply(*)";
            this.radiobtnMultiply.UseVisualStyleBackColor = true;
            // 
            // radiobtnDivide
            // 
            this.radiobtnDivide.AutoSize = true;
            this.radiobtnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radiobtnDivide.Location = new System.Drawing.Point(50, 103);
            this.radiobtnDivide.Name = "radiobtnDivide";
            this.radiobtnDivide.Size = new System.Drawing.Size(129, 33);
            this.radiobtnDivide.TabIndex = 11;
            this.radiobtnDivide.TabStop = true;
            this.radiobtnDivide.Text = "Divide(/)";
            this.radiobtnDivide.UseVisualStyleBackColor = true;
            // 
            // radiobtnModulus
            // 
            this.radiobtnModulus.AutoSize = true;
            this.radiobtnModulus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radiobtnModulus.Location = new System.Drawing.Point(48, 180);
            this.radiobtnModulus.Name = "radiobtnModulus";
            this.radiobtnModulus.Size = new System.Drawing.Size(168, 33);
            this.radiobtnModulus.TabIndex = 13;
            this.radiobtnModulus.TabStop = true;
            this.radiobtnModulus.Text = "Modulus(%)";
            this.radiobtnModulus.UseVisualStyleBackColor = true;
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.Color.Thistle;
            this.btnCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCompute.Location = new System.Drawing.Point(48, 214);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(166, 41);
            this.btnCompute.TabIndex = 14;
            this.btnCompute.Text = "COMPUTE";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // lblResults
            // 
            this.lblResults.BackColor = System.Drawing.Color.Cyan;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblResults.Location = new System.Drawing.Point(177, 329);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(512, 160);
            this.lblResults.TabIndex = 16;
            this.lblResults.Text = "Click a Button";
            this.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmXmenFirstClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(847, 658);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblLeftOperand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLeftOperand);
            this.Controls.Add(this.txtRightOperand);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnFloat);
            this.Controls.Add(this.btnLong);
            this.Controls.Add(this.btnInt);
            this.Controls.Add(this.btnShort);
            this.Controls.Add(this.btnByte);
            this.Name = "frmXmenFirstClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classes Commence";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnByte;
        private System.Windows.Forms.Button btnShort;
        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnLong;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnFloat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtRightOperand;
        private System.Windows.Forms.TextBox txtLeftOperand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLeftOperand;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.RadioButton radiobtnModulus;
        private System.Windows.Forms.RadioButton radiobtnDivide;
        private System.Windows.Forms.RadioButton radiobtnMultiply;
        private System.Windows.Forms.RadioButton radiobtnSubtract;
        private System.Windows.Forms.RadioButton radiobtnAdd;
        private System.Windows.Forms.Label lblResults;
    }
}

