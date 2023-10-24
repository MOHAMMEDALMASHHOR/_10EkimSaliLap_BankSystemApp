class Account
{
    public List<string> Activities { get; set; }
    private double balance;
    public double Balance
    {
        get { return balance; }
        set {if (value<0)
        {
            throw new Exception("The Balance Can't Be Less Than Zero!!!");
        }
             balance = value; }
    }
    
    public string FirstName { get; set; }
    public string LastName { get; set; }
   // public string FullName { get;  }
    public DateTime AccountDate { get; private set; }
    public DateTime Date { get; private set; }
    //Methods
    public void Deposit(double value){
        Balance+=value;
        Date = DateTime.Now;
        Activities.Add($"In The Date Of {Date} This Amount Of Money: {value} Has Been Deposied. Now The Current Balance is: {Balance}");
    }
    public void Withdrawl(double value){
        if (value <50 || value>10_000)
        {
            throw new Exception("You Can't Withdrawl Money More Than 10000 Or Less Than 50!!!");
        }
        Balance-=value;
        Date = DateTime.Now;
        Activities.Add($"In The Date Of {Date} This Amount Of Money: {value} Has Been Withdrawled. Now The Current Balance is: {Balance}");

    }
    public void AccountActivites(){
        foreach (var item in Activities)
        {
            System.Console.WriteLine(item);
        }
    }
    public Account()
    {
        Activities = new List<string>();
        FirstName = "";
        LastName = "";
        AccountDate = DateTime.Now;
    }
    public Account(string FirstName, string LastName):this()
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
    }
    public void CheckAccount(){
        System.Console.WriteLine($"The Date of Creating the Account: {AccountDate}\nThe Onwer's Full Name: {FirstName} {LastName}\nThe Total Balance Of The Account: {Balance}\nThe Activites That Have Happened: ");
        AccountActivites();
        
    }
}

//Using string[] with indexes 

/* class Account
{
    public string[] Activities { get; set; }
    private double balance;
    int index = 0;
    public double Balance
    {
        get { return balance; }
        set {if (value<0)
        {
            throw new Exception("The Balance Can't Be Less Than Zero!!!");
        }
             balance = value; }
    }
    
    public string FirstName { get; set; }
    public string LastName { get; set; }
   // public string FullName { get;  }
    public DateTime AccountDate { get; private set; }
    public DateTime Date { get; private set; }
    //Methods
    public void Deposit(double value){
        Balance+=value;
        Date = DateTime.Now;
        Activities[index]+=$"In The Date Of {Date} This Amount Of Money: {value} Has Been Deposied. Now The Current Balance is: {Balance}";
        index++;
    }
    public void Withdrawl(double value){
        if (value <50 || value>10_000)
        {
            throw new Exception("You Can't Withdrawl Money More Than 10000 Or Less Than 50!!!");
        }
        Balance-=value;
        Date = DateTime.Now;
        Activities[index]+=$"In The Date Of {Date} This Amount Of Money: {value} Has Been Withdrawled. Now The Current Balance is: {Balance}";
        index++;

    }
    public void AccountActivites(){
        for (var i=0; i<index+2;i++)
        {
            System.Console.WriteLine(Activities[i]);
        }
    }
    public Account()
    {
        Activities = new string[64];
        FirstName = "";
        LastName = "";
        AccountDate = DateTime.Now;
    }
    public Account(string FirstName, string LastName):this()
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
    }
    public void CheckAccount(){
        System.Console.WriteLine($"The Date of Creating the Account: {AccountDate}\nThe Onwer's Full Name: {FirstName} {LastName}\nThe Total Balance Of The Account: {Balance}\nThe Activites That Have Happened: ");
        AccountActivites();
        
    }
} */