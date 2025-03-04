# FizzBuzzProcessor Web API

## Introduction
FizzBuzzProcessor is a .NET Core Web API that accepts an array of values and processes them using the FizzBuzz logic:
- If a number is divisible by **3**, it returns `"Fizz"`.
- If a number is divisible by **5**, it returns `"Buzz"`.
- If a number is divisible by **both 3 and 5**, it returns `"FizzBuzz"`.
- If the value is not divisible by 3 or 5, it logs `"Divided X by 3"` and `"Divided X by 5"`.
- If the input is empty or not a number, it returns `"Invalid item"`.

## Features
✅ Developed using **.NET 8 (Latest Version)**  
✅ Implements **SOLID Principles**  
✅ Uses **Dependency Injection**  
✅ **Unit Tested** with xUnit & Moq  
✅ **Swagger & Postman Support**  

### Prerequisites
- Install **Visual Studio 2022**  
- Install **.NET SDK (Latest Version)**  
- (Optional) Install **Postman** for API testing


# C# Console Application  
## Prerequisites  
Before running the application, ensure you have:  
- .NET SDK installed (Check with: `dotnet --version`)

- ## Running the Console Application

- ### **Method 1: Running with `dotnet run` (Development Mode)**  
1. Open Command Prompt or PowerShell.  
2. Navigate to the project directory:  
   'cd path\to\your\project'
3.  Run the application using
   'dotnet run'
4. Once the application starts goto
   http://localhost:5005/swagger/index.html


## Troubleshooting
1. If you encounter permission issues, try running the command prompt as Administrator.
2. Ensure .NET SDK is installed and available in system PATH.
