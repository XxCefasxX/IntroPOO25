namespace Intro
{
    public static class Edades
    {
        public static string ValidaEdad(int Edad)
        {
            string generacion = "";
            if (Edad < 4)
            {
                generacion = "Bebe";
            }
            else if (Edad < 13)
            {
                generacion = "Niño";
            }
            else if (Edad < 18)
            {
                generacion = "Adolecente";
            }
            else if (Edad < 60)
            {
                generacion = "Adulto";
            }
            else
            {
                generacion = "Anciano";
            }
            return generacion;
        }
    }
}
