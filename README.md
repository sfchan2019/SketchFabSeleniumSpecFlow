# SketchFabSeleniumSpecFlow
Automation web testing on Sketch Fab using Selenium and SpecFlow

## Table of Contents
* [Introduction](#introduction)
* [Implementation](#implementation)
* [Testing](#testing)
* [NuGet Packages](#nuget-packages)
* [Running the Test](#running-the-test)

 ## Introduction
This project was created to test the Sketch Fab website using Selenium SpecFlow for automation testing.
The aim is to test the response from website for error handling when user has input some invalid data during registration.

## Implementation


## Testing
### Test for Sign Up
- Start up Google Chrome
- Go to the home page of Sketch Fab

## NuGet Packages
 - [SpecFlow](https://specflow.org/) - SpecFlow is a framework that bring C#, Gherkin together for User Acceptence Testing.
 - [SpecFlow.Tools.MsBuild.Generation](https://specflow.org/) - This tools is used to generate Ms Build so that tests can be seen by visual studio.
 - [SpecRun.Runner](https://specflow.org/plus/runner/) - This tool is used to run SpecFlow.
 - [Selenium.WebDriver](https://www.seleniumhq.org/) - Selenium WebDriver is a Web automation framework.
 - [Selenium.Support](https://www.seleniumhq.org/) - Provide ultilits of Selenium such as Drag and Drop action or Page Object.
 - [Selenium.WebDriver.ChromeDriver](https://github.com/jsakamoto/nupkg-selenium-webdriver-chromedriver/)
 - [NUnit](https://www.nuget.org/packages/NUnit/) - NUnit is a unit-testing framework for all .Net languages.
 - [NUnit3TestAdapter](https://www.nuget.org/packages/NUnit3TestAdapter/) - NUnit 3 adapter for running tests in Visual Studio.

## Running the Test
1. Clone this project ```https://github.com/sfchan2019/SketchFabSeleniumSpecFlow.git```
2. Open **SketchFabSeleniumSpecFlow.sln** 
3. Right click on the **'SketchFabSeleniumSpecFlow'** Project file in the Solution Explorer and click **'Manage NuGet Packages..."**
4. Install all the NuGet packages mentioned in the earlier section
5. Click on **Test -> Windows -> Test Explorer** to open the test menu
6. Click on the Run All buttons in the Test Explorer  or Ctrl R, A to run all tests
