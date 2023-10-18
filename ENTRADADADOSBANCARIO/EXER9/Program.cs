using EXER9;
using System.Globalization;

    namespace Program
    {
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;


            Console.WriteLine("Entre o número da conta: ");
            int Numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre titular da conta: ");
            string titular = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial (s/n) ? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.WriteLine("Digite o valor do depósito");
                double DepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(Numero, titular, DepositoInicial);
            }
            else
            {
                conta = new ContaBancaria(Numero, titular);
                Console.WriteLine("Depósito cancelado");
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Entre valor de depósito: ");
            double quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture); 
            conta.Deposito(quantia);
            Console.WriteLine("DADOS DE CONTA ATUALIZADOS: " );
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Entre valor de saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("DADOS DE CONTA ATUALIZADOS: ");
            Console.WriteLine(conta);


        }

    }

    }
