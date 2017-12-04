using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract1
{
    public class RangeOfArray
    {
        private int Start { get; set; }
        private int Finish { get; set; }
        private int[] _array;

        public int this[int index]
        {
            get
            {
                if (Start < 0)
                {
                    return _array[(Start * -1) + index];
                }
                else if (Start > 0)
                {
                    return _array[index - Start];
                }
                return -1;
            }

            set
            {
                if (Start < 0)
                {
                    _array[(Start * -1) + index] = value;
                }
                else if (Start > 0)
                {
                    _array[index - Start] = value;
                }
            }
        }

        public RangeOfArray(int start, int finish)
        {
            Start = start;
            Finish = finish;
            if (start < 0 && finish < 0)
            {
                start = start * -1;
                finish = finish * -1;
                int x = start;
                start = finish;
                finish = x;
            }
            _array = new int[finish - start];
        }
    }
}
