﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Fibonacci : Integer
    {
        private int[] elements;
        public Fibonacci()
        {
            First = 1;
            elements = new int[Max];
            for (int i= 0; i < Max; i++)
            {
                elements[i] = GetNth(i + 1);
            }
        }

        public override int GetNext(int current)
        {
            return base.GetNext(current);
        }

        public int GetNth(int n)
        {
            if (n<=0) { throw new Exception(); }

            if ( n == 1 || n == 2) 
            {
                return 1;
            }
            else
            {
                return GetNth(n - 1) + GetNth(n - 2);
            }
            
        }
        override public int[] GetSequence(int how_many)
        {
            if (how_many > Max)
            {
                throw new Exception();
            }
            int[] seq_array = new int[how_many];
            /*
            for (int i = 0; i < how_many; i++)
            {
                seq_array[i] = i;
            }*/
            int counter = 0;
            seq_array[counter] = GetFirst();
            while (counter < how_many - 1)
            {
                /* Attempt 1
                seq_array[counter+1] = GetNext(seq_array[counter]);
                counter++;
                */
                counter++;
                seq_array[counter] = GetNext(seq_array[counter - 1]);
            }

            for (int n = 0; n < how_many; n++)
            {
                seq_array[n] = GetNth(n + 1);
            }

            return seq_array;
        }
    }
}
