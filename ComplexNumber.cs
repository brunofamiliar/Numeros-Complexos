namespace Aula3ex4
{
    class ComplexNumber
    {
        private double realPart;
        private double imaginaryPart;
        
        public double RealPart {
            get {
                return realPart;
            }
            set {
                realPart = value;
            }
        }
        public double ImaginaryPart
        {
            get
            {
                return imaginaryPart;
            }
            set
            {
                imaginaryPart = value;
            }
        }

        //Construtor da classe

        public ComplexNumber(double realPart, double imaginaryPart) {
            this.realPart = realPart;
            this.imaginaryPart = imaginaryPart;
        }


        //Métodos retornam um novo objeto com o valor da operação
        public ComplexNumber addition(ComplexNumber complexNumber) {
             double resultRealPart = RealPart + complexNumber.RealPart;
            double resultImaginaryPart = ImaginaryPart + complexNumber.ImaginaryPart;
            return new ComplexNumber(resultRealPart, resultImaginaryPart);
        }

        public ComplexNumber subtraction(ComplexNumber complexNumber)
        {
            double resultRealPart = RealPart - complexNumber.RealPart;
            double resultImaginaryPart = ImaginaryPart - complexNumber.ImaginaryPart;
            return new ComplexNumber(resultRealPart, resultImaginaryPart);
        }
    }
}
