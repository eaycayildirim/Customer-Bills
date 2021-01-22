
namespace CustomerBills
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalMinutesTextbox = new System.Windows.Forms.TextBox();
            this.totalTextsTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totalBillLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.addTariffButton = new System.Windows.Forms.Button();
            this.customerTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Minutes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Texts:";
            // 
            // totalMinutesTextbox
            // 
            this.totalMinutesTextbox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalMinutesTextbox.Location = new System.Drawing.Point(189, 94);
            this.totalMinutesTextbox.Name = "totalMinutesTextbox";
            this.totalMinutesTextbox.Size = new System.Drawing.Size(129, 25);
            this.totalMinutesTextbox.TabIndex = 6;
            // 
            // totalTextsTextbox
            // 
            this.totalTextsTextbox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalTextsTextbox.Location = new System.Drawing.Point(189, 142);
            this.totalTextsTextbox.Name = "totalTextsTextbox";
            this.totalTextsTextbox.Size = new System.Drawing.Size(129, 25);
            this.totalTextsTextbox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(24, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Bill:";
            // 
            // totalBillLabel
            // 
            this.totalBillLabel.AutoSize = true;
            this.totalBillLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalBillLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.totalBillLabel.Location = new System.Drawing.Point(248, 266);
            this.totalBillLabel.Name = "totalBillLabel";
            this.totalBillLabel.Size = new System.Drawing.Size(13, 18);
            this.totalBillLabel.TabIndex = 9;
            this.totalBillLabel.Text = "-";
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calculateButton.Location = new System.Drawing.Point(24, 188);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(129, 37);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "CALCULATE";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clearButton.Location = new System.Drawing.Point(189, 188);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(129, 37);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // addTariffButton
            // 
            this.addTariffButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addTariffButton.Location = new System.Drawing.Point(345, 26);
            this.addTariffButton.Name = "addTariffButton";
            this.addTariffButton.Size = new System.Drawing.Size(116, 38);
            this.addTariffButton.TabIndex = 12;
            this.addTariffButton.Text = "ADD TARIFF";
            this.addTariffButton.UseVisualStyleBackColor = true;
            this.addTariffButton.Click += new System.EventHandler(this.addTariffButton_Click);
            // 
            // customerTypeComboBox
            // 
            this.customerTypeComboBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerTypeComboBox.FormattingEnabled = true;
            this.customerTypeComboBox.Items.AddRange(new object[] {
            "Gold",
            "Silver",
            "Bronze"});
            this.customerTypeComboBox.Location = new System.Drawing.Point(189, 35);
            this.customerTypeComboBox.Name = "customerTypeComboBox";
            this.customerTypeComboBox.Size = new System.Drawing.Size(129, 26);
            this.customerTypeComboBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(484, 322);
            this.Controls.Add(this.customerTypeComboBox);
            this.Controls.Add(this.addTariffButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalBillLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalTextsTextbox);
            this.Controls.Add(this.totalMinutesTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculate Bills";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totalMinutesTextbox;
        private System.Windows.Forms.TextBox totalTextsTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalBillLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button addTariffButton;
        private System.Windows.Forms.ComboBox customerTypeComboBox;
    }
}

