using QuestPDF.Infrastructure;
using QuestPDF.Helpers;
using QuestPDF.Fluent;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GolobalClasses;
using System.Runtime.Remoting.Messaging;

namespace Bussiness
{
    public  class BlPrintReports : IDocument 
    { 
        string Title { get; set; }
        List<DataGridViewColumn> dgvcloumns;
        List<DataGridViewRow> dgvrows;
        string Period=string.Empty;
        string TotalSales=string.Empty; 

        public BlPrintReports(List<DataGridViewColumn> dgvcloumns, List<DataGridViewRow> dgvrows, string title ,string ReportPeriod ,string totalsales="")
        {
            this.Title = title;  
            this.dgvcloumns = dgvcloumns;
            this.dgvrows = dgvrows;
            Period = ReportPeriod; 
            this.TotalSales = totalsales;    
        } 


        public void Compose(IDocumentContainer container)
        {

            container.Page(page =>
            {
                page.Size(PageSizes.A4);
                page.Margin(20,Unit.Point);  

                page.Size(PageSizes.A4);

                page.Header().Element(ComposeHeader);
                page.Content().Element(ComposeContent);

                page.Footer().AlignCenter().Text(t =>
                {
                    t.CurrentPageNumber();
                    t.Span(" / ");
                    t.TotalPages();  
                });
            });
        } 


        private void ComposeHeader(IContainer container)
        { 
            var scale =.9f;  

            container.Row(row =>
            {
                row.RelativeItem().Column(column =>
                {
                    if (Settings.ResturantInfo.LogoPath != string.Empty)
                    {
                        try
                        {
                            column.Item().Height(30, Unit.Millimetre).Image(Settings.ResturantInfo.LogoPath); 
                        } catch
                        {

                        }
                    } 

                    column.Item().Scale(scale).Text(Settings.ResturantInfo.ResturantName);
                    column.Item().Scale(scale).Text(Settings.ResturantInfo.ResturantAddress);
                    column.Item().Text("");
                    column.Item().Scale(scale).Text(DateTime.Now.ToString());

                });


                row.RelativeItem().Border(1).Column(column =>
                {

                    short padding = 10;
                    column.Item().BorderBottom(1).Padding(padding).Text(Title).SemiBold().AlignCenter();
                    column.Item().Padding(padding).Text($"Asked By User : {Settings.LoggedInUser.Person.FirstName} {Settings.LoggedInUser.Person.LastName}");
                    
                    column.Item().Padding(padding).Text($"User LeveL : {Settings.LoggedInUser.Role.RoleName}");
                    column.Item().Padding(padding).Text("Report Period : ");
                    column.Item().Padding(padding).Text(Period);
                           
                    


                }); 


            });
        }
        private void ComposeContent(IContainer container)
        {


            container.PaddingVertical(40).Column(column =>
            {
                column.Item().Element(ComposeTable);
                column.Item().Text(TotalSales);
            });
        }

        private void ComposeTable(IContainer container)
        {


            container.Table(table =>
            {
                table.ColumnsDefinition(columndef =>
                {
                    foreach (var col in dgvcloumns)
                    {
                        columndef.RelativeColumn();
                    }
                });

                table.Header(header =>
                {
                    foreach (var col in dgvcloumns)
                    {
                        header.Cell().Background(Colors.Grey.Lighten2).Text(col.HeaderText).SemiBold();
                    }
                });


                foreach (var row in dgvrows)
                {
                    foreach (var col in dgvcloumns)
                    {
                        var cellvalue = row.Cells[col.Index].Value?.ToString() ?? "";
                        table.Cell().Element(CellSytling).Text(cellvalue);


                        IContainer CellSytling(IContainer Con)
                        {
                            return Con.BorderBottom(1).BorderColor(Colors.Grey.Lighten1).PaddingVertical(5);
                        }
                    }
                }



            });
        }



        public  DocumentMetadata GetMetadata()
        {
            return DocumentMetadata.Default; 
        } 
        public DocumentSettings GetSettings()
        {
            return DocumentSettings.Default;
        }
    }
}
