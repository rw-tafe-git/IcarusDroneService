using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    //Student Riley, id 30002737, Date: 12/02/2023
    //Assessment Task 3

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
        private List<Drone> FinishedList = new List<Drone>();

        //6.3	Create a global Queue<T> of type Drone called “RegularService”.
        private Queue<Drone> RegularService = new Queue<Drone>();
        //6.4	Create a global Queue<T> of type Drone called “ExpressService”.
        private Queue<Drone> ExpressService = new Queue<Drone>();


        //6.5	Create a button method called “AddNewItem” that will add a new service item to a Queue<> based on the priority. Use TextBoxes for the Client Name, Drone Model, Service Problem and Service Cost. Use a numeric up/down control for the Service Tag. The new service item will be added to the appropriate Queue based on the Priority radio button.
        private void ButtonAddDrone_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxClientName.Text) && !string.IsNullOrEmpty(TextBoxClientModel.Text) && !string.IsNullOrEmpty(TextBoxServiceCost.Text) && !string.IsNullOrEmpty(TextBoxServiceCost.Text) && !string.IsNullOrEmpty(IntegerUpDownServiceTag.Text))
            {
                //Error trapping
                try
                {
                    Drone addDrone = new Drone();
                    addDrone.SetClientName(TextBoxClientName.Text);
                    addDrone.SetDroneModel(TextBoxClientModel.Text);
                    addDrone.SetServiceProblem(TextBoxServiceProblem.Text);
                    addDrone.SetServiceCost(double.Parse(TextBoxServiceCost.Text));
                    addDrone.SetServiceTag(int.Parse(IntegerUpDownServiceTag.Text));
                    
                    if (GetServicePriority() == 1)
                    {
                        RegularService.Enqueue(addDrone);
                        DisplayRegularService();

                        TextBlockStatus.Text = "Successfully added drone to Regular Service";
                    }
                    if (GetServicePriority() == 2)
                    {
                        //6.6	Before a new service item is added to the Express Queue the service cost must be increased by 15%.
                        addDrone.SetServiceCost(double.Parse(TextBoxServiceCost.Text) * 1.15);
                        ExpressService.Enqueue(addDrone);
                        DisplayExpressService();

                        TextBlockStatus.Text = "Successfully added drone to Express Service";
                    }
                    ClearTextBoxes();
                    IncrementServiceTag();
                }
                catch
                {
                    TextBlockStatus.Text = "Could not add drone";
                }
            }
            else
            {
                TextBlockStatus.Text = "Could not add drone";
            }
        }

        //6.7	Create a custom method called “GetServicePriority” which returns the value of the priority radio group. This method must be called inside the “AddNewItem” method before the new service item is added to a queue.
        private int GetServicePriority()
        {
            int priority = 0;
            if (rbRegular.IsChecked == true)
            {
                priority = 1;
            }
            else if (rbExpress.IsChecked == true)
            {
                priority = 2;
            }

            return priority;
        }

        private void FinishedListDisplay()
        {
            listBoxCompletedServices.Items.Clear();
            foreach(Drone drone in FinishedList)
            {
                listBoxCompletedServices.Items.Add(drone.DisplayFinishedDrones());
            }
        }

        //6.8	Create a custom method that will display all the elements in the RegularService queue. The display must use a List View and with appropriate column headers.
        private void DisplayRegularService()
        {
            listViewRegularServiceQueue.Items.Clear();

            foreach (Drone value in RegularService)
            {
                listViewRegularServiceQueue.Items.Add(new { Name = value.GetClientName(), Model = value.GetDroneModel(), Problem = value.GetServiceProblem(), Cost = value.GetServiceCost(), Tag = value.GetServiceTag() });
            }
        }

        //6.9	Create a custom method that will display all the elements in the ExpressService queue. The display must use a List View and with appropriate column headers.
        private void DisplayExpressService()
        {
            listViewExpressServiceQueue.Items.Clear();

            foreach (Drone value in ExpressService)
            {
                listViewExpressServiceQueue.Items.Add(new { Name = value.GetClientName(), Model = value.GetDroneModel(), Problem = value.GetServiceProblem(), Cost = value.GetServiceCost(), Tag = value.GetServiceTag() });
            }
        }

        //6.10	Create a custom keypress method to ensure the Service Cost textbox can only accept a double value with one decimal point.
        private void TextBoxServiceCost_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //Regex regex = new Regex;
        }

        //6.11	Create a custom method to increment the service tag control, this method must be called inside the “AddNewItem” method before the new service item is added to a queue.
        private void IncrementServiceTag()
        {
            int currentTag = (int)IntegerUpDownServiceTag.Value;
            currentTag = currentTag + 10;
            IntegerUpDownServiceTag.Value = currentTag;
        }

        //6.12	Create a mouse click method for the regular service ListView that will display the Client Name and Service Problem in the related textboxes.
        private void listViewRegularServiceQueue_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (listViewRegularServiceQueue.SelectedIndex != -1)
                {
                    int index = listViewRegularServiceQueue.SelectedIndex;
                    TextBoxClientName.Text = RegularService.ElementAt(index).GetClientName();
                    TextBoxClientModel.Text = RegularService.ElementAt(index).GetDroneModel();
                    TextBoxServiceCost.Text = RegularService.ElementAt(index).GetServiceCost().ToString();
                    TextBoxServiceProblem.Text = RegularService.ElementAt(index).GetServiceProblem();
                }
                else
                {
                    listViewRegularServiceQueue.UnselectAll();
                }
            }
            catch
            {
                TextBlockStatus.Text = "Selection error";
            }
        }

        //6.13	Create a mouse click method for the express service ListView that will display the Client Name and Service Problem in the related textboxes.
        private void listViewExpressServiceQueue_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (listViewExpressServiceQueue.SelectedIndex != -1)
                {
                    int index = listViewExpressServiceQueue.SelectedIndex;
                    TextBoxClientName.Text = ExpressService.ElementAt(index).GetClientName();
                    TextBoxClientModel.Text = ExpressService.ElementAt(index).GetDroneModel();
                    TextBoxServiceCost.Text = ExpressService.ElementAt(index).GetServiceCost().ToString();
                    TextBoxServiceProblem.Text = ExpressService.ElementAt(index).GetServiceProblem();
                }
                else
                {
                    listViewExpressServiceQueue.UnselectAll();
                }
            }
            catch
            {
                TextBlockStatus.Text = "Selection error";
            }
        }

        //6.14	Create a button click method that will remove a service item from the regular ListView and dequeue the regular service Queue<T> data structure. The dequeued item must be added to the List<T> and displayed in the ListBox for finished service items.
        private void ButtonServiceDroneRegular_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (RegularService.Count > 0)
            {
                FinishedList.Add(RegularService.Dequeue());
                DisplayRegularService();
                FinishedListDisplay();

                TextBlockStatus.Text = "Successfully dequeued service";
            }
        }

        //6.15	Create a button click method that will remove a service item from the express ListView and dequeue the express service Queue<T> data structure. The dequeued item must be added to the List<T> and displayed in the ListBox for finished service items.
        private void ButtonServiceDroneExpress_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (ExpressService.Count > 0)
            {
                FinishedList.Add(ExpressService.Dequeue());
                DisplayExpressService();
                FinishedListDisplay();

                TextBlockStatus.Text = "Successfully dequeued service";
            }
        }

        //6.16	Create a double mouse click method that will delete a service item from the finished listbox and remove the same item from the List<T>.
        private void listBoxCompletedServices_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            RemoveCompleted();
        }

        private void ButtonRemoveService_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            RemoveCompleted();
        }

        void RemoveCompleted()
        {
            try
            {
                int index = listBoxCompletedServices.SelectedIndex;
                FinishedList.RemoveAt(index);
                FinishedListDisplay();

                TextBlockStatus.Text = "Successfully removed completed service from list";
            }
            catch 
            {
                TextBlockStatus.Text = "Could not remove completed service from list";
            }
        }

        //6.17	Create a custom method that will clear all the textboxes after each service item has been added.
        private void ClearTextBoxes()
        {
            TextBoxClientName.Clear();
            TextBoxClientModel.Clear();
            TextBoxServiceCost.Clear();
            TextBoxServiceProblem.Clear();
        }
    }
}
