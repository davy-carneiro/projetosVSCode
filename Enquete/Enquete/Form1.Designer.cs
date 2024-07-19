namespace Enquete
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
            LblPergunta = new Label();
            GpRadios = new GroupBox();
            RadioClaro = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            button1 = new Button();
            GpRadios.SuspendLayout();
            SuspendLayout();
            // 
            // LblPergunta
            // 
            LblPergunta.AutoSize = true;
            LblPergunta.Font = new Font("Arial", 15.75F);
            LblPergunta.Location = new Point(94, 86);
            LblPergunta.Name = "LblPergunta";
            LblPergunta.Size = new Size(233, 24);
            LblPergunta.TabIndex = 0;
            LblPergunta.Text = "Ter aulas nos sábados?";
            // 
            // GpRadios
            // 
            GpRadios.Controls.Add(RadioClaro);
            GpRadios.Controls.Add(radioButton2);
            GpRadios.Controls.Add(radioButton3);
            GpRadios.Font = new Font("Arial", 15.75F);
            GpRadios.Location = new Point(69, 173);
            GpRadios.Name = "GpRadios";
            GpRadios.Size = new Size(626, 131);
            GpRadios.TabIndex = 1;
            GpRadios.TabStop = false;
            GpRadios.Text = "groupBox1";
            // 
            // RadioClaro
            // 
            RadioClaro.AutoSize = true;
            RadioClaro.Location = new Point(25, 35);
            RadioClaro.Name = "RadioClaro";
            RadioClaro.Size = new Size(78, 28);
            RadioClaro.TabIndex = 2;
            RadioClaro.TabStop = true;
            RadioClaro.Text = "Claro";
            RadioClaro.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(25, 93);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(147, 28);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(479, 82);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(147, 28);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 15.75F);
            button1.Location = new Point(329, 358);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(GpRadios);
            Controls.Add(LblPergunta);
            Name = "Form1";
            Text = "Form1";
            GpRadios.ResumeLayout(false);
            GpRadios.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblPergunta;
        private GroupBox GpRadios;
        private RadioButton RadioClaro;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button button1;
    }
}
