﻿using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Controllers
{
    public class ExcelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public List<DestinationModel> DestinationList()
        {
            List<DestinationModel> destinationModel = new();
            using (var c = new Context())
            {
                destinationModel = c.Destinations.Select(x => new DestinationModel
                {
                    City = x.City,
                    DayNighy = x.DayNighy,
                    Price = x.Price,
                    Capacity = x.Capacity
                }).ToList();
            }
            return destinationModel;
        }

        public IActionResult StaticExcelReport()
        {
            ExcelPackage excelPackage = new();
            var workSheet = excelPackage.Workbook.Worksheets.Add("Sayfa1");
            workSheet.Cells[1, 1].Value = "Rota";
            workSheet.Cells[1, 2].Value = "Rehber";
            workSheet.Cells[1, 3].Value = "kontenjan";

            workSheet.Cells[2, 1].Value = "Gürcistan Batum Turu";
            workSheet.Cells[2, 2].Value = "Çetin Yazıcı";
            workSheet.Cells[2, 3].Value = "50";

            workSheet.Cells[3, 1].Value = "Sırbistan Makendonya Turu";
            workSheet.Cells[3, 2].Value = "Zehra Akıncı";
            workSheet.Cells[3, 3].Value = "25";

            var bytes = excelPackage.GetAsByteArray();

            return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "dosya1.xlsx");
        }
        public IActionResult DestinationExcelReport()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Tur Listesi");
                workSheet.Cell(1, 1).Value = "Şehir";
                workSheet.Cell(1, 2).Value = "Konaklama Süresi";
                workSheet.Cell(1, 3).Value = "Fiyat";
                workSheet.Cell(1, 4).Value = "Kapasite";

                int rowCount = 2;
                foreach (var item in DestinationList())
                {
                    workSheet.Cell(rowCount, 1).Value = item.City;
                    workSheet.Cell(rowCount, 2).Value = item.DayNighy;
                    workSheet.Cell(rowCount, 3).Value = item.Price;
                    workSheet.Cell(rowCount, 4).Value = item.Capacity;
                    rowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "YeniListe.xlsx");
                }
            }
        }
    }
}