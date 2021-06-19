1. File Menu on Top in Visual Studio>Extensions>Manage Extensions>Type in SpecFlow>Download SpecFlow for Visual Studio 2019>Close Visual Studio then download will start>

2. Install SpecFlow and SpecFlow.NUnit or SpecFlow.Tools.MsBuild.Generation nuget packages

3. Create folders
	1.Features,
	2.PageObject
	3.StepDefinition,
	4.Utilities

4. Right mouse click on Features folder>Add>New item>SignUp.feature

5. Right mouse click Generate Step Definitions>Click Generate Button>Select Folder C:\CSharpSpecFlow\CSharpSpecFlow\StepDefinition

6. In SignUpSteps.cs enter a line in and save and then resave SignUp.feature to bind the step definitions

7. Right click on line in SignUp.feature and select go to step definition goes to SignUpSteps.cs

8. Right click on Utilities folder>Add new item>SpecFlow Hooks

9. Create SignUpPage.cs under PageObject folder

This is a simple project to test a signup page to learn BDD behavior driven development for .NET.
It captures requirements in your test code.