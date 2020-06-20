using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9
{
    class List
    {
        public int value;

        public List prev;

        public List next;

        public List(int val)
        {
            value = val;
        }

        public void Show()
        {
            Console.Write(value + " ");
        }
    }
}