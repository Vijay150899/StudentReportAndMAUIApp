# Student Report and Product MAUI Application

This repository contains two separate applications:

1. **Student Report API** - An ASP.NET Core Web API that generates student report cards based on Student IDs.
2. **Product MAUI App** - A .NET MAUI application that displays a list of products and detailed product information using a public API.

---

## 📂 Project Structure
- `StudentReportAPI` - ASP.NET Core Web API (Task 1)
- `MauiProductApp` - .NET MAUI Application (Task 2)

---

## 🚀 Applications

### 1. Student Report API

#### Description
An ASP.NET Core Web API that generates student report cards based on a list of Student IDs.

#### Features
- Returns student details: Name, Class, Section, Academic Year
- Returns exam-wise marks: Subjects, Marks Obtained, Maximum Marks, Total, Percentage

#### Technologies
- ASP.NET Core Web API
- Entity Framework Core (In-Memory Database)
- C#

---

### 2. Product MAUI App

#### Description
A .NET MAUI application that displays a list of products fetched from a public REST API. Allows users to view detailed information about each product.

#### Features
- Displays product list with image, title, and price
- Shows detailed product page on selection
- Fetches product data from a public REST API

#### Technologies
- .NET MAUI
- MVVM Architecture
- REST API Integration
- C#
- XAML

---

## 🔧 How to Run

### Student Report API
1. Open the solution in **Visual Studio 2022**.
2. Set **StudentReportAPI** as the startup project.
3. Run the API. Use tools like Postman to test the endpoints.

### Product MAUI App
1. Set **MauiProductApp** as the startup project.
2. Select target device: Windows Machine, Android Emulator, or supported MAUI platform.
3. Build and run the project.

---

## 🌐 API Used in Product App
- [Fake Store API](https://fakestoreapi.com/products)

---

## ✅ Summary
This project demonstrates:
- API development using ASP.NET Core
- Cross-platform mobile/desktop app development using .NET MAUI
- REST API consumption
- Basic MVVM architecture in MAUI

