using System;

class Park
{
    // Data members
    public string Name { get; set; }
    public string Location { get; set; }
    public string Type { get; set; }
    public double Fee { get; set; }
    public int NumEmployees { get; set; }
    public int NumVisitorsLast12Months { get; set; }
    public double AnnualBudget { get; set; }

    // Constructor
    public Park(string name, string location, string type, double fee, int numEmployees, int numVisitorsLast12Months, double annualBudget)
    {
        Name = name;
        Location = location;
        Type = type;
        Fee = fee;
        NumEmployees = numEmployees;
        NumVisitorsLast12Months = numVisitorsLast12Months;
        AnnualBudget = annualBudget;
    }

    // Method to return basic park information
    public string GetParkInfo()
    {
        return $"Park Name: {Name}\nLocation: {Location}\nType: {Type}";
    }

    // Method to return facilities available
    public string GetFacilities()
    {
        // You can expand this method to include more detailed facilities information if needed
        return $"Facilities Available: {Type}";
    }

    // Method to compute cost per visitor
    public double ComputeCostPerVisitor()
    {
        return AnnualBudget / NumVisitorsLast12Months;
    }

    // Method to compute revenue from fees for the past year
    public double ComputeRevenueFromFees()
    {
        return NumVisitorsLast12Months * Fee;
    }

    // ToString method to return all data members with appropriate labels
    public override string ToString()
    {
        return $"Park Name: {Name}\nLocation: {Location}\nType: {Type}\nFee: {Fee:C}\nNumber of Employees: {NumEmployees}\nNumber of Visitors (Last 12 Months): {NumVisitorsLast12Months}\nAnnual Budget: {AnnualBudget:C}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Testing Park class
        Park Banff = new Park("Banff National Park", "Alberta", "National", 30.00, 100, 500000, 10000000);

        Console.WriteLine(Banff.GetParkInfo());
        Console.WriteLine(Banff.GetFacilities());
        Console.WriteLine($"Cost per Visitor: {Banff.ComputeCostPerVisitor():C}");
        Console.WriteLine($"Revenue from Fees: {Banff.ComputeRevenueFromFees():C}");
        Console.WriteLine(Banff.ToString());
    }
}
