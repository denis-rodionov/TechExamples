USE master
GO

CREATE DATABASE University
GO

USE University
GO

CREATE TABLE Students
(
	studID INT PRIMARY KEY IDENTITY(1,1),
	firstName VARCHAR(20) NOT NULL,
	lastName VARCHAR(20) NOT NULL,
	thirdName VARCHAR(20), 	-- Отчество
	pasNo VARCHAR(15) NOT NULL,
	recordBook VARCHAR(15),
	age TINYINT,
	startYear SMALLINT,
	phone VARCHAR(20),
	address VARCHAR(40),
	groupID INT
)
GO

CREATE TABLE Groups
(
	groupID INT PRIMARY KEY IDENTITY(1,1),
	groupIndex VARCHAR(10) NOT NULL UNIQUE,
	curatorID INT,
	specID INT,					-- специальность
	course SMALLINT
)
GO

ALTER TABLE Students
	ADD CONSTRAINT stud_group_fk FOREIGN KEY ( groupID )
	REFERENCES Groups ( groupID )
GO

CREATE TABLE Specialities
(
	specID INT PRIMARY KEY IDENTITY(1,1),
	specName VARCHAR(40),
	cathID INT
)
GO

ALTER TABLE Groups
	ADD CONSTRAINT group_spec_fk FOREIGN KEY ( specID )
	REFERENCES Specialities ( specID )
GO

CREATE TABLE Cathedras
(
	cathID INT PRIMARY KEY IDENTITY(1,1),
	cathName VARCHAR(30) NOT NULL UNIQUE,
	cathIndex VARCHAR(10) NOT NULL UNIQUE,
	cathDesc VARCHAR(100),
	headID INT, 	-- заведующий кафедрой
	facID INT
)
GO	

ALTER TABLE Specialities
	ADD CONSTRAINT spec_cath_fk FOREIGN KEY ( cathID )
	REFERENCES Cathedras ( cathID ) ON DELETE CASCADE
GO

CREATE TABLE Faculties
(
	facID INT PRIMARY KEY IDENTITY(1,1),
	facName VARCHAR(20) NOT NULL UNIQUE,
	facDesc VARCHAR(100),
	headID INT
)
GO

ALTER TABLE Cathedras
	ADD CONSTRAINT cath_fac_fk FOREIGN KEY ( facID )
	REFERENCES Faculties ( facID ) ON DELETE NO ACTION
GO

CREATE TABLE Teachers
(
	teachID INT PRIMARY KEY IDENTITY (1,1),
	firstName VARCHAR(20) NOT NULL,
	lastName VARCHAR(20) NOT NULL,
	thirdName VARCHAR(20),
	pasNO VARCHAR(15) NOT NULL,
	degree INT,
	age	TINYINT,
	phone VARCHAR(15),
	address VARCHAR(40),
	cathID INT,
	post INT,		-- должность
	rank INT		-- научное звание
)
GO

ALTER TABLE Teachers
	ADD CONSTRAINT teach_cath_fk FOREIGN KEY ( cathID )
	REFERENCES Cathedras ( cathID ) ON DELETE CASCADE
GO

ALTER TABLE Cathedras
	ADD CONSTRAINT head_cath_fk FOREIGN KEY ( headID )
	REFERENCES Teachers ( teachID )
GO

ALTER TABLE Groups
	ADD CONSTRAINT group_teach_fk FOREIGN KEY ( curatorID )
	REFERENCES Teachers ( teachID )
GO

ALTER TABLE Faculties
	ADD CONSTRAINT head_fac_fk FOREIGN KEY ( headID )
	REFERENCES Teachers ( teachID )
GO

CREATE TABLE Subjects
(
	subID INT PRIMARY KEY IDENTITY(1,1),
	subName VARCHAR(40),
	subDesc VARCHAR(80)
)
GO

CREATE TABLE TeachSubjects
(
	teachID INT NOT NULL, 
	subID INT NOT NULL,
	groupID INT NOT NULL,

	CONSTRAINT teach_fk FOREIGN KEY ( teachID )
	REFERENCES Teachers ( teachID ),

	CONSTRAINT subject_fk FOREIGN KEY ( subID )
	REFERENCES Subjects ( subID ),

	CONSTRAINT group_fk FOREIGN KEY ( groupID )
	REFERENCES Groups ( groupID )
)
GO

CREATE TABLE Exams
(
	subID INT,
	studID INT,
	teachID INT,
	examStatus VARCHAR(20),	-- зчёт или экзамен
	isMark BIT,
	mark TINYINT,

	CONSTRAINT subject_exam_fk FOREIGN KEY ( subID )
	REFERENCES Subjects ( subID ),

	CONSTRAINT student_exam_fk FOREIGN KEY ( studID )
	REFERENCES Students ( studID ),
	
	CONSTRAINT teacher_exam_fk FOREIGN KEY ( teachID )
	REFERENCES Teachers ( teachID )
)
GO

CREATE TABLE Buildings
(
	buildID INT PRIMARY KEY IDENTITY(1,1),
	address VARCHAR(30)
)
GO

CREATE TABLE Auditoriums
(
	audID INT PRIMARY KEY IDENTITY(1,1),
	audNO VARCHAR(10),
	buildID INT,
	capasity TINYINT,	-- Вместимость

	CONSTRAINT building_aud_fk FOREIGN KEY ( buildID )
	REFERENCES Buildings ( buildID )
)
GO

CREATE TABLE SpecSubjects
(
	specID INT NOT NULL,
	subID INT NOT NULL,
	hours INT, 

	CONSTRAINT spec_ss_fk FOREIGN KEY ( specID )
	REFERENCES Specialities ( specID ),

	CONSTRAINT sub_ss_fk FOREIGN KEY ( subID )
	REFERENCES Subjects ( subID )
)
GO

CREATE TABLE DegreesTable
(
	degID INT PRIMARY KEY IDENTITY(1,1),
	degText VARCHAR(100)
)
GO

ALTER TABLE Teachers
	ADD CONSTRAINT deg_fk FOREIGN KEY ( degree)
	REFERENCES DegreesTable ( degID )
GO

CREATE TABLE Post
(
	postID INT PRIMARY KEY IDENTITY(1,1),
	postText VARCHAR(100)
)
GO

CREATE TABLE Rank
(
	rankID INT PRIMARY KEY IDENTITY(1,1),
	rankText VARCHAR (100)
)
GO

ALTER TABLE Teachers
	ADD CONSTRAINT post_fk FOREIGN KEY (post)
	REFERENCES Post (postID)
GO

ALTER TABLE Teachers
	ADD CONSTRAINT rank_fk FOREIGN KEY (rank)
	REFERENCES Rank (rankID)
GO

CREATE TABLE Rights
(
	login VARCHAR(40) PRIMARY KEY,
	pas VARCHAR(40),
	rights INT
)
GO

---------------------------------------------------
-- Представления
---------------------------------------------------
-- Преподаватели
USE University
GO
CREATE VIEW TeachersView AS 
SELECT f.teachID, f.firstName, f.lastName, f.thirdName, f.pasNO, d.degText, 
	f.age, f.phone, f.address, c.cathName, p.postText, r.rankText
FROM Teachers f LEFT JOIN DegreesTable d ON f.degree = d.degID
LEFT JOIN Cathedras c ON f.cathID = c.cathID
LEFT JOIN Post p ON f.post = p.postID
LEFT JOIN Rank r ON f.rank = r.rankID
GO

-- Кафедры
USE University
GO
CREATE VIEW CathedrasView AS
SELECT c.cathID, c.cathName, c.cathIndex, c.cathDesc, f.facName, 
	t.firstName, t.lastName, t.thirdName, t.teachID
FROM Cathedras c LEFT JOIN Faculties f ON c.facID = f.facID
LEFT JOIN Teachers t ON c.headID = t.teachID
GO

-- Факультеты
USE University
GO
CREATE VIEW FacultiesView AS
SELECT f.facID, f.facName, f.facDesc, t.firstName, t.lastName,
	t.thirdName, f.headID
FROM Faculties f LEFT JOIN Teachers t ON f.headID = t.teachID
GO

-- Группы
USE University
GO
CREATE VIEW GroupsView AS
SELECT g.groupID, g.groupIndex, g.course, s.specName, t.firstName,
	t.lastName, t.thirdName, g.curatorID, c.cathName, f.facName,
	COUNT(st.studID) AS studCount
FROM Groups g LEFT JOIN Specialities s ON g.specID = s.specID
	LEFT JOIN Teachers t ON g.curatorID = t.teachID
	LEFT JOIN Cathedras c ON s.cathID = c.cathID
	LEFT JOIN Faculties f ON f.facID = c.facID
	LEFT JOIN Students st ON g.groupID = st.groupID
GROUP BY g.groupID, g.groupIndex, g.course, s.specName, t.firstName,
	t.lastName, t.thirdName, g.curatorID, c.cathName, f.facName 
GO

-- Студенты
USE University
GO
CREATE VIEW StudentsView AS
SELECT s.studID, s.firstName, s.lastName, s.thirdName, s.pasNO, 
	s.recordBook, s.age, s.startYear, s.phone, s.address, s.groupID,
	g.course, g.groupIndex, c.cathName, f.facName
FROM Students s LEFT JOIN Groups g ON s.groupID = g.groupID
	LEFT JOIN Specialities sp ON sp.specID = g.specID
	LEFT JOIN Cathedras c ON c.cathID = sp.cathID
	LEFT JOIN Faculties f ON f.facID = c.facID
GO


---------------------------------------------------
-- Триггеры
---------------------------------------------------

USE University
GO
CREATE TRIGGER InsertIntoTeachersView
ON TeachersView
INSTEAD OF INSERT
AS
	INSERT INTO Teachers (firstName, lastName, thirdName, pasNO,
		phone, age, degree, address, cathID, post, rank)
	SELECT t.firstName, t.lastName, t.thirdName, t.pasNO, t.phone,
		t.age, d.degID, t.address, c.cathID, p.postID, r.rankID
	FROM Inserted t LEFT JOIN DegreesTable d ON t.degText = d.degText
	LEFT JOIN Cathedras c ON t.cathName = c.cathName
	LEFT JOIN Post p ON t.postText = p.postText
	LEFT JOIN Rank r ON t.rankText = r.rankText
GO

USE University
GO
CREATE TRIGGER UpdateTeachersView
ON TeachersView
INSTEAD OF UPDATE
AS
	UPDATE Teachers
	SET
		firstName = i.firstName,
		lastName = i.lastName,
		thirdName = i.thirdName,
		age = i.age,
		pasNO = i.pasNO,
		phone = i.phone, 
		address = i.address,
		cathID = c.cathID,
		degree = d.degID,
		post = p.postID,
		rank = r.rankID
	FROM Teachers t JOIN Inserted i ON t.teachID = i.teachID 
	LEFT JOIN Cathedras c ON i.cathName = c.cathName
	LEFT JOIN DegreesTable d ON i.degText = d.degText
	LEFT JOIN Post p ON i.postText = p.postText
	LEFT JOIN Rank r ON i.rankText = r.rankText
GO

-- Добавление одноимённой специальности после добавления кафедры
-- В случае необходимости связи один ко многим между Кафедрами и 
-- специальностями, этот триггер нелбходимо убрать
USE University
GO
CREATE TRIGGER InsertCathAddSpec
ON Cathedras
AFTER INSERT
AS
	INSERT INTO Specialities (specName, cathID)
	SELECT cathName, cathID
	FROM Inserted
GO	

-- Изменение одноимённой специальности после добавления кафедры
-- В случае необходимости связи один ко многим между Кафедрами и 
-- специальностями, этот триггер необходимо убрать
USE University
GO
CREATE TRIGGER UpdateCathUpdateSpec
ON Cathedras
AFTER UPDATE
AS
	UPDATE Specialities SET
		specName = i.cathName
	FROM Inserted i JOIN Specialities s ON i.cathID = s.cathID
GO


---------------------------------------------------
-- Тестовые данные
---------------------------------------------------

INSERT INTO DegreesTable (degText)
VALUES ('Кандидат физико-математических наук')
INSERT INTO DegreesTable (degText)
VALUES ('Кандидат химических наук')
INSERT INTO DegreesTable (degText)
VALUES ('Кандидат биологических наук')
INSERT INTO DegreesTable (degText)
VALUES ('Кандидат геолого-минералогических наук')
INSERT INTO DegreesTable (degText)
VALUES ('Кандидат географических наук')
INSERT INTO DegreesTable (degText)
VALUES ('Кандидат филологических наук')
INSERT INTO DegreesTable (degText)
VALUES ('Кандидат юридических наук')
INSERT INTO DegreesTable (degText)
VALUES ('Кандидат экономических наук')
INSERT INTO DegreesTable (degText)
VALUES ('Кандидат философских наук')
INSERT INTO DegreesTable (degText)
VALUES ('Кандидат психологических наук')
INSERT INTO DegreesTable (degText)
VALUES ('Кандидат исторических наук')
INSERT INTO DegreesTable (degText)
VALUES ('Доктор физико-математических наук')
INSERT INTO DegreesTable (degText)
VALUES ('Доктор химических наук')
INSERT INTO DegreesTable (degText)
VALUES ('Доктор биологических наук')
INSERT INTO DegreesTable (degText)
VALUES ('Доктор геолого-минералогических наук')
INSERT INTO DegreesTable (degText)
VALUES ('Доктор географических наук')
INSERT INTO DegreesTable (degText)
VALUES ('Доктор филологических наук')
INSERT INTO DegreesTable (degText)
VALUES ('Доктор юридических наук')
INSERT INTO DegreesTable (degText)
VALUES ('Доктор экономических наук')
INSERT INTO DegreesTable (degText)
VALUES ('Доктор философских наук')
INSERT INTO DegreesTable (degText)
VALUES ('Доктор психологических наук')
INSERT INTO DegreesTable (degText)
VALUES ('Доктор исторических наук')

INSERT INTO Post (postText)
VALUES ('Доцент')
INSERT INTO Post (postText)
VALUES ('Старший преподаватель')
INSERT INTO Post (postText)
VALUES ('Преподаватель')
INSERT INTO Post (postText)
VALUES ('Асистент')
INSERT INTO Post (postText)
VALUES ('Профессор')

INSERT INTO Rank (rankText)
VALUES ('Доцент')
INSERT INTO Rank (rankText)
VALUES ('Профессор')

INSERT INTO Rights (login, pas, rights)
VALUES ('adm', 'adm', 64)

----------------------------------------------
-- Timetables
----------------------------------------------
CREATE TABLE Timetable
(
	id INT PRIMARY KEY IDENTITY(1,1),
	subID INT NOT NULL,
	teachID INT NOT NULL,
	groupID INT NOT NULL,
	day_of_week INT NOT NULL,
	pair_number INT NOT NULL,
	
	CONSTRAINT fk_pair_subject FOREIGN KEY (subID)
	REFERENCES Subjects ( subID ),
	
	CONSTRAINT fk_pair_teacher FOREIGN KEY (teachID)
	REFERENCES Teachers ( teachID),
	
	CONSTRAINT fk_pair_group FOREIGN KEY (groupID)
	REFERENCES Groups ( groupID)
)
GO

CREATE TABLE GroupsSubjectBundle
(
	id INT PRIMARY KEY IDENTITY(1,1),
	teachID INT NOT NULL,
	groupID INT NOT NULL,
	count_of_pair INT NOT NULL,
	
	CONSTRAINT fk_GSB_teacher FOREIGN KEY (teachID)
	REFERENCES Teachers ( teachID),
	
	CONSTRAINT fk_GSB_group FOREIGN KEY (groupID)
	REFERENCES Groups ( groupID)
)
GO

CREATE TABLE TeacherSubjectBundle
(
	id INT PRIMARY KEY IDENTITY(1,1),
	subID INT NOT NULL,
	teachID INT NOT NULL,
	
	CONSTRAINT fk_TSB_subject FOREIGN KEY (subID)
	REFERENCES Subjects ( subID ),
	
	CONSTRAINT fk_TSB_teacher FOREIGN KEY (teachID)
	REFERENCES Teachers ( teachID)
)
GO