using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Threading;
using System.Threading.Tasks;

namespace WpfHospitalManagement
{
    class Patient
    {
        Grid page;
        Button buttonNew;
        Button buttonManagement;

        public Patient(Grid page)
        {
            this.page = page;
            buttonNew = new Button();
            buttonNew.Height = 100;
            buttonNew.Width = 100;
            buttonNew.Content = "New Patient";
            buttonNew.Margin = new Thickness(70, 155, 580, 164);
            buttonNew.BorderThickness = new Thickness(0);
            buttonNew.Click += new RoutedEventHandler(buttonNew_Click);
            page.Children.Add(buttonNew);

            buttonManagement = new Button();
            buttonManagement.Content = "Manage Patients";
            buttonManagement.Height = 100;
            buttonManagement.Width = 100;
            buttonManagement.Margin = new Thickness(240, 155, 410, 164);
            buttonManagement.BorderThickness = new Thickness(0);
            buttonManagement.Click += new RoutedEventHandler(buttonManagement_Click);
            page.Children.Add(buttonManagement);

        }

        private void buttonNew_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonManagement_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
