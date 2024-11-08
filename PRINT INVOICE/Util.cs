using System.Collections.Generic;

namespace PRINT_INVOICE
{
    public class Util
    {
        public static List<DAL.products> products = new List<DAL.products>();
        public static List<DAL.CustAndVend> CustAndVends = new List<DAL.CustAndVend>();
        public static int CustomerId = 0;
        public static string UserName = "user";
    }
    public enum InvoiceType
    {
        Sales,
        purchase
    }
    public enum PartType
    {
        Customer,
        Vendor
    }    
}
