using Intro;

Calculadora calc = new Calculadora();

Console.WriteLine("Ingrese el numero 1:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el numero 2:");
int num2 = Convert.ToInt32(Console.ReadLine());

int totalsuma = calc.Suma(num1,num2);

//Console.WriteLine("El total de la suma es: "+ totalsuma);
Console.WriteLine($"El total de la suma es: {totalsuma}");