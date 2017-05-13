using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO.Model
{
    public class CuadraticOrder : ComplexityOrder
    {
        public override int Execute(List<int> collection)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                for (int j = 0; j < collection.Count; j++)
                {

                }
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
                for (int j = 0; j < collection.Count; j++)
                {
                    sum = sum - j - 1; 
                }
            }

            return 0;
        }
    }
}
