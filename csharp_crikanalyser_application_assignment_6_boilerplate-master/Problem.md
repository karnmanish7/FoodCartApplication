# Assignment-6 - Junior FSE MC1

## MC1: OO Programming using C#

### Objective

To develop console application for creating Result Summary on runs scored and wickets taken for the matches played against various team in a tournament

***Concepts Covered***
1. Delegates
2. MultiCast Delegate
3. Indexers
4. Lambda Expressions

## TestCase and Development Code

> - Follow the Test cases in `test` Project
> - CricketRepository class contains static collection with CricketMatch details which would be used by test cases
> - Start writing your development code in `CrikAnalyser.Service` Project

## Expected Outcome 

> - Check the expected outcome of test cases written in `test` Project to get the
    required result
> - Check the Below output as a reference to execute the test cases

```
Runs Scored Analysis

Total Matches Played : 5
Total Wickets Taken : 1410
Maximum Wickets Taken : 350
Minimum Wickets Taken : 220
Average Wickets Taken : 282

Wickets Taken Analysis

Total Matches Played : 5
Total Wickets Taken : 28
Maximum Wickets Taken : 7
Minimum Wickets Taken : 3
Average Wickets Taken : 5.6

 Score Analysis against Team Australia

Result Against Team Australia : India Won By 1 Run

List of Defeated Opponents

Pakistan
England
Australia

List of Winning Opponents

SA
West Indies

```
## Executable Console Application
> - Its `optional` once all the required test cases executed successfully 
    you can try with executable application i.e `CrikAnalyser.APP`
    to get the output in a `console window`

#### To use this as a boilerplate for your new project, you can follow these steps

1. Clone the base boilerplate in the folder **CrikAnalyser_Application_Assignment_6** of your local machine
     
    `git clone https://gitlab-cts.stackroute.in/groupname/CrikAnalyser_Application_Assignment_6.git`
         
2. Navigate to assignment-solution folder

    `cd CrikAnalyser_Application_Assignment_6`

3. Remove its remote or original reference

     `git remote rm origin`

4. Create a new repo in gitlab named `CrikAnalyser_Application_Assignment_6` as private repo

5. Add your new repository reference as remote

     `git remote add origin https://gitlab-cts.stackroute.in/{{yourusername}}/CrikAnalyser_Application_Assignment_6`

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
📦crikanalyser_application_assignment_6
 ┣ 📂CrikAnalyser.APP
 ┃ ┣ 📂Properties
 ┃ ┃ ┗ 📜AssemblyInfo.cs
 ┃ ┣ 📜App.config
 ┃ ┣ 📜CrikAnalyser.APP.csproj
 ┃ ┗ 📜Program.cs
 ┣ 📂CrikAnalyser.Service
 ┃ ┣ 📂Models
 ┃ ┃ ┣ 📜CricketMatch.cs
 ┃ ┃ ┗ 📜CricketMatchResults.cs
 ┃ ┣ 📂Properties
 ┃ ┃ ┗ 📜AssemblyInfo.cs
 ┃ ┣ 📂Repositories
 ┃ ┃ ┗ 📜CricketMatchRepository.cs
 ┃ ┣ 📂Services
 ┃ ┃ ┗ 📜ScoreBoardService.cs
 ┃ ┗ 📜CrikAnalyser.Service.csproj
 ┣ 📂test
 ┃ ┣ 📂Properties
 ┃ ┃ ┗ 📜AssemblyInfo.cs
 ┃ ┣ 📜CricketMatchRepositoryTest.cs
 ┃ ┣ 📜packages.config
 ┃ ┗ 📜test.csproj
 ┣ 📜.gitignore
 ┣ 📜crikanalyser_application_assignment_8.sln
 ┣ 📜Problem.md
 ┗ 📜README.md
```
<b> `Don't change any file in test project` </b>