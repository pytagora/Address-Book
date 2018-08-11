# Address-book
*Address-Book* is a WPF application developed in VS2017 for every PC user. It is a very simple Desktop App for storing contacts. This App presents my introduction to programming WPF applications. Additionally, it is my first experience of developing projects using modern and sophisticated methods and techniques.
 

[![AppVeyor](https://img.shields.io/appveyor/ci/gruntjs/grunt.svg)](![AppVeyor](https://img.shields.io/appveyor/ci/pytagora/Address-book.svg))
[![GitHub license](https://img.shields.io/github/license/pytagora/Address-book.svg)](https://github.com/pytagora/Address-book/blob/master/LICENSE.md)

## About
The idea is to learn and get necessary programming experience through developing, building and deploying the stable release of the software. Software has two windows. The main window contains all the necessary data in the shape of a table. An additional window is opened by clicking the button **Add** which purpose is to add new contact to the table.

### In progress:
- Comment section has its limitations. Should make flexible size for input.
- Adding new contact is not possible at all. Database solution will be build in the following week.
- Table is currently not able to display big number of data/rows what is wished for in every modern app.
- Search and Filter query.
- In the MainWindow there is the default photo, but the user himself should be able to put his own.
- There still isn't made a decision which data is mandatory and which is elective.

### Future ideas:
- *Email* and *Social Network Id* as a hyperlink.
- Information form for *user* himself.
- *Residence* place connected to Google Maps.

### Additional feature:
- *Loading photo* for each new contact in the AddNewContact window.
- *Music Player* in the top left corner of MainWindow.

Below you can see the current state of the software. Two contacts which data you can see are loaded manually using Code behind method not UI solution.
![Current look of the application](https://raw.githubusercontent.com/pytagora/Address-Book/master/projects/view/images/Demo_App.jpg)

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
- Loading photo for new contact.
- Fixed size for both windows.
- Style for buttons, table and etc. (In progress...)

# License
*Address-Book* is lincensed under the [GNU GPLv3.0 license](https://github.com/pytagora/Address-book/blob/master/LICENSE.md).
