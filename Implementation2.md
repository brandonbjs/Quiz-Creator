# Implementation 1

## 1. Introduction
	Quiz Creator is a desktop application that allows students and educators to effortlessly create,
	edit, sort, and administer quizzes while emphasizing privacy and security so that educators feel comfortable
	distributing their material amongst their students, without fear of acadmic dishonesty. In this first implementation
	of our program, users can create a quiz and save it on their local machine. Users can also take quizzes they have
	created, and recieve a score immediately upon submission.
	Trello: https://trello.com/b/63mdFtER/task-board
	GitHub: https://github.com/brandonbjs/Quiz-Creator

## 2. Implemented requirements
	-Course Selection / Course List (Steven, Tyler..work was done together on one computer)
	https://trello.com/c/L6LNzhlp/43-d6-requirement-course-selection
	Steven approved the pull request
	-Get immediate results: Bryan implemented the ability to get immediate results from taking a quiz. Brandon reviewed
	 and approved the pull request. [Pull Request](https://github.com/brandonbjs/Quiz-Creator/pull/11/files) 
	 [screenshot](https://trello-attachments.s3.amazonaws.com/5f20c3de6fda1481479ad6e8/841x778/ee99230c96d54ed9128f244ad5c8b1e7/Screenshot_of_requirement.png)
	

## 3. Demo

## 4. Code Quality
	Coders have been adopting the use of regions for housing related code within classes. Coders have practiced adequate 
	naming conventions when writing methods and classes, as well as commenting more difficult lines of code for 
	readability and maintainability. Followed DRY principle, with minimal duplications implemented where possible. 
	Functions and classes are small and focus on one task. Coders refactored constantly, with pull requests being requested 
	after every stage. Coding conventions have been uniform; brackets are not on the same line as code and have no spaces 
	before them (i.e. same character as the method/class line above). Vertical allignment of nesting code is three spaces 
	from bracket character number.

## 5. Lessons Learned
	In retrospective, we would have liked to practice pair programming in the future as we have a lot to learn from 
	each other and can possibly surpass barriers if pair programming was performed. Some changes we would make in the future 
	is refactoring the code for saving a quiz to a local machine and saving a course quiz to our database. As it stands, 
	we are saving local quizzes as XML on our local machine while course quizzes created by instructors are intended to be 
	saved to a database by a means other than XML which will lead to significantly more code writing. 