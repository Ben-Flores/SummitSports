Use inew233Xfa24;
Go

CREATE TABLE bfloresFA24.Position
(
	PositionID int IDENTITY(1000,1) CONSTRAINT PK_PositionID PRIMARY KEY,
	PositionTitle varchar(20) not null
);
Go

CREATE TABLE bfloresFA24.Person
(
    PersonID int IDENTITY(1000,1) CONSTRAINT PK_PersonID PRIMARY KEY,
    Title varchar(15) NULL,
    NameFirst varchar(20) NOT NULL,
    NameMiddle varchar(20) NULL,
    NameLast varchar(20) NOT NULL,
    Suffix varchar(20) NULL,
    Address1 varchar(30) NOT NULL,
    Address2 varchar(30) NULL,
    Address3 varchar(30) NULL,
    City varchar(30) NOT NULL,
    Zipcode varchar(10) NOT NULL,
    State varchar(2) NOT NULL,
    Email varchar(40) NULL,
    PhonePrimary varchar(20) NULL,
    PhoneSecondary varchar(20) NULL,
    Image varbinary(max) NULL,
	PersonDeleted bit NULL
);
Go

CREATE TABLE bfloresFA24.SecurityQuestions
(
    QuestionID int IDENTITY(100,1) CONSTRAINT PK_QuestionID PRIMARY KEY,
    SetID int NOT NULL,
    QuestionPrompt varchar(50) NOT NULL
);
Go

CREATE TABLE bfloresFA24.Logon
(
    LogonID int IDENTITY(2000,1) CONSTRAINT PK_LogonID PRIMARY KEY, 
    PersonID int NOT NULL,
    LogonName  varchar(20) NOT NULL,
    Password varchar(20) NOT NULL,
    FirstChallengeQuestion int NOT NULL,
    FirstChallengeAnswer varchar(20) NOT NULL, 
    SecondChallengeQuestion int NOT NULL,
    SecondChallengeAnswer varchar(20) NOT NULL,
    ThirdChallengeQuestion int NOT NULL,
    ThirdChallengeAnswer varchar(20) NOT NULL,
    PositionID int NOT NULL,
    AccountDisabled bit NULL, 
    AccountDeleted bit NULL
    CONSTRAINT FK_Logon_PersonID FOREIGN KEY (PersonID) REFERENCES bfloresFA24.Person(PersonID),
    CONSTRAINT FK_FirstChallengeQuestion FOREIGN KEY (FirstChallengeQuestion) REFERENCES bfloresFA24.SecurityQuestions(QuestionID),
    CONSTRAINT FK_SecondChallengeQuestion FOREIGN KEY (SecondChallengeQuestion) REFERENCES bfloresFA24.SecurityQuestions(QuestionID),
    CONSTRAINT FK_ThirdChallengeQuestion FOREIGN KEY (ThirdChallengeQuestion) REFERENCES bfloresFA24.SecurityQuestions(QuestionID),
	CONSTRAINT FK_Logon_PostionID FOREIGN KEY (PositionID) REFERENCES bfloresFA24.Position(PositionID),
	CONSTRAINT UQ_LogonName UNIQUE(LogonName)
);
Go