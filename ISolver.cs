using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIcalculator
{
    public interface ISolver
    {
         void Accumulate(string s);
         void Clear();
         double Solve(string s);
    }
}
