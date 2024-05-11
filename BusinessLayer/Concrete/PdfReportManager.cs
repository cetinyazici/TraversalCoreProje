using BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PdfReportManager : IPdfReportService
    {
        public byte[] PDFList<T>(List<T> t) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
