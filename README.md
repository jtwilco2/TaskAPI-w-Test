# TaskApp

A full-stack demonstration application build with a **.NET Web API** backend and a modern **Angular** standalone frontend. This project includes automated testing using **xUnit**.

## 📂 Project Structure

* **'TaskApi/'** - The .NET Web API backend serving task data.
* **'task-app/'** - The Angular frontend application.
* **'TaskApi.Tests/'** - The xUnit automation test suite for the API.

## 📋 Prerequisites

Ensure you have the following installed on your local machine:
* [.NET 8.0 SDK] 
* [Node.js]
* [Angular CLI]

## 🚀 How to Run the Application

You will need two seperate terminals to run the backend and fronted plus one more terminal to run the xUnit test.

### 1. Start the .NET Backend
Open your first terminal, navigate to the API directory, and run the project:
cd TaskApi
dotnet run

## 2. Start the Angular Frontend
Open a second terminal, navigate to the frontend directory:
npm install
ng serve -o

***NOTE*** you may need to change the app.component.ts to the correct port depending on what port the API is listening on...check first terminal


## 3. Run Test
Open a third terminal
cd TaskApi.Tests
dotnet test

You should get 1 succeded!!!