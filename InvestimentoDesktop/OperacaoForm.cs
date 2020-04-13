using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestimentoDesktop
{
    public partial class OperacaoForm : Form
    {
        public OperacaoForm()
        {
            InitializeComponent();
        }

        private void OperacaoForm_Load(object sender, EventArgs e)
        {
            cmb_tipo_operacao.Items.Add("Compra");
            cmb_tipo_operacao.Items.Add("Venda");
        }

        private void txt_quantidade_ValueChanged(object sender, EventArgs e)
        {
            int quantidade = Convert.ToInt32(txt_quantidade.Value);
            double valor = Convert.ToDouble(txt_valor.Text);
            lbl_valor_total.Text = (quantidade * valor).ToString();
        }

        private void txt_valor_ValueChanged(object sender, EventArgs e)
        {
            int quantidade = Convert.ToInt32(txt_quantidade.Value);
            double valor = Convert.ToDouble(txt_valor.Text);
            lbl_valor_total.Text = (quantidade * valor).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string msg = "Confirmar Operação?";
            const string titulo = "Operação";
            var check = MessageBox.Show(msg, titulo,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                StreamWriter x;
                string caminhoSalvo = "..\\trades.txt";
                if (File.Exists("..\\trades.txt"))
                {
                    x = File.AppendText(caminhoSalvo);
                    x.WriteLine($";{cmb_tipo_operacao.Text};;{txt_quantidade.Value};;;{txt_valor.Text};;;;{lbl_valor_total.Text}");
                    x.Close();
                }
                else
                {
                    x = File.CreateText(caminhoSalvo);
                    x.WriteLine($";{cmb_tipo_operacao.Text};;{txt_quantidade.Value};;;{txt_valor.Text};;;;{lbl_valor_total.Text}");
                    x.Close();
                }
                txt_quantidade.Value = 0;
                txt_valor.Text = Convert.ToString(0.00);
                lbl_valor_total.Text = Convert.ToString(0.00);
            }
        }
    }
}
