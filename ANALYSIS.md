# Analysis

## 1. System Description

## 2. Model

## 3. Class Responsibilities

1.	**User**
	* User class specifies the user's name and the list of courses related to said user. Their email will establish a link to their respective institution, 
	which is also specified as a field for further search options. Each user has access to their created quizzes, can add created quizzes and can use the SearchMyQuizzes() method
	to find related quizzes based on keywords.

1.	**Student**
	* Student is a subclass of user that allows for the assessment and submition of quizzes given to said student by instructors. 

1.	**Professor**
	* Professor is a subclass of user that establishes their respective title and allows the professor to grade/regrade any question according to their judgement
	using the GradeQuiz() method. 

1.	**Institution**
	* Institution class specifies the institution name and houses the list of courses with related quizzes within. This class has methods that involve searching, adding, changing, and 
	deleting courses to its respective instituion.

1.	**Course**
	* Course class specifies the list of quizzes created that relate to the course, as well as the instructor who created it. Instructors are able to see Students who have added said course
	to their list of courses during user creation. Users are able to search for quizzes related to the course while only instructors can add created quizzes to the course.

1. **Quiz**
	* Quiz class is responsible for creating, saving, opening, and taking quizzes. It houses a list of questions created, responses given, and specifies whether the quiz is protected or not. Any quiz 
	intended to be added to a course must be added by a professor and is password protected. Student created quizzes may not be added to courses and is only viewable by the student themself. Students and
	Instructors are able to select individual quizzes and search for questions within the quiz based on keyword. Once the quiz is sumbitted the user can view their responses and whether or not they got the
	answer correct; students may also view the responses at a later time for further study needs.

1. **Question**
   * Question class involves the creation of each individual quiz question. The creator will specify the prompt and the intended correct answer. In realtime, the student can always see/edit their response before moving
   on to the next question.

1. **MultipleChoiceQuestion**
   * The MultipleChoiceQuestion class has the responsilbity of creating multiple choice questions, and requires the specification of each response choice during creation. In realtime, the student can see the choice they've
   selected before moving on to the next question. This allows for more options when creating quiz questions.

1. **MatchingQuestion**
   * The MatchingQuestion class has the responsibility of creating matching questions, it will give the user another option when creating quiz questions.

1. **FillInTheBlankQuestion**
   * The FillInTheBlankQuestion class has the responsibility of creating fill in the blank questions, it will give the user yet another option when creating quiz questions. This question also allows for some judgements to be 
   made by professors when it comes to the grading process.

1. **Response**
   * Response class is a subclass of Question class and is responsible for comparing the user response to the 'correct' answer established in Question class. It will specify whether the user got the answer correct but is not 
   responsible for displaying those results back to the user.