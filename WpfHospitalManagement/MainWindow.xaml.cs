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

namespace WpfHospitalManagement
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainPageOpen();
        }
        public void MainPageOpen()
        {
            new MainPage(page);
        }

        public void PatientPageOpen()
        {
            new Patient(page);
        }
        public void RoomPageOpen()
        {
            new Room(page);
        }
        public void BillPageOpen()
        {
            new Bill(page);
        }

        public void ectPageOpen()
        {
            new ect(page);
        }
        
    }
}
