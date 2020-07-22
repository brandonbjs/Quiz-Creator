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
	-Initial design features(Brandon, Jacob, Bryan, Steve)
	-Take local quizes(Bryan)
	-Save local quizes(Jacob)
	-Create local quizes(Steve)
		a. Title Quizes
		b. Create questions with answers
		c. Add/remove questions
	-Edit preexisting quizes(Jacob)

## 3. Adopted technologies
	C#: C# is a popular programming language and is the basis of the .NET Framework.
	.Net Framework: This is a popular and powerful software development framework
			for building and running applications on Windows. We chose it because
			it offers quick deployment of applications and provides more scalability 
			than others like it.
	Windows Forms: Windows Forms is a free graphical class library included in
			.NET framework. We are using it because it allows to easily 
			create an easy to manage UI for our application.
	Visual Studio: Visual Studio is an integrated development environment for use on Windows.
			We chose it because it facilitated the use of the previous technologies listed
			and allows us to work on the application together through the use of the live share
			feature.
	mySQL: mySQL is an open source database management system. We chose it because it is free to use
		and it allows us to store quiz files for our application in a place other than the local machine.

## 4. Learning/training
	To learn these technologies and the programming language that much of the group
	was unfamiliar with we used resources on the internet, and Jacob gave us multiple tutorials / demos
	of windows forms in BBlearn collaborate.

## 5. Deployment
	The current state of our MVP does not require the implmentation of a docker. We are considering the
	use of a docker in the future if databases are intigrated. As of now all files are handled locally and 
	the application is able to be run on any modern widows machine without reliance on external dependencies. 
	
## 6. Licensing
	The licensing we are going to use for this application is the Apache License
	2.0. We chose to adopt this license because The theoretical goal of the application
	would be to market this app to educational institutions for commercial use.
	This license makes the most sense because it allows the application to be distributed
	and used privately as well. This license is also generally used for smaller software packages
	rather than large systems.

## 7. Readme File
	code of conduct: https://github.com/brandonbjs/Quiz-Creator/blob/master/CODE_OF_CONDUCT.md
	readme: https://github.com/brandonbjs/Quiz-Creator/blob/master/README.md
	license:https://github.com/brandonbjs/Quiz-Creator/blob/master/LICENSE.md
	contributing: https://github.com/brandonbjs/Quiz-Creator/blob/master/CONTRIBUTING.md

[link to README file](https://github.com/brandonbjs/Quiz-Creator/blob/master/README.md)
[link to CONTRIBUTING file](https://github.com/brandonbjs/Quiz-Creator/blob/master/CONTRIBUTING.md)
[link to LICENSE file](https://github.com/brandonbjs/Quiz-Creator/blob/master/LICENSE.md)
[link to CODE_OF_CONDUCT file](https://github.com/brandonbjs/Quiz-Creator/blob/master/CODE_OF_CONDUCT.md)

## 8. Look and Feel
	To avoid confusion of new users and further the ease of use we constructed a straight foward applicaiton
	that will take little to no time to adapt to. All areas requiring user input include instructions of the 
	action that we wish the user to prefrom. 
	
	Clicking buttons such as "Make New Local Quiz" will bring up a new window that will allow users to do just that. 
	
	The application is free of gimics or flashy designs to prevent users from getting lost in the quiz making/taking 
	process.

	Additionally all windows are properly titled so that users will have no trouble navigating the applications multiple 
	windows. 

	Start Sreen UI Screenshot: https://github.com/brandonbjs/Quiz-Creator/blob/master/StartScreen.PNG
	Maker Screen UI Screenshot: https://github.com/brandonbjs/Quiz-Creator/blob/master/MakerScreen.PNG
	Taker Screen UI Screenshot: https://github.com/brandonbjs/Quiz-Creator/blob/master/TakerScreen.PNG
	
	
## 9. Lessons learned
	-Move away from saving by text files and towards a database. 
	-Search for quizes by quiz names rather than text files. 
	-How to properly manage a group activity using git hub and other collaboration tools
	-Proper communication on both pushing and pullng as to not overwrite each other projects. 
	-Have assignement done before last meeting. 
	-Plan to use more pull requests for future implementations
	
## 10. Demo
	
