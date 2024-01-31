//namespace _Esercizio03_BankAccount
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Benvenuto nel sistema");

//            Console.Write("Inserisci il tuo nome: ");
//            string firstName = Console.ReadLine();

//            Console.Write("Inserisci il tuo cognome: ");
//            string lastName = Console.ReadLine();

//            Console.Write("Inserisci la tua città: ");
//            string city = Console.ReadLine();

//            Random random = new Random();
//            string accountNumber = random.Next(100000, 999999).ToString();

//            Console.WriteLine($"Il tuo numero di conto è: {accountNumber}");

//            int initialBalance;
//            do
//            {
//                Console.Write("Inserisci un deposito iniziale (minimo 1000 euro): ");
//                initialBalance = int.Parse(Console.ReadLine());
//            } while (initialBalance < 1000);

//            BankAccount account = new BankAccount(accountNumber, initialBalance, firstName, lastName, city);

//            Console.WriteLine($"Benvenuto {account.FirstName} n° {account.AccountNumber}");

//            while (true)
//            {
//                Console.WriteLine($"Il tuo saldo attuale è {account.Balance}");
//                Console.WriteLine("Seleziona un'opzione:");
//                Console.WriteLine("1. Versare");
//                Console.WriteLine("2. Prelevare");
//                Console.WriteLine("3. Uscire");

//                string option = Console.ReadLine();

//                switch (option)
//                {
//                    case "1":
//                        Console.Write("Inserisci l'importo da versare:");
//                        int depositAmount = int.Parse(Console.ReadLine());
//                        account.Deposit(depositAmount);
//                        break;
//                    case "2":
//                        Console.Write("Inserisci l'importo da prelevare:");
//                        int withdrawalAmount = int.Parse(Console.ReadLine());
//                        account.Withdraw(withdrawalAmount);
//                        break;
//                    case "3":
//                        return;
//                    default:
//                        Console.Write("Opzione non valida.");
//                        break;
//                }
//            }
//        }
//    }

//    public class BankAccount
//    {
//        public string AccountNumber { get; set; }
//        public int Balance { get; set; }
//        public string FirstName { get; set; }
//        public string LastName { get; set; }
//        public string City { get; set; }

//        public BankAccount(string _accountNumber, int _initialBalance, string _firstName, string _lastName, string _city)
//        {
//            AccountNumber = _accountNumber;
//            Balance = _initialBalance;
//            FirstName = _firstName;
//            LastName = _lastName;
//            City = _city;
//        }

//        public void Deposit(int amount)
//        {
//            if (amount > 0)
//            {
//                Balance += amount;
//                Console.WriteLine($"Hai versato {amount} euro.");
//            }
//            else
//            {
//                Console.WriteLine("L'importo deve essere maggiore di zero.");
//            }
//        }

//        public void Withdraw(int amount)
//        {
//            if (amount > 0 && amount <= Balance)
//            {
//                Balance -= amount;
//                Console.WriteLine($"Hai prelevato {amount} euro.");
//            }
//            else
//            {
//                Console.WriteLine("Importo non valido o saldo insufficiente.");
//            }
//        }
//    }
//}

//namespace _Esercizio03_ArrayNomi
//{
//    internal class Program
//    {
//        static void Main(string[] arg)
//        {
//            Console.WriteLine("Inserisci il numeri di nomi da inserire:");
//            int dimension = int.Parse(Console.ReadLine());
//            string[] names = new string[dimension];

//            for (int i = 0; i < names.Length; i++)
//            {
//                Console.Write($"Inserisci il nome {i + 1}: ");
//                names[i] = Console.ReadLine();
//            }

//            Console.Write("Inserisci il nome da ricercare:");
//            string searchName = Console.ReadLine();

//            int index = 0;
//            bool foundIt = false;

//            while (index < names.Length && !foundIt)
//            {
//                if (names[index] == searchName)
//                {
//                    foundIt = true;

//                }
//                else
//                {
//                    index++;
//                } 
//            }

//            if (foundIt)
//            {
//                Console.WriteLine("Il nome è presente");
//            }
//            else
//            {
//                Console.WriteLine("Il nome non è presente");
//            }
//        }
//    }
//}


namespace _Esercizio03_SommaEMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quanto numeri sono dentro l'array?: ");
            int dimension = int.Parse(Console.ReadLine());
            int[] numbers = new int[dimension];

            int sum= 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Inserisci il numero {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i];
            }

            int average = sum / numbers.Length;

            Console.WriteLine($"La somma è {sum} e la media è {average}");
        }
    }
}