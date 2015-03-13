use master
GO

CREATE DATABASE FiveStones
GO

use FiveStones
GO

CREATE TABLE Players (
	id INT PRIMARY KEY IDENTITY(1,1),
	name VARCHAR(MAX) NOT NULL,
	pas VARCHAR(MAX) NOT NULL,
	email VARCHAR(MAX) NOT NULL,
	vin_count INT NOT NULL,
	lose_count INT NOT NULL,
	logged_on BIT NOT NULL
)
GO

CREATE TABLE Log (
	id INT PRIMARY KEY IDENTITY(1,1),
	event_time DATETIME NOT NULL,
	event_desc VARCHAR(MAX) NOT NULL
)
GO