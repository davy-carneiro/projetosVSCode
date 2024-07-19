namespace Filme
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
            LblTitulo = new Label();
            TxtTitulo = new TextBox();
            TxtAutor = new TextBox();
            LblAutor = new Label();
            LblGen = new Label();
            CmbGen = new ComboBox();
            ChkRisc = new CheckBox();
            ChkAmass = new CheckBox();
            ChkFalt = new CheckBox();
            GpChks = new GroupBox();
            BtnMostrar = new Button();
            GpChks.SuspendLayout();
            SuspendLayout();
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Location = new Point(75, 34);
            LblTitulo.Margin = new Padding(5, 0, 5, 0);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(61, 24);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "Título";
            // 
            // TxtTitulo
            // 
            TxtTitulo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtTitulo.Location = new Point(207, 32);
            TxtTitulo.Margin = new Padding(5);
            TxtTitulo.Name = "TxtTitulo";
            TxtTitulo.Size = new Size(321, 29);
            TxtTitulo.TabIndex = 1;
            // 
            // TxtAutor
            // 
            TxtAutor.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtAutor.Location = new Point(207, 95);
            TxtAutor.Margin = new Padding(5);
            TxtAutor.Name = "TxtAutor";
            TxtAutor.Size = new Size(321, 29);
            TxtAutor.TabIndex = 3;
            // 
            // LblAutor
            // 
            LblAutor.AutoSize = true;
            LblAutor.Location = new Point(75, 97);
            LblAutor.Margin = new Padding(5, 0, 5, 0);
            LblAutor.Name = "LblAutor";
            LblAutor.Size = new Size(59, 24);
            LblAutor.TabIndex = 2;
            LblAutor.Text = "Autor";
            // 
            // LblGen
            // 
            LblGen.AutoSize = true;
            LblGen.Location = new Point(75, 163);
            LblGen.Margin = new Padding(5, 0, 5, 0);
            LblGen.Name = "LblGen";
            LblGen.Size = new Size(80, 24);
            LblGen.TabIndex = 4;
            LblGen.Text = "Gênero";
            // 
            // CmbGen
            // 
            CmbGen.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbGen.FormattingEnabled = true;
            CmbGen.Items.AddRange(new object[] { "Suspense", "Fantasia", "Romance policial" });
            CmbGen.Location = new Point(207, 160);
            CmbGen.Name = "CmbGen";
            CmbGen.Size = new Size(321, 32);
            CmbGen.TabIndex = 5;
            // 
            // ChkRisc
            // 
            ChkRisc.AutoSize = true;
            ChkRisc.Location = new Point(9, 31);
            ChkRisc.Name = "ChkRisc";
            ChkRisc.Size = new Size(191, 28);
            ChkRisc.TabIndex = 8;
            ChkRisc.Text = "Páginas riscadas";
            ChkRisc.UseVisualStyleBackColor = true;
            // 
            // ChkAmass
            // 
            ChkAmass.AutoSize = true;
            ChkAmass.Location = new Point(9, 66);
            ChkAmass.Name = "ChkAmass";
            ChkAmass.Size = new Size(182, 28);
            ChkAmass.TabIndex = 9;
            ChkAmass.Text = "Capa amassada";
            ChkAmass.UseVisualStyleBackColor = true;
            // 
            // ChkFalt
            // 
            ChkFalt.AutoSize = true;
            ChkFalt.BackColor = SystemColors.Menu;
            ChkFalt.ForeColor = SystemColors.ControlText;
            ChkFalt.Location = new Point(252, 31);
            ChkFalt.Name = "ChkFalt";
            ChkFalt.Size = new Size(197, 28);
            ChkFalt.TabIndex = 10;
            ChkFalt.Text = "Páginas faltandoa";
            ChkFalt.UseVisualStyleBackColor = false;
            ChkFalt.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // GpChks
            // 
            GpChks.Controls.Add(ChkFalt);
            GpChks.Controls.Add(ChkRisc);
            GpChks.Controls.Add(ChkAmass);
            GpChks.Location = new Point(75, 230);
            GpChks.Name = "GpChks";
            GpChks.Size = new Size(453, 100);
            GpChks.TabIndex = 11;
            GpChks.TabStop = false;
            GpChks.Text = "Condições";
            GpChks.Enter += groupBox1_Enter;
            // 
            // BtnMostrar
            // 
            BtnMostrar.Location = new Point(226, 351);
            BtnMostrar.Name = "BtnMostrar";
            BtnMostrar.Size = new Size(134, 35);
            BtnMostrar.TabIndex = 12;
            BtnMostrar.Text = "Mostrar";
            BtnMostrar.UseVisualStyleBackColor = true;
            BtnMostrar.Click += BtnMostrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 422);
            Controls.Add(BtnMostrar);
            Controls.Add(GpChks);
            Controls.Add(CmbGen);
            Controls.Add(LblGen);
            Controls.Add(TxtAutor);
            Controls.Add(LblAutor);
            Controls.Add(TxtTitulo);
            Controls.Add(LblTitulo);
            Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Setor de Livros";
            GpChks.ResumeLayout(false);
            GpChks.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTitulo;
        private TextBox TxtTitulo;
        private TextBox TxtAutor;
        private Label LblAutor;
        private Label LblGen;
        private ComboBox CmbGen;
        private CheckBox ChkRisc;
        private CheckBox ChkAmass;
        private CheckBox ChkFalt;
        private GroupBox GpChks;
        private Button BtnMostrar;
    }
}
