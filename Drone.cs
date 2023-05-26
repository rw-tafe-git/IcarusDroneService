using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace IcarusDroneService
{
    // 6.1	Create a separate class file to hold the data items of the Drone. Use separate getter and setter methods, ensure the attributes are private and the accessor methods are public. Add a display method that returns a string for Client Name and Service Cost. Add suitable code to the Client Name and Service Problem accessor methods so the data is formatted as Title case or Sentence case. Save the class as “Drone.cs”.
    internal class Drone
    {
        private string ClientName;
        private string DroneModel;
        private string ServiceProblem;
        private double ServiceCost;
        private int ServiceTag;

        public Drone() { }

        public string GetClientName()
        {
            return ClientName;
        }

        public void SetClientName(string newClient)
        {
            if (newClient == null)
                ClientName = "Unknown";
            else
                ClientName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(newClient);
        }

        public string GetDroneModel()
        {
            return DroneModel;
        }

        public void SetDroneModel(string newModel)
        {
            DroneModel = newModel;
        }

        public string GetServiceProblem()
        {
            return ServiceProblem;
        }

        public void SetServiceProblem(string newServiceProblem)
        {
            ServiceProblem = newServiceProblem;
        }

        public double GetServiceCost()
        {
            return ServiceCost;
        }

        public void SetServiceCost(double newServiceCost)
        {
            if (newServiceCost <= 0)
                ServiceCost = 44.99f;
            else
                ServiceCost = newServiceCost;
        }

        public int GetServiceTag()
        {
            return ServiceTag;
        }

        public void SetServiceTag(int newServiceTag)
        {
            ServiceTag = newServiceTag;
        }

        public string DisplayFinishedDrones()
        {
            return GetClientName() + " : " + GetServiceCost();
        }
    }
}
