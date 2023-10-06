using AI.Visualize.Domain.ContainerObjects;
using AI.Visualize.Domain.Model_Containers.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI.Visualize.Domain.Model_Containers
{
    public class BasicModelContainer : IModelContainer
    {
        private IList<Point<_3Vector, _3Vector>> vectorPointsList;
        public BasicModelContainer(IList<Point<_3Vector, _3Vector>> vectorPointsList)
        {

            this.vectorPointsList = vectorPointsList;
        }
        public IList<Point<_3Vector, _3Vector>> VectorPointsList
        {
            get { return vectorPointsList; }

        }
    }
}
