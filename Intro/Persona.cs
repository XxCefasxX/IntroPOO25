using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Nacimiento { get; set; }
        public int Edad { get; }

        //Constructor de la clase
        public Persona(string nombre,string apellido, DateTime nacimiento ) 
        {
            try
            {
                Console.WriteLine("Este es el constructor de Persona");
                Nombre = nombre;
                Apellido = apellido;
                Nacimiento = nacimiento;

                //Juan
                TimeSpan ts = DateTime.Now - Nacimiento;//difrencia de dias entre 2 fechas
                Edad = Convert.ToInt32(Math.Floor (ts.TotalDays / 365.25));

                //Kall-el
                //Edad = DateTime.Now.Year - nacimiento.Year;
                //if (DateTime.Now.Month < Nacimiento.Month || 
                //    (DateTime.Now.Month==Nacimiento.Month && DateTime.Now.Day<Nacimiento.Day))
                //{
                //    Edad--;
                //}


            }
            catch(Exception ex)
            {
                Console.WriteLine($"error: {ex.Message}");
            }
        }
       
    }
}
