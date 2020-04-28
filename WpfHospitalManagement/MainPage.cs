using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Threading;
using System.Threading.Tasks;

namespace WpfHospitalManagement
{
    class MainPage
    {
        Patient patientPage;
        Bill billPage;
        ect ectPage;

        Grid page;
        Button buttonPatient,buttonRoom,buttonBill,buttonect;
        MainWindow main;


        public MainPage(Grid page)
        {
            this.page = page;
            buttonPatient = new Button();
            buttonPatient.Height = 100;
            buttonPatient.Width = 100;
            buttonPatient.Content = "Patient";
            buttonPatient.Margin = new Thickness(70,155,580,164);
            buttonPatient.BorderThickness = new Thickness(0);
            buttonPatient.Click += new RoutedEventHandler(buttonPatient_Click);
            page.Children.Add(buttonPatient);

            buttonRoom = new Button();
            buttonRoom.Content = "Room";
            buttonRoom.Height = 100;
            buttonRoom.Width = 100;
            buttonRoom.Margin = new Thickness(240, 155, 410, 164);
            buttonRoom.BorderThickness = new Thickness(0);
            buttonRoom.Click += new RoutedEventHandler(buttonRoom_Click);
            page.Children.Add(buttonRoom);

            buttonBill = new Button();
            buttonBill.Content = "Bill";
            buttonBill.Height = 100;
            buttonBill.Width = 100;
            buttonBill.Margin = new Thickness(410, 155, 240, 164);
            buttonBill.BorderThickness = new Thickness(0);
            buttonBill.Click += new RoutedEventHandler(buttonRoom_Click);
            page.Children.Add(buttonBill);

            buttonect = new Button();
            buttonect.Content = "ect";
            buttonect.Height = 100;
            buttonect.Width = 100;
            buttonect.Margin = new Thickness(580, 155, 70, 164);
            buttonect.BorderThickness = new Thickness(0);
            buttonect.Click += new RoutedEventHandler(buttonect_Click);
            page.Children.Add(buttonect);

            MainWindow main = new MainWindow();

        }
        private void buttonPatient_Click(object sender, RoutedEventArgs e)
        {
            main.PatientPageOpen();
        }
        private void buttonRoom_Click(object sender, RoutedEventArgs e)
        {
            main.RoomPageOpen();            
        }
        private void buttonBill_Click(object sender, RoutedEventArgs e)
        {
            main.BillPageOpen();
        }
        private void buttonect_Click(object sender, RoutedEventArgs e)
        {
            main.ectPageOpen();
        }
    }
}
