# Doctor_Who_Core

This repository contains my implementation of a SQL Server Database containing data such as: the list of episodes, doctors, authors, companions, enemies, etc. from the long-running TV show: Doctor Who. This database was created using Entity Framework Core 5.0 and in accordance with the rules, requirements, and constraints set forth by this project’s instructions and which can be found later in this README file. Furthermore, it is worth mentioning that this project was designed to help introduce interns to the basics, as well as the more advanced techniques, of using Entity Framework Core 5.0 to create, populate, and manipulate SQL Relational Databases. In addition to introducing interns to the basics of using Entity Framework Core, the project’s requirements go further than just the basics to include some of the more advanced Entity Framework techniques such as change tracking, working with disconnected scenarios, working with migrations, using SqlRaw to create Views, User-Defined Stored Procedures, and User-Defined Functions, using bulk operations, interacting with related data through loading, and much more. While not all of the previously mentioned techniques and skills were necessarily deployed in my implementation of this project, most were utilized in order to create the data models, create database objects, seed the database with data, and then create data repositories and functions to manipulate the database/data model as needed. Finally, please note that all the data used to populate this database is in the Data_Files folder of the project repository and further explanation of the structure of this repository can be found at the end of this README file.

As part of my internship as a Backend Development Intern at Foothill Technology Solutions, I was asked to complete a task-based training program. This training program involves taking online courses to better hone and improve an intern's programming skills and work with development teams to get a taste of what a career in software development is like all while performing tasks (doing assigned projects) that help deepen an intern's understanding of the material and the training they are receiving.

For my fifth task, I was asked to create an extensive Doctor Who relational database, using Entity Framework Core, which stores information about the TV show such as: the list of doctors, companions, enemies, authors, actors, episodes, and much more. Furthermore, the database/data models have to follow a set of rules and constraints in order to fulfill the requirements of this project, which can be found later in this README file. This exercise was designed to help interns become familiar with the basics, as well as the more advanced techniques, of using Entity Framework Core to create, populate, develop, and maintain a database over a period of time. Furthermore, by completing this project, interns will become comfortable using and deploying the skills they learn throughout their EF Core training to real-world applications. 

Here are the instructions I received for this project:

Before you start:
1. Use .NET Core 3.0+.
2. Do one task at a time and run tests.
3. Follow GIT best practices you learned to push your code.
4.This exercise depends on SQL: Doctor Who exercise (checkout my Doctor_Who repository for more details).

Requirements:
1. Create a DB named DoctorWhoCore (using SSMS).

2. Create a console application project named DoctorWho.

3. Create a library project named DoctorWho.Db and reference it from DoctorWho project.

4. Create DoctorWhoCoreDbContext and add it to DoctorWho.Db

5. Create the data models for Doctor Who tables with all necessary keys, relationships, constraints and navigations. These models should exist in DoctorWho.Db

6. Write migrations to create the previous tables. Migrations should exist in DoctorWho.Db.

7. Seed the tables with at least 5 records in each.

8. Write migrations to create the functions, sprocs and views from previous exercise.

9. Write methods in EF in the console app to execute the functions, sprocs and views from previous exercise.

10. Write Create/Update/Delete methods for companions, enemies, doctors, authors, and episodes.

11. Write methods to:

	a. AddEnemyToEpisode: Add an enemy to an episode.
	b. AddCompanionToEpisode: Add a companion to an episode.
	c. GetAllDoctors: Get all available doctors.
	d. GetEnemyById: Get an enemy by ID.
	e. GetCompanionById: Get a companion by ID.

12. Create a repository class for each entity and call it: {EntityName}Repository.cs, and move related methods from the previous requirements to the right repository. These repositories should exist in Repositories folder DoctorWho.Db

My repository is divided into the following folders and sub-folders:
1. The "Data_Files" Folder: contains all the CSV files used to populate the databse and its objects with various information.
2. The "Database" Folder: contains the backup file for the database which was created and populated for the purpose of this project.
3. The "DoctorWho" Folder: this folder contains the following sub-folders:
	a. DoctorWho.Db: contains the Migrations folder, the Repositories folder (which is comprised of a number of repository classes, one for each entity that was created, and containing all the methods required to create, update, and delete a record in a repository), as well as the DoctorWho DbContext class for this project.
	b. DoctorWho.Domain: contains all the entities classes required to create the data models for this project.
	c. DoctorWho.UI: a simple console user interface to run the different methods and functionalities of this project.

Thanks,

Ayham R.