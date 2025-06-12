# System Integration Project (Academic)

This project addresses the integration of a legacy desktop system with a modern web-based analytics platform for an industrial company. The goal was to automate and synchronize production data flow, eliminating manual processes and reducing errors.

## Project Overview

The system integrates multiple components:

- **AplicacaoDesktop**: Simulates the generation of production data (piece code, time, test results) at set intervals.
- **AplicacaoWeb**: Receives, validates, and stores production data using stored procedures and SQL query calls.
- **Base_de_Dados**: Automatically computes production cost, profit, and loss using business rules and triggers.
- **AplicacaoDesktop_2_RabbitMQ**: Decouples the AplicacaoDesktop and AplicacaoWeb.
- **AplicacaoManager**: Displays real-time metrics such as:
  - Total produced items
  - Number of test results of status "OK" items
  - Average production time per piece

## Technologies Used

- `C#`, `ASP.NET`
- `Microsoft SQL Server`
- `RabbitMQ` and `RabbitMQ Streams`
- `Sikulix`
- `Visual Studio`
- `GitHub`

## Data Flow

### AplicacaoDesktop
- Calls the API of **AplicacaoWeb**
- Sends message to **RabbitMQ**
- Sends message to **RabbitMQ Stream**

### AplicacaoManager
- Processes the message from **RabbitMQ Stream**
- Displays the data

### AplicacaoDesktop_2_RabbitMQ
- Processes the message from **RabbitMQ**
- Calls the API of **AplicacaoWeb**
- Shows the data of the test results of status "failed" in **AplicacaoDesktop**

### AplicacaoWeb
- Processes the message from **RabbitMQ** and calls the **Base_de_Dados**
- Processes REST or SOAP messages and calls the **Base_de_Dados**

### Base_de_Dados
- Receives stored procedure calls
- Receives SQL query calls
- Activates triggers
