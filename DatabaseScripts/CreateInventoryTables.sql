USE inew233xfa24;
GO

CREATE TABLE bfloresFA24.Categories
(
	CategoryID int IDENTITY(100,1) CONSTRAINT PK_CategoryID PRIMARY KEY,
	CategoryName varchar(30) NOT NULL,
	CategoryDescription varchar(100) NULL
);

CREATE TABLE bfloresFA24.Inventory
(
	InventoryID int IDENTITY(100,1) CONSTRAINT PK_InventoryID PRIMARY KEY,
	ItemName varchar(100) NOT NULL,
	ItemDescription varchar(max) NOT NULL,
	CategoryID int NOT NULL,
	RetailPrice decimal(9,2) NOT NULL,
	Cost decimal(9,2) NOT NULL,
	Quantity int NOT NULL CHECK (Quantity >= 0),
	RestockThreshold int NOT NULL CHECK (RestockThreshold >= 0),
	ItemImage varbinary(max),
	Discontinued bit,
	CONSTRAINT FK_CategoryID FOREIGN KEY(CategoryID) REFERENCES bfloresFA24.Categories(CategoryID)
);
Go

 CREATE TABLE bfloresFA24.Discounts
(
	DiscountID int IDENTITY(3000,1) NOT NULL,
	DiscountCode varchar(20) NOT NULL,
	Description varchar(50) NOT NULL,
	DiscountLevel int NOT NULL,
	InventoryID int NULL,
	DiscountType int NOT NULL,
	DiscountPercentage decimal(3, 2) NULL,
	DiscountDollarAmount decimal(11, 2) NULL,
	StartDate date NULL,
	ExpirationDate date NOT NULL,
	CONSTRAINT PK_DiscountID PRIMARY KEY CLUSTERED (DiscountID),
	CONSTRAINT FK_InventoryID FOREIGN KEY(InventoryID) REFERENCES bfloresFA24.Inventory(InventoryID)
 );
GO

CREATE TABLE bfloresFA24.Orders
(
	OrderID int IDENTITY(1000,1) NOT NULL,
	DiscountID int NULL,
	PersonID int NOT NULL,
	EmployeeID int NULL,
	OrderDate date NOT NULL,
	CC_Number varchar(20) NULL,
	ExpDate varchar(7) NULL,
	CCV varchar(3) NULL,
	CONSTRAINT PK_OrderID PRIMARY KEY CLUSTERED (OrderID),
	CONSTRAINT FK_CustomerID FOREIGN KEY(PersonID) REFERENCES bfloresFA24.Person (PersonID),
	CONSTRAINT FK_EmployeeID FOREIGN KEY(EmployeeID) REFERENCES bfloresFA24.Person (PersonID),
	CONSTRAINT FK_DiscountID FOREIGN KEY(DiscountID) REFERENCES bfloresFA24.Discounts (DiscountID)
);
GO

CREATE TABLE bfloresFA24.OrderDetails(
	OrderDetailsID int IDENTITY(1,1) NOT NULL,
	OrderID int NOT NULL,
	InventoryID int NOT NULL,
	DiscountID int NULL,
	Quantity int NOT NULL,
	CONSTRAINT PK_OrderDetailsID PRIMARY KEY CLUSTERED (OrderDetailsID),
	CONSTRAINT FK_OrderDetails_DiscountID FOREIGN KEY(DiscountID) REFERENCES bfloresFA24.Discounts (DiscountID),
	CONSTRAINT FK_ItemID FOREIGN KEY(InventoryID) REFERENCES bfloresFA24.Inventory (InventoryID),
	CONSTRAINT FK_OrderID FOREIGN KEY(OrderID) REFERENCES bfloresFA24.Orders (OrderID)
);
GO