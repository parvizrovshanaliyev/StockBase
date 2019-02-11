using CompBase_test1.classes;
using CompBase_test1.UserControls;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CompBase_test1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool StateClosed { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void UpBorder_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
            
                this.DragMove();
            
        }

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            UserControl_Call.UserControl_Add(Contents, new Home());
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UserControl_Call.UserControl_Add(Contents, new Home());
        }

        private void Purchase_Click(object sender, RoutedEventArgs e)
        {
            UserControl_Call.UserControl_Add(Contents, new Purchase());
        }





        #region Window Control buttons

        private void BtnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void BtnMaxmize_Click(object sender, RoutedEventArgs e)
        {
            //this.WindowState = WindowState.Maximized;
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        #endregion

        
    }
}
