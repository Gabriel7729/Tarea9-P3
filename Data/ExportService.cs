using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Drawing;
using Syncfusion.Pdf.Grid;

namespace Tarea_9.Data
{

    public class ExportService
    {
        public MemoryStream CreatePdf(Vacunados[] vacuna)
        {
            if(vacuna == null)
            {
                throw new ArgumentException("Data Cannot be null");
            }

            //Create a new PDF document
            using(PdfDocument pdfDocument = new PdfDocument())
            {
                int paragraphAfterSpacing = 8;
                int cellMargin = 8;

                //Add page to the pdf document
                PdfPage page = pdfDocument.Pages.Add();

                //Create new font
                PdfStandardFont font = new PdfStandardFont(PdfFontFamily.TimesRoman, 16);

                //Create a tex elemnt to draw a text in pdf page    
                PdfTextElement title = new PdfTextElement("Weather Forecast", font, PdfBrushes.Black);
                PdfLayoutResult result = title.Draw(page, new PointF(0,0));
            
                 PdfStandardFont contentfont = new PdfStandardFont(PdfFontFamily.TimesRoman, 12);
                 PdfLayoutFormat format = new PdfLayoutFormat();
                 format.Layout = PdfLayoutType.Paginate;

                //Create a pdf
                PdfGrid pdfGrid = new PdfGrid();
                pdfGrid.Style.CellPadding.Left = cellMargin;
                pdfGrid.Style.CellPadding.Right = cellMargin;


                //Applying built in style to the PDF
                pdfGrid.ApplyBuiltinStyle(PdfGridBuiltinStyle.GridTable4Accent1);


                //Assing Data Source
                pdfGrid.DataSource = vacuna.ToList();

                pdfGrid.Style.Font = contentfont;


                //Draw pdf grid into the pdf page
                pdfGrid.Draw(page, new PointF(0, result.Bounds.Bottom + paragraphAfterSpacing));

                using(MemoryStream stream = new MemoryStream())
                {
                    pdfDocument.Save(stream);
                    pdfDocument.Close(true);
                    return stream;
                }


            }            
        }
    }

}