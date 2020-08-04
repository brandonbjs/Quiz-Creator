# Verification & Validation

## 1. Description
  Quiz Creator is a desktop application that allows students and educators to effortlessly create,
	edit, sort, and administer quizzes while emphasizing privacy and security so that educators feel comfortable
	distributing their material amongst their students, without fear of acadmic dishonesty. Users are able to create their 
  quiz and save it locally on their machine, or they can pull premade quiz specific to a course they are enrolled in
  from a database. When users submit a quiz, it immediately returns their grade to them. The application is designed to 
  used effortlessly without much of a learning curve.

## 2. Verification (Tests) 

## 2.1 Unit Test

## 2.2 Integration Test

#### 2.2.1 
For our integration tests we used the Nunit test framework in visual studio.

#### 2.2.2
[link to location of tests](https://github.com/brandonbjs/Quiz-Creator/blob/master/Quiz-Creator/IntegrationTest.cs)

#### 2.2.3
Our first test verifies our Database class's ability to load the information of a given course and store that 
information into a course object. The success of this test means Database.cs and Course.cs are successfully integrated.
[link to test location](https://github.com/brandonbjs/Quiz-Creator/blob/master/Quiz-Creator/IntegrationTest.cs)

#### 2.2.4
[link to test execution](https://github.com/brandonbjs/Quiz-Creator/blob/master/IntegrationTestsResults.png)

### 2.3 Acceptance

### 2.3.1 The test framework used was Coded UI Tests for Visual Studio

### 2.3.2 https://github.com/brandonbjs/Quiz-Creator/tree/master/Acceptance%20Tests/AcceptanceTests

### 2.3.3   Mouse.Click(uISignUpWindow, new Point(225, 141));
            uITextboxEmailEdit.Text = this.StudentTestParams.UITextboxEmailEditText;
            Keyboard.SendKeys(uITextboxEmailEdit, this.StudentTestParams.UITextboxEmailEditSendKeys, ModifierKeys.None);
            Keyboard.SendKeys(uITextboxPasswordEdit, this.StudentTestParams.UITextboxPasswordEditSendKeys, true);
            Keyboard.SendKeys(uITextboxConfirmEdit, this.StudentTestParams.UITextboxConfirmEditSendKeys, true);
            Mouse.Click(uIComboBoxTypeWindow, new Point(305, 125));
            uIComboBoxTypeComboBox.SelectedItem = this.StudentTestParams.UIComboBoxTypeComboBoxSelectedItem;
            Mouse.Click(uISignUpWindow1, new Point(193, 146));
            Mouse.Click(uIOKButton, new Point(22, 19));	

https://github.com/brandonbjs/Quiz-Creator/blob/master/Acceptance%20Tests/AcceptanceTests/AcceptanceTests/UIMap.Designer.cs
(lines 73 - 101)
this tests if a student is able to create an account to use with the application

### 2.3.4 https://github.com/brandonbjs/Quiz-Creator/blob/master/Acceptance%20Tests/AcceptanceTests%20ScreenShots.pdf


## 3. Validation (User Evaluation)

# User Validation 1:

Question: What are your initial impressions of the application?

Answer: It looks like an old computer program but easy to understand.

Question: Do you find the application easy to navigate?

Answer: The application is pretty self explanatory, buttons do what they are supposed to, and are labeled accordingly. I thought 
that the opening of multiple windows would be confusing, but it actually aids in knowing where you are in the application and what 
screen does what.  

Question: Would you use this application over something like a quizlet?

Answer: If both Quizlet and this application are available I would have to choose Quizlet. However I think there is room for both in 
a students work place. Their ability to create and save local quizzes to your computer could be a great study tool for those without 
or limited internet access.

Question: If we could make one improvement to our application, what would you like to see? 

Answer: Visually the application just isn't appealing, at least not to me. It works fine and does its job, but in the current state 
of technology where we have thousands of applications on our phones with flashy and cute animations, it just feels a little outdated. 

Reflection: 
Our system is rather easy to adapt to and understand. Without any interaction or instruction my user was able to fully navigate making, 
saving, and taking a quiz. She did not realize there was an online capability through the database. It only took a small bit of instruction 
and demonstration before she understood the difference between local and non local quizzes and why she needed to make an account. I think 
we have officially accomplished our value proposition and provided a study tool for students to use to help better their learning. The user 
loved the simplicity of the application and even brought up a great point that I didn't think of before. This point being that we can work 
alongside our competitors. Rather than try to replace them we can act as an offline alternative for users internet access.      

# User Validation 2:

Question: What are your initial impressions of the application?

Answer: I think the market is already oversaturated with applications that try to emulate what Quizlet is doing, and this is a very simplified 
version of these applications. This is a 'dumbed' down version of Quizlet that needs a lot more work to become something that would compete, or 
be as useful as Quizlet. However, for the purpose of the application it operates as it should. I was successfully able to make, take, and grade 
a quiz effectively. 


Question: Do you find the application easy to navigate?

Answer: Yes. I find this application easy to navigate. Perhaps, it is a little too simple to navigate because not all the features have been 
implemented yet. It feels as though it is missing quite a bit.


Question: Would you use this application over something like quizlet?

Answer: No. This application doesn't have a lot of the features, or support options like Quizlet has. Obviously it is still in its early stages 
but Quizlet already 'has the market'. I think this application would need a lot more work to begin to compete with Quizlet, and a lot of that would 
involve mirroring features that Quizlet already has. 


Question: If we could make one improvement to our application, what would you like to see?

Answer: View course button doesn't work. I also think the GUI needs to be 'prettified'. Doing this same type of thing on a 
web application would be highly more effective than downloading something locally - that's just the way the world is going. Schools utilize 
chromebooks that rely on things like the cloud, or virtual sites like Quizlet and that's just the way things are going. 

Reflection: 
Overall, our application is simple to use and navigate for users, if overly simplistic. Our application could be a lot more fleshed out, with added 
functionality and a web application to increase usability and flexibility. It functions as intended for the already implemented features, which is 
good. I think we are on the way to fully delivering on our value proposition, and future implementations would ensure that. 

