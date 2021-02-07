CREATE DATABASE db_resource_management;
USE db_resource_management;

CREATE TABLE Item
(
  Item_Id	INT			AUTO_INCREMENT NOT NULL,
  Item_Name	VARCHAR(40)	NOT NULL,
  Catagory 	VARCHAR(20)	DEFAULT "unspecified",
  IsActive BIT DEFAULT 1,
  PRIMARY KEY (Item_Id)
);

CREATE TABLE Item_Attribute
(
  Item_Id	INT			NOT NULL,
  Attribute	VARCHAR(30)	NOT NULL,
  Att_Value VARCHAR(30)	NOT NULL,
  PRIMARY KEY (Attribute, Item_Id),
  FOREIGN KEY (Item_Id) REFERENCES Item(Item_Id)
);

CREATE TABLE Depot
(
  Depot_Id		INT		 							AUTO_INCREMENT NOT NULL,
  Depot_Name	VARCHAR(30)							NOT NULL,
  Size			ENUM("SMALL", "MEDIUM", "LARGE")	NOT NULL,
  Occupancy 	SMALLINT 							UNSIGNED DEFAULT "0",
  Address		TINYTEXT,
  IsActive BIT DEFAULT 1,
  PRIMARY KEY (Depot_Id)
);

CREATE TABLE Item_Order
(
  Item_Order_Id INT			AUTO_INCREMENT NOT NULL,
  Order_Date	DATETIME	NOT NULL,
  Ship_Date		DATE,
  Price 		DOUBLE		NOT NULL,
  Order_Status	ENUM("PROBLEM", "CANCELLED", "RETURNED", "IN_PROCESS", "IN_TRANSIT", "DELIVERED") DEFAULT "IN_PROCESS" NOT NULL,
  PRIMARY KEY (Item_Order_Id)
);

CREATE TABLE Supplier
(
  Supplier_Id	INT			AUTO_INCREMENT NOT NULL,
  Supplier_Name	VARCHAR(30)	NOT NULL,
  Address		TINYTEXT,
  Contact		VARCHAR(60),
  PRIMARY KEY (Supplier_Id)
);

CREATE TABLE Stock
(
  Depot_Id	INT NOT NULL,
  Item_Id	INT NOT NULL,
  Quantity	INT UNSIGNED DEFAULT "0" NOT NULL,  
  PRIMARY KEY (Item_Id, Depot_Id),
  FOREIGN KEY (Item_Id) REFERENCES Item(Item_Id),
  FOREIGN KEY (Depot_Id) REFERENCES Depot(Depot_Id)
);

CREATE TABLE Depot_Log
(
  Log_Id	INT						UNIQUE AUTO_INCREMENT NOT NULL,
  Depot_Id	INT						NOT NULL,
  Item_Id	INT						NOT NULL,
  Log_Date	DATETIME				NOT NULL,
  Log_Type	ENUM("ENTRY", "EXIT")	NOT NULL,
  Quantity	INT UNSIGNED			NOT NULL,
  Log_Desc	TINYTEXT				NOT NULL,
  PRIMARY KEY (Log_Id),
  FOREIGN KEY (Depot_Id) REFERENCES Depot(Depot_Id),
  FOREIGN KEY (Item_Id) REFERENCES Item(Item_Id)
);

CREATE TABLE Item_Order_In
(
  Item_Order_Id	INT				NOT NULL,
  Item_Id		INT				NOT NULL,
  Quantity		INT UNSIGNED	NOT NULL,
  PRIMARY KEY (Item_Order_Id, Item_Id),
  FOREIGN KEY (Item_Order_Id) REFERENCES Item_Order(Item_Order_Id),
  FOREIGN KEY (Item_Id) REFERENCES Item(Item_Id)
);

CREATE TABLE Item_Order_To
(
  Item_Order_Id	INT NOT NULL,
  Depot_Id		INT NOT NULL,
  PRIMARY KEY (Item_Order_Id, Depot_Id),
  FOREIGN KEY (Item_Order_Id) REFERENCES Item_Order(Item_Order_Id),
  FOREIGN KEY (Depot_Id) REFERENCES Depot(Depot_Id)
);

CREATE TABLE Item_Order_From
(
  Item_Order_Id	INT NOT NULL,
  Supplier_Id	INT NOT NULL,
  PRIMARY KEY (Supplier_Id, Item_Order_Id),
  FOREIGN KEY (Supplier_Id) REFERENCES Supplier(Supplier_Id),
  FOREIGN KEY (Item_Order_Id) REFERENCES Item_Order(Item_Order_Id)
);