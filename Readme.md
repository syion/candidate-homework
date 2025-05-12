<div style="text-align: center;"><img src="https://www.syion.com/icons/logo.png" width="50%"/></div>

# SYION - Candidate Homework

Hello Candidate! 

Thank you for considering SYION for your next career move. We are excited to see your skills in action. 👩🏻‍💻👨🏻‍💻

This repository contains a homework assignment that we would like you to complete.
The objective is to see how you approach a problem, your coding style, and your ability to communicate your thought process. The actual answer(s) is not as important as how you arrive at the answer(s).

NOTE: Yep - we totally get that you can cheat and use AI to do this. Sure, we get it. Which is why the answer(s) are not that important but your understanding of the problem and your thought process are:
- Why you chose the approach you did
- Why you created various files
- Why you styled your code the way you did
- What libraries you might have used and why this library over that library

Finally, the most critical part of this assignment is _communication_. Are you also able to follow instructions and communicate the steps you used to achive the results.

We expect no more than 2 hours on this assignment. If you are spending more time than that, please stop and reach out to us. We are happy to help you with any questions you might have.

## The Assignments

### 1. WebService Wrapper

- Why: Our main product is an old .NET FF 4.7.2 application this we need to migrate to .NET Core.
- Where: The `ASMXWebserviceWrapperService` project.
- What: Create a WebService wrapper for a Free API (two options to use are foud in the file `WebServices/WebServiceWrapperService.asmx.cs`)
  - Connect to the API of your choice.
  - Display the results in a simple HTML page. ** DOES NOT HAVE TO BE FANCY **
  
### 2. API application

- Why: Our new projects / migrated projects will all be done in .NET Core "Latest" (currently, .NET 8 or .NET 9)
- Where: The `API` project.
- What: Create a sample API that will return a list of items from a database.
  - Database is a list of people and their pets.
  - API is restricted by simple APIKeys. These are found in the database.
  - I would like to add a new person with/without a pet. This returns their API Key.
  - I would like to update a pet. I cannot update another persons pet.
  - I would also like to Add a pet. I cannot add a pet to another person.
  - Database schema is provided in the file `Database/DatabaseSchema.sql`
  - Choose your own DB.
  - Finally, I would like some tests to cover all/some of the API.

  
### Final Notes / Suggestions
- We 🥰 git with the fork/pull request model. We also love seeing commits.
- We love seeing tests. If some tests start to become repetitive, just have some placehold code "similar to above, tests for scenario-a, scenario-b, etc". More interested in seeing the thought process than the actual tests.
- We 🥰 seeing comments in the code. We are not looking for a novel, but we do want to see your thought process.
- If we had to clone this code to work on it locally, just assume we have only .NET 4.7.2 and NET Core 8/9 installed. Also Docker and git. That's it .. Oh! and an internet connection.


Any questions? PLEASE email and ask. We are happy to help you with any questions you might have.

Good luck and I hope you enjoy this assignment. We are looking forward to seeing your results.

-- end of document --