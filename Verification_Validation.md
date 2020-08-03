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

### Script

### Results

### Reflections
