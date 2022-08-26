/*Console.WriteLine("Digite seu nome: ");
string name = Console.ReadLine();
Console.WriteLine($"Olá {name}, Seja muito bem vindo!");
Console.WriteLine("Digite o ano de nascimento: ");
int year = int.Parse(Console.ReadLine());
int age = 2022 - year;
Console.WriteLine($" O Sr. {name} tem a idade de: {age} anos!");

if (age >= 18 ) 
{
    Console.WriteLine("Você é maior de idade.");
}
else 
{
    Console.WriteLine("você é menor de idade. ");
}
*/

class Program
{
    static void Main()
    {
        int i = 10;
        int i2 = i;
        i2 = 20;

        Test t = new Test();
        t.X = 12;
        
        Test t2 = t;
        t2 = new Test();
        t2.X = 20;

        Console.WriteLine(t.X);
    }
}

