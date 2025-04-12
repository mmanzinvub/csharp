namespace fuelCalculator
{
    partial class calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonCalculate = new Button();
            textTarifa = new TextBox();
            textDuzina = new TextBox();
            textPotrosnja = new TextBox();
            textGorivo = new TextBox();
            textPlatiti = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(325, 46);
            label1.TabIndex = 1;
            label1.Text = "Potrošnja (L/100km):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(281, 46);
            label2.TabIndex = 3;
            label2.Text = "Dužina puta (km):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 158);
            label3.Name = "label3";
            label3.Size = new Size(356, 46);
            label3.TabIndex = 5;
            label3.Text = "Cijena goriva (1L/EUR):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 386);
            label4.Name = "label4";
            label4.Size = new Size(332, 46);
            label4.TabIndex = 7;
            label4.Text = "Potrebno natočiti (L):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 463);
            label5.Name = "label5";
            label5.Size = new Size(288, 46);
            label5.TabIndex = 8;
            label5.Text = "Cijena natočenog:";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCalculate.Location = new Point(12, 224);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(659, 141);
            buttonCalculate.TabIndex = 14;
            buttonCalculate.Text = "IZRAČUNAJ";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // textTarifa
            // 
            textTarifa.BackColor = SystemColors.Window;
            textTarifa.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textTarifa.Location = new Point(374, 158);
            textTarifa.Multiline = true;
            textTarifa.Name = "textTarifa";
            textTarifa.Size = new Size(297, 46);
            textTarifa.TabIndex = 16;
            // 
            // textDuzina
            // 
            textDuzina.BackColor = SystemColors.Window;
            textDuzina.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textDuzina.Location = new Point(374, 82);
            textDuzina.Multiline = true;
            textDuzina.Name = "textDuzina";
            textDuzina.Size = new Size(297, 46);
            textDuzina.TabIndex = 19;
            // 
            // textPotrosnja
            // 
            textPotrosnja.BackColor = SystemColors.Window;
            textPotrosnja.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textPotrosnja.Location = new Point(374, 9);
            textPotrosnja.Multiline = true;
            textPotrosnja.Name = "textPotrosnja";
            textPotrosnja.Size = new Size(297, 46);
            textPotrosnja.TabIndex = 20;
            // 
            // textGorivo
            // 
            textGorivo.BackColor = SystemColors.Window;
            textGorivo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textGorivo.Location = new Point(374, 383);
            textGorivo.Multiline = true;
            textGorivo.Name = "textGorivo";
            textGorivo.ReadOnly = true;
            textGorivo.Size = new Size(297, 46);
            textGorivo.TabIndex = 21;
            // 
            // textPlatiti
            // 
            textPlatiti.BackColor = SystemColors.Window;
            textPlatiti.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textPlatiti.Location = new Point(374, 463);
            textPlatiti.Multiline = true;
            textPlatiti.Name = "textPlatiti";
            textPlatiti.ReadOnly = true;
            textPlatiti.Size = new Size(297, 46);
            textPlatiti.TabIndex = 22;
            // 
            // calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(683, 547);
            Controls.Add(textPlatiti);
            Controls.Add(textGorivo);
            Controls.Add(textPotrosnja);
            Controls.Add(textDuzina);
            Controls.Add(textTarifa);
            Controls.Add(buttonCalculate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "calculator";
            Text = "Fuel Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonCalculate;
        private TextBox textTarifa;
        private TextBox textDuzina;
        private TextBox textPotrosnja;
        private TextBox textGorivo;
        private TextBox textPlatiti;
    }
}
