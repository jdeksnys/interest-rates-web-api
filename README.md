# Lending Rates Web Api (ASP.NET Core)

## About
A Web Api returning loan interest rate data stored in Azure SQL (Postgre) database.<br>
Data from the Central Bank of Lithuania (https://www.lb.lt/en/lending-rates-1) was used to populate the Azure database.

#### Aim of project
- Build a working Web Api

#### Learning outcomes
- General knowledge of Web Api in .Net Core
- Entity framework (Azure database context setup)
- Code-first migrations


## Documentation

#### Swagger: https://interest-rates-web-api.azurewebsites.net/swagger/index.html
#### Request url: https://interest-rates-web-api.azurewebsites.net/api/{type}/{period}
- **type (string): "corporation"/"household".** *Represents loan lending rates to non-financial corporations or households respectively.*
- **period (string, optional): "01-MM-yyyy".** *Specify month for data values. Range: 01-01-2015 - 01-02-2022. Ex.: "01-09-2019".*
