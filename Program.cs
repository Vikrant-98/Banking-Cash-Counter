using System;
using System.Collections;

namespace Banking_Cash_Counter
{
    class Program
    {
        public int accountNumber;
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
            }
            foreach (var element in myQueue)
            {
                Console.WriteLine(element);
            }
        }
    }
}
