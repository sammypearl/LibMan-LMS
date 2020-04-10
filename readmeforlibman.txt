
LibMan LMS is simple library management system built with asp.net core 3.1 and mssql

Functions:

User will login or register to borrow an asset e.g Books, Video
The registration of new Patron (a library user), Assets is done by admin through the database server by writing script to update the db table.
A user will have a libraryIdCard after new registration.
A user can borrow assets, place a hold on an asset, checkout an asset when done with it, mark an asset 'lost' when it is lost and mark it 'found' when it is found, and pay fees on lost assets that were not found.


Usage:
 
 A user will register with the app to use it.
 The user will go to the admin to register as a patron and to borrow an asset, which would be done on the database server by the library Database administrator.
 
 A library card with LibraryIdCard would be issued to user.
 The user will proceed to the application to carry the rest of needed activities.
 