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


class Program
{
    static void Main()
    {
        int i = 10;
        int i2 = i;
        i2 = 20;

        Test t = new Test();
        t.X = 12;
        
        t = null;

        Test t2 = t;
        t2 = new Test();
        t2.X = 20;

        Console.WriteLine(t.X);
    }
}

*/

class Program
{
      static void Main()
      {
            BankAccount account1 = new BankAccount("Dutra", 1000);
 
            BankAccount account2 = new BankAccount("Peter", 1000);

            account1.Deposit(-100);

            account2.Deposit(100);

            console.WriteLine(account2.GetBalance());
      }
}

class BankAccount
{
      private string name;

      private decimal balance;

      public BankAccount(string name, decimal balance)
      {
            if(string.IsNullOrWhiteSpace(name))
            {
                  throw new Exception("Nome inválido.", nameof(name));
            }
            if(balance < 0)
            {
                  throw new Exception("Saldo não pode ser negativo.");
            }
            this.name = name;
            this.balance = balance;
      }
      public void Deposit(decimal amount)
      {
            if(amount <= 0)
            {
                  return;
            }

            balance += amount;
      }

      public decimal GetBalance()
      {
            return balance;
      }
}