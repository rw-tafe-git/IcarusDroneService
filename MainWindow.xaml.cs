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

        //6.2	Create a global List<T> of type Drone called “FinishedList”. 
        private List<Drone> FinishedList;

        //6.3	Create a global Queue<T> of type Drone called “RegularService”.
        private Queue<Drone> RegularService;
        //6.4	Create a global Queue<T> of type Drone called “ExpressService”.
        private Queue<Drone> ExpressService;
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

        private void ButtonAddDrone_Click(object sender, RoutedEventArgs e)
        {
            //Put thingz here
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




        /*
        6.5	Create a button method called “AddNewItem” that will add a new service item to a Queue<> based on the priority. Use TextBoxes for the Client Name, Drone Model, Service Problem and Service Cost. Use a numeric up/down control for the Service Tag. The new service item will be added to the appropriate Queue based on the Priority radio button.
        6.6	Before a new service item is added to the Express Queue the service cost must be increased by 15%.
        6.7	Create a custom method called “GetServicePriority” which returns the value of the priority radio group. This method must be called inside the “AddNewItem” method before the new service item is added to a queue.
        6.8	Create a custom method that will display all the elements in the RegularService queue. The display must use a List View and with appropriate column headers.
        6.9	Create a custom method that will display all the elements in the ExpressService queue. The display must use a List View and with appropriate column headers.
        6.10	Create a custom keypress method to ensure the Service Cost textbox can only accept a double value with one decimal point.
        6.11	Create a custom method to increment the service tag control, this method must be called inside the “AddNewItem” method before the new service item is added to a queue.
        6.12	Create a mouse click method for the regular service ListView that will display the Client Name and Service Problem in the related textboxes.
        6.13	Create a mouse click method for the express service ListView that will display the Client Name and Service Problem in the related textboxes.
        6.14	Create a button click method that will remove a service item from the regular ListView and dequeue the regular service Queue<T> data structure. The dequeued item must be added to the List<T> and displayed in the ListBox for finished service items.
        6.15	Create a button click method that will remove a service item from the express ListView and dequeue the express service Queue<T> data structure. The dequeued item must be added to the List<T> and displayed in the ListBox for finished service items.
        6.16	Create a double mouse click method that will delete a service item from the finished listbox and remove the same item from the List<T>.
        6.17	Create a custom method that will clear all the textboxes after each service item has been added.
        */










    }
}
