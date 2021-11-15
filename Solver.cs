using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIcalculator
{
    class Solver : ISolver
    {
        float result;
       char[] oper = {'*', '/', '%', '-', '+', '.'};
        string[] operations = new string [1];
       public void Accumulate(string s)
        {
            int operPoint = 0; 
            for (int i = 0; i < oper.Length; i++)
            {
                string operationString = "";
                char op = oper[i];

                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j] == op)
                    {
                        for (int k = j--; k > 0; k--)
                        {
                            if (k == j-- && s[k] == op) { }

                            else if (s[k] < 0 || s[k] > 9)
                            {
                                break;
                            }
                            operationString += s[k];
                        }
                        operationString = op + ""; 
                        for (int h = j; h < s.Length; h++)
                        {
                            if (h == j && s[h] == op) { }

                            else if (s[h] < 0 || s[h] > 9)
                            {
                                break;
                            }
                            operationString += s[h];

                        }
                        operations = new string[operPoint + 1];
                        operations[operPoint++] = operationString;
                    }
                }
            }

        }
        public void Clear()
        { 
            
        }
        public double Solve(string s)
        {
            for (int i = 0; i < operations.Length; i++)
            {
                string st = operations[i];

                result += Convert.ToInt32(st);
            
            }

            return Convert.ToDouble(s);
        }
    }
}
