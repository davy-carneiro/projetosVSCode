using System.ComponentModel;

namespace Votacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            String nome = TxtNome.Text; 
            int idade = Int32.Parse(TxtIdade.Text); // convers�o de string para inteiro

            String msgIni = nome+", voc�";
            String msgFin = "pode votar!";

            if (idade < 16)
            {
                MessageBox.Show(msgIni + " n�o " + msgFin);
            }
            else
            {
                MessageBox.Show(msgIni + " " + msgFin);
            }
        }
    }
}
