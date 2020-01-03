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
                       type,
                       facilities;
        private double feePerVisitor,
                       annualBudget;
        private int numberOfEmployees,
                    visitorsLastYear;
        // properties
        public string Name { set; get; }
        public string Location { set; get; }
        public string Type { set; get; }
        public string Facilities { set; get; }
        public double FeePerVisitor { set; get; }
        public double AnnualBudget { set; get; }
        public int NumberOfEmployees { set; get; }
        public int VisitorsLastYear { set; get; }
        // constructors
        public Park()
        {
            name = "Grand Canyon";
            location = "Arizona";
            type = "National Park";
            facilities = "hiking, camping, rafting";
            feePerVisitor = 15;
            annualBudget = 21324300;
            numberOfEmployees = 382;
            visitorsLastYear = 6380000;
        }
        public Park(string parkName, string parkLocation, string parkType, string parkFacilities, double parkFeePerVisitor, double parkAnnualBudget, int parkEmployees, int parkVisitors)
        {
            name = parkName;
            location = parkLocation;
            type = parkType;
            facilities = parkFacilities;
            feePerVisitor = parkFeePerVisitor;
            annualBudget = parkAnnualBudget;
            numberOfEmployees = parkEmployees;
            visitorsLastYear = parkVisitors;
        }
        // instance methods
        public string ParkType()
        {
            string result = String.Format("{0, 16} {1, 24}\n", "Park Name:", name);
            result += String.Format("{0, 16} {1, 24}\n", "Park Location:", location);
            result += String.Format("{0, 16} {1, 24}\n", "Park Type:", type);
            return result;
        }
        public string ParkFacilities()
        {
            string result = String.Format("{0, 16} {1, 24}\n", "Park Name:", name);
            result += String.Format("{0, 16} {1, 24}\n", "Park Location:", location);
            result += String.Format("{0, 16} {1, 24}\n", "Facilities:", facilities);
            return result;
        }
        public double CostPerVisitor()
        {
            return annualBudget / visitorsLastYear;
        }
        public override string ToString()
        {
            string result = String.Format("***********************************************\n");
            result += String.Format("* {0, 18} {1, 24} *\n", "Park Name:", name);
            result += String.Format("* {0, 18} {1, 24} *\n", "Park Location:", location);
            result += String.Format("* {0, 18} {1, 24} *\n", "Park Type:", type);
            result += String.Format("* {0, 18} {1, 24} *\n", "Facilities:", facilities);
            result += String.Format("* {0, 18} {1, 24:C} *\n", "Fee Per Visitor:", feePerVisitor);
            result += String.Format("* {0, 18} {1, 24:C} *\n", "Budget:", annualBudget);
            result += String.Format("* {0, 18} {1, 24} *\n", "Employees:", numberOfEmployees);
            result += String.Format("* {0, 18} {1, 24} *\n", "Visitors:", visitorsLastYear);
            result += String.Format("* {0, 18} {1, 24:C} *\n", "Cost Per Visitor:", CostPerVisitor());
            result += String.Format("***********************************************\n");
            return result;
        }
    }
}
