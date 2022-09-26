namespace pizzaParlor
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
            this.pizzaLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sliceLabel = new System.Windows.Forms.Label();
            this.subLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.sliceOuput = new System.Windows.Forms.TextBox();
            this.subOutput = new System.Windows.Forms.TextBox();
            this.taxOutput = new System.Windows.Forms.TextBox();
            this.totalOutput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.dealLabel = new System.Windows.Forms.Label();
            this.choiceBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pizzaLabel
            // 
            this.pizzaLabel.AutoSize = true;
            this.pizzaLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pizzaLabel.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pizzaLabel.Location = new System.Drawing.Point(237, 9);
            this.pizzaLabel.Name = "pizzaLabel";
            this.pizzaLabel.Size = new System.Drawing.Size(91, 27);
            this.pizzaLabel.TabIndex = 0;
            this.pizzaLabel.Text = "Pizza π";
            this.pizzaLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pizzaParlor.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(362, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 169);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // sliceLabel
            // 
            this.sliceLabel.AutoSize = true;
            this.sliceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sliceLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sliceLabel.Location = new System.Drawing.Point(12, 51);
            this.sliceLabel.Name = "sliceLabel";
            this.sliceLabel.Size = new System.Drawing.Size(240, 24);
            this.sliceLabel.TabIndex = 2;
            this.sliceLabel.Text = "Number of Slices ($3.14)";
            // 
            // subLabel
            // 
            this.subLabel.AutoSize = true;
            this.subLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subLabel.Location = new System.Drawing.Point(48, 136);
            this.subLabel.Name = "subLabel";
            this.subLabel.Size = new System.Drawing.Size(85, 24);
            this.subLabel.TabIndex = 3;
            this.subLabel.Text = "Subtotal";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taxLabel.Location = new System.Drawing.Point(23, 178);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(123, 24);
            this.taxLabel.TabIndex = 4;
            this.taxLabel.Text = "Tax Amount";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalLabel.Location = new System.Drawing.Point(23, 226);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(110, 24);
            this.totalLabel.TabIndex = 5;
            this.totalLabel.Text = "Total Price";
            // 
            // sliceOuput
            // 
            this.sliceOuput.Location = new System.Drawing.Point(258, 56);
            this.sliceOuput.Name = "sliceOuput";
            this.sliceOuput.Size = new System.Drawing.Size(87, 20);
            this.sliceOuput.TabIndex = 6;
            this.sliceOuput.TextChanged += new System.EventHandler(this.sliceOuput_TextChanged);
            // 
            // subOutput
            // 
            this.subOutput.Location = new System.Drawing.Point(201, 140);
            this.subOutput.Name = "subOutput";
            this.subOutput.Size = new System.Drawing.Size(87, 20);
            this.subOutput.TabIndex = 7;
            // 
            // taxOutput
            // 
            this.taxOutput.Location = new System.Drawing.Point(201, 183);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(87, 20);
            this.taxOutput.TabIndex = 8;
            // 
            // totalOutput
            // 
            this.totalOutput.Location = new System.Drawing.Point(201, 231);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(87, 20);
            this.totalOutput.TabIndex = 9;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculateButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.calculateButton.Location = new System.Drawing.Point(115, 90);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(88, 29);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // dealLabel
            // 
            this.dealLabel.AutoSize = true;
            this.dealLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dealLabel.Location = new System.Drawing.Point(400, 191);
            this.dealLabel.Name = "dealLabel";
            this.dealLabel.Size = new System.Drawing.Size(208, 25);
            this.dealLabel.TabIndex = 11;
            this.dealLabel.Text = "Limited Time Deal!";
            // 
            // choiceBox
            // 
            this.choiceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choiceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceBox.FormattingEnabled = true;
            this.choiceBox.Items.AddRange(new object[] {
            "Deal",
            "No deal"});
            this.choiceBox.Location = new System.Drawing.Point(439, 231);
            this.choiceBox.Name = "choiceBox";
            this.choiceBox.Size = new System.Drawing.Size(143, 26);
            this.choiceBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(667, 372);
            this.Controls.Add(this.choiceBox);
            this.Controls.Add(this.dealLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subOutput);
            this.Controls.Add(this.sliceOuput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subLabel);
            this.Controls.Add(this.sliceLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pizzaLabel);
            this.Name = "Form1";
            this.Text = "`";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pizzaLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label sliceLabel;
        private System.Windows.Forms.Label subLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox sliceOuput;
        private System.Windows.Forms.TextBox subOutput;
        private System.Windows.Forms.TextBox taxOutput;
        private System.Windows.Forms.TextBox totalOutput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label dealLabel;
        private System.Windows.Forms.ComboBox choiceBox;
    }
}

