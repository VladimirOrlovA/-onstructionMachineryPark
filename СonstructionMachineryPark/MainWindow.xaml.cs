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

using СonstructionMachineryPark.pages;
using ConstructionMachineryPark.BAL.DLL;

namespace СonstructionMachineryPark
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public static Menu _MenuTopBar = null;
        public static Frame _FrameCenter = null;
        public static StackPanel _ServiceMesBottom = null;

        public MainWindow()
        {
            InitializeComponent();
            _MenuTopBar = mMenuTopBar;
            _FrameCenter = fFrameCenter;
            _ServiceMesBottom = spServiceMesBottom;
            _FrameCenter.Navigate(new PageWelcome());
            this.Loaded += MainWindow_Loaded;

            TestOutMes();
        }


        //Задержка выполнения метода.
        //На время ожидания не блокирует поток. На время ожидания метод задерживает своё выполнение на заданное время,
        async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            await Task.Delay(0000);
            _FrameCenter.Navigate(null);
            new MenuTopBar();
            _MenuTopBar.Visibility = Visibility.Visible;
        }

        public void TestOutMes()
        {
            var obj = new Equipment();
            string objTypeName = obj.GetType().ToString();
            objTypeName = objTypeName.Substring(objTypeName.LastIndexOf('.') + 1);

            MessageBox.Show(objTypeName);
        }
    }
}
