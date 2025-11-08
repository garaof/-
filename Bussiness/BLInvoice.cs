using DataAccess;
using GolobalClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public  class BLInvoice
    {
        public static int AddNewInvoice(GInvoice invoice)
        {
            int newinvoiceid = DAInvoice.GetNewInvoiceID();
            if(newinvoiceid == -1)
            {
                return -1;
            }
            string invoiceNumber = $"Inv-{newinvoiceid.ToString()}-{DateTime.Now.Year.ToString().Substring(2)}";
            invoice.InvoiceNumber = invoiceNumber;  
            return DAInvoice.AddNewInvoice(invoice);    
        }


        public static GInvoice FindInvoiceByID(int invoiceid)
        {
            return DAInvoice.FindInvoiceByID(invoiceid);    
        }
        public static DataTable GetLast100Invoice()
        {
            return DAInvoice.GetLast100Invoice();
        }

        public static DataTable FindAllInvoicesInSpecificDate(DateTime date)
        {
            return DAInvoice.FindAllInvoicesInSpecificDate(date);
        }


    }
}
