INSERT INTO bfloresFA24.Position
VALUES
('Manager'),
('Employee'),
('Customer');
Go

INSERT INTO bfloresFA24.Person
(NameFirst, NameLast, Address1, City, State, Zipcode)
VALUES
('Marcus', 'Green', '1550 Carnegie St', 'Houston', 'TX', '77001'),
('Daenae', 'Corell', '676 Reacker Blvd', 'Pasadena', 'TX', '77015'),
('Mikael', 'Braun', '7815 Woodrow Ct', 'Baytown', 'TX', '77520');
Go

INSERT INTO bfloresFA24.Logon
(PersonID, LogonName, Password, FirstChallengeQuestion, FirstChallengeAnswer, SecondChallengequestion, SecondChallengeAnswer, ThirdChallengeQuestion, ThirdChallengeAnswer, PositionID)
VALUES
(1000, 'ManagerMarc', 'M@rcmyw0rd', 100, 'Houston', 104, 'Maurice', 108, 'This one', 1000),
(1001, 'DCorell22', 'freneticBarge!', 102, 'Boston', 103, 'Maurice', 106, 'Clam Chowder', 1001),
(1002, 'MadMikey', 'asd!@#BLIMEY', 101, 'jaguar', 105, 'maiden china', 107, 'tenet', 1002);