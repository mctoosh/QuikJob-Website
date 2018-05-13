# QuikJob-Website
QuikJob is a job portal website where applicants are able to apply for a job

The system that is created is a job portal website called QuickJob Ltd. The core functionality of the system is to allow the applicant to apply for different types of jobs. Before the applicant can apply for any jobs they would need to be a member of the website. Here they have the option of registering to the system. Once registered they can search for more jobs and save these jobs to their account. They then can apply for the saved jobs where the system would then redirect the applicants to a page where they can update their personal details. Once they complete updating their details they would successfully have applied for the job. 
The details would then be passed on to the admin side where they can view all the details of the applicant including their personal details and also the jobs that they have applied for. They can also download any CV that the applicant has. Furthermore, the admin would also be able to add jobs and job categories onto the system. However, before the admin can complete any of these actions, he would need to be a member of an admin that possess login details so that he could enter the admin page. 
Below will show step by step how the core functional job portal website works.    
View Applicant Details (Admin)

 ![image](https://user-images.githubusercontent.com/15992710/39968705-4a794538-56c9-11e8-95a1-c52b99486ee3.png)
 
(Figure 1)

Before the admin enters the admin page, they must put in the correct username and password. If they put in the wrong details the system prompts an error message
 
 ![image](https://user-images.githubusercontent.com/15992710/39968948-1277de02-56cd-11e8-8795-c03a380a7f09.png)

 
(Figure 2)



The code that I used to prompt the error is 
 
 ![image](https://user-images.githubusercontent.com/15992710/39968961-428a1b1e-56cd-11e8-9cc0-f77f4d33524b.png)

 
(Figure 3)

Once the admin enters the correct login details, they will be redirected to the admin home page where they are able to view all the applicants that have applied for a job. 
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39968984-8c8a162e-56cd-11e8-95f6-95cbc83a736b.png)

 
(Figure 4)

On this page the admin will be able to view the details of the applicant such as their first and last name. furthermore, with this page they are able to contact the applicants by either using their email address or their phone number. Moreover, the admin has the option to download the user’s CV or to view the applicant’s full details. Moreover, by using the left side if the page, the admin can get to different pages. 
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39968992-974139bc-56cd-11e8-8c84-9ac8e995a9a3.png)

 
(Figure 5)

Once the admin selects view full details for a specific applicant, the system will display the full details of the applicant. On this page the admin will be able to view the applicant details and also the jobs they have applied for, such as figure 5 shows that the applicant has applied for the job Google as an administrator. 
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39968995-a0bf0190-56cd-11e8-9d7d-7f8fc587fe4e.png)

 
(Figure 6)

The admin then has the option to download the applicant’s CV, so that they can view further details of the applicant such as work experiences and educations. Once the admin clicks on download CV, the system will prompt a save as window where the admin can save the CV on to his system. The admin is then able to view the CV as shown on figure 7. 
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969000-b5ed3a82-56cd-11e8-8b04-cb65ab662f10.png)

 
(Figure 7)

Add Jobs (Admin)
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969002-c0b387a0-56cd-11e8-88ba-04344edfb6e2.png)

 
(Figure 8)

On this page the admin will be able to add new jobs so that the applicants can apply for them. Once the admin has filled in the details he has the option to add a company or job image as shown on figure 9.  
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969003-c9389c62-56cd-11e8-8c91-71e1ca70b32f.png)

 
(Figure 9)

Furthermore, the admin would need to add the job on to a category where he would select it from the dropdown list of categories as shown on figure 10. 
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969012-e32d9ef6-56cd-11e8-9d68-e7cb8b605041.png)

 
(Figure 10)

Once the admin fills in all the details for the job, the web page will then display a message telling them they have successfully uploaded the job onto the user home page, where they are able to apply for this job, as shown as figure 11.  


![image](https://user-images.githubusercontent.com/15992710/39969017-f07eaa1e-56cd-11e8-86a0-8be92ac02776.png)

 
(Figure 11)

Furthermore, all the characters are also removed from the textboxes as soon as the job is uploaded successfully as shown on figure 11. The code that I used to perform this action is shown on figure 12. 
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969019-fb1236da-56cd-11e8-822f-cad01fae3959.png)

 
(Figure 12)

Add Job Category (Admin)
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969021-05a91f28-56ce-11e8-80f7-e22d0c7cad08.png)
 
(Figure 13)

On this page the admin is able to add Job categories on to the user home page. With these categories, it helps the applicants to filter the job roles to jobs that they are looking for such as, admin or It Technician. Once the admin adds a job category, the system will prompt a message saying that the job category was added successfully, as shown on figure 14 
 
 
 
![image](https://user-images.githubusercontent.com/15992710/39969031-19304cce-56ce-11e8-8ac5-9a72e199f33f.png)
 
(Figure 14)
 
 
![image](https://user-images.githubusercontent.com/15992710/39969036-2b3c0b74-56ce-11e8-882b-3f9a8ea86b90.png)
 
 
(Figure 15)

The job category is then successfully displayed on to the page, as shown on figure 15. Furthermore, the admin has the option to delete the job category, where this would also delete all the jobs that are in that category, the admin would need to select the delete button displayed next to the job category name, where in return it will remove the job category as shown on figure 16. 
  
  
  
![image](https://user-images.githubusercontent.com/15992710/39969039-379ea980-56ce-11e8-90b9-a1796c9049c2.png)
  
(Figure 16)

Once the admin has completed his work, he would need to logout from the admin web page by using the logout button as shown on figure 17 and 18. 
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969045-4e991fda-56ce-11e8-9c25-bbeb0417fe71.png)

 
(Figure 17)

 
 
![image](https://user-images.githubusercontent.com/15992710/39969047-550c27ea-56ce-11e8-94b1-dc8e8d69e716.png)
 
 
(Figure 18)

Once the admin selects the logout button the system will redirect the admin to the admin login page as shown on figure 19. 
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969051-6aea044c-56ce-11e8-8d11-db096a759c86.png)
 
(Figure 19)

Furthermore, the admin has the option to visit the User home page by clicking on the button user home page as shown on figure 20. 
 
 
 
![image](https://user-images.githubusercontent.com/15992710/39969052-7260280a-56ce-11e8-8f56-bfad208e2f92.png)

 
(Figure 20)

Display Jobs (Applicant)
 
 ![image](https://user-images.githubusercontent.com/15992710/39969056-7d66bd36-56ce-11e8-9529-df3fa1934bd3.png)
 
 
(Figure 21)

Once the applicant enters the website they will be displayed with this homepage as shown on figure 21. Whenever the admin adds a new job, it will be displayed on to this page where the applicants can then apply for those jobs.   
The applicants have the option to use the search text box to filter out the job that they are looking for as shown on figure 22 and 23. 
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969058-8cb1acc4-56ce-11e8-95e3-284b0f3e3750.png)
 
(Figure 22)
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969062-a8463dc4-56ce-11e8-8cb5-d3c6eb8dadaf.png)
 
(Figure 23)

Furthermore, as you can see the search box on figure 23, I have used the SQL like operator, where it finds any value that has face on the web page. The code that I used for this to work is shown on figure 24. 
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969071-c8c6f98a-56ce-11e8-8167-2beec6fa1465.png)
 
(Figure 24)

Furthermore, the applicant can also use the job categories that is displayed on the left of the home page as shown on figure 25. 
  
  ![image](https://user-images.githubusercontent.com/15992710/39969075-d9812746-56ce-11e8-943c-a0b049cc1e69.png)
  
(Figure 25)

Once the applicant selects a category, the homepage will display all the related job roles to the applicant as shown on figure 26, only the software developer job roles are displayed. 
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969082-e4844038-56ce-11e8-9748-bcb09760be69.png)
 
(Figure 26)

Once the applicant selects a job from the homepage, they will be redirected to the jobs description web page, where the applicant can find out further details of the job as shown on figure 27. 
   
   
   ![image](https://user-images.githubusercontent.com/15992710/39969095-031e5bbe-56cf-11e8-9b42-309a9c68b6c6.png)
   
(Figure 27)

Furthermore, the applicant has the choice to print out the description of the job by pressing the print button displayed on the bottom left corner of the home page as shown on figure 28. 
  
  
  ![image](https://user-images.githubusercontent.com/15992710/39969101-12ecc486-56cf-11e8-8f47-caaec48f58f0.png)
  
(Figure 28)

If the applicant feels like this is the right job for him he has the option of saving the job by selecting the save job button as shown on figure 27. Once the applicant clicks the save job button, the job is then added to the saved jobs of the applicant as shown on figure 29. 

 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969106-206d76fa-56cf-11e8-87b5-2fbfa66874b2.png)
 
(Figure 29)

The applicant then has the option to either apply for the saved job or to look for other jobs to apply for as well. As soon as the applicant is satisfied with the jobs he saved, he then would need to apply for the jobs by clicking on the button apply for jobs as shown on figure 30. 

 
![image](https://user-images.githubusercontent.com/15992710/39969109-2de7c25e-56cf-11e8-9a21-cbd6b7b8f5b5.png)
 
 
(Figure 30)

Moreover, if the applicant changes his mind about a job that he doesn’t feel comfortable with, he has the option of deleting that job from his saved list by clicking on the button delete. The job would then be deleted as shown on figure 31. 
   
   
   ![image](https://user-images.githubusercontent.com/15992710/39969114-3b181532-56cf-11e8-99e5-5080fc47214d.png)
   
(Figure 31)

Once the applicant is completely happy with the jobs, he then can press the apply for jobs button. As soon as the applicant selects the apply for jobs button, the systems would require the applicant login to the website, this is because the user would need to be registered to the system before applying for any jobs, as shown on figure 32.
Applicant Authentication (Applicant)
  
  
  ![image](https://user-images.githubusercontent.com/15992710/39969117-467a9594-56cf-11e8-87d8-99dbc101165c.png)
  
(Figure 32)

If the applicant is not a member on the system he would then need to click on the Register here button, so that he can apply for jobs. Once the applicant selects the register here button, the system will redirect the applicant to the register page as shown on figure 33. 

 
![image](https://user-images.githubusercontent.com/15992710/39969120-4fa0f136-56cf-11e8-8fb1-b0aeaf4b7f82.png)
 
 
(Figure 33)

On this page the applicant can register by putting in his details, he also has to put in his personal CV as shown on figure 34. 
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969121-617fa9ba-56cf-11e8-9ada-ee2add7dc461.png)
 
(Figure 34)

Once the applicant registers, he would get a message that says the applicant has registered successfully and all the text boxes would be cleared as shown on figure 35.
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969125-6ccc9d1e-56cf-11e8-80d7-89ab1806b92f.png)
 
(Figure 35)

The applicant can now login using the details he registered with. As soon as the applicant logs in to the system, the system would prompt a welcome message using the applicants first and last name as shown on figure 36. 
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969126-745d0690-56cf-11e8-9892-5d92166773a3.png)
 
(Figure 36)
However, if the applicant saves a job and he is already a member and is able to sign in, the system would redirect the applicant straight to the update user details page, where the applicant can update any incorrect or outdated details of the applicant as shown on figure 39. 
Once the applicant signs in to the system he would need to select saved jobs, so that he can apply for the job he saved before registering as shown on figure 37 and 38, furthermore, as shown on figure 37, once the applicant is logged in to the system, the navigation bar would show logout instead of login and also the applicant will get the option to view the jobs he applied for by selecting my jobs link. 
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969128-7d97b796-56cf-11e8-920b-bc78486c7bd3.png)
 
(Figure 37)
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969130-89933ed0-56cf-11e8-97f7-eeb818f20c1f.png)
 
(Figure 38)

View Applicant Details (Applicant)
Once the applicant selects apply for jobs, the system would this type redirect him to the update user details page, where the applicant gets the option of updating any incorrect or outdated information about them self’s as shown on figure 39. 
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969136-a69f5784-56cf-11e8-8625-9b32b7d2f1e8.png)
 
(Figure 39)

Once the applicant is satisfied with his details he would select update and continue, where these details would then be passed to the admin page. The admin would then be able to view the users details and his CV after this stage as shown on figure 4 and figure 5. 
Furthermore, the applicant also has the option to view his details by selecting My jobs from the navigation bar as shown on figure 40 and 41. 
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969143-b87bd784-56cf-11e8-8e3b-816f16033fb9.png)
 
(Figure 40)
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969144-bfa20bfa-56cf-11e8-9708-603a8ce81909.png)

 
(Figure 41)

Furthermore, the applicant can also view the full details by selecting the link view full details where the page would then be redirected to the full details of the applicant as shown on figure 42. Furthermore, the applicant can also download a copy of his own CV by clicking on the link download CV here. 
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969145-caee5acc-56cf-11e8-9136-33a0cd461b25.png)
 
(Figure 42)

Once the applicant has finished searching and applying for jobs, he then has to logout from his account by selecting the logout link on the navigation bar as shown on figure 43. 
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969148-d450909e-56cf-11e8-8975-4b590ddf232e.png)
 
(Figure 43)

Once the applicant logs out from his account the system will redirect the applicant to the log in page as shown on figure 32. 
Furthermore, the link logout would be changed to login on the navigation bar as shown on figure 44. 

 
 ![image](https://user-images.githubusercontent.com/15992710/39969153-df8e0cf2-56cf-11e8-84a8-3cfeca99fd40.png)
 
(Figure 44)

Furthermore, if the applicant puts in the wrong login details, the system would prompt an error message as shown on figure 45. 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969157-ea43c7fe-56cf-11e8-8aef-69359771bf92.png)

 
(Figure 45)



# Documentation
### Use Case Diagram
![image](https://user-images.githubusercontent.com/15992710/39969251-fbb7ae0a-56d0-11e8-9155-f1fff843d34b.png)

![image](https://user-images.githubusercontent.com/15992710/39969266-282d3810-56d1-11e8-96e3-dc42cb14c50f.png)

### Entity Relationship Diagrams  
![image](https://user-images.githubusercontent.com/15992710/39969287-73f45cce-56d1-11e8-9637-42aeeca07afe.png)

# Testing
There was an actual testing strategy carried out for the system, where all the testing’s that were carried out managed to pass successfully, there were 285 tests carried out as shown on figure 46. 
    
    
   ![image](https://user-images.githubusercontent.com/15992710/39969415-2414757a-56d3-11e8-8c88-9aba64dcee57.png)
    
(Figure 46)

I first started off creating a test framework class where I was able to add five different test classes as shown on figure 47. Furthermore, I also created a class library as shown on figure 48.  
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969433-7cda8082-56d3-11e8-9ff2-c83a5ad34d1b.png)
 
(Figure 47)
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969443-a04803fa-56d3-11e8-9e5a-f682deb67ad7.png)

 
(Figure 48)

For each test class I would have different test methods inside them. I first started off with testing the job table. For each field property in the job table I created an instance as shown on figure 49. 

 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969446-a901ea42-56d3-11e8-85b5-3a0929ec7776.png)
 
(Figure 49)

Furthermore, testing was carried out for the validation methods for the job class. At this stage I was able to use my test plan to carry out the rest of the testing’s as shown on figure 50 and 51. 
   
   
   ![image](https://user-images.githubusercontent.com/15992710/39969449-b6f311b2-56d3-11e8-9a54-e12f3ac8e412.png)

   
(Figure 50)
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969459-c3dd84d4-56d3-11e8-8f46-e8f9d44cf1d0.png)
 
(Figure 51)

Moreover, I also had to work on the class library where I had to write the validation range for each job field as shown on figure 52. 
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969463-d0b9e530-56d3-11e8-8817-8792b658c3c1.png)
 
(Figure 52)

I also was able to complete the testing for find method as shown on figure 53. 
  
  
  ![image](https://user-images.githubusercontent.com/15992710/39969467-d9f4dbaa-56d3-11e8-924f-8adbf6673499.png)
  
(Figure 53)

I also had to work on the class library for the job class so that the data could be found from the database as shown on figure 54. 
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969470-e4a89e38-56d3-11e8-8711-d69ba17ef3a8.png)

 
(Figure 54)

I managed to follow this strategy and structure to create the rest of the testing’s.  

### Validations (Applicant)

Whenever the applicant is registering, the system requires the applicant to put in characters that are either below 22 characters. For the address, age and password field they are required to put in below 40 characters, otherwise the system will prompt an error message saying a maximum of 22 or 40 characters allowed as shown on figure 55. 
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969480-0fcd4bb8-56d4-11e8-9eb9-4b0d7cbc8e55.png)
 
(Figure 55)

Furthermore, whenever the applicant leaves any fields blank, the system would require the applicant to put in a minimum of one character, otherwise the system would prompt an error message of a star sign indicating this field must be filled as shown on figure 56. 
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969483-1a18a16c-56d4-11e8-867f-006fbf785159.png)

 
(Figure 56)

Furthermore, whenever the applicant inputs in an incorrect email address, the system will prompt an error message saying incorrect email as shown on figure 57. 
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969493-37a3b974-56d4-11e8-9f2e-13474ec4c52a.png)
 
(Figure 57)

### Validations (Admin)

Similarly, whenever the admin wants to add a job to the system, the system would require the admin to input into the fields characters that are below 22 for the job name, job type, and job postcode. The system also requires characters that are below 100 for job description field, and characters below 40 is required for the job address field as shown on figure 58. 
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969495-4293f51a-56d4-11e8-9899-62f84281a262.png)
 
(Figure 58)

Moreover, the system also requires the admin to input into the fields minimum of one character, otherwise the system will prompt and error message of a star sign indicating that the field must be filled in as shown on figure 59. 
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969496-4b15ae18-56d4-11e8-92f6-3c788ddc2ddb.png)
 
(Figure 59)
The same validation is added to the job category name, where the system requires the admin to input into the field a character that is below 22 characters and also to at least have a one character as a minimum as shown on figure 60 and 61. 
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969502-554b316e-56d4-11e8-96e0-9ca2abc8e8f1.png)
 
(Figure 60)
 
 
 ![image](https://user-images.githubusercontent.com/15992710/39969510-675b648c-56d4-11e8-900c-3bbf54a27c09.png)
 
(Figure 61)



