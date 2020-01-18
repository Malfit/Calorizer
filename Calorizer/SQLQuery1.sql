CREATE TABLE dbo.[User]
(
ID_user int CONSTRAINT PK_User PRIMARY KEY,
Name_user varchar(50))

CREATE TABLE dbo.[Eat_dish]
(
Date_ DATE ,
Time_ TIME,
ID_dish INT,
ID_user INT,
CONSTRAINT PK_Eat_dish PRIMARY KEY (Date_,Time_,ID_user,ID_dish),
CONSTRAINT FK_Eat_dish1 FOREIGN KEY (ID_user)  REFERENCES dbo.[User](ID_user),
CONSTRAINT FK_Eat_dish2 FOREIGN KEY (ID_dish) REFERENCES dbo.[Dish](ID_dish))

CREATE TABLE dbo.[Dish]
(
ID_dish INT CONSTRAINT PK_Dish PRIMARY KEY,
Name_dish varchar(50))

CREATE TABLE dbo.[Use_food_for_the_dish]
(
weight_ INT,
ID_dish INT,
Name_product varchar(50),
CONSTRAINT PK_Use_food_for_the_dish  PRIMARY KEY (ID_dish,Name_product),
CONSTRAINT FK_Use_food_for_the_dish1 FOREIGN KEY (ID_dish) REFERENCES dbo.[Dish](ID_dish),
CONSTRAINT FK_Use_food_for_the_dish2 FOREIGN KEY (Name_product) REFERENCES dbo.[Products](Name_product))

CREATE TABLE dbo.[Products]
(
Name_product varchar(50) CONSTRAINT PK_Products PRIMARY KEY,
health_benefits INT,
calories_per_100g INT,
Liquid varchar(30))
