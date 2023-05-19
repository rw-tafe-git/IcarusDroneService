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

namespace IcarusDroneService
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //private List<Drone> FinishedList;


        // private void ButtonAddService_PreviewMouseDown()

        private int GetServicePriority()
        {
            int priority = 0;
            if(rbRegular.IsChecked == true)
            {

            }

            return priority;
        }

        private void DisplayRegularService()
        {
            /*listViewRegularServiceQueue.Items.Clear();

            foreach (Drone value in RegularService)
            {

                listViewRegularServiceQueue.Items.Add(new { Name = value.GetClientName, Model = value.GetClientName, Problem = value.GetClientName, Cost = value.GetClientName, Tag = value.GetClientName })
            }*/
        }

        private void TextBoxServiceCost_PreviewTextInput()
        {
            //Regex regex = new Regex
        }

        //private void IncrementS

        /*private void listViewRegularServiceQueue_SelectionChanged()
        {
            if (listViewRegularServiceQueue.SelectedIndex != -1)
            {
                int index = listViewRegularServiceQueue.SelectedIndex;
                TextBoxClientName.Text = RegularService.ElementAt(index).GetClientName();
                TextBoxClientModel.Text = RegularService.ElementAt(index).GetClientModel();
                TextBoxServiceCost.Text = RegularService.ElementAt(index).GetServiceCost();
                TextBoxServiceProblem.Text = RegularService.ElementAt(index).GetServiceProblem();
            }
            else
            {
                listViewRegularServiceQueue.UnselectAll();
            }
        }

        private void RegularServiceDrone_PreviewMouseDown()
        {
            if (RegularService.Count > 0)
            {
                FinishedList.Add(ExpressService.Dequeue());
                DisplayExpressService();
                FinishedListDisplay();
            }
        }

        private void FinishedListDisplay()
        {
            listBoxFinished.Items.Clear();
            foreach(Drone drone in FinishedList)
            {
                listBoxFinished.Items.Add(drone.DisplayFinishedDrones());
            }
        }

        private void listBoxFinished_MouseDoubleClick()
        {
            int index = listBoxFinished.SelectedIndex;
            FinishedListDisplay().RemoveAt()
        }*/
    }
}
