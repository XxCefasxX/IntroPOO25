/*
Calculadora calc = new Calculadora();

Console.WriteLine("Ingrese el numero 1:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el numero 2:");
int num2 = Convert.ToInt32(Console.ReadLine());

int totalsuma = calc.Suma(num1,num2);
int totalresta = calc.Resta(num1,num2);
int totalmulti = calc.Multiplicacion(num1,num2);
double totaldivi = calc.Division(num1,num2);

//Console.WriteLine("El total de la suma es: "+ totalsuma);
Console.WriteLine($"El total de la suma es: {totalsuma}");
Console.WriteLine($"El total de la resta es: {totalresta}");
Console.WriteLine($"El total de la multiplicacion es: {totalmulti}");
Console.WriteLine($"El total de la division es: {totaldivi}");
*/

/*
Console.WriteLine("Ingresa tu edad:");
int edad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"La persuna es un: {Edades.ValidaEdad(edad)}");
*/

using Intro;

Console.WriteLine("Ingresa un Numero: ");
int numero= Convert.ToInt32(Console.ReadLine());
if (Numeros.EsPar(numero))
{
    Console.WriteLine("El numero es par");
}
else
{
    Console.WriteLine("El numero es impar");
}