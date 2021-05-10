using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EXERCISE_01___UPCASTING_DOWNCASTING.Entites  {
    //------------------------------- START -------------------------------//
    class Account {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }
    //------------------------------- CONST -------------------------------//  
        public Account() { }

        public Account(int number, string holder, double balance) {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
    //------------------------------- MET --------------------------------//
        public void Withdraw(double amount) {
            Balance -= amount;
        }
        public void Deposit(double amount) {
            Balance += amount;
        }
    }
    //-------------------------------- END -------------------------------//
}

