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

/*
Console.WriteLine("Ingresa un Numero: ");
int numero= Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"El factorial del numero es {Numeros.Factorial(numero)}");
*/


//using Intro;

//int[] arreglonumeros = new int[10];
//string[] listatexto = {"d","s","dsds"};
//bool[] listabool=new bool[5];
//arreglonumeros[0] = 5;
//arreglonumeros[1] = 3;
//arreglonumeros[2] = 8;
//arreglonumeros[3] = 7;
//arreglonumeros[4] = 17;
//arreglonumeros[5] = 19;
//arreglonumeros[5] = 10;
//arreglonumeros[9] = 20;



//List<int> listaint = new List<int>();
//listaint.Add(2);
//listaint.Add(23);
//listaint.Add(6);

//for(int i = 0; i < listaint.Count; i++)
//{
//    Console.WriteLine(listaint[i]);
//}

//List<int> lista = new List<int>();
//Console.WriteLine("Cuantos numeros quiere?");
//int n = Convert.ToInt32(Console.ReadLine());
//for (int i = 0; i < n; i++)
//{
//    Console.WriteLine("Ingresa un numero");
//    int num= Convert.ToInt32(Console.ReadLine());
//    lista.Add(num);
//}
//for(int i = 0; i < lista.Count; i++)
//{
//    int numero = lista[i];

//}


using Intro;
DateTime nacimiento = Convert.ToDateTime("10/11/1976");
Persona persona = new Persona("Juan","Perez",nacimiento);
Console.WriteLine(persona);

//DateTime nacimiento2 = Convert.ToDateTime("10/9/1976");
//Persona persona2 = new Persona("Juan", "Perez", nacimiento2);
//Console.WriteLine(persona2.Edad);




















