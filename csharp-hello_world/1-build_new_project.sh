#!/bin/bash

# Create the project directory
mkdir -p 1-new_project

# Navigate to the project directory
cd 1-new_project

# Initialize a new C# Console Application
dotnet new console -o .

# Build the project
dotnet build
