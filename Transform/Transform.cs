using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{
    public static class Transform 
    {
        public static List<int> Map(this int[] numbers, Func<int, int> operation)
        {
            List<int> operation_list = new List<int>();
            foreach(int digit in numbers){
              operation_list.Add(operation(digit));
            }
            return operation_list;
        }
    }
}
