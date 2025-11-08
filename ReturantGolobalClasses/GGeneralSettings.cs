using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using QuestPDF;
using QuestPDF.Infrastructure;
using BarcodeStandard;
using SkiaSharp;

namespace GolobalClasses
{
    
          
    
    public static class Settings
    {
        public static List<GDish> SelectedDishes = new List<GDish>();
        public static decimal CurrentOrderTotal { get; set; } = 0;
        public static GAdditionalServices gAdditionalServices {get; set; } 
        public static decimal CurrentOrderNetVAlue {  get; set; }   
        public static GUser LoggedInUser { get; set; } 
        public static int CurrentSessionID { get; set; }  
        public static int CurrentOrderID { get; set; }   
        public static List <GOrderDetailsRecord> InvoiceItems { get; set; }  =new List<GOrderDetailsRecord>();
        public static GResturantInfo ResturantInfo { get; set; } = new GResturantInfo();
        public static decimal CurrentDeliveryCost { get; set; } = 0; 
        public static decimal CurrentService { get; set; } = 0; 


        
        public static string Connectionstring { get; set; } = "";
        public static string CurrencySymbol = "SR";



        //General Methods : 
        public static  MemoryStream GetBarcodeImageForCurrentOrder(GInvoice invoice)
        {
            Barcode barcode = new Barcode()
            {
                IncludeLabel = false ,
                Alignment = AlignmentPositions.Center,

            };


             SkiaSharp.SKImage image = barcode.Encode(BarcodeStandard.Type.Code128, invoice.InvoiceNumber, 300, 100); 
             MemoryStream ms = new MemoryStream();
             SKData data = image.Encode(SKEncodedImageFormat.Png, 100); 
             data.SaveTo(ms);
             ms.Seek(0, SeekOrigin.Begin);
             return ms; 
            
        }



    }



    public static class Logger
    {
        private static readonly string LogFilePath = "App_Errors.txt";

        public static void Log(string Message)
        {
            try
            {
                string ErrorMessage = $"{DateTime.Now: yyyy-MM-dd HH:mm:ss} -{Message}";
                File.AppendAllText(LogFilePath, ErrorMessage + Environment.NewLine);
            }
            catch { } 
        } 


    }  


    

    public class ImageHandling
    {

        private static string GenerateGuid()
        {
            Guid guid = Guid.NewGuid(); 
            return guid.ToString(); 
        } 


        private static  bool CreateFolderIfNotExists(string FilePath)
        {

            if (!Directory.Exists(FilePath))
            {
                try
                {
                    Directory.CreateDirectory(FilePath); 
                    return true; 
                }catch(Exception ex)
                {
                    Logger.Log(ex.Message);
                    return false; 
                }
            }

            return true;
        }  


        private static string ReplaceFileNameWithGuid(string FileName)
        {
            FileInfo fi = new FileInfo(FileName);   
            string extension=fi.Extension;   
            return GenerateGuid() + extension;  
        }   


        public static bool CopyImageToImagesFile(ref string SourceFile) 
        {
            string destinationFolder = @"C:\FastFoods-Dishes-Images\";

            if (!CreateFolderIfNotExists(destinationFolder))
            {
                return false;   
            }  

            string DestinationFile =destinationFolder + ReplaceFileNameWithGuid(SourceFile); 
            try
            {
                File.Copy(SourceFile, DestinationFile, true);

            }catch(System.IO.IOException ex)
            {
                Logger.Log(ex.Message); 
                return false;   
            }

            SourceFile = DestinationFile;
            return true;    

        } 
        
        







    } 

}
