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
using _04_06_dist;

namespace _04_06_dist
{
    /// <summary>
    /// Логика взаимодействия для Seller.xaml
    /// </summary>
    public partial class Seller : Page
    {
        private Order _currentorder = new Order();
        public Seller()
        {
            InitializeComponent();
            DataContext = _currentorder;

            
      
            
            

        }

        
        private void Button_add_order(object sender, RoutedEventArgs e)
        {
            StringBuilder ERRORS = new StringBuilder();
            if (_currentorder.ID is string)
                ERRORS.AppendLine("ID - номер ");
            if (_currentorder.ID < 10000000)
                ERRORS.AppendLine("id клиента - 6 значный номер");
            if (ERRORS == null)
            {
                predelbrusye_entities.Getcontext().Order.Add(_currentorder);
                predelbrusye_entities.Getcontext().SaveChanges();
            }
            else
            {
                MessageBox.Show(Convert.ToString(ERRORS));
            }
           
        }
        private void Buttonback_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new auth());
        }
    }
}
