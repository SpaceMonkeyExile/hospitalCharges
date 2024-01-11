namespace hospitalCharges
{
    partial class hospitalCharges
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
            this.hospitalStaylabel = new System.Windows.Forms.Label();
            this.medicationAmountLabel = new System.Windows.Forms.Label();
            this.surgicalAmountLabel = new System.Windows.Forms.Label();
            this.labAmountLabel = new System.Windows.Forms.Label();
            this.rehabAmountLabel = new System.Windows.Forms.Label();
            this.totalStayLabel = new System.Windows.Forms.Label();
            this.hospitalStayTextbox = new System.Windows.Forms.TextBox();
            this.medicationAmountTextbox = new System.Windows.Forms.TextBox();
            this.surgicalAmountTextbox = new System.Windows.Forms.TextBox();
            this.labAmountTextbox = new System.Windows.Forms.TextBox();
            this.rehabAmountTextbox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.totalStayOutputLable = new System.Windows.Forms.Label();
            this.totalOtherOutputLabel = new System.Windows.Forms.Label();
            this.totalCostOutputLabel = new System.Windows.Forms.Label();
            this.otherTotalLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hospitalStaylabel
            // 
            this.hospitalStaylabel.AutoSize = true;
            this.hospitalStaylabel.Location = new System.Drawing.Point(13, 17);
            this.hospitalStaylabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hospitalStaylabel.Name = "hospitalStaylabel";
            this.hospitalStaylabel.Size = new System.Drawing.Size(211, 18);
            this.hospitalStaylabel.TabIndex = 11;
            this.hospitalStaylabel.Text = "Number of days in the hospital:";
            // 
            // medicationAmountLabel
            // 
            this.medicationAmountLabel.AutoSize = true;
            this.medicationAmountLabel.Location = new System.Drawing.Point(13, 49);
            this.medicationAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.medicationAmountLabel.Name = "medicationAmountLabel";
            this.medicationAmountLabel.Size = new System.Drawing.Size(237, 18);
            this.medicationAmountLabel.TabIndex = 12;
            this.medicationAmountLabel.Text = "Amount of medication charges:    $";
            // 
            // surgicalAmountLabel
            // 
            this.surgicalAmountLabel.AutoSize = true;
            this.surgicalAmountLabel.Location = new System.Drawing.Point(13, 83);
            this.surgicalAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surgicalAmountLabel.Name = "surgicalAmountLabel";
            this.surgicalAmountLabel.Size = new System.Drawing.Size(236, 18);
            this.surgicalAmountLabel.TabIndex = 13;
            this.surgicalAmountLabel.Text = "Amount of surgical charges:         $";
            // 
            // labAmountLabel
            // 
            this.labAmountLabel.AutoSize = true;
            this.labAmountLabel.Location = new System.Drawing.Point(12, 114);
            this.labAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labAmountLabel.Name = "labAmountLabel";
            this.labAmountLabel.Size = new System.Drawing.Size(237, 18);
            this.labAmountLabel.TabIndex = 14;
            this.labAmountLabel.Text = "Amount of Lab charges:                $";
            // 
            // rehabAmountLabel
            // 
            this.rehabAmountLabel.AutoSize = true;
            this.rehabAmountLabel.Location = new System.Drawing.Point(10, 149);
            this.rehabAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rehabAmountLabel.Name = "rehabAmountLabel";
            this.rehabAmountLabel.Size = new System.Drawing.Size(239, 18);
            this.rehabAmountLabel.TabIndex = 15;
            this.rehabAmountLabel.Text = "Amount of rehabilitation charges:  $";
            // 
            // totalStayLabel
            // 
            this.totalStayLabel.AutoSize = true;
            this.totalStayLabel.Location = new System.Drawing.Point(13, 193);
            this.totalStayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalStayLabel.Name = "totalStayLabel";
            this.totalStayLabel.Size = new System.Drawing.Size(171, 18);
            this.totalStayLabel.TabIndex = 16;
            this.totalStayLabel.Text = "Cost of the hospital stay:";
            // 
            // hospitalStayTextbox
            // 
            this.hospitalStayTextbox.Location = new System.Drawing.Point(253, 11);
            this.hospitalStayTextbox.Name = "hospitalStayTextbox";
            this.hospitalStayTextbox.Size = new System.Drawing.Size(100, 24);
            this.hospitalStayTextbox.TabIndex = 0;
            this.hospitalStayTextbox.Text = "0";
            // 
            // medicationAmountTextbox
            // 
            this.medicationAmountTextbox.Location = new System.Drawing.Point(253, 43);
            this.medicationAmountTextbox.Name = "medicationAmountTextbox";
            this.medicationAmountTextbox.Size = new System.Drawing.Size(100, 24);
            this.medicationAmountTextbox.TabIndex = 1;
            this.medicationAmountTextbox.Text = "0";
            // 
            // surgicalAmountTextbox
            // 
            this.surgicalAmountTextbox.Location = new System.Drawing.Point(253, 77);
            this.surgicalAmountTextbox.Name = "surgicalAmountTextbox";
            this.surgicalAmountTextbox.Size = new System.Drawing.Size(100, 24);
            this.surgicalAmountTextbox.TabIndex = 2;
            this.surgicalAmountTextbox.Text = "0";
            // 
            // labAmountTextbox
            // 
            this.labAmountTextbox.Location = new System.Drawing.Point(253, 111);
            this.labAmountTextbox.Name = "labAmountTextbox";
            this.labAmountTextbox.Size = new System.Drawing.Size(100, 24);
            this.labAmountTextbox.TabIndex = 3;
            this.labAmountTextbox.Text = "0";
            // 
            // rehabAmountTextbox
            // 
            this.rehabAmountTextbox.Location = new System.Drawing.Point(253, 143);
            this.rehabAmountTextbox.Name = "rehabAmountTextbox";
            this.rehabAmountTextbox.Size = new System.Drawing.Size(100, 24);
            this.rehabAmountTextbox.TabIndex = 4;
            this.rehabAmountTextbox.Text = "0";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(57, 301);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(81, 30);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(215, 301);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 29);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(359, 7);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(36, 36);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "&X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // totalStayOutputLable
            // 
            this.totalStayOutputLable.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.totalStayOutputLable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalStayOutputLable.Location = new System.Drawing.Point(243, 193);
            this.totalStayOutputLable.Name = "totalStayOutputLable";
            this.totalStayOutputLable.Size = new System.Drawing.Size(110, 19);
            this.totalStayOutputLable.TabIndex = 8;
            this.totalStayOutputLable.Text = "$0.00";
            // 
            // totalOtherOutputLabel
            // 
            this.totalOtherOutputLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.totalOtherOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalOtherOutputLabel.Location = new System.Drawing.Point(243, 226);
            this.totalOtherOutputLabel.Name = "totalOtherOutputLabel";
            this.totalOtherOutputLabel.Size = new System.Drawing.Size(110, 19);
            this.totalOtherOutputLabel.TabIndex = 9;
            this.totalOtherOutputLabel.Text = "$0.00";
            // 
            // totalCostOutputLabel
            // 
            this.totalCostOutputLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.totalCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalCostOutputLabel.Location = new System.Drawing.Point(243, 258);
            this.totalCostOutputLabel.Name = "totalCostOutputLabel";
            this.totalCostOutputLabel.Size = new System.Drawing.Size(110, 19);
            this.totalCostOutputLabel.TabIndex = 10;
            this.totalCostOutputLabel.Text = "$0.00";
            // 
            // otherTotalLabel
            // 
            this.otherTotalLabel.AutoSize = true;
            this.otherTotalLabel.Location = new System.Drawing.Point(13, 226);
            this.otherTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.otherTotalLabel.Name = "otherTotalLabel";
            this.otherTotalLabel.Size = new System.Drawing.Size(106, 18);
            this.otherTotalLabel.TabIndex = 17;
            this.otherTotalLabel.Text = "Other charges:";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(13, 258);
            this.totalCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(78, 18);
            this.totalCostLabel.TabIndex = 18;
            this.totalCostLabel.Text = "Total cost:";
            // 
            // hospitalCharges
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearButton;
            this.ClientSize = new System.Drawing.Size(398, 354);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.otherTotalLabel);
            this.Controls.Add(this.totalCostOutputLabel);
            this.Controls.Add(this.totalOtherOutputLabel);
            this.Controls.Add(this.totalStayOutputLable);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.rehabAmountTextbox);
            this.Controls.Add(this.labAmountTextbox);
            this.Controls.Add(this.surgicalAmountTextbox);
            this.Controls.Add(this.medicationAmountTextbox);
            this.Controls.Add(this.hospitalStayTextbox);
            this.Controls.Add(this.totalStayLabel);
            this.Controls.Add(this.rehabAmountLabel);
            this.Controls.Add(this.labAmountLabel);
            this.Controls.Add(this.surgicalAmountLabel);
            this.Controls.Add(this.medicationAmountLabel);
            this.Controls.Add(this.hospitalStaylabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "hospitalCharges";
            this.Text = "Hospital Charges";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hospitalStaylabel;
        private System.Windows.Forms.Label medicationAmountLabel;
        private System.Windows.Forms.Label surgicalAmountLabel;
        private System.Windows.Forms.Label labAmountLabel;
        private System.Windows.Forms.Label rehabAmountLabel;
        private System.Windows.Forms.Label totalStayLabel;
        private System.Windows.Forms.TextBox hospitalStayTextbox;
        private System.Windows.Forms.TextBox medicationAmountTextbox;
        private System.Windows.Forms.TextBox surgicalAmountTextbox;
        private System.Windows.Forms.TextBox labAmountTextbox;
        private System.Windows.Forms.TextBox rehabAmountTextbox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label totalStayOutputLable;
        private System.Windows.Forms.Label totalOtherOutputLabel;
        private System.Windows.Forms.Label totalCostOutputLabel;
        private System.Windows.Forms.Label otherTotalLabel;
        private System.Windows.Forms.Label totalCostLabel;
    }
}

