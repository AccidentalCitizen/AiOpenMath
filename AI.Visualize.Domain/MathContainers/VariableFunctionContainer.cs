using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI.Visualize.Domain.MathContainers
{
    public static class VariableFunctionContainer
    {
        public static IList<Func<double, double, double, double, double>> FunctionCoEfficientList { get; set; }

        public static double GetCurrentValue(int functionIndex, double u, double v, double w, double t)
        {
            return FunctionCoEfficientList[functionIndex](u, v, w, t);
        }
    }
}
