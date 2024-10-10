# PlatformDemo

## Overview

`PlatformDemo` is a .NET solution that includes a Class Library for managing service plans and associated timesheets, and an ASP.NET Core Web App for displaying these service plans.

## Class Library

The Class Library contains two main classes:

1. **ServicePlan**

    - `ServicePlanId`: Unique identifier for the service plan.
    - `DateOfPurchase`: Date when the service plan was purchased.
    - `Timesheets`: A list of associated timesheets.

2. **Timesheet**
    - `TimesheetId`: Unique identifier for the timesheet.
    - `RelatedServicePlan`: The service plan associated with the timesheet.
    - `DateTimeOfStart`: Start date and time of the timesheet.
    - `DateTimeOfEnd`: End date and time of the timesheet.
    - `Description`: A brief description of the timesheet.

## Web App

The ASP.NET Core Web App references the Class Library and displays a list of service plans, including the number of associated timesheets.

## Sample Data

The solution includes sample data consisting of 10-15 service plans, each with 0-5 associated timesheets.

## How to Run

1. Clone the repository.
2. Open the solution in Visual Studio or your preferred IDE.
3. Build the solution.
4. Run the Web App project.

## Documentation

The code is documented with comments to provide clarity on the functionality of each class and method.
