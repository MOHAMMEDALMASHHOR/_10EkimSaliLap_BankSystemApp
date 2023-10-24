// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, User");
Account user1 = new Account();
user1.Balance = 10000;
user1.FirstName ="Mohammed";
user1.LastName = "Almashhor";
user1.CheckAccount();
user1.Deposit(500);
user1.Deposit(500);
user1.Withdrawl(500);
user1.AccountActivites();
user1.CheckAccount();

//user1.Withdrawl(00);
Account user2= new Account("Mohammed","Almashhor");
user1.Balance = 10000;

user1.CheckAccount();
user1.Deposit(500);
user1.Deposit(500);
user1.Withdrawl(500);
user1.AccountActivites();
user1.CheckAccount();



