using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace indovina_numero { 

    public partial class Form1 : Form
{

        Random randomNumber = new Random();

    int numero = 0;
    int indovinate = 0;

    public Form1()
    {
            InitializeComponent();

        generaDomande();
    }

    private void controllaNumero(object sender, EventArgs e)
    {
          int i = int.Parse(textInserisciNumero.Text);

            indovinate += 1;
        label2.Text = "numero tentativi" + indovinate ;

            if (i == numero)
        {
            MessageBox.Show("hai indovinato.prova un altro numero");
            generaDomande();
            textInserisciNumero.Text = "";
            indovinate = 0;
            label2.Text = "numero tentativi" + indovinate ;
        }
        else if (i < numero)
        {
            MessageBox.Show("troppo piccolo");
        }
        else
        {
            MessageBox.Show("troppo grande");
        }


    }

    private void generaDomande()
    {
        numero = randomNumber.Next(0, 10);

        label1.Text = "sto pensando a un numero tra: 0 and 10 ";
    }
}
}