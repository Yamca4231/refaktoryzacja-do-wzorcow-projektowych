using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temporary_Field
{
    public class InvoiceGenerator
    {
        public void GenerateInvoice()
        {
            int invoiceNumber = 12345;
            using (var pdfWriter = new PdfWriter($"Invoice_{invoiceNumber}.pdf"))
            {
                // Generowanie faktury
                pdfWriter.Write("Invoice Content");
            }            
        }
        public void OtherMethod()
        {
            // Metoda, która nie korzysta z tymczasowych pól
        }
    }
}
