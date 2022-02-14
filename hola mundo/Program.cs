using hola_mundo;
using System.Collections;

ArrayList als = new ArrayList();






int a = 2;
int aa = 1;
long ba = 1289900;
bool ok = false;
double d = 12.3;
char c = 'a';
string s = "esto es un string";

carritos carro = new carritos(300, 4, "jetta");

carritos carro1 = new carritos(400, 4, "mazda");

als.Add(carro);
als.Add(carro1);

Console.WriteLine("als");
Console.WriteLine("    Count:    {0}", als.Count);
Console.WriteLine("    Capacity: {0}", als.Capacity);
Console.Write("    Values:");





Console.WriteLine(carro.getNombre() + " "+ carro.getPuertas() + " "+ carro.getHorsepower());
Console.WriteLine(carro1.getNombre() + " " + carro1.getPuertas() + " " + carro1.getHorsepower());

Console.WriteLine("hola");
Console.WriteLine(s);
Console.WriteLine("esto es un int"+" "+ a);
Console.WriteLine("esto es un bool"+" "+ ok);
Console.WriteLine("esto es un char"+ " "+c);
Console.WriteLine("esto es un bool" + " " +ba );

int sum = Metodocalc(2, 3);
Console.WriteLine("suma de dos numeros: \n"+sum);
bool grande = Metodobol(30);
Console.WriteLine(grande+"\n");

Console.WriteLine("escriba un numero para salir");
int Metodocalc(int a, int b )
{

    return a+b;
}

bool Metodobol(int a)
{
    return a > 10;
}


int i= 5;
if (i > 10)
{
    Console.WriteLine(i+" es mayor a 10");

}
else
{
    Console.WriteLine(i+" es menor a 10");
}

Console.ReadKey();