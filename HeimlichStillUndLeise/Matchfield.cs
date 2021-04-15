using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeimlichStillUndLeise
{
    public class Matchfield
    {
        private char[,] MyMatchfield;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="size">size muss eine gerade Zahl sein</param>
        public Matchfield(int size)
        {
            MyMatchfield = new char[size, size];
            for (int y = 0; y < MyMatchfield.GetLength(0); y++)
            {
                for (int x = 0; x < MyMatchfield.GetLength(1); x++)
                {
                    MyMatchfield[y, x] = ' ';
                }
            }
            MyMatchfield[size / 2 - 1, size / 2 - 1] = 'X';     //B2
            MyMatchfield[size / 2, size / 2 - 1] = 'O';         //B3
            MyMatchfield[size / 2 - 1, size / 2] = 'O';         //C2
            MyMatchfield[size / 2, size / 2] = 'X';             //C3
        }
        public char GetField(int y, int x)
        {
            return MyMatchfield[y, x];
        }

        public char GetField(int y, char x)
        {
            int xnumber = Convert.ToInt32(x)-65;
            return GetField(y, xnumber);
        }

        public void SetField(int y, int x, char value)
        {
            MyMatchfield[y, x] = value;
        }

        public void SetField(int y, char x, char value)
        {
            int xnumber = Convert.ToInt32(x) - 65;
            SetField(y, xnumber, value);
        }

        public IEnumerable<char> GetAllFields()
        {
            List<char> result = new List<char>();

            foreach (char c in MyMatchfield)
            {
                result.Add(c);
            }

            return result;
        }

        public int GetLength(int dimension)
        {
            return MyMatchfield.GetLength(dimension);
        }
    }
}
