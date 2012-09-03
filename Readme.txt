    FERIE- FRAVÆRS INDBERETNING
    Copyright (C) 2012  Rasmus Zweidorff Iversen

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.

=== ABOUT THIS PROJECT ===
The project consists of two parts, one is the web based interface for the reporting of absence and vacation to a local instance, the second is the actual reporting to KMD Ferie and KMD Fravær which is a program running at dayli intervals generating files "snitfladefiler" for when KMD does a pull request.

The project comes with a local database already setup and and ready to use, otherwise the database connection just has to be modified to use antoher database.

Visual Studio 2010 is what has been primarely used, and is thus recomended for the project. A copy of the ASP.NET MVC 3 framework will also need to be recovered from here <http://www.asp.net/mvc/mvc3>.

=== INSTALL INSTUCTIONS ===

First deploy this project, open it up in visual studio, right click on the project FerieFravaerIndberetning and choose "Publish"

Second, create the databases from the table definition of the local database, or just use the already bundled database.

Third, run the program FerieFravaerFileGenerator and set it to run at the right intervals (according to when KMD does pull requests). You might have to build it first if the bin folder is empty.

