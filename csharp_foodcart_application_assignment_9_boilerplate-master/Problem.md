# Assignment-9 - Junior FSE MC1

## MC1: OO Using C#

### Objective:

To implement Data Persistence using EF6 in FoodCart Application

***Concepts Covered***
1. Domain Modeling and Managing Entity Relationships::
   one-to-many relationships, 
   one-to-one relationships, 
   many-to-many relationships
2. Managing Database Creation and Seeding Data

## TestCase and Development Code
> - Follow the Test cases in `test` Project
> - Start writing your development code in `FoodCart.Service` Project

## Expected Outcome 
> - Check the expected outcome of test cases written in `test` Project to get the
    required result
> - Check the Below output as a reference to execute the test cases

```
Welcome to FoodCart Application::
EF, Relations and Seed Data::
Required Data Created Successfully!!
```
## Executable Console Application
> - Its `optional` once all the required test cases executed successfully 
    you can try with executable application i.e `FoodCart.App`
    to get the output in a `console window`
#### To use this as a boilerplate for your new project, you can follow these steps

1. Clone the base boilerplate in the folder **FoodCart_Application_Assignment_9** of your local machine
     
    `git clone https://gitlab-cts.stackroute.in/groupname/FoodCart_Application_Assignment_9.git`
         
2. Navigate to assignment-solution folder

    `cd FoodCart_Application_Assignment_9`

3. Remove its remote or original reference

     `git remote rm origin`

4. Create a new repo in gitlab named `FoodCart_Application_Assignment_9` as private repo

5. Add your new repository reference as remote

     `git remote add origin https://gitlab-cts.stackroute.in/{{yourusername}}/FoodCart_Application_Assignment_9`

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
📦FoodCart_Application_Assignment_9
 ┣ 📂FoodCart.App
 ┃ ┣ 📜FoodCart.App.csproj
 ┃ ┗ 📜Program.cs
 ┣ 📂FoodCart.Service
 ┃ ┣ 📂ContextLayer
 ┃ ┃ ┣ 📜CustomerConfigurations.cs
 ┃ ┃ ┣ 📜FoodContext.cs
 ┃ ┃ ┗ 📜FoodDBInitializer.cs
 ┃ ┣ 📂Models
 ┃ ┃ ┣ 📜Customer.cs
 ┃ ┃ ┣ 📜OrderItem.cs
 ┃ ┃ ┣ 📜FoodOrder.cs
 ┃ ┣ 📂Repositories
 ┃ ┃ ┗ 📜CustomerRepository.cs
 ┃ ┃ ┗ 📜OrderRepository.cs
 ┃ ┣ 📜App.config
 ┃ ┗ 📜FoodCart.Service.csproj
 ┣ 📂test
 ┃ ┣ 📜App.config
 ┃ ┣ 📜CustomerRepositoryTest.cs
 ┃ ┣ 📜OrderRepositoryTest.cs
 ┃ ┗ 📜test.csproj
 ┣ 📜.gitignore
 ┣ 📜FoodCart_Application_Assignment_12.sln
 ┣ 📜Problem.md
 ┗ 📜README.md

```
<b> `Don't change any file in test project` </b>