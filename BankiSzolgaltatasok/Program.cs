namespace BankiSzolgaltatasok
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Tulajdonos t1 = new Tulajdonos("1");
            Tulajdonos t2 = new Tulajdonos("2");
            Tulajdonos t3 = new Tulajdonos("3");
            Tulajdonos t4 = new Tulajdonos("4");
            Tulajdonos t5 = new Tulajdonos("5");
            Tulajdonos t6 = new Tulajdonos("6");
            Tulajdonos t7 = new Tulajdonos("7");

            Bank b1 = new Bank();
            b1.SzamlaNyitas(t1,2000);
            b1.SzamlaNyitas(t2,4000);
			b1.SzamlaNyitas(t3,0);
            b1.SzamlaNyitas(t4,0);
            b1.SzamlaNyitas(t5,500);
            b1.SzamlaNyitas(t6,10000);
            b1.SzamlaNyitas(t7,0);

            Console.WriteLine(b1.OsszHitelkeret);
            Console.WriteLine("------------");
        }
    }
}