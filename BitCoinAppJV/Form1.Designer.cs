namespace BitCoinAppJV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.currencyselectionBox = new System.Windows.Forms.ComboBox();
            this.btnGetRates = new System.Windows.Forms.Button();
            this.bitcoinamountbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.conversionlabel = new System.Windows.Forms.Label();
            this.conversionresultbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currencyselectionBox
            // 
            this.currencyselectionBox.FormattingEnabled = true;
            this.currencyselectionBox.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP"});
            this.currencyselectionBox.Location = new System.Drawing.Point(92, 259);
            this.currencyselectionBox.Name = "currencyselectionBox";
            this.currencyselectionBox.Size = new System.Drawing.Size(121, 21);
            this.currencyselectionBox.TabIndex = 0;
            this.currencyselectionBox.Text = "Select Currency";
            // 
            // btnGetRates
            // 
            this.btnGetRates.Location = new System.Drawing.Point(92, 369);
            this.btnGetRates.Name = "btnGetRates";
            this.btnGetRates.Size = new System.Drawing.Size(121, 23);
            this.btnGetRates.TabIndex = 1;
            this.btnGetRates.Text = "Calculate Rate";
            this.btnGetRates.UseVisualStyleBackColor = true;
            this.btnGetRates.Click += new System.EventHandler(this.btnGetRates_Click);
            // 
            // bitcoinamountbox
            // 
            this.bitcoinamountbox.Location = new System.Drawing.Point(92, 315);
            this.bitcoinamountbox.Name = "bitcoinamountbox";
            this.bitcoinamountbox.Size = new System.Drawing.Size(121, 20);
            this.bitcoinamountbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(92, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "BitCoin amount";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // conversionlabel
            // 
            this.conversionlabel.AutoSize = true;
            this.conversionlabel.BackColor = System.Drawing.Color.Blue;
            this.conversionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversionlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.conversionlabel.Location = new System.Drawing.Point(326, 247);
            this.conversionlabel.Name = "conversionlabel";
            this.conversionlabel.Size = new System.Drawing.Size(191, 13);
            this.conversionlabel.TabIndex = 4;
            this.conversionlabel.Text = "Conversion Result (AKA stonks):";
            this.conversionlabel.Visible = false;
            // 
            // conversionresultbox
            // 
            this.conversionresultbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversionresultbox.Location = new System.Drawing.Point(280, 263);
            this.conversionresultbox.Name = "conversionresultbox";
            this.conversionresultbox.Size = new System.Drawing.Size(308, 56);
            this.conversionresultbox.TabIndex = 5;
            this.conversionresultbox.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(92, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Click here to find out your net worth:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 421);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.conversionresultbox);
            this.Controls.Add(this.conversionlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bitcoinamountbox);
            this.Controls.Add(this.btnGetRates);
            this.Controls.Add(this.currencyselectionBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "BitCoin Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currencyselectionBox;
        private System.Windows.Forms.Button btnGetRates;
        private System.Windows.Forms.TextBox bitcoinamountbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label conversionlabel;
        private System.Windows.Forms.TextBox conversionresultbox;
        private System.Windows.Forms.Label label3;
    }
}

