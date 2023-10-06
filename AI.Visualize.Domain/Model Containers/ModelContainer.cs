using AI.Visualize.Domain.Model_Containers.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI.Visualize.Domain.Model_Containers
{
    public class ModelContainer : IModel
    {
        public IModelContainer container { get; private set; }

        public ModelContainer(IModelContainer container)
        {
            this.container = container;
        }

    }
}
