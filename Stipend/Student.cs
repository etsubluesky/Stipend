using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stipend
{
    public class Student
    {
        private string id;
        private string firstName;
        private string lastName;
        private double balance;

        private static double CURRENT_STIPEND = 15.00; 


        public Student(string id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            NewDay();
        }

        public Student(Student otherStudent)
        {
            this.id = otherStudent.id;
            this.firstName = otherStudent.firstName;
            this.lastName = otherStudent.lastName;
            this.balance = otherStudent.balance;
        }

        public bool Equals(Student otherStudent)
        {
            /*
            return  this.id == otherStudent.id && 
                    this.firstName == otherStudent.firstName &&
                    this.lastName == otherStudent.lastName;

            */

            if ( this.id == otherStudent.id &&
                    this.firstName == otherStudent.firstName &&
                    this.lastName == otherStudent.lastName)
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }


        public string GetId()
        {
            return this.id;
        }

        public string GetFirstName()
        {
            return this.firstName;
        }

        public string GetLastName()
        {
            return this.lastName;
        }

        public double GetBalance()
        {
            return this.balance;
        }


        public void NewDay()
        {
            this.balance = CURRENT_STIPEND;
        }

        public string FullName()
        {
            return $"{firstName} {lastName}";
        }

        public override string ToString()
        {
            string msg = "";

            msg += $"{FullName()} (ID: {id})\n";
            msg += $"Current Balance: {balance.ToString("C")}";

            return msg;
        }

        public double Purchase(double totalPurchase)
        {
            balance -= totalPurchase;
            //balance = balance - totalPurchase


            //if a negative is returned you owe money
            return balance;
        }
    }
}
