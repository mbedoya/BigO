using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO.Model
{
    public class ConstantOrder : ComplexityOrder
    {
        public override int Execute(List<int> collection)
        {
            if (collection != null && collection.Count > 0)
            {
                return collection[0];
            }

            return 0;
        }

        public override int ExecuteMultipleOperations(List<int> collection)
        {
            int aux = 3;

            if (collection != null && collection.Count > 0)
            {
                if (collection[0] == 3)
                {
                    aux = aux * 2 - 2;
                }
                else
                {
                    return aux;
                }
            }

            return 0;
        }
    }
}
