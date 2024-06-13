using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Calculator_Expresii_Matematice
{
    public class Operatie : Calculator
    {
        public string op;
        public string termen;
        public string[] memorie = { " " };

        public Operatie()
        {
            op = " ";
            termen = " ";
            memorie[0] = " ";
        }
        public void Calc(char op, Stack<double> stiva)
        {
            if (PreiaDoi(out t1, out t2, stiva))
            {
                switch (op)
                {
                    case '+':
                        rezultat = t1 + t2;
                        break;
                    case '-':
                        rezultat = t1 - t2;
                        break;
                    case '*':
                        rezultat = t1 * t2;
                        break;
                    case '/':
                        rezultat = t1 / t2;
                        break;
                }
                stiva.Push(rezultat);
            }
        }
        public void CalcTrig(char trigo, Stack<double> stiva)
        {
            t3 = stiva.Pop();

            switch (trigo)
            {
                case 's':
                    rezultat = Math.Sin((t3 * Math.PI) / 180);
                    break;
                case 'c':
                    rezultat = Math.Cos(t3 * Math.PI / 180);
                    break;
                case 't':
                    rezultat = Math.Tan((t3 * Math.PI) / 180);
                    break;
            }

            stiva.Push(rezultat);
        }
    }

}
