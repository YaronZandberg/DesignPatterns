using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_And_Proxy
{
    public class ProxyFactory
    {
        private const string CUSTOMER_USERNAME = "Yaron";
        private const string CUSTOMER_PASSWORD = "Aa123456";
        private const string COMPANY_USERNAME = "ELAL";
        private const string COMPANY_PASSWORD = "13579";
        private const string ADMIN_USERNAME = "admin";
        private const string ADMIN_PASSWORD= "admin";

        public ClientProxy Login(string username, string password)
        {
            // Check if the customer credentials are right
            if ((CUSTOMER_USERNAME.Equals(username)) && (CUSTOMER_PASSWORD.Equals(password)))
            {
                return (new CustomerProxy());
            }
            // Check if the company credentials are right
            else if ((COMPANY_USERNAME.Equals(username)) && (COMPANY_PASSWORD.Equals(password)))
            {
                return (new CompanyProxy());
            }
            // Check if the admin credentials are right
            else if ((ADMIN_USERNAME.Equals(username)) && (ADMIN_PASSWORD.Equals(password)))
            {
                return (new AdminProxy());
            }
            // Default situation - throwing exception
            else
            {
                throw new Exception("Wrong credentials");
            }
        }
    }
}
