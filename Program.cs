using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"
                AuthType=AD; 
                Url=https://orga5a74ca2.crm8.dynamics.com/; 
               
                Username=admin@nitinchoudhary1512gmailcom.onmicrosoft.com; 
                Password=Nittin@1234;
                Password=Nittin@1234;

            ";

            CrmServiceClient conn = new CrmServiceClient(connectionString);

            if (conn.IsReady)
            {
                Console.WriteLine("Connected to CRM!");

                // Sample: Retrieve user ID
                Guid userid = ((WhoAmIResponse)conn.Execute(new WhoAmIRequest())).UserId;
                Console.WriteLine("User ID: " + userid.ToString());
            }
            else
            {
                Console.WriteLine("Connection failed: " + conn.LastCrmError);
            }
            Console.Read();
            Console.Read();
            Console.WriteLine("this is sample");
        }
    }
}
