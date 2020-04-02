using System;
using System.Collections;

namespace Banking_Cash_Counter
{
    class Program
    {
        public int accountNumber;
        public int index = 0;
        int[] balance = new int[10] ;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Banking Cash Counter");
            Program obj = new Program();
            obj.Counter();
        }
        public void Counter()
        {
            Random rand = new Random();
            Queue myQueue = new Queue();
            for ( int i = 0 ; i < 10 ; i++ )                                    //At a time 10 entry in Bank Counter
            {
                accountNumber = rand.Next();
                accountNumber = (accountNumber % 90000) + 10000 ;               //5 Digit Random Account Number  
                myQueue.Enqueue(accountNumber);                                 //Enqueue the user(random account number)
                balance[i] = rand.Next();
                balance[i] = balance[i] % 10000;
            }
            foreach (var element in myQueue)                                    //Account Number and Balance
            {
                Console.WriteLine("Account Number "+ element + " Balance is : " +balance[index++]);
            }
            index = 0;
            while (myQueue.Count > 0)
            {
                Console.WriteLine($"User: {myQueue.Peek()}");
                Operation();
                myQueue.Dequeue();                                              //Dequeue when user is done
                index++;
            }
        }
        public void Withdraw()                                                  //Withdraw the amount
        {
            Console.WriteLine("Enter amount want to withdraw :");
            int amount = int.Parse(Console.ReadLine());                         //Validate Withdraw amount is correct or not
            if (balance[index] - amount > 0)
            {
                balance[index] = balance[index] - amount;
                Console.WriteLine("Your balance is :"+balance[index]);
            }
            else
            {
                Console.WriteLine("You can't withdraw " + amount + " amount\nYour balance is :"+balance[index]);
            }
        }
        public void Deposit()                                                   //Deposit the Amount
        {
            Console.WriteLine("Enter amount want to deposit :");
            int amount = int.Parse(Console.ReadLine());
            if (amount > 0)                                                     //Validate Deposit amount is correct or not
            {
                balance[index] = balance[index] + amount;
            }
            else
            {
                Console.WriteLine("Enter valid amount");
            }
        }
        public void Operation()
        {
            int choice1 = 0;
            while (choice1 == 0)                                                                //Condition for repeat the transaction
            {
                Console.WriteLine("Your balance is "+ balance[index]);
                Console.WriteLine("1).For Withdraw\n2).For Deposit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Withdraw();                                                           //Withdraw
                        break;
                    case 2:
                        Deposit();                                                            //Deposit
                        break;
                    default:
                        Console.WriteLine("No match found");
                        break;
                }
                Console.WriteLine("Press 0 For continue your transaction or any number to exit:");      //Ask for to repeat or not 
                choice1 = int.Parse(Console.ReadLine());
            }
        }
    }
}
