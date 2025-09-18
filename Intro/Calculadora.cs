namespace Intro
{
    public class Calculadora
    {
        public int Suma(int Num1, int Num2)
        {
            return Num1 + Num2;
        }

        //Resta
        public int Resta(int Num1, int Num2)
        {
            return Num1 - Num2;
        }
        //Multi
        public int Multiplicacion(int Num1, int Num2)
        {
            return Num1 * Num2;
        }
        //Div
        public double Division(int Num1, int Num2)
        {
            return Convert.ToDouble( Num1) / Convert.ToDouble( Num2);
        }
    }
}
