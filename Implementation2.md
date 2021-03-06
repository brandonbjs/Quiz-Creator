# Implementation 2

## 1. Introduction
	Quiz Creator is a desktop application that allows students and educators to effortlessly create,
	edit, sort, and administer quizzes while emphasizing privacy and security so that educators feel comfortable
	distributing their material amongst their students, without fear of acadmic dishonesty. In this first implementation
	of our program, users can create a quiz and save it on their local machine. Users can also take quizzes they have
	created, and recieve a score immediately upon submission.
	Trello: https://trello.com/b/63mdFtER/task-board
	GitHub: https://github.com/brandonbjs/Quiz-Creator

## 2. Implemented requirements
### Course Selection / Course List
(Steven, Tyler..work was done together on one computer)  
[Trello Link](https://trello.com/c/L6LNzhlp/43-d6-requirement-course-selection) / [Screenshot](https://github.com/brandonbjs/Quiz-Creator/blob/master/CourseSelect.PNG).  
Steven approved the [pull request](https://github.com/brandonbjs/Quiz-Creator/pull/22).

### Get immediate results.
Bryan implemented the ability to get immediate results from taking a quiz.  
[Trello Link](https://trello.com/c/FASJ0gYe/41-d6-requirement-get-results) / 
[screenshot](https://trello-attachments.s3.amazonaws.com/5f20c3de6fda1481479ad6e8/841x778/ee99230c96d54ed9128f244ad5c8b1e7/Screenshot_of_requirement.png).  
Brandon reviewed and approved the [pull request](https://github.com/brandonbjs/Quiz-Creator/pull/11/files).
	
### Creating multiple choice questions & multiple question types on the Maker Screen
Implemented by Jacob.  
[Trello link](https://trello.com/c/IdcjooVt/54-baileys-story-1-create-quizzes-to-test-my-knowledge) / 
[Screenshot](https://github.com/brandonbjs/Quiz-Creator/blob/master/MCQuestionPic.PNG).  
Brandon reviewed and approved [pull request](https://github.com/brandonbjs/Quiz-Creator/pull/16)

### Question Selection Drop Down Box.
Implemented by Brandon.  
[Trello link](https://trello.com/c/8pkcT76S/56-d6-dropdown-question-fix) / 
[Screenshot](https://github.com/brandonbjs/Quiz-Creator/blob/master/QuestionSelection.PNG).  
Brandon reviewed and approved [pull request](https://github.com/brandonbjs/Quiz-Creator/pull/16)

## 3. Demo
[Demo Video](https://github.com/brandonbjs/Quiz-Creator/blob/master/DemoVid2.mp4)
## 4. Code Quality
	Coders have been adopting the use of regions for housing related code within classes. Coders have practiced adequate 
	naming conventions when writing methods and classes, as well as commenting more difficult lines of code for 
	readability and maintainability. Followed DRY principle, with minimal duplications implemented where possible. 
	Functions and classes are small and focus on one task. Coders refactored constantly, with pull requests being requested 
	after every stage. Coding conventions have been uniform; brackets are not on the same line as code and have no spaces 
	before them (i.e. same character as the method/class line above). Vertical allignment of nesting code is three spaces 
	from bracket character number.  Code folding is used in some of the longer classes, like MakerScreen, for organization.

## 5. Lessons Learned
	In retrospective, we would have liked to practice pair programming in the future as we have a lot to learn from 
	each other and can possibly surpass barriers if pair programming was performed. Some changes we would make in the future 
	is refactoring the code for saving a quiz to a local machine and saving a course quiz to our database. As it stands, 
	we are saving local quizzes as XML on our local machine while course quizzes created by instructors are intended to be 
	saved to a database by a means other than XML which will lead to significantly more code writing. We encountered some 
	difficulties with git, and learned that in the future, we can use the .gitignore file to prevent certain conflicts.
