﻿# FoodCart_Application_Assignment_2 - Junior FSE MC1

## MC1: Developing Foodcart Application using Console Window(C# .Net Framework) 

## Objective

> - To develop a Console based Application for `Foodcart Application` Using .Net Framework 

***Concepts Covered***
1. Parameters and argument
2. Return values
3. Generic Classes, Generic Methods
4. Inheritance, Polymorphism, Members
5. Base classes
6. Inherited and overridden methods
7. Extension Methods


### The estimated effort to complete this assignment is 4-5 hours

### To Do :
    - Fork the boilerplate
    - Clone the repository in your local directory
    - Start coding in your local copy
    - Push the code in git

## TestCase and Development Code
> - Follow the Test cases in `test` Project
> - Start writing your development code in `FoodCart` Project

### Expected Outcome:

Assignment Solution should contain:
> - C#.Net Framework Console Application With Required Functionalities
> - Models, Services should be in code behind files
> - Check the expected outcome of test cases written in `test` Project to get the
    required result
> - Check the Below output as a reference to execute the test cases

```
Enter 1 for Online Order, 2 for Offline Order : 1

Enter Order Details

Customer Name Vikram
Address Bangaluru
Mobile No 9876545678
Do you have Coupon Code  Y:Yes, N:No Y
Enter Coupon Code 50
Food Item Veg Biryani
Price (Rs.) 300
Quantity 2

Enter Y to Continue, E to Exit Y
Enter 1 for Online Order, 2 for Offline Order : 2

Enter Order Details

Table No 3
Pay Mode Cash
Food Item Veg Pulav
Price (Rs.) 200
Quantity 2

Enter Y to Continue, E to Exit E

Printing All Orders

Customer Name : Vikram
 Address : Bangaluru
 Mobile No : 9876545678
 Coupon Code : True
 Date : 5/15/2020 8:03:22 PM
 Item : Veg Biryani
 Quantity : 2
 Price (Rs.) : 300

Table No : 3 PayMode  : Cash Date : 5/15/2020 8:03:48 PM
 Item : Veg Pulav
 Quantity : 2
 Price (Rs.) : 200


Total Quantity Ordered : 4

Total Amount (Rs.) : 950

```
## Executable Console Application

> - Its `optional` once all the required test cases executed successfully 
    you can try with executable application i.e `FoodCart.ConsoleApp`
    to get the output in a `console window`

### Instructions

1. Fork this boilerplate repository
2. Clone the boilerplate repository and cd into it
3. Analyze the application requirements as provided with the Readme.md file
4. Execute the test cases locally
5. Fix the solution code for failed test cases
6. Push the solution to git for review

#### To use this as a boilerplate for your new project, you can follow these steps

1. Clone the base boilerplate in the folder **FoodCart-Assignment-Step2** of your local machine
     
    `git clone https://gitlab-cts.stackroute.in/groupname/FoodCart-Assignment-Step2.git`
         
2. Navigate to assignment-solution folder

    `cd FoodCart-Assignment-Step2`

3. Remove its remote or original reference

     `git remote rm origin`

4. Create a new repo in gitlab named `FoodCart-Assignment-Step2` as private repo

5. Add your new repository reference as remote

     `git remote add origin https://gitlab-cts.stackroute.in/{{yourusername}}/FoodCart-Assignment-Step2`

     **Note: {{yourusername}} should be replaced by your username from gitlab**

5. Check the status of your repo 
     
     `git status`

6. Use the following command to update the index using the current content found in the working tree, to prepare the content staged for the next commit.

     `git add .`
 
7. Commit and Push the project to git

     `git commit -a -m "Initial commit | or place your comments according to your need"`

     `git push -u origin master`

8. Check on the git repo online, if the files have been pushed

### Important instructions for Participants
> - We expect you to write the assignment on your own by following through the guidelines, learning plan, and the practice Assignments
> - The code must not be plagirized, the mentors will randomly pick the submissions and may ask you to explain the solution
> - The code must be properly indented, code structure maintained as per the boilerplate and properly commented
> - Follow through the problem statement shared with you

### MENTORS TO BEGIN REVIEW YOUR WORK ONLY AFTER ->
> - You add the respective Mentor as a Reporter/Master into your Assignment Repository
> - Intimate your Mentor on Slack with your Git URL - Once you done working and is ready for review.

	   
**Note : Once you have cloned boilerplate from the given gitlab URL, open the project in the Visual studio. 
Your project test cases might show compile time errors for methods, as you have not written the complete code.**

### Project structure

The folders and files you see in this repositories is how it is expected to be in projects, which are submitted for review

```
📦FoodCart_Application_Assignment_2
 ┣ 📂FoodCart.ConsoleApp
 ┃ ┣ 📜App.config
 ┃ ┣ 📜FoodCart.ConsoleApp.csproj
 ┃ ┗ 📜Program.cs
 ┣ 📂FoodCart.Service
 ┃ ┣ 📂Models
 ┃ ┃ ┣ 📜FoodCart.cs
 ┃ ┃ ┣ 📜FoodOrder.cs
 ┃ ┃ ┣ 📜OfflineOrder.cs
 ┃ ┃ ┗ 📜OnlineOrder.cs
 ┃ ┣ 📂Properties
 ┃ ┃ ┗ 📜AssemblyInfo.cs
 ┃ ┣ 📂Service
 ┃ ┃ ┗ 📜CartOperations.cs
 ┃ ┃ ┗ 📜CartService.cs
 ┃ ┗ 📜FoodCart.Service.csproj
 ┣ 📂test
 ┃ ┣ 📜FoodOrderTest.cs
 ┃ ┗ 📜test.csproj
 ┣ 📜.gitignore
 ┣ 📜FoodCart_Application_Assignment_2.sln
 ┣ 📜Problem.md
 ┗ 📜README.md

```
<b> `Don't change any file in test project` </b>
 
