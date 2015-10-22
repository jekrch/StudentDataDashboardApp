using System;
using System.Globalization;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace PFdata.Dashboard.Data
{
    // Methods for creating and saving screenshots. Used in MainWindow and ReportWindow
    static class ScreenshotGenerator 
    {
        
        // Renders a FrameworkElement as RenderTargetBitmap and scales image according to specified multiplier
        public static RenderTargetBitmap RenderBitmap(FrameworkElement visualToRender, double scale)
        {

            RenderTargetBitmap bmp = new RenderTargetBitmap
                (
                (int)(scale * (visualToRender.ActualWidth )),
                (int)(scale * (visualToRender.ActualHeight )),
                96 * scale,
                96 * scale,
                PixelFormats.Pbgra32
                );

            bmp.Render(visualToRender);

            return bmp;
        }

        // Allows user to take a screen shot of the mainwindow page, with name columns hidden.
        public static RenderTargetBitmap GetReportImage(Grid view, Point dateStampPoint, 
            bool oneGrid, double column1Width, double column2Width)
        {

            string date = DateTime.Now.ToString("d");
            Size size = new Size(view.ActualWidth, view.ActualHeight);
            var converter = new BrushConverter();

            // Generate blue brush for datestamp background
            var allianceBlue = (Brush)converter.ConvertFromString("#FF919EAD"); 


            if (size.IsEmpty)
                return null;

            DrawingVisual drawingVisual = new DrawingVisual();

            using (DrawingContext context = drawingVisual.RenderOpen())
            {
                context.DrawRectangle(new VisualBrush(view), null, new Rect(new Point(), size));
            
                // Adds a datestamp to screenshot 

                FormattedText formattedText = new FormattedText(
                    date,
                    CultureInfo.GetCultureInfo("en-us"),
                    FlowDirection.LeftToRight,
                    new Typeface("Segoe UI"),
                    12,
                    Brushes.White);

                // Creates a blue background for datestamp
                context.DrawRectangle(allianceBlue, null,  
                    new Rect(new Point(dateStampPoint.X - 7, dateStampPoint.Y-1),
                             new Point(dateStampPoint.X + 63, dateStampPoint.Y +19)));

                // Adds datestamp on top of blue rectangle
                context.DrawText(formattedText, dateStampPoint);

                // Mask the name column from dataGrid
                context.DrawRectangle(Brushes.White, null,
                   new Rect(new Point(11, 134),
                            new Point(11 + column1Width, view.ActualHeight - 127) ));

                // If there are two grids showing, mask the name column from dataGrid2
                if (!oneGrid)
                {
                    context.DrawRectangle(Brushes.White, null,
                    new Rect(new Point((view.ActualWidth / 2) + 10, 134),
                             new Point((view.ActualWidth / 2) + 10 + column2Width, view.ActualHeight - 127)));
                }
              

            }

            RenderTargetBitmap result = RenderBitmap(view, 1.2);
           
            result.Render(drawingVisual);

            return result;
        }

        public static void SaveAsJpg(RenderTargetBitmap src, Stream outputStream)
        {
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();

            RenderOptions.SetEdgeMode(src, EdgeMode.Aliased);
            encoder.Frames.Add(BitmapFrame.Create(src));

            encoder.Save(outputStream);
        }

    }
}
