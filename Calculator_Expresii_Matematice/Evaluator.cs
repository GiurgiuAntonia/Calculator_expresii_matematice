using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace Calculator_Expresii_Matematice
{
    public partial class Evaluator : Form
    {
        private Calculator calculator;
        private string caleFisier = "C:\\Users\\Ioana\\OneDrive\\Desktop\\2241\\Giurgiu_Antonia\\Calculator_Expresii_Matematice\\Calculator_Expresii_Matematice\\expresiiSalvate.txt";
        private string ultimaExpresieSalvata = string.Empty;
        public Evaluator()
        {
            InitializeComponent();
            calculator = new Calculator();
            InitializeazaExpresieAnterioara();
        }

        private void InitializeazaExpresieAnterioara()
        {
            string ultimaExpresie = CitesteUltimaExpresieSalvata();
            if (!string.IsNullOrEmpty(ultimaExpresie))
            {
                exp_ant.Text = ultimaExpresie;
            }
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            try
            {
                string expresieData = calctxt.Text;
                if (string.IsNullOrWhiteSpace(expresieData))
                {
                    MessageBox.Show("Expresie negasita!");
                    return;
                }

                Calculator calculator = new Calculator();
                string expresiePoloneza = calculator.Poloneza(expresieData);
                double rezultatf = calculator.CalculPoloneza(expresiePoloneza);

                SalveazaExpresie(expresieData);
                rezutxt.Text = rezultatf.ToString();

                exp_ant.Text = ultimaExpresieSalvata;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SalveazaExpresie(string expresie)
        {
            try
            {
                File.AppendAllText(caleFisier, expresie + Environment.NewLine);
                ultimaExpresieSalvata = expresie;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvarea expresiei: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string CitesteUltimaExpresieSalvata()
        {
            try
            {
                if (File.Exists(caleFisier))
                {
                    string[] linii = File.ReadAllLines(caleFisier);
                    if (linii.Length > 0)
                    {
                        return linii[linii.Length - 1];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la citirea ultimei expresii salvate: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return string.Empty;
        }
    }
}


