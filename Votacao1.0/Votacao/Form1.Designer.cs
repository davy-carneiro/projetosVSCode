namespace Votacao
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
            LblNome = new Label();
            LblIdade = new Label();
            TxtNome = new TextBox();
            TxtIdade = new TextBox();
            BtnVerificar = new Button();
            SuspendLayout();
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Font = new Font("Arial", 15.75F);
            LblNome.Location = new Point(99, 89);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(76, 24);
            LblNome.TabIndex = 0;
            LblNome.Text = "Nome: ";
            // 
            // LblIdade
            // 
            LblIdade.AutoSize = true;
            LblIdade.Font = new Font("Arial", 15.75F);
            LblIdade.Location = new Point(99, 163);
            LblIdade.Name = "LblIdade";
            LblIdade.Size = new Size(74, 24);
            LblIdade.TabIndex = 1;
            LblIdade.Text = "Idade: ";
            // 
            // TxtNome
            // 
            TxtNome.Font = new Font("Arial", 14.25F);
            TxtNome.Location = new Point(171, 86);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(186, 29);
            TxtNome.TabIndex = 2;
            // 
            // TxtIdade
            // 
            TxtIdade.Font = new Font("Arial", 14.25F);
            TxtIdade.Location = new Point(171, 165);
            TxtIdade.Name = "TxtIdade";
            TxtIdade.Size = new Size(186, 29);
            TxtIdade.TabIndex = 3;
            // 
            // BtnVerificar
            // 
            BtnVerificar.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnVerificar.Location = new Point(145, 272);
            BtnVerificar.Name = "BtnVerificar";
            BtnVerificar.Size = new Size(174, 45);
            BtnVerificar.TabIndex = 4;
            BtnVerificar.Text = "Verificar";
            BtnVerificar.UseVisualStyleBackColor = true;
            BtnVerificar.Click += BtnVerificar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 450);
            Controls.Add(BtnVerificar);
            Controls.Add(TxtIdade);
            Controls.Add(TxtNome);
            Controls.Add(LblIdade);
            Controls.Add(LblNome);
            Name = "Form1";
            Text = "Votar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblNome;
        private Label LblIdade;
        private TextBox TxtNome;
        private TextBox TxtIdade;
        private Button BtnVerificar;
    }
}
