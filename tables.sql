create table patient
(
	patientid int primary key auto_increment,
	username varchar(200),
	passwordhash varchar(200),
	minbpm int,
	maxbpm int,
	mintemp float,
	maxtemp float,
	token varchar(200)
);

create table doctor
(
	doctorid int primary key auto_increment,
	username varchar(200),
	passwordhash varchar(200)
);

create table patientdata
(
	patientdataid int primary key auto_increment,
	userid int,
	datetime datetime,
	pulse int,
	temp float,
	isnormal int
);

