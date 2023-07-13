using AiOpenMath.Domain.Basic;
using AiOpenMath.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiOpenMath.Domain
{
    public static class UniversityIntegration
    {
        private static Dictionary<int, Pair<string, string>> IntegralStore(string repX)
        {
            var derivativeStore = new Dictionary<int, Pair<string, string>>();
            derivativeStore.Add(1, new Pair<string, string>("csc (x)", "- ln|csc (x) + cot (x)|"));
            derivativeStore.Add(2, new Pair<string, string>("b^(x)", "{b^(x)}/{ln(b)}"));
            derivativeStore.Add(3, new Pair<string, string>("ln|sec (x) + tan (x)|", "sec (x)"));
            derivativeStore.Add(4, new Pair<string, string>("ln(x)", "(x) ln(x) - (x)"));
            derivativeStore.Add(5, new Pair<string, string>("csc^2 (x)", "- cot (x)"));
            derivativeStore.Add(6, new Pair<string, string>(" sec (x) tan (x)", "sec (x)"));
            derivativeStore.Add(7, new Pair<string, string>(" sec^2 (x)", " tan (x)"));
            derivativeStore.Add(8, new Pair<string, string>("arcsin (x)", "(x) arcsin (x) + √{1-(x)^2}"));
            derivativeStore.Add(9, new Pair<string, string>("arccsc (x)", "(x) arccos (x) - √{1-(x)^2}"));
            derivativeStore.Add(10, new Pair<string, string>("arctan (x)", "(x) arctan (x) - {1/2} ln(1+(x)^2)"));
            derivativeStore.Add(11, new Pair<string, string>("1 /{ √{1 - (x)^2}}", "arcsin (x)"));
            derivativeStore.Add(12, new Pair<string, string>("1 /{(x) √{(x)^2 - 1}}", "arcsec|(x)|"));
            derivativeStore.Add(13, new Pair<string, string>("1 /{1 + (x)^2}", "arctan (x)"));
            foreach (var pair in derivativeStore) { var p = pair.Value; p.GetKey = p.GetKey.Replace("x", repX); p.GetValue = p.GetValue.Replace("x", repX); }
            return derivativeStore;
        }

        private static Dictionary<int, Pair<string, string>> LaplaceStore(string repX)
        {
            var derivativeStore = new Dictionary<int, Pair<string, string>>();
            derivativeStore.Add(1, new Pair<string, string>("t", "1/(s^2)"));
            derivativeStore.Add(2, new Pair<string, string>("1", "1/(s)"));
            derivativeStore.Add(3, new Pair<string, string>("t^k/{k!}", "1/{s^{ k + 1}}"));
            derivativeStore.Add(4, new Pair<string, string>("e^{at}", "1/{s-a}"));
            derivativeStore.Add(5, new Pair<string, string>("Cos(ωt)", "s/{s^2 + ω^2}"));
            derivativeStore.Add(6, new Pair<string, string>("Sin(ωt)", ""));
            derivativeStore.Add(7, new Pair<string, string>("Cos(ωt + φ)", "{s cos φ − ω sin φ} / {s^2 + ω^2}"));
            derivativeStore.Add(8, new Pair<string, string>("e^{ −at } cos ωt", "{s + a}/{(s + a)^2 + ω^2}"));
            derivativeStore.Add(9, new Pair<string, string>("e^{ −at } sin ωt", "ω/{(s + a)^2 + ω^2}"));
            derivativeStore.Add(10, new Pair<string, string>("t^{n - 1/2}", @"\displaystyle \frac{{1 \cdot 3 \cdot 5 \cdots \left( {2n - 1} \right)\sqrt \pi  }}{{{2^n}{s^{n + \frac{1}{2}}}}}"));
            derivativeStore.Add(11, new Pair<string, string>("tSin(at)", "2as/{s^2 + a^2}^2"));
            derivativeStore.Add(12, new Pair<string, string>("tCos(at)", "{s^2 - a^2}/{s^2 + a^2}^2"));
            derivativeStore.Add(13, new Pair<string, string>("Sin(at + b)", @"\displaystyle \frac{{s\sin \left( b \right) + a\cos \left( b \right)}}{{{s^2} + {a^2}}}"));
            derivativeStore.Add(14, new Pair<string, string>("Cos(at + b)", @"\displaystyle \frac{{s\cos \left( b \right) - a\sin \left( b \right)}}{{{s^2} + {a^2}}}"));
            derivativeStore.Add(15, new Pair<string, string>("t^n e^{at}", "(s - a)^{n+1}"));
            foreach (var pair in derivativeStore) { var p = pair.Value; p.GetKey = p.GetKey.Replace("t", repX); p.GetValue = p.GetValue.Replace("x", repX); }
            return derivativeStore;
        }


        //uv - ∫ v du


        private static Dictionary<int, Pair<string, string>> IntegralStore()
        {
            var derivativeStore = new Dictionary<int, Pair<string, string>>();
            derivativeStore.Add(1, new Pair<string, string>("csc (x)", "- ln|csc (x) + cot (x)|"));
            derivativeStore.Add(2, new Pair<string, string>("b^(x)", "{b^(x)}/{ln(b)}"));
            derivativeStore.Add(3, new Pair<string, string>("ln|sec (x) + tan (x)|", "sec (x)"));
            derivativeStore.Add(4, new Pair<string, string>("ln(x)", "(x) ln(x) - (x)"));
            derivativeStore.Add(5, new Pair<string, string>("csc^2 (x)", "- cot (x)"));
            derivativeStore.Add(6, new Pair<string, string>(" sec (x) tan (x)", "sec (x)"));
            derivativeStore.Add(7, new Pair<string, string>(" sec^2 (x)", " tan (x)"));
            derivativeStore.Add(8, new Pair<string, string>("arcsin (x)", "(x) arcsin (x) + √{1-(x)^2}"));
            derivativeStore.Add(9, new Pair<string, string>("arccsc (x)", "(x) arccos (x) - √{1-(x)^2}"));
            derivativeStore.Add(10, new Pair<string, string>("arctan (x)", "(x) arctan (x) - {1/2} ln(1+(x)^2)"));
            derivativeStore.Add(11, new Pair<string, string>("1 /{ √{1 - (x)^2}}", "arcsin (x)"));
            derivativeStore.Add(12, new Pair<string, string>("1 /{(x) √{(x)^2 - 1}}", "arcsec|(x)|"));
            derivativeStore.Add(13, new Pair<string, string>("1 /{1 + (x)^2}", "arctan (x)"));
            return derivativeStore;
        }


        public static string IntegrationByParts(IHomeworkParameters parameters)
        {
            Dictionary<int, Pair<string, string>> derivativeStore = IntegralStore();

            //Let u=x and let v = key in the pair
            var rnd = new Random();
            var val = rnd.Next(1, 13);
            var v = derivativeStore[val].GetKey;
            var full = "" + derivativeStore[val].GetValue;
            return "∫" + "x*" + v + " dx" + "\n $ Answer :=" + "x*" + v + "-" + full;
        }




        public static string IntegrationStandard2D(IHomeworkParameters parameters)
        {
            var derivativeStore = IntegralStore();

            var derivativeStorey = IntegralStore("y");

            //Let u=x and let v = key in the pair
            var rnd = new Random();
            var a = rnd.Next(1, 13).ToString();
            var b = rnd.Next(1, 13).ToString();
            var c = rnd.Next(1, 13).ToString();
            var d = rnd.Next(1, 13).ToString();
            var val = rnd.Next(1, 13);
            var valy = rnd.Next(1, 13);
            var v = derivativeStore[val].GetKey;// Integral
            var yv = derivativeStorey[valy].GetKey; // Integral
            var dy = derivativeStorey[valy].GetValue;// Derivative
            var replaced = v.Replace("x", "(" + yv + ")");
            var integral = "∫_a^b".Replace("a", a).Replace("b", b) +
                "∫_a^b".Replace("a", "{" + c + yv + "}").Replace("b", "{" + d + yv + "}")
                + v + " (" + dy + ") " + "dxdy";
            var full = "" + derivativeStore[val].GetValue;// Derivative
            return integral + "\n $ Answer := set dy = " + derivativeStorey[valy].GetValue + "set dv = " + derivativeStore[val].GetValue;
        }
        public static string IntegrationJacobian2D(IHomeworkParameters parameters)
        {
            parameters.ComplexityID = 2;

            var derivativeStoreUV = IntegralStore("(uv)");
            var derivativeStoreV = IntegralStore("v");
            var derivativeStoreU = IntegralStore("u");

            //Let u=x and let v = key in the pair
            var rnd = new Random();
            var a = rnd.Next(-13, 13).ToString();
            var b = rnd.Next(-13, 13).ToString();
            var c = rnd.Next(-13, 13).ToString();
            var d = rnd.Next(-13, 13).ToString();
            var valFunc = rnd.Next(1, 13);
            var val = rnd.Next(1, 13);
            var valy = rnd.Next(1, 13);
            var val1 = rnd.Next(1, 13);
            var valy1 = rnd.Next(1, 13);

            var Guv = derivativeStoreUV[valFunc].GetValue;
            //uv will be substituted
            var Gx = "";
            if (parameters.ComplexityID == 2)
            {
                var Dux = derivativeStoreU[val].GetValue;
                var Dvy = derivativeStoreV[valy1].GetValue;
                var Duy = derivativeStoreV[valy].GetValue;
                var Dvx = derivativeStoreU[val1].GetValue;

                Guv = Guv.Replace("u", "(" + derivativeStoreU[val].GetKey + ")");
                Guv = Guv.Replace("v", "(" + derivativeStoreV[valy1].GetKey + ")");
                Guv = " ∫∫" + Guv + "(" + Dux + ")" + "(" + Dvy + ")" + " du dv " + "+ ∫∫" + Guv + "(" + Dvx + ")" + "(" + Duy + ")" + "du dv";
            }
            if (parameters.ComplexityID == 1)
            {
                Gx = "∫∫" + derivativeStoreU[val].GetValue.Replace("u", "(" + a + "x + " + b + "y)") + "(" + derivativeStoreV[val1].GetValue.Replace("v", "(" + c + "x + " + d + "y)") + ")" + "dx dy";
            }
            return Guv + "\n $ Answer := set u =" + derivativeStoreU[val].GetValue + " set v = " + derivativeStoreU[valy1].GetValue;
        }
        public static string LIneIntegral(IHomeworkParameters parameters)
        {
            parameters.ComplexityID = 1;
            var rnd = new Random();
            var result = "";
            var a = rnd.Next(-13, 13).ToString();
            var b = rnd.Next(-13, 13).ToString();
            var val1 = rnd.Next(1, 13);
            var val2 = rnd.Next(1, 13);
            var val3 = rnd.Next(1, 13);
            Dictionary<int, Pair<string, string>> integral = new Dictionary<int, Pair<string, string>>();
            if (parameters.ComplexityID == 1)
            {
                integral = IntegralStore("(" + a + "x" + b + ")");
                result = "∲" + "𝙞 (" + integral[val1].GetValue + ")" + "+ 𝙟 (" + integral[val2].GetValue + ")" + "+ 𝙠 (" + integral[val3].GetValue + ") dx";
            }
            if (parameters.ComplexityID == 2)
            {
                //var integral = IntegralStore("(" + a + "x^2" + b + ")");
                //result = " ∫" + "𝙞 (" + integral[val1].GetValue + ")" + "𝙟 (" + integral[val2].GetValue + ")" + "𝙠 (" + integral[val3].GetValue + ") dt";

            }

            return result + "\n $ Answer := i " + integral[val1].GetKey + " j " + integral[val2].GetKey + " k " + integral[val2].GetKey;
        }
        public static string IntegrationLaplace(IHomeworkParameters parameters)
        {
            parameters.ComplexityID = 1;

            var laplace = LaplaceStore("t");

            //Let u=x and let v = key in the pair
            var rnd = new Random();
            var a = rnd.Next(1, 13).ToString();
            var b = rnd.Next(1, 13).ToString();
            var c = rnd.Next(1, 13).ToString();
            var d = rnd.Next(1, 13).ToString();
            var val = rnd.Next(1, 13);
            var valy = rnd.Next(1, 13);

            var differentialequation = "";
            if (parameters.ComplexityID == 1)
            {
                differentialequation = "{d^2y}/{dt^2} + {dy}/{dt} + y = " + laplace[val].GetKey;
            }
            return differentialequation + "\n $ Answer := set value of operator to " + laplace[val].GetValue;
        }

        public static string LeibnezDifferentialEquation(IHomeworkParameters parameters)
        {
            // ∫P need be integrable and ∫Q [e^∫P]
            var integralStore = IntegralStore("x");
            parameters.ComplexityID = 1;

            var rnd = new Random();
            var a = rnd.Next(1, 13).ToString();
            var b = rnd.Next(1, 13).ToString();
            var val = rnd.Next(1, 13);
            var vale = rnd.Next(-1, 1);

            var differentialequation = "";
            if (parameters.ComplexityID == 1)
            {
                val = rnd.Next(1, 13);
                vale = rnd.Next(-1, 1);
                differentialequation = "{dy}/{dx} + y(" + a + "x + " + b + ")^{" + vale.ToString() + "} = " + integralStore[val].GetValue;
            }
            return differentialequation + "\n $ Answer :=";
        }
    }
}
