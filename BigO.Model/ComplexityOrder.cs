using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO.Model
{
    public abstract class ComplexityOrder
    {
        public abstract int Execute(List<int> collection);
        public abstract int ExecuteMultipleOperations(List<int> collection);
    }
}
