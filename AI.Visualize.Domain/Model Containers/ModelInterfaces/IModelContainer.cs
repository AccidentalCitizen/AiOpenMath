using AI.Visualize.Domain.ContainerObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI.Visualize.Domain.Model_Containers.ModelInterfaces
{
    public interface IModelContainer
    {
        IList<Point<_3Vector, _3Vector>> VectorPointsList { get; }
    }
}
