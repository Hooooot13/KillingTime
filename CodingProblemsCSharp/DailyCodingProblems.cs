using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemsCSharp
{
    public class DailyCodingProblems
    {

        //Given a string of length N reverse the string
        public string reverseWordOrderInString_OneLiner(string S)
        {   
            return string.Join(" ", S.ToLower().Split(' ').Reverse());
        } //Using the features of C# trivializes this problem.
        //Since strings are objects and can be seamlessly converted into
        //  Enumerables wich allow manipulations the whole process 
        //  is really easy with C#
        //  I might do this at a later time with another language


        //Given an ineger array of N length
        //  Where each value represents the unit hight of a wall
        //  Suppose it will rain and all spots between two walls gets filled up
        //  Compute the number of units enclosed by two walls 
        //  Do this in O(N) time and O(1) space
        //  EX1:    GIVEN : [2, 1, 2]           RESULT : 1
        //          GIVEN : [3, 0, 1, 3, 0, 5]  RESULT : 8
        //          \_/\_/\_/\_/\_/\_/\_/\_/\_/\_/\_/\_/\_/
        //           `````````````````\```````````````````
        //            `````````````````\`````````````````
        //           ``````````````````/``````````#```````
        //            ````/\```````````\````````` #``````
        //           ````/  \``````````/`````#~~#~#```````
        //            ```#  #```#~#````\`````#~~#~#``````
        //           ````####```###````/`````#~##~#```````
        public int rainTrapped(int[] walls)
        {
            int spacesLeft = 0;
            int spacesRight = 0;
            int spaces = 0;
            int potentialSpaces = 0;
            int localMaxLeft = walls[0];
            int localMaxLeftIndex = 0;
            int localMaxRight = walls[^1];
            int localMaxRightIndex = walls.Length - 1;


            for (int i = 0; i <= ((walls.Length - 1) / 2); i++)
            {

                //if ((walls[i] == localMaxLeft) || (walls[i] == localMaxRight)) continue;

                if (walls[i] > localMaxLeft)
                {
                    localMaxLeft = walls[i];
                    localMaxLeftIndex = i;
                }
                else if (walls[i] < localMaxLeft)
                {
                    spaces += (localMaxLeft - walls[i]);
                }
                else if (walls[walls.Length - 1 - i] > localMaxRight)
                {
                    localMaxRight = walls[walls.Length - 1 - i];
                    localMaxRightIndex = walls.Length - 1 - i;
                }
                else if (walls[walls.Length - 1 - i] < localMaxRight)
                {
                    spaces += (localMaxRight - walls[i]);
                }


            }

            if ((walls[walls.Length / 2] > localMaxLeft) || (walls[walls.Length / 2] > localMaxRight)) return spaces;

            if (localMaxRight > localMaxLeft)
            {
                spaces = spaces - (localMaxRightIndex - (walls.Length / 2) * (localMaxRight - localMaxLeft));
            }
            else if (localMaxRight < localMaxLeft)
            {
                spaces = spaces - ((walls.Length / 2) - localMaxLeftIndex * (localMaxLeft - localMaxRight));
            }
            return spaces;
        }

    }
}
