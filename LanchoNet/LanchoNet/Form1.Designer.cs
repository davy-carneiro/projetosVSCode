namespace LanchoNet
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
            LblSucos = new Label();
            CmbSucos = new ComboBox();
            LblParaComer = new Label();
            ChkCoxinha = new CheckBox();
            ChkPastel = new CheckBox();
            ChkBomba = new CheckBox();
            GpPagamento = new GroupBox();
            RadioCartao = new RadioButton();
            RadioPix = new RadioButton();
            LblTotal = new Label();
            BtnEnviar = new Button();
            LblValor = new Label();
            GpPagamento.SuspendLayout();
            SuspendLayout();
            // 
            // LblSucos
            // 
            LblSucos.AutoSize = true;
            LblSucos.Font = new Font("Arial", 15.75F);
            LblSucos.Location = new Point(30, 29);
            LblSucos.Name = "LblSucos";
            LblSucos.Size = new Size(58, 24);
            LblSucos.TabIndex = 0;
            LblSucos.Text = "Suco";
            // 
            // CmbSucos
            // 
            CmbSucos.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbSucos.Font = new Font("Arial", 15.75F);
            CmbSucos.FormattingEnabled = true;
            CmbSucos.Items.AddRange(new object[] { "Laranja", "Goiaba", "Graviola", "Acerola", "Maracujá", "Cupuaçu", "Bacuri", "Limonada" });
            CmbSucos.Location = new Point(110, 26);
            CmbSucos.Name = "CmbSucos";
            CmbSucos.Size = new Size(210, 32);
            CmbSucos.TabIndex = 1;
            CmbSucos.SelectedIndexChanged += CmbSucos_SelectedIndexChanged;
            // 
            // LblParaComer
            // 
            LblParaComer.AutoSize = true;
            LblParaComer.Font = new Font("Arial", 15.75F);
            LblParaComer.Location = new Point(30, 75);
            LblParaComer.Name = "LblParaComer";
            LblParaComer.Size = new Size(129, 24);
            LblParaComer.TabIndex = 2;
            LblParaComer.Text = "Para Comer:";
            // 
            // ChkCoxinha
            // 
            ChkCoxinha.AutoSize = true;
            ChkCoxinha.Font = new Font("Arial", 15.75F);
            ChkCoxinha.Location = new Point(39, 120);
            ChkCoxinha.Name = "ChkCoxinha";
            ChkCoxinha.Size = new Size(105, 28);
            ChkCoxinha.TabIndex = 3;
            ChkCoxinha.Text = "Coxinha";
            ChkCoxinha.UseVisualStyleBackColor = true;
            ChkCoxinha.CheckedChanged += ChkCoxinha_CheckedChanged;
            // 
            // ChkPastel
            // 
            ChkPastel.AutoSize = true;
            ChkPastel.Font = new Font("Arial", 15.75F);
            ChkPastel.Location = new Point(39, 154);
            ChkPastel.Name = "ChkPastel";
            ChkPastel.Size = new Size(88, 28);
            ChkPastel.TabIndex = 4;
            ChkPastel.Text = "Pastel";
            ChkPastel.UseVisualStyleBackColor = true;
            // 
            // ChkBomba
            // 
            ChkBomba.AutoSize = true;
            ChkBomba.Font = new Font("Arial", 15.75F);
            ChkBomba.Location = new Point(39, 188);
            ChkBomba.Name = "ChkBomba";
            ChkBomba.Size = new Size(94, 28);
            ChkBomba.TabIndex = 5;
            ChkBomba.Text = "Bomba";
            ChkBomba.UseVisualStyleBackColor = true;
            // 
            // GpPagamento
            // 
            GpPagamento.Controls.Add(RadioCartao);
            GpPagamento.Controls.Add(RadioPix);
            GpPagamento.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GpPagamento.Location = new Point(39, 238);
            GpPagamento.Name = "GpPagamento";
            GpPagamento.Size = new Size(381, 100);
            GpPagamento.TabIndex = 6;
            GpPagamento.TabStop = false;
            GpPagamento.Text = "Forma de Pagamento";
            // 
            // RadioCartao
            // 
            RadioCartao.AutoSize = true;
            RadioCartao.Location = new Point(283, 33);
            RadioCartao.Name = "RadioCartao";
            RadioCartao.Size = new Size(92, 28);
            RadioCartao.TabIndex = 1;
            RadioCartao.TabStop = true;
            RadioCartao.Text = "Cartão";
            RadioCartao.UseVisualStyleBackColor = true;
            // 
            // RadioPix
            // 
            RadioPix.AutoSize = true;
            RadioPix.Location = new Point(6, 33);
            RadioPix.Name = "RadioPix";
            RadioPix.Size = new Size(57, 28);
            RadioPix.TabIndex = 0;
            RadioPix.TabStop = true;
            RadioPix.Text = "Pix";
            RadioPix.UseVisualStyleBackColor = true;
            // 
            // LblTotal
            // 
            LblTotal.AutoSize = true;
            LblTotal.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblTotal.Location = new Point(45, 379);
            LblTotal.Name = "LblTotal";
            LblTotal.Size = new Size(140, 24);
            LblTotal.TabIndex = 7;
            LblTotal.Text = "Total a Pagar:";
            // 
            // BtnEnviar
            // 
            BtnEnviar.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEnviar.Location = new Point(153, 456);
            BtnEnviar.Name = "BtnEnviar";
            BtnEnviar.Size = new Size(167, 35);
            BtnEnviar.TabIndex = 8;
            BtnEnviar.Text = "Lançar Pedido";
            BtnEnviar.UseVisualStyleBackColor = true;
            BtnEnviar.Click += BtnEnviar_Click;
            // 
            // LblValor
            // 
            LblValor.AutoSize = true;
            LblValor.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblValor.Location = new Point(272, 379);
            LblValor.Name = "LblValor";
            LblValor.Size = new Size(0, 27);
            LblValor.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 554);
            Controls.Add(LblValor);
            Controls.Add(BtnEnviar);
            Controls.Add(LblTotal);
            Controls.Add(GpPagamento);
            Controls.Add(ChkBomba);
            Controls.Add(ChkPastel);
            Controls.Add(ChkCoxinha);
            Controls.Add(LblParaComer);
            Controls.Add(CmbSucos);
            Controls.Add(LblSucos);
            Name = "Form1";
            Text = "LanchoNet";
            GpPagamento.ResumeLayout(false);
            GpPagamento.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblSucos;
        private ComboBox CmbSucos;
        private Label LblParaComer;
        private CheckBox ChkCoxinha;
        private CheckBox ChkPastel;
        private CheckBox ChkBomba;
        private GroupBox GpPagamento;
        private RadioButton RadioCartao;
        private RadioButton RadioPix;
        private Label LblTotal;
        private Button BtnEnviar;
        private Label LblValor;
    }
}
