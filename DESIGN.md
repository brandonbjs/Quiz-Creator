# Design

## Description
Quiz Creator is a system that allows users (students and educators), to make, take, save and edit
quizzes for the purpose of studying and refining their knowledge. We intend for student made quizzes
to be created locally, for their own personal enrichment, while instructor made quizzes are saved on a database
and can be added to their respective course for students to view. The user interface is designed
in such a way that makes it simple to use, without losing any of its required functionality. 

## Architecture

## Class Diagram

## Sequence Diagram

	-User Case: Taking a local quiz
	Actor: User
	Description: The user can take a local quiz once it has been created
	Pre-Conditions: The user has already created a local quiz and saved it to their local drive
	Post-Conditions: The quiz has been taken and have fed back a grade
	Main Flow & Alternative Flows (shown with #.# format):
		1. User enters a Quiz Title into a search box
		2. System finds local quiz and displays the quiz taker screen
			2.1. System is unable to find a quiz with matching quiz title
			2.2. System informs the user that the quiz title entered does not exist and that the
				 quiz was not found.
			2.3. System prompts the user to try searching for another quiz title.
		3. User goes through quiz questions and answers accordingly.
		4. System receieves responses and saves them.
		5. User submits quiz once finished.
		6. System compares user responses to answers declared by quiz creator.
		7. System displays quiz results back to user.

## Design Patterns

![Figure 5.1](https://github.com/brandonbjs/Quiz-Creator/blob/master/Figure5.1.png)

Design Pattern 1: (Behavioral) Template Method - MatchingQuestion overrides the CorrectResponse() method in the Question class

![Figure 5.2](https://github.com/brandonbjs/Quiz-Creator/blob/master/DesignPattern5.2.PNG)

Design Pattern 2: (Behavioral) Iterator Pattern - SearchForRelatedQuestion() method iterates through the quiz class' available
list of questions and searches the question prompts to find the first question that contains the user entered keyword. If a related
question is found, it returns the question index, otherwise the method returns -1.
[Quiz Class Link](https://github.com/brandonbjs/Quiz-Creator/blob/master/Quiz-Creator/Quiz.cs)
 / [Question Class Link](https://github.com/brandonbjs/Quiz-Creator/blob/master/Quiz-Creator/Question.cs)



## Design Principles
	SOLID Principles
	-Single responsibility principle
		-**A class should only have 1 responsibility**.
		-Our question class has 1 job: to hold the prompt and response from the user. It is not responsible for grading 
		 or displaying the quiz.
	-Open/Closed principle
		-**Entities should be open for extension but closed for modification**.
		-Our quiz class's fields are all private and can only be accessed via the getter and setter methods. 
	-Liskov substitution principle
		-**Objects in a program should be able to be replaced with instances of their subtypes**.
		 without altering correctness of the program
		-We intend to implement this in our multiple types of questions: the subtypes of questions should function exactly
		 the same as the base question class within the quiz program. 
	-Interface segregation principle
		-**Many client-specific interfaces are better than one general-purpose interface**.
		-This principle should be focused on with student and professor account-specific interfaces: professor interface 
		 should have access to grading quizzes and adding content to a course; while student interface should view only 
		 their own grades and course content and see their own practice quizzes.
	-Dependency inversion principle
		-**Depend upon abstractions, not concretions**.
		-Quiz class plans to hold abstract question class, but due to the Liskov substitution principle, will be able to 
		 hold any question type. That way quiz does not depend on any specific type of question to be added.
