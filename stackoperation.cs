using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration
{
    internal class stackoperation<T>
    {
        private readonly T[] Segment;
        private int SegmentNumbers;
        private readonly int Limit;
        public stackoperation(int size)
        {
            Segment = new T[size];
            SegmentNumbers = 0;
            Limit = size;
        }
        public void Push(T Unit)
        {
            if (SegmentNumbers == Limit - 1)
            {
                Console.WriteLine("Stack overflow");
            }
            else
            {
                Segment[SegmentNumbers] = Unit;
                SegmentNumbers++;
            }
        }
        public T Pop()
        {
            SegmentNumbers--;
            return Segment[SegmentNumbers];
        }
        public bool IsEmpty()
        {
            return SegmentNumbers == 0;
        }
        public T Peek()
        {
            return Segment[SegmentNumbers - 1];
        }
    }
}
