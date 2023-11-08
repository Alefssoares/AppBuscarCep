using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscadeCEPWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        private void maskCep_leave(object sender, EventArgs e)
        {
            BuscarCep(maskCep.Text);
        }
        async Task BuscarCep(string cep)
        {
            try
            {
                var cepbuscar = RestService.For<ICepApiServices>("https://viacep.com.br/");
                var endereco = await cepbuscar.GetAddressAsync(cep);

                txtLogradouro.Text = endereco.Logradouro;
                txtBairro.Text = endereco.Bairro;
                txtComplemento2.Text = endereco.Complemento2;
                txtMunicipio.Text = endereco.Localidade;
                txtEstado.Text = endereco.Uf;
                
            }
            catch(Exception e)
            {
                MessageBox.Show("Falha! \n " + e.Message);
            }
        }

       
    }

   
}
