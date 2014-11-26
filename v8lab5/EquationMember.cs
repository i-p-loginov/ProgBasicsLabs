
namespace v8lab5
{
    /// <summary>
    /// Элемент полинома
    /// </summary>
    public struct EquationMember
    {
        private readonly int _exponent;

        private readonly double _factor;

        public EquationMember(double factor, int exponent)
        {
            this._factor = factor;
            this._exponent = exponent;            
        }

        /// <summary>
        /// Показатель степени.
        /// </summary>
        public int Exponent
        {
            get
            {
                return this._exponent;
            }
        }

        /// <summary>
        /// Коэффициент перед элементом полинома.
        /// </summary>
        public double Factor
        {
            get
            {
                return this._factor;
            }
        }
        
    }
}
