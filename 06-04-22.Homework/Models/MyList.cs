using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_04_22.Homework.Models
{
    class MyList<T>
    {
        public T[] nums;
        public MyList()
        {
            nums = new T[0];
        }
        public T this[int index]
        {
            get { return nums[index]; }
            set
            {
                nums[index] = value;
            }
        }

        


        
    }
}