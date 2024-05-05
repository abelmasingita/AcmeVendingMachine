ACME Vending Machine

Description

The ACME Vending Machine project is a software solution for managing a vending machine. It provides functionalities for users to select products, make purchases, and receive change. This project aims to demonstrate the use of Angular for the frontend and ASP.NET Core for the backend.

Features

1. Browse or Search from available products
2. Select products for purchase
3. View total price and tendered amount
4. Receive change after purchase

Technologies Used

1. Angular
2. ASP.NET Core
3. HTML/CSS
4. TypeScript
5. Boostrap 5

Installation

Clone the repository
Navigate to the project/solution directory
Start the server on Visual studio by clicking the start button and both client(Angular) and Server(ASP.NET) apps will run.
Navigate to https://localhost:7135/swagger/index.html to access backend APIs
Navigate to https://127.0.0.1:4200/ to access frontend

Usage

1. Select a product from the list
2. Enter the tendered amount and complete the purchase
3. Click Purchase Button and Your change will be displayed.
4. If Tendered Amount is less than the purchase price, an alert will be displayed and purchase button disabled.


Figma Designs

https://www.figma.com/file/N9RDwQf7rVRYOp7wTJnQ3M/Mobile-Vending?type=design&node-id=0-1&mode=design&t=6G0BK2LsIcEN6AmP-0

![Mobile Vending](https://github.com/abelmasingita/AcmeVendingMachine/assets/60102940/4c30de67-b594-4a62-9ed5-5a1c229ed82d)


Solution - Code Explanation

![image](https://github.com/abelmasingita/AcmeVendingMachine/assets/60102940/6064a469-25a8-4aac-bf56-b6f20b106c8e)

On the Picture above you will see 3 projects.

1. acmevendingmachine.client - Angular FrontEnd
2. AcmeVendingMachine.Server - C# - ASP.NET Web API
3. AcmeVendingMachineTest - C# XUnit Tests

Build and run the Server project
![image](https://github.com/abelmasingita/AcmeVendingMachine/assets/60102940/b149dd60-5b3d-4211-8585-630ccae39a02)

Swagger API Documentation - https://localhost:7135/swagger/index.html
![image](https://github.com/abelmasingita/AcmeVendingMachine/assets/60102940/403d3de3-e26d-4b3d-8a6d-0e7cb0b42c12)

Angular/Client Frontend - https://127.0.0.1:4200

![image](https://github.com/abelmasingita/AcmeVendingMachine/assets/60102940/e267b905-94b7-4f40-8018-122afb75c033)

Change After Product Purchase
![image](https://github.com/abelmasingita/AcmeVendingMachine/assets/60102940/3b29b622-4c13-4404-bd65-3d99d55f0046)





