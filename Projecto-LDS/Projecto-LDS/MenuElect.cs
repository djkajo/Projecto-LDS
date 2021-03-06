﻿namespace Projecto_LDS
{
    using System;
    using System.Windows.Forms;


    // criar o delegate
    public delegate void FormCloseEventHandler(object source, EventArgs args);
    public delegate void CalculoConsumosEventHandler(object source, EventArgs args);
    public delegate void RecebeVazioEventHandler(object source, string ContagemVazio);
    public delegate void RecebeForaEventHandler(object source, string ContagemFora);
    public delegate void TarifaEventHandler(object source, string tarifa);

    public partial class MenuElect : Form
    {
        public event FormCloseEventHandler FormClose;
        public event CalculoConsumosEventHandler ConsumosRecebidos;
        public event RecebeVazioEventHandler recebeVazio;
        public event RecebeForaEventHandler recebeFora;
        public event TarifaEventHandler recebetarifa;


        public MenuElect()
        {
            InitializeComponent();
        }

        private void escolhaTarifa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox4_TextChanged(object sender, EventArgs e)
        {

            string ContagemVazio = LeituraVazio.Text;

            //delegate
            OnrecebeVazio(this, ContagemVazio);


        }


        public void textBox5_TextChanged(object sender, EventArgs e)
        {

            string ContagemFora = LeituraForaVazio.Text;
            //delegate
            OnrecebeFora(this, ContagemFora);

        }





        private void button1_Click(object sender, EventArgs e)
        {
            // método delegate
            OnConsumosRecebidos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            //label2.Text = RecebeResultado (double resultado);

        }

        public double RecebeResultado(double resultado)
        {
            return resultado;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String tarifa = comboBox1.Text;
            OnTarifa(this, tarifa);
        }

        public virtual void OnTarifa(MenuElect menuElect, String tarifa)
        {
            recebetarifa?.Invoke(this, tarifa);
        }

        public virtual void OnConsumosRecebidos()
        {
            ConsumosRecebidos?.Invoke(this, EventArgs.Empty);
        }

        public virtual void OnFormClose()
        {
            FormClose?.Invoke(this, EventArgs.Empty);
        }

        private void OnrecebeVazio(MenuElect menuElect, string contagemVazio)
        {
            recebeVazio?.Invoke(this, contagemVazio);
        }

        private void OnrecebeFora(MenuElect menuElect, string contagemFora)
        {
            recebeFora?.Invoke(this, contagemFora);
        }
    }
}
