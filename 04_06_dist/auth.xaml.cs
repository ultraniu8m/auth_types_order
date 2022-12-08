using System;
using System.Collections.Generic;
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
namespace _04_06_dist
{
    /// <summary>
    /// Логика взаимодействия для auth.xaml
    /// </summary>
    public partial class auth : Page
    {
       
       
        public auth()
        {
            
            InitializeComponent();
            

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            string actual_login = login.Text.ToString();
            string actual_password_1 = password_.Password;
            string actual_password_2 = visible_pass.Text;
            this.NavigationService.Navigate(new Seller());
            

            foreach(Employee actu_employee in predelbrusye_entities.Getcontext().Employee.ToList())
            {
                if (actu_employee.Login.ToString() == actual_login)
                    if (actu_employee.Password.ToString() == password_.Password.ToString())
                    {
                        actu_employee.LastEnter = DateTime.Now;
                        int type_of_login = actu_employee.Post;
                        break;
                        if (type_of_login == 1)
                            this.NavigationService.Navigate(new Seller());
                        if (type_of_login == 2)
                            this.NavigationService.Navigate(new Seller());
                        if (type_of_login == 3)
                            this.NavigationService.Navigate(new Admin());
                    }
                    else
                        MessageBox.Show("Введен неверный пароль");
                else
                {
                    MessageBox.Show("Введен неверный логин");
                }
            }
            /*
            switch (actual_login)
            {
                case "Admin":
                {
                        if (actual_password_1 == "Admin" || actual_password_2 == "Admin")

                            this.NavigationService.Navigate(new Admin());
                        break;
                }
                case "Seller":
                    {
                        if (actual_password_1 == "Seller" || actual_password_2 == "Seller")
                            this.NavigationService.Navigate(new Seller());
                        break;
                    }
                case "StSeller":
                    {
                        if (actual_password_1 == "StSeller" || actual_password_2 == "StSeller")
                            this.NavigationService.Navigate(new StSeller());
                        break;
                    }

            }
            */
        }
            
        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            var checkBox = sender as CheckBox;
            if (checkBox.IsChecked.Value)
            {
                visible_pass.Text = password_.Password;
                password_.Visibility = Visibility.Hidden;
                visible_pass.Visibility = Visibility.Visible;

            }
            else
            {
                password_.Password = visible_pass.Text;
                visible_pass.Visibility = Visibility.Hidden;
                password_.Visibility = Visibility.Visible;
            }
                

        }
    }
}
