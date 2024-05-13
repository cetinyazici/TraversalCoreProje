using BusinessLayer.Abstract;
using DocumentFormat.OpenXml.Wordprocessing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{
    public class PdfReportController : Controller
    {
        private readonly IPdfReportService _pdfReportService;

        public PdfReportController(IPdfReportService pdfReportService)
        {
            _pdfReportService = pdfReportService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/dosya1.pdf");
            var stream = new FileStream(path, FileMode.Create);

            iTextSharp.text.Document document = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();

            iTextSharp.text.Paragraph paragraph = new iTextSharp.text.Paragraph("Traversal Rezervasyon Pdf Raporu");

            document.Add(paragraph);
            document.Close();
            return File("/pdfreports/dosya1.pdf", "application/pdf", "dosya1.pdf");
        }

        public IActionResult StaticCustomerReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "dosya2.pdf");
            var stream = new FileStream(path, FileMode.Create);

            iTextSharp.text.Document document = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();

            PdfPTable pdfPTable = new PdfPTable(3);

            pdfPTable.AddCell("Misafir Adı");
            pdfPTable.AddCell("Misafir Soyadı");
            pdfPTable.AddCell("Misafir TC");

            pdfPTable.AddCell("Çetin");
            pdfPTable.AddCell("Yazıcı");
            pdfPTable.AddCell("11111111110");

            pdfPTable.AddCell("Zehra");
            pdfPTable.AddCell("Akıncı");
            pdfPTable.AddCell("22222222222");

            pdfPTable.AddCell("Murat");
            pdfPTable.AddCell("Yücedağ");
            pdfPTable.AddCell("44444444445");

            document.Add(pdfPTable);

            document.Close();
            return File("/pdfreports/dosya2.pdf", "application/pdf", "dosya2.pdf");
        }
    }
}
