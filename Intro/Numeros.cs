namespace Intro
{
    public static class Numeros
    {
        //public bool EsPar(int Numero)
        //{
        //    bool par = (Numero % 2) == 0;
        //    return par;
        //}

        //public bool EsPar(int Numero)
        //{
        //    return (Numero % 2) == 0;
        //}

        public static bool EsPar(int Numero) => (Numero % 2) == 0;

        //Metodo para validar si es primo
        public static bool EsPrimo(int Numero)
        {
            for(int i = 2; i < Numero/2; i++)
            {
                if (Numero % i == 0) return false;
            }
            return true;
        }
        //Metodo para calcular factorial
        public static int Factorial(int Numero)
        {
            int fact = Numero;
            for(int i = Numero - 1; i > 1; i--)
            {
                //fact = fact * i;
                fact *= i;
            }
            return fact;
        }
    }
}
