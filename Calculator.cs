using System.Globalization;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Expresii_Matematice
{
    public class Calculator
    {
        private string expresieAnterioara;
        private Stack<string> st = new Stack<string>();
        public double t1, t2, t3, rezultat;
        private Stack<double> stiva = new Stack<double>();
        string termen = "";

        public string Poloneza(string exp)
        {
            exp = "(" + exp + ")";
            int v = exp.Length;
            string polo = "";
            char[] expr = exp.ToCharArray();

            for (int i = 0; i < v; i++)
            {
                if (char.IsDigit(expr[i]) || expr[i] == ',')
                {
                    termen += expr[i];
                }

                if (expr[i] == '(')
                {
                    st.Push(expr[i].ToString());
                }

                if (expr[i] == ')')
                {
                    polo += termen + " ";
                    termen = "";

                    while (st.Peek() != "(")
                    {
                        polo += st.Pop();
                    }

                    st.Pop();
                }

                if (expr[i] == '+' || expr[i] == '-')
                {
                    polo += termen + " ";
                    termen = "";

                    if (st.Count == 0 || st.Peek() == "(")
                    {
                        st.Push(expr[i].ToString());
                    }
                    else
                    {
                        polo += st.Pop();
                        i--;
                        
                    }
                }

                if (expr[i] == '*' || expr[i] == '/')
                {
                    polo += termen + " ";
                    termen = "";

                    if (st.Count == 0 || st.Peek() == "(" || st.Peek() == "+" || st.Peek() == "-")
                    {
                        st.Push(expr[i].ToString());
                    }
                    else
                    {
                        polo += st.Pop();
                        i--;
                    }
                }

                if (expr[i] == 's' || expr[i] == 'c' || expr[i] == 't')
                {
                    polo += termen + "";
                    termen = "";

                    if (st.Count == 0 || st.Peek() == "(" || st.Peek() == "+" || st.Peek() == "-" || st.Peek() == "*" || st.Peek() == "/")
                    {
                        st.Push(expr[i].ToString());
                    }
                    else
                    {
                        polo += st.Pop();
                        i--;
                    }
                }
            }

            return polo;
        }
        public double CalculPoloneza(string poloneza)
        {
            double rez;
            char[] operatori = { '+', '-', '*', '/' };
            int n = poloneza.Length;
            char[] po = poloneza.ToCharArray();
            double nr = 0;
            int j = 0;
            Operatie calc = new Operatie();
            if (po[0] == ' ') j = 1;

            for (int i = j; i < n; i++)
            {
                if (char.IsDigit(po[i]) || po[i] == ',')
                {
                    termen += po[i];
                }

                if ((po[i] == ' ') && (po[i - 1] != 's') && (po[i - 1] != 'c') && (po[i - 1] != 't'))
                {
                    if (double.TryParse(termen, out nr))
                    {
                        AdaugaStiva(nr);
                        nr = 0;
                        termen = "";
                    }
                    else
                    {
                        Console.WriteLine("Format numeric nevalid pentru 'termen'");
                    }

                }

                if (Array.IndexOf(operatori, po[i]) != -1)
                {
                    calc.Calc(po[i], stiva);
                    i++;
                }

                if (po[i] == 's' || po[i] == 'c' || po[i] == 't')
                {
                    calc.CalcTrig(po[i], stiva);
                }
            }

            rez = stiva.Peek();
            return rez;
        }

        public void AdaugaStiva(double nr)
        {
            stiva.Push(nr);
        }

        public bool PreiaDoi(out double t1, out double t2, Stack<double> stiva)
        {
            t1 = 0;
            t2 = 0;

            if (stiva.Count < 2)
                return false;

            t2 = stiva.Pop();
            t1 = stiva.Pop();
            return true;
        }
        public string ExpresieAnterioara
        {
            get { return expresieAnterioara; }
            set { expresieAnterioara = value; }
        }

        public void SalveazaExpresieAnterioara(string caleFisier)
        {
            File.WriteAllText(caleFisier, expresieAnterioara);
        }

        public string IncarcaExpresieAnterioara(string caleFisier)
        {
            if (File.Exists(caleFisier))
            {
                expresieAnterioara = File.ReadAllText(caleFisier);
                return expresieAnterioara;
            }
            else
            {
                return "Fișierul nu există.";
            }
        }
    }
}

