using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

class Program
{
    static void Main(string[] args)
    {
        string pdfPath = @"C:\Users\HP\source\repos\pdf\sample.pdf";  // full path

        Document document = new Document(PageSize.A4);

        using (FileStream fs = new FileStream(pdfPath, FileMode.Create))
        {
            PdfWriter writer = PdfWriter.GetInstance(document, fs);

            document.Open();

            document.Add(new Paragraph("Hello, iTextSharp!"));
            document.Add(new Paragraph("This PDF is generated using iTextSharp in C#.\n\n"));

            PdfPTable table = new PdfPTable(3);
            table.AddCell("ID");
            table.AddCell("Name");
            table.AddCell("Email");

            table.AddCell("1");
            table.AddCell("Pon Sinthu");
            table.AddCell("sinthu@example.com");

            table.AddCell("2");
            table.AddCell("John Doe");
            table.AddCell("john@example.com");

            document.Add(table);

            Paragraph footer = new Paragraph("\n\nGenerated on: " + DateTime.Now);
            footer.Alignment = Element.ALIGN_RIGHT;
            document.Add(footer);

            document.Close();
        }

        Console.WriteLine("PDF created successfully at: " + pdfPath);
    }
}
