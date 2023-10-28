namespace TempConverter
{
    partial class Form1
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
            txtTenpInput = new TextBox();
            cmbInputUnit = new ComboBox();
            cmbOutputUnit = new ComboBox();
            btnConvert = new Button();
            label1 = new Label();
            lblResult = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtTenpInput
            // 
            txtTenpInput.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtTenpInput.Location = new Point(73, 115);
            txtTenpInput.Name = "txtTenpInput";
            txtTenpInput.Size = new Size(184, 43);
            txtTenpInput.TabIndex = 0;
            // 
            // cmbInputUnit
            // 
            cmbInputUnit.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            cmbInputUnit.FormattingEnabled = true;
            cmbInputUnit.Location = new Point(282, 112);
            cmbInputUnit.Name = "cmbInputUnit";
            cmbInputUnit.Size = new Size(72, 45);
            cmbInputUnit.TabIndex = 1;
            // 
            // cmbOutputUnit
            // 
            cmbOutputUnit.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            cmbOutputUnit.FormattingEnabled = true;
            cmbOutputUnit.Location = new Point(445, 112);
            cmbOutputUnit.Name = "cmbOutputUnit";
            cmbOutputUnit.Size = new Size(72, 45);
            cmbOutputUnit.TabIndex = 2;
            // 
            // btnConvert
            // 
            btnConvert.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnConvert.Location = new Point(567, 112);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(142, 48);
            btnConvert.TabIndex = 3;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(380, 119);
            label1.Name = "label1";
            label1.Size = new Size(47, 38);
            label1.TabIndex = 4;
            label1.Text = "To";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblResult.Location = new Point(381, 230);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(46, 54);
            lblResult.TabIndex = 5;
            lblResult.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(165, 19);
            label2.Name = "label2";
            label2.Size = new Size(391, 46);
            label2.TabIndex = 6;
            label2.Text = "Temperature Converter";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(73, 95);
            label3.Name = "label3";
            label3.Size = new Size(101, 17);
            label3.TabIndex = 7;
            label3.Text = "Enter the value";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(350, 217);
            label4.Name = "label4";
            label4.Size = new Size(46, 17);
            label4.TabIndex = 8;
            label4.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblResult);
            Controls.Add(label1);
            Controls.Add(btnConvert);
            Controls.Add(cmbOutputUnit);
            Controls.Add(cmbInputUnit);
            Controls.Add(txtTenpInput);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTenpInput;
        private ComboBox cmbInputUnit;
        private ComboBox cmbOutputUnit;
        private Button btnConvert;
        private Label label1;
        private Label lblResult;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}