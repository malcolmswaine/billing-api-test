# billing-api-test

Spike demo app based on requirements from 


# Task-Billing-API
This repository contains a description of the programming task used to evaluate software developers.

## Billing API

"XYZ Inc." is an imaginary company with main business focus on selling a variety of goods and services online via their E-Shop platform. Currently, there is a need for a new billing API that could process orders.

Each incoming order should contain:
* Order number;
*	User id;
*	Payable amount;
*	Payment gateway (identifier to map appropriate payment gateway);
*	Optional description.

When the billing service processes order, it sends the order to an appropriate payment gateway. If the order is processed successfully by the payment gateway, the billing service creates a receipt and returns it in response.

## Implementation rules

* Code should be covered with unit tests;
* Programming language - C#;
* Solution should be put into Github;
* Use REST API.

Rather than that, there are no restrictions - you can use any .NET framework you like, add any dependencies you want and enrich this API by any functionality you want to. The main goal of this task is to understand how you think and to see how your actual code looks.

## And Also ...

Create Console app in .net framework or .net core.
* The app should support two arguments.
* The app should have extension method that adds one argument to another
* The app should display the result.
* The app should have a few unit tests for this extension method.
* The app should save result in a database of your choice.
