using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using BarcodeLib;
using iTextSharp;
using GroupDocs.Signature;
using GroupDocs.Signature.Options;
namespace _04_06_dist
{
    /// <summary>
    /// Логика взаимодействия для Seller.xaml
    /// </summary>
    public partial class Seller : Page
    {
        public Seller()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // данные которые нужно добавить в бд
            string actual_id = new_order.Text;
            string actual_client = new_client.Text;
            string actual_service = new_service.Text;

            /* Создание штрих-кода
            using (Signature signature = new Signature("path/document.pdf"))
            {
                // Создайте параметры штрих-кода с текстом штрих-кода
                BarcodeSignOptions options = new BarcodeSignOptions("Signed by GroupDocs using GroupDocs.Signature.")
                {
                    // Установите тип кодировки штрих-кода
                    EncodeType = BarcodeTypes.Code128,

                    // Установить положение подписи
                    Left = 205,
                    Top = 170,
                    Width = 200,
                    Height = 50
                };
                // Примените штрих-код к документу для подписи.
                SignResult result = signature.Sign("path/document-with-barcode.pdf", options);
            }
            */
        }
    }
}
