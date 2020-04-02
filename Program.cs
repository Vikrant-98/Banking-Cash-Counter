using System;
using System.Collections;

namespace Banking_Cash_Counter
{
    class Program
    {
        public int accountNumber;
        int index = 0;
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
                myQueue.Enqueue(accountNumber);
                balance[i] = rand.Next();
                balance[i] = balance[i] % 10000;
            }
            foreach (var element in myQueue)                                    //Account Number and Balance
            {
                Console.WriteLine("Account Number "+ element + " Balance is : " +balance[index++]);
            }
        }
    }
}
