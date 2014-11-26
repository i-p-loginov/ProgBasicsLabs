using System;
using System.Collections.Generic;

namespace v8lab6
{
    public sealed class EquationFileModel
    {
        public EquationFileModel(Solution solution)
        {
            if (solution == null)
                throw new ArgumentNullException();

            this.Roots = solution.Roots;
            this.Equation = solution.Equation;
        }

        public IEnumerable<double> Roots
        {
            get;
            private set;
        }

        public Equation Equation
        {
            get;
            private set;
        }

        public override string ToString()
        {
            //а вот тут нужно придумать формат хранения 1 уравнения с решениями.
            //вариант:
            //a,b;c,d;e,f;
            //23.2323;32323;2323;4343;
            throw new NotImplementedException("");
            //return base.ToString();
        }
    }
}
