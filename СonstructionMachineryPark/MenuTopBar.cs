using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using System.Windows.Controls;
using СonstructionMachineryPark.pages;

namespace СonstructionMachineryPark
{
    public class MenuTopBar
    {
        public static int formActionStatus = 1; // 0-create    1-read   2-update    3-delete

        public MenuTopBar()
        {
            MenuItem file = new MenuItem() { Header = "File" };
            MenuItem menuFileExit = new MenuItem() { Header = "Exit" };
            menuFileExit.Click += MenuFileExit_Click;
            file.Items.Add(menuFileExit);

            MenuItem equipment = new MenuItem() { Header = "Equipment" };
            MenuItem manufacture = new MenuItem() { Header = "Manufacture" };
            MenuItem model = new MenuItem() { Header = "Model" };

            equipment.Click += Equipment_Click;
            manufacture.Click += Manufacture_Click;
            model.Click += Model_Click;

            equipment.Items.Add(subMenuRead());
            manufacture.Items.Add(subMenuRead());
            model.Items.Add(subMenuRead());

            equipment.Items.Add(subMenuCreate());
            manufacture.Items.Add(subMenuCreate());
            model.Items.Add(subMenuCreate());

            equipment.Items.Add(subMenuUpdate());
            manufacture.Items.Add(subMenuUpdate());
            model.Items.Add(subMenuUpdate());

            equipment.Items.Add(subMenuDelete());
            manufacture.Items.Add(subMenuDelete());
            model.Items.Add(subMenuDelete());

            manufacture.Items.Add(new Separator());
            manufacture.Items.Add(subMenuExport());
            model.Items.Add(new Separator());
            model.Items.Add(subMenuExport());

            MainWindow._MenuTopBar.Items.Add(file);
            MainWindow._MenuTopBar.Items.Add(equipment);
            MainWindow._MenuTopBar.Items.Add(manufacture);
            MainWindow._MenuTopBar.Items.Add(model);

            MainWindow._MenuTopBar.Visibility = Visibility.Visible;
        }


        //============================================================================//

        private MenuItem subMenuCreate()
        {
            MenuItem createRecord = new MenuItem { Header = "Создать" };
            createRecord.Click += CreateRecord_Click;
            return createRecord;
        }

        private MenuItem subMenuExport()
        {
            MenuItem export = new MenuItem() { Header = "Экспорт" };
            MenuItem exportXML = new MenuItem() { Header = "в формат XLM" };
            MenuItem exportSOAP = new MenuItem() { Header = "в формат SOAP" };
            export.Items.Add(exportXML);
            export.Items.Add(exportSOAP);
            return export;
        }

        //============================================================================//

        private void Equipment_Click(object sender, RoutedEventArgs e)
        {           
            //MessageBox.Show("Equipment форма " + formActionStatus);
            MainWindow._FrameCenter.Navigate(new PageEquipment());
        }

        private void Manufacture_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Manufacture форма " + formActionStatus);
            MainWindow._FrameCenter.Navigate(new PageManufacturer());
        }

        private void Model_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Model форма " + formActionStatus);
            MainWindow._FrameCenter.Navigate(new PageModel());
        }


        //============================================================================//

        private MenuItem subMenuRead()
        {
            MenuItem readRecord = new MenuItem { Header = "Просмотр" };
            readRecord.Click += ReadRecord_Click;
            return readRecord;
        }

        private void ReadRecord_Click(object sender, RoutedEventArgs e)
        {
            formActionStatus = 1;
        }

        private void CreateRecord_Click(object sender, RoutedEventArgs e)
        {
            formActionStatus = 0;
        }

        private MenuItem subMenuUpdate()
        {
            MenuItem updateRecord = new MenuItem { Header = "Сохранить" };
            updateRecord.Click += UpdateRecord_Click;
            return updateRecord;
        }

        private void UpdateRecord_Click(object sender, RoutedEventArgs e)
        {
            formActionStatus = 2;
        }

        private MenuItem subMenuDelete()
        {
            MenuItem deleteRecord = new MenuItem { Header = "Удалить" };
            deleteRecord.Click += DeleteRecord_Click;
            return deleteRecord;
        }

        private void DeleteRecord_Click(object sender, RoutedEventArgs e)
        {
            formActionStatus = 3;
        }

        private static void MenuFileExit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
