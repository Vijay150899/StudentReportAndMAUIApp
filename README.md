# Student Report API

This is an ASP.NET Core Web API that generates student report cards based on a list of Student IDs.

## Features
- Returns student details: Name, Class, Section, Academic Year
- Returns exam-wise marks details: Subjects, Marks Obtained, Maximum Marks, Total, Percentage

## Technologies
- ASP.NET Core Web API
- Entity Framework Core (In-Memory Database)
- LINQ

## How to Run
1. Open the solution in Visual Studio.
2. Run the API.
3. Use Postman to call the endpoint:
   - POST: `https://localhost:{port}/api/ReportCard/GetReportCards`
   - Body (JSON): 
     ```json
     [1, 2]
     ```

## Sample API Endpoint
```http
POST /api/ReportCard/GetReportCards
