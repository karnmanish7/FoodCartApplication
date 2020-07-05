# Assignment-1 - Junior FSE MC1

## MC1: Managing Input/Output for FoodCart_Application Orders 

***Concepts Covered***
1. Value types
2. Non-nullable value type
3. Nullable value type
4. checked and unchecked

### The estimated effort to complete this assignment is 2-3 hours

### To Do :
    - Fork the boilerplate
    - Clone the repository in your local directory
    - Start coding in your local copy
    - Push the code in git

## TestCase and Development Code
> - Follow the Test cases in `test` Project
> - Start writing solution code in `FoodCart` Project

### Expected Outcome:

Assignment Solution should contain:

> - C#.Net Framework Console Application With Required Functionalities
> - Models, Services should be in code behind files
> - Check the expected values of test cases written in `test` Project to get the required result
> - Check the Below output as a reference to execute the test cases

```
Enter Order Details

Customer Name Vikram
Food Item Veg Biryani
Price Rs. 200
Quantity 2
Do you have Coupon Code  Y:Yes, N:No Y
Enter Coupon Code 50

Order Placed Successfully

Enter Y to Continue, E to Exit Y

Enter Order Details

Customer Name Anil
Food Item Veg Pulav
Price Rs. 150
Quantity 1
Do you have Coupon Code  Y:Yes, N:No N

Order Placed Successfully

Enter Y to Continue, E to Exit E

Printing All Orders

Customer Name : Vikram Order Date : 5/26/2020 10:50:39 AM Food Item : Veg Biryani Price Rs. : 200 Quantity : 2 Coupon Code:50 Bill Amount Rs. : 350
Customer Name : Anil Order Date : 5/26/2020 10:50:55 AM Food Item : Veg Pulav Price Rs. : 150 Quantity : 1 Coupon Code:0 Bill Amount Rs. : 150

Total Quantity Ordered : 3

Total Amount (Rs.) : 500

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

1. Clone the base boilerplate in the folder **FoodCart-Assignment-Step1** of your local machine
     
    `git clone https://gitlab-cts.stackroute.in/groupname/FoodCart-Assignment-Step1.git`
         
2. Navigate to assignment-solution folder

    `cd FoodCart-Assignment-Step1`

3. Remove its remote or original reference

     `git remote rm origin`

4. Create a new repo in gitlab named `FoodCart-Assignment-Step1` as private repo

5. Add your new repository reference as remote

     `git remote add origin https://gitlab-cts.stackroute.in/{{yourusername}}/FoodCart-Assignment-Step1`

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
📦FoodCart_Application_Assignment_1
 ┣ 📂FoodCart.ConsoleApp
 ┃ ┣ 📜App.config
 ┃ ┣ 📜FoodCart.ConsoleApp.csproj
 ┃ ┗ 📜Program.cs
 ┣ 📂FoodCart.Service
 ┃ ┣ 📂Models
 ┃ ┃ ┗ 📜FoodOrder.cs
 ┃ ┣ 📂Service
 ┃ ┃ ┗ 📜OrderService.cs
 ┃ ┗ 📜FoodCart.Service.csproj
 ┣ 📂test
 ┃ ┣ 📜FoodCartTest.cs
 ┃ ┗ 📜test.csproj
 ┣ 📜.gitignore
 ┣ 📜FoodCart_Application_Assignment_1.sln
 ┣ 📜Problem.md
 ┗ 📜README.md
```
<b> `Don't change any file in test project` </b>
 
