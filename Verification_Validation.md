# Verification & Validation

## 1. Description
  Quiz Creator is a desktop application that allows students and educators to effortlessly create,
	edit, sort, and administer quizzes while emphasizing privacy and security so that educators feel comfortable
	distributing their material amongst their students, without fear of acadmic dishonesty. Users are able to create their 
  quiz and save it locally on their machine, or they can pull premade quiz specific to a course they are enrolled in
  from a database. When users submit a quiz, it immediately returns their grade to them. The application is designed to 
  used effortlessly without much of a learning curve.

## 2. Verification (Tests) 

### 2.1 Unit Test

### 2.2 Integration Test

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

User Validation 1:

Question: What are your initial impressions of the application?

Answer: It looks like an old computer program but easy to understand.

Question: Do you find the application easy to navigate?

Answer: The application is pretty self explanatory, buttons do what they are supposed to, and are labeled accordingly. I thought that the opening of multiple windows would be confusing, but it actually aids in knowing where you are in the application and what screen does what.  

Would you use this application over something like a quizlet?

If both Quizlet and this application are available I would have to choose Quizlet. However I think there is room for both in a students work place. Their ability to create and save local quizzes to your computer could be a great study tool for those without or limited internet access.

If we could make one improvement to our application, what would you like to see? 

Visually the application just isn't appealing, at least not to me. It works fine and does its job, but in the current state of technology where we have thousands of applications on our phones with flashy and cute animations, it just feels a little outdated. 

Reflections: 

Our system is rather easy to adapt to and understand. Without any interaction or instruction my user was able to fully navigate making, saving, and taking a quiz. She did not realize there was an online capability through the database. It only took a small bit of instruction and demonstration before she understood the difference between local and non local quizzes and why she needed to make an account. I think we have officially accomplished our value proposition and provided a study tool for students to use to help better their learning. The user loved the simplicity of the application and even brought up a great point that I didn't think of before. This point being that we can work alongside our competitors. Rather than try to replace them we can act as an offline alternative for users internet access.      
