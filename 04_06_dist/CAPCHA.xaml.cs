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
    /// Логика взаимодействия для CAPCHA.xaml
    /// </summary>
    public partial class CAPCHA : Page
    {
        public string CaptchaValue { get; set; }
        public event System.EventHandler CaptchaRefreshed;
        public CAPCHA()
        {
            InitializeComponent();
            CreateCaptcha();
        }
        private void ResetCaptchaButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            CreateCaptcha();
        }
        public void CreateCaptcha()
        {
            string allowchar = string.Empty;
            allowchar = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
            allowchar += "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,y,z";
            allowchar += "1,2,3,4,5,6,7,8,9,0";
            char[] a = { ',' };
            string[] ar = allowchar.Split(a);
            string pwd = string.Empty;
            string temp = string.Empty;
            System.Random r = new System.Random();

            for (int i = 0; i < 6; i++)
            {
                temp = ar[(r.Next(0, ar.Length))];

                pwd += temp;
            }

            CaptchaText.Text = pwd;

            CaptchaValue = CaptchaText.Text;

            CaptchaRefreshed?.Invoke(this, System.EventArgs.Empty);
        }
        private void BtnCaptchaenter_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (CaptchaText.Text.ToString() == CaptchaEnter.Text.ToString())
            {
                this.NavigationService.Navigate(new auth());
            }
            else
            {
                MessageBox.Show("Капча введена не верно. Программа звершена.");
                System.Windows.Application.Current.Shutdown();
            }
        }
    }
}
