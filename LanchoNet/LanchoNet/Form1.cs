namespace LanchoNet
{
    public partial class Form1 : Form
    {
        private Double total = 0;
        private int selectedSuco = 0;

        public Form1()
        {
            InitializeComponent();

            // fazendo varios elementos dispararem um mesmo evento
            ChkCoxinha.CheckedChanged += CheckBox_CheckedChanged;
            ChkBomba.CheckedChanged += CheckBox_CheckedChanged;
            ChkPastel.CheckedChanged += CheckBox_CheckedChanged;
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            /*
             *  Suco: R$ 2,50
             *  Coxinha: R$ 4,00
             *  Pastel: R$ 4,50
             *  Bomba: R$ 5,50
             * 
             * 
             */
            String texto = "";

            String targetSuco = CmbSucos.Text;

            List<Boolean> chks = new List<Boolean>();
            chks.Add(ChkCoxinha.Checked);
            chks.Add(ChkPastel.Checked);
            chks.Add(ChkBomba.Checked);

            List<String> chksTxt = new List<String>();
            chksTxt.Add(ChkCoxinha.Text);
            chksTxt.Add(ChkPastel.Text);
            chksTxt.Add(ChkBomba.Text);

            List<String> chksSelecteds = new List<String>();

            int quantProdSelect = 0;

            List<String> pagamentosTxt = new List<String>();
            pagamentosTxt.Add(RadioPix.Text);
            pagamentosTxt.Add(RadioCartao.Text);

            List<Boolean> pagamentosBool = new List<Boolean>();
            pagamentosBool.Add(RadioPix.Checked);
            pagamentosBool.Add(RadioCartao.Checked);

            String targetPagamento = "";

            for (int i = 0; i < pagamentosBool.Count; i++)
            {
                if (pagamentosBool[i] == true)
                {
                    targetPagamento = pagamentosTxt[i];
                }
            }

            for (int i = 0; i < chks.Count; i++)
            {
                if (chks[i] == true)
                {
                    chksSelecteds.Add(chksTxt[i]);
                    quantProdSelect++;
                }
            }

            if (targetSuco == "" && quantProdSelect == 0)
            {
                MessageBox.Show("Nenhum produto foi selecionado!");
            }
            else
            {
                if (targetSuco != "") {
                    texto += "Suco: " + CmbSucos.Text + "\n";
                }
                else
                {
                    texto += "Nenhum suco foi selecionado!\n";
                }

                if (quantProdSelect != 0)
                {
                    texto += "\nSalgados selecionados:\n";


                    for (int i = 0; i < chksSelecteds.Count; i++)
                    {
                        texto += " ." + chksSelecteds[i] + "\n";
                    }

                }

                texto += "\nA forma de pagamento escolhida é: " + targetPagamento + "\n";

                texto += "\nTotal à pagar: " + this.total.ToString("C") + "\n";

                MessageBox.Show(texto);
            }

            /*
                texto = "" +
                "O suco selecionado é: " + targetSuco + "\n" +
                "Quantidade de comestíveis: " + quantProdSelect +
                "Pagamento: " + targetPagamento;
            */

            
        }

        private void CmbSucos_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (selectedSuco == 0)
            {
                selectedSuco = 1;
                this.total += 2.50;
            }

            LblValor.Text = this.total.ToString("C");

        }

        private void ChkCoxinha_CheckedChanged(object sender, EventArgs e)
        {
            // MessageBox.Show("mudou a coxibha");
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                if (checkBox.Text == "Coxinha")
                {
                    if (ChkCoxinha.Checked == true)
                    {
                        this.total += 4;
                    }
                    else
                    {
                        this.total -= 4;
                    }
                }

                if (checkBox.Text == "Pastel")
                {
                    if (ChkPastel.Checked == true)
                    {
                        this.total += 4.5;
                    }
                    else
                    {
                        this.total -= 4.5;
                    }
                }
                
                if (checkBox.Text == "Bomba")
                {
                    if (ChkBomba.Checked == true)
                    {
                        this.total += 5.5;
                    }
                    else
                    {
                        this.total -= 5.5;
                    }
                }
               

                LblValor.Text = total.ToString("C");
            }
        }
    }
}
