using System.Windows.Forms.VisualStyles;

namespace Filme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("i love u");
            // CmbGen.Items.Add("i love u");

            String titulo = TxtTitulo.Text;
            String autor  = TxtAutor.Text;
            String genero = CmbGen.Text;
            
            List<string> chksTxt = new List<string>();
            chksTxt.Add(ChkRisc.Text);
            chksTxt.Add(ChkAmass.Text);
            chksTxt.Add(ChkFalt.Text);

            List<bool> chksCheck = new List<bool>();
            chksCheck.Add(ChkRisc.Checked);
            chksCheck.Add(ChkAmass.Checked);
            chksCheck.Add(ChkFalt.Checked);


            String texto = "";

            texto += "" +
            "Titulo: " + titulo + "\n" +
            "Autor: " + autor + "\n" +
            "Gênero: " + genero + "\n";


            for (int i = 0; i < chksCheck.Count; i++)
            {
                texto += chksTxt[i];

                if (chksCheck[i] == true)
                {
                    texto += " está marcado!";
                }
                else
                {
                    texto += " não está marcado!";
                }

                texto += "\n";
            }
       

            MessageBox.Show(texto);


        }
    }
}
