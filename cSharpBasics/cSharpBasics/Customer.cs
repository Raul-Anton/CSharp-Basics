using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace cSharpBasics
{
    internal class Customer
    {
        private int CustomerId { get; set; }
        private string CustomerName { get; set; }
        private string EmailAddress { get; set; }
        private string Password { get; set; }

        public Customer(int customerId, string customerName, string emailAddress, string password)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            EmailAddress = emailAddress;
            Password = password;
        }

        public void Register()
        {

        }

        public void Login()
        {

        }

        public override string ToString()
        {
            return $"CustomerId: {CustomerId}, CustomerName: {CustomerName}, EmailAddress: {EmailAddress}, Password: {Password}";
        }
    }
}
