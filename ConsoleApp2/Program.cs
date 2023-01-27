using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
             HDFCServiceReference.PaymentUtilitiesSoapClient

                aa = new HDFCServiceReference.PaymentUtilitiesSoapClient("PaymentUtilitiesSoap");
           var checksum= aa.GenerateRequestChecksum("TEST743", "39737", "10119", "S000000170", "localhost:51775/Wait.aspx", "localhost:51775/Wait.aspx", "INGMIB");
        }
    }
}
