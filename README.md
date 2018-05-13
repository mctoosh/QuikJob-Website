# QuikJob-Website
QuikJob is a job portal website where applicants are able to apply for a job

The system that is created is a job portal website called QuickJob Ltd. The core functionality of the system is to allow the applicant to apply for different types of jobs. Before the applicant can apply for any jobs they would need to be a member of the website. Here they have the option of registering to the system. Once registered they can search for more jobs and save these jobs to their account. They then can apply for the saved jobs where the system would then redirect the applicants to a page where they can update their personal details. Once they complete updating their details they would successfully have applied for the job. 
The details would then be passed on to the admin side where they can view all the details of the applicant including their personal details and also the jobs that they have applied for. They can also download any CV that the applicant has. Furthermore, the admin would also be able to add jobs and job categories onto the system. However, before the admin can complete any of these actions, he would need to be a member of an admin that possess login details so that he could enter the admin page. 
Below will show step by step how the core functional job portal website works.    
View Applicant Details (Admin)

 ![image](https://user-images.githubusercontent.com/15992710/39968705-4a794538-56c9-11e8-95a1-c52b99486ee3.png)
 
(Figure 1)

Before the admin enters the admin page, they must put in the correct username and password. If they put in the wrong details the system prompts an error message
 
(Figure 2)

The code that I used to prompt the error is 
 
(Figure 3)

Once the admin enters the correct login details, they will be redirected to the admin home page where they are able to view all the applicants that have applied for a job. 
 
(Figure 4)

On this page the admin will be able to view the details of the applicant such as their first and last name. furthermore, with this page they are able to contact the applicants by either using their email address or their phone number. Moreover, the admin has the option to download the user’s CV or to view the applicant’s full details. Moreover, by using the left side if the page, the admin can get to different pages. 
 
(Figure 5)

Once the admin selects view full details for a specific applicant, the system will display the full details of the applicant. On this page the admin will be able to view the applicant details and also the jobs they have applied for, such as figure 5 shows that the applicant has applied for the job Google as an administrator. 
 
(Figure 6)

The admin then has the option to download the applicant’s CV, so that they can view further details of the applicant such as work experiences and educations. Once the admin clicks on download CV, the system will prompt a save as window where the admin can save the CV on to his system. The admin is then able to view the CV as shown on figure 7. 
 
(Figure 7)

Add Jobs (Admin)
 
(Figure 8)

On this page the admin will be able to add new jobs so that the applicants can apply for them. Once the admin has filled in the details he has the option to add a company or job image as shown on figure 9.  
 
(Figure 9)

Furthermore, the admin would need to add the job on to a category where he would select it from the dropdown list of categories as shown on figure 10. 
 
(Figure 10)

Once the admin fills in all the details for the job, the web page will then display a message telling them they have successfully uploaded the job onto the user home page, where they are able to apply for this job, as shown as figure 11.  


 
(Figure 11)

Furthermore, all the characters are also removed from the textboxes as soon as the job is uploaded successfully as shown on figure 11. The code that I used to perform this action is shown on figure 12. 
 
(Figure 12)

Add Job Category (Admin)
 
(Figure 13)

On this page the admin is able to add Job categories on to the user home page. With these categories, it helps the applicants to filter the job roles to jobs that they are looking for such as, admin or It Technician. Once the admin adds a job category, the system will prompt a message saying that the job category was added successfully, as shown on figure 14 
 
(Figure 14)
 
(Figure 15)

The job category is then successfully displayed on to the page, as shown on figure 15. Furthermore, the admin has the option to delete the job category, where this would also delete all the jobs that are in that category, the admin would need to select the delete button displayed next to the job category name, where in return it will remove the job category as shown on figure 16. 
  
(Figure 16)

Once the admin has completed his work, he would need to logout from the admin web page by using the logout button as shown on figure 17 and 18. 
 
(Figure 17)

 
(Figure 18)

Once the admin selects the logout button the system will redirect the admin to the admin login page as shown on figure 19. 
 
(Figure 19)

Furthermore, the admin has the option to visit the User home page by clicking on the button user home page as shown on figure 20. 
 
(Figure 20)

Display Jobs (Applicant)
 
(Figure 21)

Once the applicant enters the website they will be displayed with this homepage as shown on figure 21. Whenever the admin adds a new job, it will be displayed on to this page where the applicants can then apply for those jobs.   
The applicants have the option to use the search text box to filter out the job that they are looking for as shown on figure 22 and 23. 
 
(Figure 22)
 
(Figure 23)

Furthermore, as you can see the search box on figure 23, I have used the SQL like operator, where it finds any value that has face on the web page. The code that I used for this to work is shown on figure 24. 
 
(Figure 24)

Furthermore, the applicant can also use the job categories that is displayed on the left of the home page as shown on figure 25. 
  
(Figure 25)

Once the applicant selects a category, the homepage will display all the related job roles to the applicant as shown on figure 26, only the software developer job roles are displayed. 
 
(Figure 26)

Once the applicant selects a job from the homepage, they will be redirected to the jobs description web page, where the applicant can find out further details of the job as shown on figure 27. 
   
(Figure 27)

Furthermore, the applicant has the choice to print out the description of the job by pressing the print button displayed on the bottom left corner of the home page as shown on figure 28. 
  
(Figure 28)

If the applicant feels like this is the right job for him he has the option of saving the job by selecting the save job button as shown on figure 27. Once the applicant clicks the save job button, the job is then added to the saved jobs of the applicant as shown on figure 29. 

 
(Figure 29)

The applicant then has the option to either apply for the saved job or to look for other jobs to apply for as well. As soon as the applicant is satisfied with the jobs he saved, he then would need to apply for the jobs by clicking on the button apply for jobs as shown on figure 30. 

 
(Figure 30)

Moreover, if the applicant changes his mind about a job that he doesn’t feel comfortable with, he has the option of deleting that job from his saved list by clicking on the button delete. The job would then be deleted as shown on figure 31. 
   
(Figure 31)

Once the applicant is completely happy with the jobs, he then can press the apply for jobs button. As soon as the applicant selects the apply for jobs button, the systems would require the applicant login to the website, this is because the user would need to be registered to the system before applying for any jobs, as shown on figure 32.
Applicant Authentication (Applicant)
  
(Figure 32)

If the applicant is not a member on the system he would then need to click on the Register here button, so that he can apply for jobs. Once the applicant selects the register here button, the system will redirect the applicant to the register page as shown on figure 33. 

 
(Figure 33)

On this page the applicant can register by putting in his details, he also has to put in his personal CV as shown on figure 34. 
 
(Figure 34)

Once the applicant registers, he would get a message that says the applicant has registered successfully and all the text boxes would be cleared as shown on figure 35.
 
(Figure 35)

The applicant can now login using the details he registered with. As soon as the applicant logs in to the system, the system would prompt a welcome message using the applicants first and last name as shown on figure 36. 
 
(Figure 36)
However, if the applicant saves a job and he is already a member and is able to sign in, the system would redirect the applicant straight to the update user details page, where the applicant can update any incorrect or outdated details of the applicant as shown on figure 39. 
Once the applicant signs in to the system he would need to select saved jobs, so that he can apply for the job he saved before registering as shown on figure 37 and 38, furthermore, as shown on figure 37, once the applicant is logged in to the system, the navigation bar would show logout instead of login and also the applicant will get the option to view the jobs he applied for by selecting my jobs link. 
 
(Figure 37)
 
(Figure 38)

View Applicant Details (Applicant)
Once the applicant selects apply for jobs, the system would this type redirect him to the update user details page, where the applicant gets the option of updating any incorrect or outdated information about them self’s as shown on figure 39. 
 
(Figure 39)

Once the applicant is satisfied with his details he would select update and continue, where these details would then be passed to the admin page. The admin would then be able to view the users details and his CV after this stage as shown on figure 4 and figure 5. 
Furthermore, the applicant also has the option to view his details by selecting My jobs from the navigation bar as shown on figure 40 and 41. 
 
(Figure 40)
 
(Figure 41)

Furthermore, the applicant can also view the full details by selecting the link view full details where the page would then be redirected to the full details of the applicant as shown on figure 42. Furthermore, the applicant can also download a copy of his own CV by clicking on the link download CV here. 
 
(Figure 42)

Once the applicant has finished searching and applying for jobs, he then has to logout from his account by selecting the logout link on the navigation bar as shown on figure 43. 
 
(Figure 43)

Once the applicant logs out from his account the system will redirect the applicant to the log in page as shown on figure 32. 
Furthermore, the link logout would be changed to login on the navigation bar as shown on figure 44. 

 
(Figure 44)

Furthermore, if the applicant puts in the wrong login details, the system would prompt an error message as shown on figure 45. 
 
(Figure 45)
