namespace Stokes_Assign5_Floor_Covering_App
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCarpet = new System.Windows.Forms.TabPage();
            this.listBoxCarpet = new System.Windows.Forms.ListBox();
            this.lbCarpet = new System.Windows.Forms.Label();
            this.tpHardwood = new System.Windows.Forms.TabPage();
            this.listBoxHardwood = new System.Windows.Forms.ListBox();
            this.lbHardwood = new System.Windows.Forms.Label();
            this.tpLaminate = new System.Windows.Forms.TabPage();
            this.listBoxLaminate = new System.Windows.Forms.ListBox();
            this.lbLaminate = new System.Windows.Forms.Label();
            this.lbDimensions = new System.Windows.Forms.Label();
            this.lbWidth = new System.Windows.Forms.Label();
            this.lbLength = new System.Windows.Forms.Label();
            this.tbWidthFt = new System.Windows.Forms.TextBox();
            this.tbLengthFt = new System.Windows.Forms.TextBox();
            this.tbWidthInches = new System.Windows.Forms.TextBox();
            this.tbLengthInches = new System.Windows.Forms.TextBox();
            this.lbWidthFT = new System.Windows.Forms.Label();
            this.lbLengthFT = new System.Windows.Forms.Label();
            this.lbWidthInches = new System.Windows.Forms.Label();
            this.lbLengthInches = new System.Windows.Forms.Label();
            this.btCalculate = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpCarpet.SuspendLayout();
            this.tpHardwood.SuspendLayout();
            this.tpLaminate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpCarpet);
            this.tabControl1.Controls.Add(this.tpHardwood);
            this.tabControl1.Controls.Add(this.tpLaminate);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1311, 505);
            this.tabControl1.TabIndex = 0;
            // 
            // tpCarpet
            // 
            this.tpCarpet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tpCarpet.Controls.Add(this.listBoxCarpet);
            this.tpCarpet.Controls.Add(this.lbCarpet);
            this.tpCarpet.Location = new System.Drawing.Point(10, 55);
            this.tpCarpet.Name = "tpCarpet";
            this.tpCarpet.Padding = new System.Windows.Forms.Padding(3);
            this.tpCarpet.Size = new System.Drawing.Size(1291, 440);
            this.tpCarpet.TabIndex = 1;
            this.tpCarpet.Text = "Carpet";
            // 
            // listBoxCarpet
            // 
            this.listBoxCarpet.FormattingEnabled = true;
            this.listBoxCarpet.ItemHeight = 38;
            this.listBoxCarpet.Items.AddRange(new object[] {
            "Berber - $21.95",
            "Cut Pile  - $22.95",
            "Frieze - $29.95",
            "Loop Pile - $21.95",
            "Plush / Velvet - $34.95",
            "Textured Saxony - $35.95"});
            this.listBoxCarpet.Location = new System.Drawing.Point(416, 216);
            this.listBoxCarpet.Name = "listBoxCarpet";
            this.listBoxCarpet.Size = new System.Drawing.Size(459, 80);
            this.listBoxCarpet.Sorted = true;
            this.listBoxCarpet.TabIndex = 1;
            this.listBoxCarpet.Enter += new System.EventHandler(this.ClearIndex_SelectedIndexChanged);
            // 
            // lbCarpet
            // 
            this.lbCarpet.AutoSize = true;
            this.lbCarpet.Location = new System.Drawing.Point(498, 145);
            this.lbCarpet.Name = "lbCarpet";
            this.lbCarpet.Size = new System.Drawing.Size(241, 39);
            this.lbCarpet.TabIndex = 0;
            this.lbCarpet.Text = "Type of Carpet";
            // 
            // tpHardwood
            // 
            this.tpHardwood.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tpHardwood.Controls.Add(this.listBoxHardwood);
            this.tpHardwood.Controls.Add(this.lbHardwood);
            this.tpHardwood.Location = new System.Drawing.Point(10, 55);
            this.tpHardwood.Name = "tpHardwood";
            this.tpHardwood.Padding = new System.Windows.Forms.Padding(3);
            this.tpHardwood.Size = new System.Drawing.Size(1291, 440);
            this.tpHardwood.TabIndex = 0;
            this.tpHardwood.Text = "Hardwood";
            // 
            // listBoxHardwood
            // 
            this.listBoxHardwood.FormattingEnabled = true;
            this.listBoxHardwood.ItemHeight = 38;
            this.listBoxHardwood.Items.AddRange(new object[] {
            "Cherry - $41.95",
            "Maple - $38.95",
            "Oak - $34.95",
            "Pine - $33.95",
            "Walnut - $30.95"});
            this.listBoxHardwood.Location = new System.Drawing.Point(416, 217);
            this.listBoxHardwood.Name = "listBoxHardwood";
            this.listBoxHardwood.Size = new System.Drawing.Size(459, 80);
            this.listBoxHardwood.Sorted = true;
            this.listBoxHardwood.TabIndex = 1;
            this.listBoxHardwood.Enter += new System.EventHandler(this.ClearIndex_SelectedIndexChanged);
            // 
            // lbHardwood
            // 
            this.lbHardwood.AutoSize = true;
            this.lbHardwood.Location = new System.Drawing.Point(498, 143);
            this.lbHardwood.Name = "lbHardwood";
            this.lbHardwood.Size = new System.Drawing.Size(295, 39);
            this.lbHardwood.TabIndex = 0;
            this.lbHardwood.Text = "Type of Hardwood";
            // 
            // tpLaminate
            // 
            this.tpLaminate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tpLaminate.Controls.Add(this.listBoxLaminate);
            this.tpLaminate.Controls.Add(this.lbLaminate);
            this.tpLaminate.Location = new System.Drawing.Point(10, 55);
            this.tpLaminate.Name = "tpLaminate";
            this.tpLaminate.Size = new System.Drawing.Size(1291, 440);
            this.tpLaminate.TabIndex = 2;
            this.tpLaminate.Text = "Laminate";
            // 
            // listBoxLaminate
            // 
            this.listBoxLaminate.FormattingEnabled = true;
            this.listBoxLaminate.ItemHeight = 38;
            this.listBoxLaminate.Items.AddRange(new object[] {
            "Hardwood Look - $19.95",
            "Smooth - $15.95",
            "Textured - $17.95",
            "Tiled Look - $21.95"});
            this.listBoxLaminate.Location = new System.Drawing.Point(392, 218);
            this.listBoxLaminate.Name = "listBoxLaminate";
            this.listBoxLaminate.Size = new System.Drawing.Size(506, 80);
            this.listBoxLaminate.Sorted = true;
            this.listBoxLaminate.TabIndex = 1;
            this.listBoxLaminate.Enter += new System.EventHandler(this.ClearIndex_SelectedIndexChanged);
            // 
            // lbLaminate
            // 
            this.lbLaminate.AutoSize = true;
            this.lbLaminate.Location = new System.Drawing.Point(506, 143);
            this.lbLaminate.Name = "lbLaminate";
            this.lbLaminate.Size = new System.Drawing.Size(279, 39);
            this.lbLaminate.TabIndex = 0;
            this.lbLaminate.Text = "Type of Laminate";
            // 
            // lbDimensions
            // 
            this.lbDimensions.AutoSize = true;
            this.lbDimensions.Location = new System.Drawing.Point(51, 567);
            this.lbDimensions.Name = "lbDimensions";
            this.lbDimensions.Size = new System.Drawing.Size(246, 32);
            this.lbDimensions.TabIndex = 1;
            this.lbDimensions.Text = "Room Dimensions";
            // 
            // lbWidth
            // 
            this.lbWidth.AutoSize = true;
            this.lbWidth.Location = new System.Drawing.Point(43, 651);
            this.lbWidth.Name = "lbWidth";
            this.lbWidth.Size = new System.Drawing.Size(88, 32);
            this.lbWidth.TabIndex = 2;
            this.lbWidth.Text = "Width";
            // 
            // lbLength
            // 
            this.lbLength.AutoSize = true;
            this.lbLength.Location = new System.Drawing.Point(43, 729);
            this.lbLength.Name = "lbLength";
            this.lbLength.Size = new System.Drawing.Size(103, 32);
            this.lbLength.TabIndex = 3;
            this.lbLength.Text = "Length";
            // 
            // tbWidthFt
            // 
            this.tbWidthFt.Location = new System.Drawing.Point(181, 651);
            this.tbWidthFt.Name = "tbWidthFt";
            this.tbWidthFt.Size = new System.Drawing.Size(100, 38);
            this.tbWidthFt.TabIndex = 4;
            // 
            // tbLengthFt
            // 
            this.tbLengthFt.Location = new System.Drawing.Point(181, 729);
            this.tbLengthFt.Name = "tbLengthFt";
            this.tbLengthFt.Size = new System.Drawing.Size(100, 38);
            this.tbLengthFt.TabIndex = 5;
            // 
            // tbWidthInches
            // 
            this.tbWidthInches.Location = new System.Drawing.Point(349, 651);
            this.tbWidthInches.Name = "tbWidthInches";
            this.tbWidthInches.Size = new System.Drawing.Size(100, 38);
            this.tbWidthInches.TabIndex = 6;
            // 
            // tbLengthInches
            // 
            this.tbLengthInches.Location = new System.Drawing.Point(349, 728);
            this.tbLengthInches.Name = "tbLengthInches";
            this.tbLengthInches.Size = new System.Drawing.Size(100, 38);
            this.tbLengthInches.TabIndex = 7;
            // 
            // lbWidthFT
            // 
            this.lbWidthFT.AutoSize = true;
            this.lbWidthFT.Location = new System.Drawing.Point(288, 651);
            this.lbWidthFT.Name = "lbWidthFT";
            this.lbWidthFT.Size = new System.Drawing.Size(31, 32);
            this.lbWidthFT.TabIndex = 8;
            this.lbWidthFT.Text = "ft";
            // 
            // lbLengthFT
            // 
            this.lbLengthFT.AutoSize = true;
            this.lbLengthFT.Location = new System.Drawing.Point(287, 735);
            this.lbLengthFT.Name = "lbLengthFT";
            this.lbLengthFT.Size = new System.Drawing.Size(31, 32);
            this.lbLengthFT.TabIndex = 9;
            this.lbLengthFT.Text = "ft";
            // 
            // lbWidthInches
            // 
            this.lbWidthInches.AutoSize = true;
            this.lbWidthInches.Location = new System.Drawing.Point(455, 651);
            this.lbWidthInches.Name = "lbWidthInches";
            this.lbWidthInches.Size = new System.Drawing.Size(98, 32);
            this.lbWidthInches.TabIndex = 10;
            this.lbWidthInches.Text = "inches";
            // 
            // lbLengthInches
            // 
            this.lbLengthInches.AutoSize = true;
            this.lbLengthInches.Location = new System.Drawing.Point(456, 734);
            this.lbLengthInches.Name = "lbLengthInches";
            this.lbLengthInches.Size = new System.Drawing.Size(98, 32);
            this.lbLengthInches.TabIndex = 11;
            this.lbLengthInches.Text = "inches";
            // 
            // btCalculate
            // 
            this.btCalculate.Location = new System.Drawing.Point(718, 606);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(290, 89);
            this.btCalculate.TabIndex = 12;
            this.btCalculate.Text = "Calculate Cost";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(718, 735);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(290, 87);
            this.btReset.TabIndex = 13;
            this.btReset.Text = "Reset Selections";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1317, 1002);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btCalculate);
            this.Controls.Add(this.lbLengthInches);
            this.Controls.Add(this.lbWidthInches);
            this.Controls.Add(this.lbLengthFT);
            this.Controls.Add(this.lbWidthFT);
            this.Controls.Add(this.tbLengthInches);
            this.Controls.Add(this.tbWidthInches);
            this.Controls.Add(this.tbLengthFt);
            this.Controls.Add(this.tbWidthFt);
            this.Controls.Add(this.lbLength);
            this.Controls.Add(this.lbWidth);
            this.Controls.Add(this.lbDimensions);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Floor Covering App";
            this.tabControl1.ResumeLayout(false);
            this.tpCarpet.ResumeLayout(false);
            this.tpCarpet.PerformLayout();
            this.tpHardwood.ResumeLayout(false);
            this.tpHardwood.PerformLayout();
            this.tpLaminate.ResumeLayout(false);
            this.tpLaminate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpCarpet;
        private System.Windows.Forms.ListBox listBoxCarpet;
        private System.Windows.Forms.Label lbCarpet;
        private System.Windows.Forms.TabPage tpHardwood;
        private System.Windows.Forms.ListBox listBoxHardwood;
        private System.Windows.Forms.Label lbHardwood;
        private System.Windows.Forms.TabPage tpLaminate;
        private System.Windows.Forms.ListBox listBoxLaminate;
        private System.Windows.Forms.Label lbLaminate;
        private System.Windows.Forms.Label lbDimensions;
        private System.Windows.Forms.Label lbWidth;
        private System.Windows.Forms.Label lbLength;
        private System.Windows.Forms.TextBox tbWidthFt;
        private System.Windows.Forms.TextBox tbLengthFt;
        private System.Windows.Forms.TextBox tbWidthInches;
        private System.Windows.Forms.TextBox tbLengthInches;
        private System.Windows.Forms.Label lbWidthFT;
        private System.Windows.Forms.Label lbLengthFT;
        private System.Windows.Forms.Label lbWidthInches;
        private System.Windows.Forms.Label lbLengthInches;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.Button btReset;
    }
}

