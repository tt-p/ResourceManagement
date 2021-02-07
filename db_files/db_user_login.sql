CREATE DATABASE db_user_login;
USE db_user_login;

CREATE TABLE Users
(
  User_Id	INT			AUTO_INCREMENT NOT NULL,
  User_Name	VARCHAR(30)	NOT NULL,
  User_Type ENUM("Factory", "Depot") NOT NULL,
  User_Pass	VARCHAR(20)	NOT NULL,
  PRIMARY KEY (User_Id)
);