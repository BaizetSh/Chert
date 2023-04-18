﻿using System;
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
using System.Windows.Shapes;

namespace StroiMater.View
{
    /// <summary>
    /// Логика взаимодействия для Captcha.xaml
    /// </summary>
    public partial class Captcha : Window
    {
        public Captcha()
        {
            InitializeComponent();
            Randomize();
        }
        private void btnVerificate_Click(object sender, RoutedEventArgs e)
        {
            if(txtCaptchaVerification.Text!= lblCaptcha.Content.ToString())
            {
                MessageBox.Show("Неверно!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
                Application.Current.Shutdown();

            }
            else
            {
                var form = new MainWindow();
                form.Show();
                Close();
            }                   
           
        }
        public void Randomize()
        {
            Random random = new Random();
            int captcha;
            lblCaptcha.Content = Convert.ToString(captcha = random.Next(100000, 999999));
        }
    }
}
