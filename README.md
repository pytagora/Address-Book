# Address book
*Address book* is a WPF application developed in VS2017 for every PC user. It present a Desktop App for storing contacts. This App is my introduction to programming WPF applications. Additionally, it is my first experience of developing projects using modern and sophisticated methods and techniques.
 

[![AppVeyor](https://img.shields.io/appveyor/ci/gruntjs/grunt.svg)](![AppVeyor](https://img.shields.io/appveyor/ci/pytagora/Address-book.svg))
[![GitHub license](https://img.shields.io/github/license/pytagora/Address-book.svg)](https://github.com/pytagora/Address-book/blob/master/LICENSE.md)

## About
The idea is to learn and get necessary programming experience through developing, building and deploying the stable release of the software. Software has two windows. The main window contains all the necessary data in the shape of a table. An additional window is opened by clicking the button **Add Contact** which purpose is to add new contact to the table.

### In progress
- Comment section has its limitations. Should make flexible size for input.
- Adding new contact is not possible at all. Database solution will be build in the following week.
- Table is currently not able to display big number of data/rows what is wished for in every modern app.
- Search and Filter query.
- In the MainWindow there is the default photo, but the user himself should be able to put his own.
- There still isn't made a decision which data is mandatory and which is elective.

### Future ideas
- Hyperlink *Email* and *Social Account*.
- *User* Information form.
- Connect *Address* to Google Maps.

### Additional feature
- *Load photo* for new contact in the AddNewContact window.
- *Play audio* in the top left corner of MainWindow.

Below you can see the current state of the software. Two contacts which data you can see are loaded manually to temporary solution.
![Current look of the application](https://raw.githubusercontent.com/pytagora/Address-Book/master/projects/view/images/demo.jpg)

## Development
Idea is to develop an application using an approach of a professional developer and get valuable experience. Modern application need to have architectural pattern so to follow that example *Address book* has **MVVM** (Model-view-viewmodel) software architectural pattern. **MVVM** gives us opportunity to separate development of GUI (Graphical User Interface), business logic and back-end logic (the data model). Additionally, it is very useful if you are planning to unit test your application. Repository cointains three main projects: View, Model and ViewModel which cointains associated files according to MVVM rules. Purpose of the fourth project SampleConsoleApplication is to test is Model project fully developed and does the back-end solution works according to plan.

## Conventions
This application is developed under the following standards:
- [C# coding standards and naming conventions](https://www.dofactory.com/reference/csharp-coding-standards).
- [Udacity Git commit message style guide](http://udacity.github.io/git-styleguide/).

## Release Notes
Below is a summary of major changes.

### 1.0.2
- License file and settings for GitHub page of the project.

### 1.0.1
- Initial build of the application.
- MainWindow and AddNewContact included.
- Code behind buttons done only partially.
- Background photo as template for both windows.
- Multiple data type input possible.
- Load photo for new contact.
- Fix size for both windows.
- Style for buttons, table and etc. (In progress...)

# License
*Address-Book* is licensed under the [GNU GPLv3.0 license](https://github.com/pytagora/Address-book/blob/master/LICENSE.md).
