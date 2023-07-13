using AiOpenMath.Domain.Basic;
using AiOpenMath.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiOpenMath.Domain
{
    public static class Gr12Wrapper
    {
        public static Func<IHomeworkParameters, string> GetSubSyllabusQuestionGenerator(int index)
        {
            IList<Triplet> tripletList = new List<Triplet>()
            {
                new Triplet(1,"BasicTrigGen",clsGr12.BasicTrigGen),
                new Triplet(2,"Integration by Parts",UniversityIntegration.IntegrationByParts),
                new Triplet(3,"SequenceSeries",clsGr12.SequenceSeries),
                new Triplet(4,"TrigProblems",clsGr12.TrigProblems),
                new Triplet(5,"TrigEqGen",clsGr12.TrigEqGen),
                new Triplet(6,"Cubic",clsGr12.Cubic),
                new Triplet(7,"LinearProgramming",clsGr12.LinearProgramming),
                new Triplet(8,"LineGraph",clsGr12.LineGraph),
                new Triplet(9,"Differentiation",clsGr12.Differentiation),
                new Triplet(10,"LogEquations",clsGr12.LogEquations),
                new Triplet(13,"2D Integration",UniversityIntegration.IntegrationStandard2D),
                new Triplet(14,"2D Jacobian Integration",UniversityIntegration.IntegrationJacobian2D),
                new Triplet(15,"Line Integration",UniversityIntegration.LIneIntegral),
                new Triplet(16,"Laplace Differential Equations",UniversityIntegration.IntegrationLaplace),
                new Triplet(17,"Leibniz Differential Equations",UniversityIntegration.LeibnezDifferentialEquation)
            };

            return tripletList.Single(r => r.index == index).function;
        }
    }
}
