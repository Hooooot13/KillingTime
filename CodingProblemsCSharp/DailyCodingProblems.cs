using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemsCSharp
{
    public class DailyCodingProblems
    {

        //Using the features of C# trivializes this problem.
        public string reverseWordOrderInString_OneLiner(string S)
        {   
            return string.Join(" ", S.ToLower().Split(' ').Reverse());
        }
    }
}
