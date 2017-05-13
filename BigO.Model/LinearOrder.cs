using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO.Model
{
    public class LinearOrder : ComplexityOrder
    {
        public override int Execute(List<int> collection)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                                
            }

            return 0;
        }

        public override int ExecuteMultipleOperations(List<int> collection)
        {
            double sum = 0;
            int num;
            for (int i = 0; i < collection.Count; i++)
            {
                num = collection[i];
                sum = sum + num;
                if (num > 3000)
                {
                    sum = sum - 1;
                }
            }

            return 0;
        }
    }
}
