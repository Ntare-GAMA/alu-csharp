#!/usr/bin/env bash
dotnet new console -o 1-new_project --force 2>&1
dotnet build 1-new_project 2>&1
