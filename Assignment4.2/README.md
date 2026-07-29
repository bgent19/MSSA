# Outline

# Psuedocode Implementation
 - This is a barebones LMS specifically for teacher users to track students.  They can add or remove studetnes from a list. Teacher should be first authenticated
 - C# WinForms Appliciation
 - Teacher class and separate student class (scope does not require a parent class for user types)
- Teacher is authenticated on initial screen. Then a list with add and remove buttons is the landing page. This allows viewinig and all required actions.
- Data will be stored locally.
- Time to complete: 1 hour

# Mock Datasources
- Stage 1: procedurally generate a list of students to test operations
- Stage 2: store and load from local JSON file.
- Stage 3: Connect to SQL db

# Workflow
- Users are given login Form to start
- User enters user Id and Password
- If auth is goodL: hide loginForm, build mainForm, attach close of login to close of main. Show Main Form and set focus
- Mainpage shows current students, options to add and delete students. (Both will update the current list)
- Mainpage has button to get Top Student. It should select the student in the list and save it to a file called TopStudent.txt

# Other requirements
- Event driven system based on login page and action buttons on the landing page.