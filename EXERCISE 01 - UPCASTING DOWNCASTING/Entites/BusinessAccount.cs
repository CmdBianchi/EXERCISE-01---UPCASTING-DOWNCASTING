using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EXERCISE_01___UPCASTING_DOWNCASTING.Entites { 
    //------------------------------- START -------------------------------//
    class BusinessAccount : Account {
        public double LoanLimit { get; set; }
        public BusinessAccount() { }
        public BusinessAccount(int number, string holder, double balance, double LoanLimit) : base(number, holder, balance){
            LoanLimit = LoanLimit;
        }
        public void Loan(double amount) {
            if (amount <= LoanLimit) {
                Balance += amount;
            }
        }
    }
    //-------------------------------- END -------------------------------//
}