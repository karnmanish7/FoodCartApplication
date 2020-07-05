# Assignment-07 - Junior FSE MC1

## MC1: OO Programming using C#

### Objective

To develop console application for fetching Food Menu details based on different criteria 

***Concepts Covered***
1. Query expression, Write LINQ queries in C#, 
2. Return a query from a method, Store the results of a query in memory
3. Group results, nested group, subquery
4. Using Exceptions, Creating and Throwing Exceptions, Try-Catch, Finally

## TestCase and Development Code
> - Follow the Test cases in `test` Project
> - Start writing your development code in `FoodCart.Service` Project

## Expected Outcome 
> - Check the expected outcome of test cases written in `test` Project to get the
    required result
> - Check the Below output as a reference to execute the test cases

```
Retrieving All FoodItems In Vegetarian Soup Category

Cream of Tomato :: Rs.250
Veg Clear :: Rs.220

Retrieving All FoodItems In Vegetarian Soup Category Ordered By Price

Veg Clear :: Rs.220
Cream of Tomato :: Rs.250

Retrieving All FoodItems Grouped by Category and SubCategory

Vegetarian :: Starters
        Grilled Paneer :: Rs.150
        Aloo Chaat :: Rs.120
Vegetarian :: Soups
        Cream of Tomato :: Rs.250
        Veg Clear :: Rs.220
Vegetarian :: Main Course
        Paneer Kadhai :: Rs.350
        Kaju Paneer :: Rs.450

Retrieving All Paneer FoodItems Grouped by Category and SubCategory

Vegetarian :: Starters
        Grilled Paneer :: Rs.150
Vegetarian :: Main Course
        Paneer Kadhai :: Rs.350
        Kaju Paneer :: Rs.450

```
## Executable Console Application
> - Its `optional` once all the required test cases executed successfully 
    you can try with executable application i.e `FoodCart.App`
    to get the output in a `console window`
#### To use this as a boilerplate for your new project, you can follow these steps

1. Clone the base boilerplate in the folder **FoodCart_Application_Assignment_7** of your local machine
     
    `git clone https://gitlab-cts.stackroute.in/groupname/FoodCart_Application_Assignment_7.git`
         
2. Navigate to assignment-solution folder

    `cd FoodCart_Application_Assignment_7`

3. Remove its remote or original reference

     `git remote rm origin`

4. Create a new repo in gitlab named `FoodCart_Application_Assignment_7` as private repo

5. Add your new repository reference as remote

     `git remote add origin https://gitlab-cts.stackroute.in/{{yourusername}}/FoodCart_Application_Assignment_7`

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
📦foodcart_application_assignment_7
 ┣ 📂FoodCart.App
 ┃ ┣ 📂Properties
 ┃ ┃ ┗ 📜AssemblyInfo.cs
 ┃ ┣ 📜App.config
 ┃ ┣ 📜FoodCart.App.csproj
 ┃ ┗ 📜Program.cs
 ┣ 📂FoodCart.Service
 ┃ ┣ 📂Exceptions
 ┃ ┃ ┣ 📜CategoryNotFoundException.cs
 ┃ ┃ ┗ 📜FoodItemsNotFoundException.cs
 ┃ ┣ 📂Models
 ┃ ┃ ┣ 📜FoodCategory.cs
 ┃ ┃ ┗ 📜FoodItem.cs
 ┃ ┣ 📂Properties
 ┃ ┃ ┗ 📜AssemblyInfo.cs
 ┃ ┣ 📂Services
 ┃ ┃ ┗ 📜FoodCartRepository.cs
 ┃ ┗ 📜FoodCart.Service.csproj
 ┣ 📂test
 ┃ ┣ 📂Properties
 ┃ ┃ ┗ 📜AssemblyInfo.cs
 ┃ ┣ 📜FoodRepositoryTest.cs
 ┃ ┗ 📜test.csproj
 ┣ 📜.gitignore
 ┣ 📜FoodCart_Application_Assignment_9.sln
 ┣ 📜Problem.md
 ┗ 📜README.md

```
<b> `Don't change any file in test project` </b>