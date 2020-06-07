using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_encapsulamento
{
    public partial class frm_Calcular : Form
    {
        public frm_Calcular()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            if (txt_ValorInicial.Text == "")
            {
                MessageBox.Show("Digite algum valor inicial!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                Calculo cal = new Calculo();

                double preco_Inicial = double.Parse(txt_ValorInicial.Text);

                int tipo_produto = 0;

                if (rdb_Leite.Checked)
                {
                    tipo_produto = 1;
                }
                else if (rdb_Martelo.Checked)
                {
                    tipo_produto = 2;
                }
                else if (rdb_ProtetorSolar.Checked)
                {
                    tipo_produto = 3;
                }
                else if (rdb_Televisao.Checked)
                {
                    tipo_produto = 4;
                }
                else if (rdb_Casa.Checked)
                {
                    tipo_produto = 5;
                }
                else
                {
                    MessageBox.Show("Selecione alguma opção!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                double resultado = cal.CalculaPrecoFinal(preco_Inicial, tipo_produto);

                txt_ValorFinal.Text = resultado.ToString();
            }
                       
        }

        private void txt_ValorInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_ValorFinal.Clear();
            txt_ValorInicial.Clear();
            rdb_Casa.Checked = false;
            rdb_Leite.Checked = false;
            rdb_Martelo.Checked = false;
            rdb_ProtetorSolar.Checked = false;
            rdb_Televisao.Checked = false;
            txt_ValorInicial.Focus();
        }
    }
}
