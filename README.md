
# Project Title

IsraeliDataGenerator

# Israeli Data Generator

The IsraeliDataGenerator class is a C# utility that allows you to generate mock Hebrew names, last names, addresses, and more.
This class can be used in your projects to generate realistic Israeli data for testing purposes.

#### Author: Ofir Somech

## Features

- Generate random Israeli Identity number
- Generate random Israeli first names
- Generate random Israeli last names
- Generate random Israeli city names
- Generate random Israeli street names
- Generate random Israeli package names
- Generate random Israeli zip codes
- Generate random house numbers with optional Hebrew letters

## Usage

1. Import the IsraeliDataGenerator class into your project.
2. Use the available methods to generate the data you need:

- GenerateIsraeliIDNumber()
- GetRandomFirstName()
- GetRandomLastName()
- GetRandomCity()
- GetRandomStreet()
- GetRandomPackageName()
- GenerateIsraeliZipCode()
- GenerateHouseNumber()
- IsValidIsraeliID(string id)

```csharp
using IsraeliDataGenerator;

string firstName = IsraeliDataGenerator.GetRandomFirstName();
string lastName = IsraeliDataGenerator.GetRandomLastName();
string city = IsraeliDataGenerator.GetRandomCity();
string street = IsraeliDataGenerator.GetRandomStreet();
string packageName = IsraeliDataGenerator.GetRandomPackageName();
string zipCode = IsraeliDataGenerator.GenerateIsraeliZipCode();
string houseNumber = IsraeliDataGenerator.GenerateHouseNumber();
string idNumber = IsraeliDataGenerator.GenerateIsraeliIDNumber();
