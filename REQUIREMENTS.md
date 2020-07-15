# Requirements

## 1. Positioning

### 1.1 Problem Statement

	- The problem of uneffective and inefficient studying methods affects
	college students; the impact of which is performing poorly on exams
	and receiving a low grade and lowering their overall GPA.

### 1.2 Product Position Statement

	- For college students who have a difficult time developing successful
	studying methods, Quiz Creator is a studying app that allows students
	to create their own tests for the purpose of quizzing their own knowledge
	and for professors to create quizzes to privately distribute amongst their
	students providing what could be used as a study guide; unlike Quizlet,
	our product does not allow test questions and their answers to be distributed
	publicly.

### 1.3 Value proposition

## 2. Stakeholders

## 3. Function requirements (features)

## 4. Non-functional requirements

## 5. MVP

For developing the minimum viable product for this application, our strategy is to first develop a simple, barebones program and add features one at a time. We will first implement our functional requirements stated above. By implementing only the functional requirements in our MVP, we can gather early feedback from users about our application without wasting any time on less important features. We will use this early feedback to decide which features we should validate and which we should change.

## 6. Use cases

### 6.1 Use case diagram
	![Use case diagram](https://github.com/bkm98/Quiz-Creator/blob/master/usecasediagram.png)
### 6.2 Use case descriptions
	Use-case: Create Practice Quiz
	1 Brief Description
		This use case describes how a student can create a practice quiz.
	2 Actors
		2.1 Student
	3 Preconditions
		The student is logged into the system
	4 Basic Flow of Events
		1. The student selects 'Create a Quiz'
		2. The system returns a template for quiz creation
		3. The student adds a question
		4. The student selects question type
		5. The system returns a template for the selected question type
		6. The student enters question text and possible answers
		7. The student indicates quiz is complete
		8. The system saves the quiz data
		9. Use case ends successfully
	5 Alternative Flows
		5.1 The student quits before step 8
			1. The system closes the quiz creation template
			2. Quiz data is deleted
			3. The use case ends
		5.2 The system does not respond
			1. The system will try to reconnect
			2. If reconnection cannot be established, the system will display the message "Connection Lost"
			3. Use case ends in failure condition
	6 Post-conditions
		7.1 Successful Completion
			A new quiz has been created and is accessible to the student
		7.2 Failure Condition
			The student is redirected to the home page
	7 Special Requirements
		-The student must have filled all required forms before quiz can be saved
	
	Use-case: Set Quiz Security
	1 Brief Description
		This use case describes how an instructor can choose who can view the quiz.
	2 Actors
		2.1 Instructor
	3 Preconditions
		The instructor is logged into the system
		The instructor has created a quiz
	4 Basic Flow of Events
		1. The instructor selects 'Quiz Privacy'
		2. The system returns the options for quiz privacy
		3. The instructor selects the desired privacy level
		4. The instructor saves the privacy level 
		5. The system saves the privacy level to the current quiz
	5 Alternative Flows
		5.1 
	6 Key Scenarios
	7 Post-conditions
	8 Special Requirements
	
	
	Use-case: Save Quizzes
	1 Brief Description
		This use case describes how a student can save a quiz for later reference.
	2 Actors
		2.1 Student
	3 Preconditions
		The student is logged into the system
		The student has access to the quiz
	4 Basic Flow of Events
		1. The student navigates to the quiz
		2. The student selects 'Save Quiz'
		3. 
	5 Alternative Flows
		5.1 
	6 Key Scenarios
	7 Post-conditions
	8 Special Requirements

## 7. User stories
	-As a student, I want to be able to categorize my quizzes so that I can easily 
	access each assessment when studying for different classes.
	Priority: Should
	Timeframe to implement: 3 days

	-As an educator, I want the implementation of a key-word based search bar so 
	that students can easily find my questions related to the topic they need 
	further emphasis on.
	Priority: Could
	Timeframe to implement: 1-2 days

	-As a student, I want to see questions I get wrong more often so I can study 
	more efficiently.
	Priority: Should
	Timeframe to implement: 5 days

	-As an educator, I want to monitor my students’ progress so I know what to 
	focus on in class.
	Priority: Could
	Timeframe to implement: 1.5 weeks

	-As a professor, I want some form of security, so that my test answers are 
	not distributed publicly.
	Priority: Must 
	Timeframe to implement: 3 days

	-As a student, I want to be able to save tests, so that I can track what I 
	have learned and what I have not.
	Priority: Must
	Timeframe to implement: 3 days

	-As a student, I want to be able to create practice quizzes so I can check my 
	knowledge before the exam.
	Priority: Must
	Timeframe to implement: 1.5 weeks

	-As a professor, I want to be able to create many different types of questions, 
	so I can check my students' understanding effectively.
	Priority: Should
	Timeframe to implement: 4 days

	-As an educator, I would like the grading process to be both automated and manual 
	to ease the correction of mistakes.
	Priority: Could
	Timeframe to implement: 1 week

	-As a educator, I would like to be able to control whether or not the students are 
	able to view answers of quiz's for integrity purposes, and to promote a higher level 
	of learning rather than memorizing.
	Priority: Could
	Timeframe to implement: 2 days

	-As an administrator, I want to be able to verify if a particular examinee has 
	taken the quiz.
	Priority: Could
	Timeframe to implement: 2 days

	-As a student, I want to be able to open quizzes that my friends make so I don't 
	have to do unnecessary work.
	Priority: Should
	Timeframe to implement: 3 days

## 8. Trello
	https://trello.com/b/GWmgwKc0/user-stories
	
	<img src="/trellouserstories.png" >
