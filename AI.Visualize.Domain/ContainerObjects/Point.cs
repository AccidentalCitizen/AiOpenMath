using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI.Visualize.Domain.ContainerObjects
{
    public class Point<X, Y>
    {
        public X Xval { get; private set; }
        public Y Yval { get; private set; }
        public Point(X Xval,
                     Y Yval)
        {
            this.Xval = Xval;
            this.Yval = Yval;
        }
    }
}
