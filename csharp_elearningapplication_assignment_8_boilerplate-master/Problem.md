# Assignment-08 - Junior FSE MC1

## MC1: OO Programming using C#

### Objective: 

To develop .NET Framework solution code based on TDD Approach

***Concepts Covered***
1. Introduction to Nunit
2. Use the concept of Assertions
3. Use the concept of Constraints and Attributes

## Development Code and Test case
> - Follow the development code in `ELearningService` Project
    and Write the Test cases in `ELearningApp.Test` Project
> - Install the required packages for writing and executing the test cases

## Expected Outcome 
> - For each requirement, test case code needs to be written, separately for Subscribers and Courses
> - Requirements are specifed through comments in Test classes provided in boilerplate
> - Course Test Cases should use Constraint Model for Assertions
> - Subscriber Test Cases should use Classic Model for Assertions
> - The solution code built should pass all the provided test cases


### To use this as a boilerplate for your new project, you can follow these steps

1. Clone the base boilerplate in the folder **ELearningApplication_Assignment_8** of your local machine
     
    `git clone https://gitlab-cts.stackroute.in/groupName/ELearningApplication_Assignment_8.git`

2. Navigate to ELearningApplication_Assignment_08 folder

    `cd ELearningApplication_Assignment_8`

3. Remove its remote or original reference

     `git remote rm origin`

4. Create a new repo in gitlab named `ELearningApplication_Assignment_8` as private repo

5. Add your new repository reference as remote

     `git remote add origin https://gitlab-cts.stackroute.in/{{yourusername}}/ELearningApplication_Assignment_8.git`

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
📦elearningapplication_assignment_8
 ┣ 📂ELearningApp.Test
 ┃ ┣ 📜ELearningApp.Test.csproj
 ┃ ┣ 📜packages.config
 ┃ ┣ 📜TestCourseRepository.cs
 ┃ ┣ 📜TestModel.cs
 ┃ ┗ 📜TestSubscriberRepository.cs
 ┣ 📂ELearningService
 ┃ ┣ 📂Models
 ┃ ┃ ┣ 📜Course.cs
 ┃ ┃ ┣ 📜InvalidInputException.cs
 ┃ ┃ ┗ 📜Subscriber.cs
 ┃ ┣ 📂Repositories
 ┃ ┃ ┣ 📜CourseRepository.cs
 ┃ ┃ ┣ 📜ICourseRepository.cs
 ┃ ┃ ┣ 📜ISubscriberRepository.cs
 ┃ ┃ ┗ 📜SubscriberRepository.cs
 ┃ ┗ 📜ELearningService.csproj
 ┣ 📜.gitignore
 ┣ 📜ELearningApplication_Assignment_11.sln
 ┣ 📜Problem.md
 ┗ 📜README.md
```
<b> `Don't change any file in test project` </b>

