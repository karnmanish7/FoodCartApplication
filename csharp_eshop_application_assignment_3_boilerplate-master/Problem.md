# Assignment-3 - Junior FSE MC1

## MC1: Developing EShop Application using Console Window(C# .Net Framework) 

***Concepts Covered***

## Skills Set Required

1. Structs, Interface Implementation
2. Explicitly Implement Interface Members
3. Enums
4. Generic Interfaces

## TestCase and Development Code
> - Follow the Test cases in `test` Project
> - Start writing your development code in `EShop.OrderService` Project

## Expected Outcome 
> - Check the expected outcome of test cases written in `test` Project to get the
    required result
> - Check the Below output as a reference to execute the test cases

```
Invoice is Getting Generated...

1. On Screen
2. Print
3. Email
4. Download

Select the Option for Making it Available <1-4> :: 1

Invoice No. I200521120936
Customer Name : Vikram. H
Invoice Date : 5/21/2020
Item Name : Veg Biriyani Price Rs. : 150 Quanity : 1 Amount Rs. : 150
Item Name : Chicken Biriyani Price Rs. : 200 Quanity : 1 Amount Rs. : 200

Total Amount Rs. : 350
```
## Executable Console Application
> - Its `optional` once all the required test cases executed successfully 
    you can try with executable application i.e `EShop.APP`
    to get the output in a `console window`

> - Below is Sample output for reference

#### To use this as a boilerplate for your new project, you can follow these steps

1. Clone the base boilerplate in the folder **EShopApplication_Assignment_3** of your local machine
     
    `git clone https://gitlab-cts.stackroute.in/groupname/EShopApplication_Assignment_3.git`
         
2. Navigate to assignment-solution folder

    `cd EShopApplication_Assignment_3`

3. Remove its remote or original reference

     `git remote rm origin`

4. Create a new repo in gitlab named `EShopApplication_Assignment_3` as private repo

5. Add your new repository reference as remote

     `git remote add origin https://gitlab-cts.stackroute.in/{{yourusername}}/EShopApplication_Assignment_3`

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
📦EShopApplication_Assignment_3
 ┣ 📂EShop.APP
 ┃ ┣ 📜App.config
 ┃ ┣ 📜EShop.APP.csproj
 ┃ ┗ 📜Program.cs
 ┣ 📂EShop.OrderService
 ┃ ┣ 📂Constants
 ┃ ┃ ┗ 📜InvoiceOptions.cs
 ┃ ┣ 📂Models
 ┃ ┃ ┣ 📜Customer.cs
 ┃ ┃ ┗ 📜Item.cs
 ┃ ┣ 📂Services
 ┃ ┃ ┣ 📜IBillable.cs
 ┃ ┃ ┣ 📜IOrderRepository.cs
 ┃ ┃ ┗ 📜OrderManager.cs
 ┃ ┗ 📜EShop.OrderService.csproj
 ┣ 📂test
 ┃ ┣ 📜EshopOrderTest.cs
 ┃ ┗ 📜test.csproj
 ┣ 📜.gitignore
 ┣ 📜EShopApplication_Assignment_4.sln
 ┣ 📜Problem.md
 ┗ 📜README.md
```
<b> `Don't change any file in test project` </b>