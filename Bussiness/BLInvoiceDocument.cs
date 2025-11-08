using GolobalClasses;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using BarcodeStandard;

namespace Bussiness
{
    public class BLInvoiceDocument : IDocument
    {
        
        private GInvoice invoice= new GInvoice();
        
        private List<GOrderDetailsRecord> ordersdetails = new List<GOrderDetailsRecord>();  
        private bool IsArchive=false;   



        public BLInvoiceDocument(GInvoice INVOICE ,List<GOrderDetailsRecord> list ,bool isarchive=false)
        {
            invoice = INVOICE;   
            IsArchive=isarchive;    
            ordersdetails = list;   
        }
        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.ContinuousSize(80, Unit.Millimetre); 
                page.Margin(10);


                page.Header().Element(ComposeHeader);
                page.Content().Element(ComposeContent);
                

                page.Footer().AlignCenter().Text(Settings.ResturantInfo.Slogan); 

            });
        } 


        private void ComposeHeader(IContainer container)
        {
            container.Row(row =>
            {
                var scale = .5f;

                row.RelativeItem().Column(column =>
                {
                    if (Settings.ResturantInfo.LogoPath != string.Empty)
                    {
                        try
                        {
                            column.Item().Height(20, Unit.Millimetre).Image(Settings.ResturantInfo.LogoPath);

                        }
                        catch
                        {

                        }

                    }
                    column.Item().Scale(scale).Text(Settings.ResturantInfo.ResturantName);
                    column.Item().Scale(scale).Text(Settings.ResturantInfo.ResturantAddress);
                    column.Item().Text("");
                    column.Item().Scale(scale).Text($"Date : {invoice.InvoiceDate}"); 

                });

                row.RelativeItem().Border(1).Column(column =>
                {
                 short padding1 = 10;
                 short padding2 = 5; 
                 column.Item().BorderBottom(1).Padding(padding1).Text("Sales Invoice").SemiBold();
                    if (!IsArchive)
                    {
                        if (Settings.gAdditionalServices.IsDisCountAsPercent)
                        {
                            column.Item().Scale(scale).Padding(padding2).Text($"Discount : {Settings.gAdditionalServices.DisCountAsPercent}  %");

                        }
                        else
                        {
                            column.Item().Scale(scale).Padding(padding2).Text($"Discount : {Settings.gAdditionalServices.DiscountAsNumber} {Settings.CurrencySymbol}");

                        }
                        column.Item().Scale(scale).Padding(padding2).Text($"Invoice Number : {invoice.InvoiceNumber}");
                        column.Item().Scale(scale).Padding(padding2).Text($"Delivery Cost : {Settings.CurrentDeliveryCost}");
                        column.Item().Scale(scale).Padding(padding2).Text($"Service : {Settings.CurrentService}");

                        column.Item().Scale(scale).Padding(padding2).Text($"Tax : {Settings.gAdditionalServices.Tax}");
                    }
                    


                }); 
            }); 
        }


        private void ComposeContent(IContainer container)
        {
            container.PaddingVertical(40).Column(column =>
            {
                column.Item().Element(ComposeTable);
                column.Item().Scale(.6f).Text($"Total : {invoice.Total} {Settings.CurrencySymbol}");
                column.Item().Scale(.6f).Text($"Net Value : {invoice.NetValue} {Settings.CurrencySymbol}");
                column.Item().Text("");
                column.Item().Text("");
                column.Item().Image(Settings.GetBarcodeImageForCurrentOrder(invoice));
            });
        }


        private void ComposeTable(IContainer container)
        {
            var scale = .5f ; 

            container.Table(table =>
            {
                //Step1 : Definition Columns : 
                table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn(2);
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn(); 
                });

                //Step2  : Definition Header : 
                table.Header(header =>
                {
                    header.Cell().Element(CellStyling).Text("Name");
                    header.Cell().Element(CellStyling).Text("Price");
                    header.Cell().Element(CellStyling).Text("Uints");
                    header.Cell().Element(CellStyling).Text("Total");

                    IContainer CellStyling(IContainer Con)
                    {
                        return Con.DefaultTextStyle(x =>x.SemiBold()).PaddingVertical(5).BorderBottom(1).BorderColor(Colors.Black); 
                        
                    }
                });


                //Definition of Data : 

                foreach(GOrderDetailsRecord record in ordersdetails)
                {

                    table.Cell().Element(CellSytling).Scale(scale).Text(record.DishName);
                    table.Cell().Element(CellSytling).Scale(scale).AlignMiddle().Text(record.DishPrice.ToString()); 
                    table.Cell().Element(CellSytling).Scale(scale).AlignMiddle().Text(record.Units.ToString());
                    table.Cell().Element(CellSytling).Scale(scale).AlignMiddle().Text(record.Total.ToString());

                    IContainer CellSytling(IContainer Con)
                    {
                        return Con.BorderBottom(1).BorderColor(Colors.Grey.Lighten1).PaddingVertical(5);
                    }

                } 

            });
        } 



        public DocumentMetadata GetMetadata()
        {
            return DocumentMetadata.Default; 
        }

        public DocumentSettings GetSettings()
        {
            return DocumentSettings.Default; 
        }
    } 
}
