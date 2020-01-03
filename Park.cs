using System;
using System.Collections.Generic;
using System.Text;

namespace park_classes
{
    class Park
    {
        // data members
        private string name,
                       location,
                       facilityType;
        private double feePerVisitor,
                       annualBudget;
        private int numberOfEmployees,
                    visitorsLastYear;
        // properties
        public string Name { set; get; }
        public string Location { set; get; }
        public string FacilityType { set; get; }
        public double FeePerVisitor { set; get; }
        public double AnnualBudget { set; get; }
        public int NumberOfEmployees { set; get; }
        public int VisitorsLastYear { set; get; }
        // constructors
        public Park()
        {
            name = "Grand Canyon";
            location = "Arizona";
            facilityType = "National Park";
            feePerVisitor = 15;
            annualBudget = 21324300;
            numberOfEmployees = 382;
            visitorsLastYear = 6380000;
        }
        public Park(string parkName, string parkLocation, string parkFacilityType, double parkFeePerVisitor, double parkAnnualBudget, int parkEmployees, int parkVisitors)
        {
            name = parkName;
            location = parkLocation;
            facilityType = parkFacilityType;
            feePerVisitor = parkFeePerVisitor;
            annualBudget = parkAnnualBudget;
            numberOfEmployees = parkEmployees;
            visitorsLastYear = parkVisitors;
        }
    }
}
