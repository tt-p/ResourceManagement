-- MySQL dump 10.13  Distrib 8.0.18, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: db_resource_management
-- ------------------------------------------------------
-- Server version	8.0.18

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

CREATE DATABASE db_resource_management;
USE db_resource_management;

--
-- Table structure for table `depot`
--

DROP TABLE IF EXISTS `depot`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `depot` (
  `Depot_Id` int(11) NOT NULL AUTO_INCREMENT,
  `Depot_Name` varchar(30) NOT NULL,
  `Size` enum('SMALL','MEDIUM','LARGE') NOT NULL,
  `Occupancy` smallint(5) unsigned DEFAULT '0',
  `Address` tinytext,
  `IsActive` bit(1) DEFAULT b'1',
  PRIMARY KEY (`Depot_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `depot`
--

LOCK TABLES `depot` WRITE;
/*!40000 ALTER TABLE `depot` DISABLE KEYS */;
INSERT INTO `depot` VALUES (1,'In-plant Factory Depot','SMALL',80,'Factory second floor, room no: 098',_binary ''),(2,'Behind the Factory Depot','MEDIUM',68,'Factory outlet, 100 m ahead. 7051 Littleton Wooster, OH 44691',_binary ''),(3,'Bartin Depot','MEDIUM',90,'7184 Glenridge Ave. Griffin, GA 30223',_binary ''),(4,'Foolet Depot','LARGE',10,'84 Boston Ave. Lancaster, NY 14086',_binary '');
/*!40000 ALTER TABLE `depot` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `depot_log`
--

DROP TABLE IF EXISTS `depot_log`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `depot_log` (
  `Log_Id` int(11) NOT NULL AUTO_INCREMENT,
  `Depot_Id` int(11) NOT NULL,
  `Item_Id` int(11) NOT NULL,
  `Log_Date` datetime NOT NULL,
  `Log_Type` enum('ENTRY','EXIT') NOT NULL,
  `Quantity` int(10) unsigned NOT NULL,
  `Log_Desc` tinytext NOT NULL,
  PRIMARY KEY (`Log_Id`),
  UNIQUE KEY `Log_Id` (`Log_Id`),
  KEY `Depot_Id` (`Depot_Id`),
  KEY `Item_Id` (`Item_Id`),
  CONSTRAINT `depot_log_ibfk_1` FOREIGN KEY (`Depot_Id`) REFERENCES `depot` (`Depot_Id`),
  CONSTRAINT `depot_log_ibfk_2` FOREIGN KEY (`Item_Id`) REFERENCES `item` (`Item_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=38 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `depot_log`
--

LOCK TABLES `depot_log` WRITE;
/*!40000 ALTER TABLE `depot_log` DISABLE KEYS */;
INSERT INTO `depot_log` VALUES (1,1,29,'2020-01-01 00:00:00','ENTRY',120,'Depot preparation'),(2,1,30,'2020-01-01 00:00:00','ENTRY',120,'Depot preparation'),(3,1,31,'2020-01-01 00:00:00','ENTRY',130,'Depot preparation'),(4,1,32,'2020-01-01 00:00:00','ENTRY',110,'Depot preparation'),(5,1,33,'2020-01-01 00:00:00','ENTRY',90,'Depot preparation'),(6,1,26,'2020-01-01 00:00:00','ENTRY',2,'Depot preparation'),(7,1,28,'2020-01-01 00:00:00','ENTRY',2,'Depot preparation'),(8,1,45,'2020-01-01 00:00:00','ENTRY',3,'Depot preparation'),(9,1,49,'2020-01-01 00:00:00','ENTRY',4,'Depot preparation'),(10,1,19,'2020-01-01 00:00:00','ENTRY',470,'Depot preparation'),(11,1,20,'2020-01-01 00:00:00','ENTRY',2010,'Depot preparation'),(12,1,22,'2020-01-01 00:00:00','ENTRY',670,'Depot preparation'),(13,1,34,'2020-01-01 00:00:00','ENTRY',3,'Depot preparation'),(14,2,1,'2020-01-01 00:00:00','ENTRY',120,'Depot preparation'),(15,2,2,'2020-01-01 00:00:00','ENTRY',160,'Depot preparation'),(16,2,3,'2020-01-01 00:00:00','ENTRY',60,'Depot preparation'),(17,2,4,'2020-01-01 00:00:00','ENTRY',80,'Depot preparation'),(18,2,9,'2020-01-01 00:00:00','ENTRY',300,'Depot preparation'),(19,2,10,'2020-01-01 00:00:00','ENTRY',185,'Depot preparation'),(20,2,11,'2020-01-01 00:00:00','ENTRY',220,'Depot preparation'),(21,2,14,'2020-01-01 00:00:00','ENTRY',120,'Depot preparation'),(22,2,15,'2020-01-01 00:00:00','ENTRY',73,'Depot preparation'),(23,2,35,'2020-01-01 00:00:00','ENTRY',1,'Depot preparation'),(24,2,36,'2020-01-01 00:00:00','ENTRY',1,'Depot preparation'),(25,2,37,'2020-01-01 00:00:00','ENTRY',0,'Depot preparation'),(26,2,47,'2020-01-01 00:00:00','ENTRY',1,'Depot preparation'),(27,3,1,'2020-01-01 00:00:00','ENTRY',270,'Depot preparation'),(28,3,2,'2020-01-01 00:00:00','ENTRY',350,'Depot preparation'),(29,3,3,'2020-01-01 00:00:00','ENTRY',400,'Depot preparation'),(30,3,4,'2020-01-01 00:00:00','ENTRY',120,'Depot preparation'),(31,3,5,'2020-01-01 00:00:00','ENTRY',322,'Depot preparation'),(32,3,6,'2020-01-01 00:00:00','ENTRY',120,'Depot preparation'),(33,4,1,'2020-01-01 00:00:00','ENTRY',720,'Depot preparation'),(34,4,2,'2020-01-01 00:00:00','ENTRY',1000,'Depot preparation'),(35,4,4,'2020-01-01 00:00:00','ENTRY',720,'Depot preparation'),(36,4,13,'2020-01-01 00:00:00','ENTRY',1200,'Depot preparation'),(37,4,14,'2020-01-01 00:00:00','ENTRY',1000,'Depot preparation');
/*!40000 ALTER TABLE `depot_log` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `item`
--

DROP TABLE IF EXISTS `item`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `item` (
  `Item_Id` int(11) NOT NULL AUTO_INCREMENT,
  `Item_Name` varchar(40) NOT NULL,
  `Catagory` varchar(20) DEFAULT 'unspecified',
  `IsActive` bit(1) DEFAULT b'1',
  PRIMARY KEY (`Item_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `item`
--

LOCK TABLES `item` WRITE;
/*!40000 ALTER TABLE `item` DISABLE KEYS */;
INSERT INTO `item` VALUES (1,'Coal','RAW_MATERIAL',_binary ''),(2,'Sand','RAW_MATERIAL',_binary ''),(3,'Stone','RAW_MATERIAL',_binary ''),(4,'Lumber','RAW_MATERIAL',_binary ''),(5,'Leather','RAW_MATERIAL',_binary ''),(6,'Limestone','RAW_MATERIAL',_binary ''),(7,'45 Steel','METAL',_binary ''),(8,'Iron Bar','METAL',_binary ''),(9,'Titanium Plate','METAL',_binary ''),(10,'Steel Pipe','METAL',_binary ''),(11,'Iron Plate','METAL',_binary ''),(12,'Log','WOOD',_binary ''),(13,'1A Wooden Stick','WOOD',_binary ''),(14,'Wooden Plate','WOOD',_binary ''),(15,'Plastic Pipe','PLASTIC',_binary ''),(16,'Polyester Resin','PLASTIC',_binary ''),(17,'2C Plastic Stick','PLASTIC',_binary ''),(18,'CC Screw','TOOL',_binary ''),(19,'A1 Screw','TOOL',_binary ''),(20,'Nail 104','TOOL',_binary ''),(21,'41-Spring','TOOL',_binary ''),(22,'BT2 Roller','TOOL',_binary ''),(23,'Rotating Assembly','SPARE',_binary ''),(24,'Lantern Ring','SPARE',_binary ''),(25,'SKF Bearing Locknut','SPARE',_binary ''),(26,'Stepladder','EQUIPMENT',_binary ''),(27,'Chainsaw','EQUIPMENT',_binary ''),(28,'Q7 Drill','EQUIPMENT',_binary ''),(29,'11 Earmuff','EQUIPMENT',_binary ''),(30,'13 Earmuff','EQUIPMENT',_binary ''),(31,'S Dust Mask','EQUIPMENT',_binary ''),(32,'Safety Helmet','EQUIPMENT',_binary ''),(33,'Safety Google','EQUIPMENT',_binary ''),(34,'9005 Toolbox','EQUIPMENT',_binary ''),(35,'Horizantal Band Saw','MACHINE',_binary ''),(36,'Vertical Band Saw','MACHINE',_binary ''),(37,'Milling Machine','MACHINE',_binary ''),(38,'Shaping Machine','MACHINE',_binary ''),(39,'Drill Press','MACHINE',_binary ''),(40,'Turret Milling Machine','MACHINE',_binary ''),(41,'Folding Machine','MACHINE',_binary ''),(42,'Surface Grinder','MACHINE',_binary ''),(43,'Platform Trolley','MACHINE',_binary ''),(44,'Computer Numerical Control Lathe','MACHINE',_binary ''),(45,'Hand GPS','ELECTRONIC',_binary ''),(46,'Accumulator','ELECTRONIC',_binary ''),(47,'Power Plant','ELECTRONIC',_binary ''),(48,'Laser Plummet','ELECTRONIC',_binary ''),(49,'Spray Gun','ELECTRONIC',_binary ''),(50,'Digital Multimeter','ELECTRONIC',_binary '');
/*!40000 ALTER TABLE `item` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `item_attribute`
--

DROP TABLE IF EXISTS `item_attribute`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `item_attribute` (
  `Item_Id` int(11) NOT NULL,
  `Attribute` varchar(30) NOT NULL,
  `Att_Value` varchar(30) NOT NULL,
  PRIMARY KEY (`Attribute`,`Item_Id`),
  KEY `Item_Id` (`Item_Id`),
  CONSTRAINT `item_attribute_ibfk_1` FOREIGN KEY (`Item_Id`) REFERENCES `item` (`Item_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `item_attribute`
--

LOCK TABLES `item_attribute` WRITE;
/*!40000 ALTER TABLE `item_attribute` DISABLE KEYS */;
/*!40000 ALTER TABLE `item_attribute` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `item_order`
--

DROP TABLE IF EXISTS `item_order`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `item_order` (
  `Item_Order_Id` int(11) NOT NULL AUTO_INCREMENT,
  `Order_Date` datetime NOT NULL,
  `Ship_Date` date DEFAULT NULL,
  `Price` double NOT NULL,
  `Order_Status` enum('PROBLEM','CANCELLED','RETURNED','IN_PROCESS','IN_TRANSIT','DELIVERED') NOT NULL DEFAULT 'IN_PROCESS',
  PRIMARY KEY (`Item_Order_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `item_order`
--

LOCK TABLES `item_order` WRITE;
/*!40000 ALTER TABLE `item_order` DISABLE KEYS */;
INSERT INTO `item_order` VALUES (1,'2020-10-16 12:14:00','2020-10-28',20000,'DELIVERED'),(2,'2020-09-10 18:37:00','2020-09-30',56000,'DELIVERED'),(3,'2020-05-04 10:20:00','2020-05-12',35750,'DELIVERED'),(4,'2020-12-20 08:35:00','2021-01-25',12000,'IN_PROCESS'),(5,'2020-12-23 17:30:00','2021-02-20',49250,'IN_PROCESS'),(6,'2020-12-24 12:00:00','2021-02-05',75000,'IN_PROCESS'),(7,'2020-12-24 13:10:00','2020-01-30',62100,'IN_PROCESS'),(8,'2020-08-12 15:50:00','2020-09-13',21700,'CANCELLED'),(9,'2020-12-16 09:45:00',NULL,15800,'PROBLEM'),(10,'2020-11-26 10:22:00','2020-12-23',11330,'RETURNED');
/*!40000 ALTER TABLE `item_order` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `item_order_from`
--

DROP TABLE IF EXISTS `item_order_from`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `item_order_from` (
  `Item_Order_Id` int(11) NOT NULL,
  `Supplier_Id` int(11) NOT NULL,
  PRIMARY KEY (`Supplier_Id`,`Item_Order_Id`),
  KEY `Item_Order_Id` (`Item_Order_Id`),
  CONSTRAINT `item_order_from_ibfk_1` FOREIGN KEY (`Supplier_Id`) REFERENCES `supplier` (`Supplier_Id`),
  CONSTRAINT `item_order_from_ibfk_2` FOREIGN KEY (`Item_Order_Id`) REFERENCES `item_order` (`Item_Order_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `item_order_from`
--

LOCK TABLES `item_order_from` WRITE;
/*!40000 ALTER TABLE `item_order_from` DISABLE KEYS */;
INSERT INTO `item_order_from` VALUES (1,5),(2,2),(3,5),(4,4),(5,2),(6,3),(7,1),(8,1),(9,1),(10,4);
/*!40000 ALTER TABLE `item_order_from` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `item_order_in`
--

DROP TABLE IF EXISTS `item_order_in`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `item_order_in` (
  `Item_Order_Id` int(11) NOT NULL,
  `Item_Id` int(11) NOT NULL,
  `Quantity` int(10) unsigned NOT NULL,
  PRIMARY KEY (`Item_Order_Id`,`Item_Id`),
  KEY `Item_Id` (`Item_Id`),
  CONSTRAINT `item_order_in_ibfk_1` FOREIGN KEY (`Item_Order_Id`) REFERENCES `item_order` (`Item_Order_Id`),
  CONSTRAINT `item_order_in_ibfk_2` FOREIGN KEY (`Item_Id`) REFERENCES `item` (`Item_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `item_order_in`
--

LOCK TABLES `item_order_in` WRITE;
/*!40000 ALTER TABLE `item_order_in` DISABLE KEYS */;
INSERT INTO `item_order_in` VALUES (1,4,17500),(2,7,5000),(3,1,10300),(4,23,4),(5,42,1),(6,8,7250),(7,14,2660),(8,16,100),(9,12,220),(10,31,400);
/*!40000 ALTER TABLE `item_order_in` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `item_order_to`
--

DROP TABLE IF EXISTS `item_order_to`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `item_order_to` (
  `Item_Order_Id` int(11) NOT NULL,
  `Depot_Id` int(11) NOT NULL,
  PRIMARY KEY (`Item_Order_Id`,`Depot_Id`),
  KEY `Depot_Id` (`Depot_Id`),
  CONSTRAINT `item_order_to_ibfk_1` FOREIGN KEY (`Item_Order_Id`) REFERENCES `item_order` (`Item_Order_Id`),
  CONSTRAINT `item_order_to_ibfk_2` FOREIGN KEY (`Depot_Id`) REFERENCES `depot` (`Depot_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `item_order_to`
--

LOCK TABLES `item_order_to` WRITE;
/*!40000 ALTER TABLE `item_order_to` DISABLE KEYS */;
INSERT INTO `item_order_to` VALUES (10,1),(1,2),(2,2),(9,2),(3,3),(6,3),(7,3),(8,3),(4,4),(5,4);
/*!40000 ALTER TABLE `item_order_to` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `stock`
--

DROP TABLE IF EXISTS `stock`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `stock` (
  `Depot_Id` int(11) NOT NULL,
  `Item_Id` int(11) NOT NULL,
  `Quantity` int(10) unsigned NOT NULL DEFAULT '0',
  PRIMARY KEY (`Item_Id`,`Depot_Id`),
  KEY `Depot_Id` (`Depot_Id`),
  CONSTRAINT `stock_ibfk_1` FOREIGN KEY (`Item_Id`) REFERENCES `item` (`Item_Id`),
  CONSTRAINT `stock_ibfk_2` FOREIGN KEY (`Depot_Id`) REFERENCES `depot` (`Depot_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stock`
--

LOCK TABLES `stock` WRITE;
/*!40000 ALTER TABLE `stock` DISABLE KEYS */;
INSERT INTO `stock` VALUES (2,1,120),(3,1,270),(4,1,720),(2,2,160),(3,2,350),(4,2,1000),(2,3,60),(3,3,400),(2,4,80),(3,4,120),(4,4,720),(3,5,322),(3,6,120),(2,9,300),(2,10,185),(2,11,220),(4,13,1200),(2,14,120),(4,14,1000),(2,15,73),(1,19,470),(1,20,2010),(1,22,670),(1,26,2),(1,28,2),(1,29,120),(1,30,120),(1,31,130),(1,32,110),(1,33,90),(1,34,3),(2,35,1),(2,36,1),(2,37,0),(1,45,3),(2,47,1),(1,49,4);
/*!40000 ALTER TABLE `stock` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `supplier`
--

DROP TABLE IF EXISTS `supplier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `supplier` (
  `Supplier_Id` int(11) NOT NULL AUTO_INCREMENT,
  `Supplier_Name` varchar(30) NOT NULL,
  `Address` tinytext,
  `Contact` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`Supplier_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supplier`
--

LOCK TABLES `supplier` WRITE;
/*!40000 ALTER TABLE `supplier` DISABLE KEYS */;
INSERT INTO `supplier` VALUES (1,'Material Retro','87C Van Dyke Street Cary, NC 27511','Ms. Vasuki, 88448-7128, US, (505) 116-9771'),(2,'Abstract Machinery','294 E. Manhattan Road Longwood, FL 32779','Ms. Blair, US, (775) 035-8160'),(3,'Iron Guide','9980 North Third St. Mundelein, IL 60060','Ms. Emanuela, US, (605) 708-9855'),(4,'Toolscape','254C Winding Way Ave. Dublin, GA 31021','Mr. Conroy, CA, (867) 669-1086'),(5,'Rawnest','7107 North Ave. Middle Village, NY 11379','Mr. Zoland, US, (228) 635-2460'),(6,'Enigma Electronics','669 Primrose Drive Ephrata, PA 17522','Ms. Kalyani, US, (574) 726-1705');
/*!40000 ALTER TABLE `supplier` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'db_resource_management'
--
/*!50003 DROP PROCEDURE IF EXISTS `DepotDeleteById` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `DepotDeleteById`(
_DepotId INT
)
BEGIN
	UPDATE
		depot
	SET
		IsActive = 0
	WHERE
		Depot_Id = _DepotId
	;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `DepotFilterByName` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `DepotFilterByName`(
_SearchValue VARCHAR(20)
)
BEGIN
	SELECT
		Depot_Id,
		Depot_Name,
        Size,
        Occupancy,
        Address
	FROM
		depot
	WHERE 
		IsActive = 1
        AND
		Depot_Name LIKE CONCAT("%",_SearchValue,"%")
    ;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `DepotInsertOrUpdate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `DepotInsertOrUpdate`(
_DepotId INT,
_DepotName VARCHAR(40),
_Size ENUM('SMALL','MEDIUM','LARGE'),
_Occupancy SMALLINT,
_Address TINYTEXT
)
BEGIN
	IF _DepotId = 0 THEN
		INSERT INTO depot (Depot_Name, Size, Occupancy, Address)
        VALUES (_DepotName, _Size, _Occupancy, _Address);
	ELSE
		UPDATE
			depot
        SET
			Depot_Name = _DepotName,
            Size = _Size,
            Occupancy = _Occupancy,
            Address = _Address
		WHERE
			Depot_Id = _DepotId;
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `DepotLogInsert` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `DepotLogInsert`(
_DepotId INT,
_ItemId INT,
_LogType ENUM('ENTRY','EXIT'),
_Quantity INT UNSIGNED
)
BEGIN
	INSERT INTO depot_log
	(Depot_Id, Item_Id, Log_Date, Log_Type, Quantity, Log_Desc) 
	VALUES
	(_DepotId, _ItemId, NOW(), _LogType, _Quantity, "** Auto Description");
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `DepotLogUpdate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `DepotLogUpdate`(
_LogId INT,
_LogDesc TINYTEXT
)
BEGIN
	UPDATE
		depot_log
	SET
		Log_Desc = _LogDesc
	WHERE
		Log_Id = _LogId;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `DepotViewById` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `DepotViewById`(
_DepotId INT
)
BEGIN
	SELECT
		*
	FROM
		depot
	WHERE
		Depot_Id = _DepotId
	;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `InsertItemAttribute` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertItemAttribute`(
_ItemId INT,
_Attribute VARCHAR(30),
_AttValue VARCHAR(30)
)
BEGIN
	INSERT INTO item_attribute (Item_Id, Attribute, Att_Value)
    VALUES (_ItemId, _Attribute, _AttValue);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ItemAttributesDeleteByItemId` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ItemAttributesDeleteByItemId`(
_ItemId INT
)
BEGIN
	DELETE FROM item_attribute 
    WHERE
		Item_Id = _ItemId
    ;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ItemDeleteById` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ItemDeleteById`(
_ItemId INT
)
BEGIN
	UPDATE
		item
	SET
		IsActive = 0
	WHERE
		Item_Id = _ItemId
	;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ItemFilterByNameOrCatagory` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ItemFilterByNameOrCatagory`(
_SearchValue VARCHAR(20)
)
BEGIN
	SELECT
		Item_Id,
		Item_Name,
        Catagory
	FROM
		item
	WHERE 
		IsActive = 1 AND
		(Item_Name LIKE CONCAT("%",_SearchValue,"%")
        OR
        Catagory LIKE CONCAT("%",_SearchValue,"%"))
    ;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ItemInsert` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ItemInsert`(
_ItemId INT,
_ItemName VARCHAR(40),
_Catagory VARCHAR(20)
)
BEGIN
	INSERT INTO item (Item_Id, Item_Name, Catagory)
	VALUES (_ItemId, _ItemName, _Catagory);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ItemInsertOrUpdate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ItemInsertOrUpdate`(
_ItemId INT,
_ItemName VARCHAR(40),
_Catagory VARCHAR(40)
)
BEGIN
	IF _ItemId = 0 THEN
		INSERT INTO item (Item_Name, Catagory)
        VALUES (_ItemName, _Catagory);
	ELSE
		UPDATE
			item
        SET
			Item_Name = _ItemName,
            Catagory = _Catagory
		WHERE
			Item_Id = _ItemId;
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ItemViewById` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ItemViewById`(
_ItemId INT
)
BEGIN
	SELECT
		*
	FROM
		item
	WHERE
		Item_Id = _ItemId
	;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SelectAllDepotLogs` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SelectAllDepotLogs`()
BEGIN
	SELECT
		d_l.Log_Id,
        d_l.Depot_Id,
        d_l.Item_Id,
        d.Depot_Name,
        i.Item_Name,
        d_l.Quantity,
        d_l.Log_Type,
        d_l.Log_Date,
        d_l.Log_Desc
	FROM 
		depot_log d_l
	JOIN
		item i
			ON d_l.Item_Id = i.Item_Id
	JOIN
		depot d
			ON d_l.Depot_Id = d.Depot_Id
	;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SelectAllDepotNames` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SelectAllDepotNames`()
BEGIN
	SELECT
		Depot_Id,
		Depot_Name
	FROM
		depot
	WHERE
		IsActive = 1
	;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SelectAllDepots` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SelectAllDepots`()
BEGIN
	SELECT
		Depot_Id,
		Depot_Name,
        Size,
        Occupancy,
        Address
	FROM
		depot
	WHERE
		IsActive = 1
	;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SelectAllItemNames` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SelectAllItemNames`()
BEGIN
	SELECT
		Item_Id,
		Item_Name
	FROM
		item
	WHERE
		IsActive = 1        
	;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SelectAllItemOrders` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SelectAllItemOrders`()
BEGIN
	SELECT
		i_o.Item_Order_Id,
        ioi.Item_Id,
		iot.Depot_Id,
        iof.Supplier_Id,
		i.Item_Name,
		ioi.Quantity,
		d.Depot_Name,
		s.Supplier_Name,
		i_o.Order_Date,
		i_o.Ship_Date,
		i_o.Order_Status,
		i_o.Price
	FROM 
		item_order i_o
	JOIN 
		item_order_in ioi
			ON i_o.Item_Order_Id = ioi.Item_Order_Id
	JOIN 
		item_order_to iot
			ON i_o.Item_Order_Id = iot.Item_Order_Id
	JOIN 
		item_order_from iof
			ON i_o.Item_Order_Id = iof.Item_Order_Id
	JOIN 
		item i
			ON ioi.Item_Id = i.Item_Id
	JOIN
		depot d
			ON iot.Depot_Id = d.Depot_Id
	JOIN
		supplier s
			ON iof.Supplier_Id = s.Supplier_Id
	;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SelectAllItems` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SelectAllItems`()
BEGIN
	SELECT
		Item_Id,
		Item_Name,
        Catagory
	FROM
		item
	WHERE
		IsActive = 1
	;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SelectAllStocks` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SelectAllStocks`()
BEGIN
	SELECT
        d.Depot_Name,
        i.Item_Name,
        s.Quantity
	FROM 
		stock s
	JOIN
		item i
			ON s.Item_Id = i.Item_Id
	JOIN
		depot d
			ON s.Depot_Id = d.Depot_Id
	;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SelectDepotLogsByDepotId` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SelectDepotLogsByDepotId`(
_DepotId INT 
)
BEGIN
	SELECT
		d_l.Log_Id,
		d_l.Depot_Id,
        d_l.Item_Id,
        d.Depot_Name,
        i.Item_Name,
        d_l.Quantity,
        d_l.Log_Type,
        d_l.Log_Date,
        d_l.Log_Desc
	FROM 
		depot_log d_l
	JOIN
		item i
			ON d_l.Item_Id = i.Item_Id
	JOIN
		depot d
			ON d_l.Depot_Id = d.Depot_Id
	WHERE
		d_l.Depot_Id = _DepotId
	;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SelectItemAttributesByItemId` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SelectItemAttributesByItemId`(
_ItemId INT
)
BEGIN
	SELECT
		Attribute,
        Att_Value
	FROM
		item_attribute
	WHERE
		Item_Id = _ItemId
	;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SelectStocksByDepotId` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SelectStocksByDepotId`(
_DepotId INT 
)
BEGIN
	SELECT
        d.Depot_Name,
        i.Item_Name,
        s.Quantity
	FROM 
		stock s
	JOIN
		item i
			ON s.Item_Id = i.Item_Id
	JOIN
		depot d
			ON s.Depot_Id = d.Depot_Id
	WHERE
		s.Depot_Id = _DepotId
	;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `SelectStocksByItemId` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SelectStocksByItemId`(
_ItemId INT 
)
BEGIN
	SELECT
        d.Depot_Name,
        i.Item_Name,
        s.Quantity
	FROM 
		stock s
	JOIN
		item i
			ON s.Item_Id = i.Item_Id
	JOIN
		depot d
			ON s.Depot_Id = d.Depot_Id
	WHERE
		s.Item_Id = _ItemId
	;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `StockInsertOrUpdate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `StockInsertOrUpdate`(
_DepotId INT,
_ItemId INT,
_Quantity INT UNSIGNED
)
BEGIN
	INSERT INTO stock (Depot_Id, Item_Id, Quantity)
	VALUES (_DepotId, _ItemId, _Quantity)
    ON DUPLICATE KEY UPDATE Quantity = _Quantity;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-01-08 19:58:32
-- MySQL dump 10.13  Distrib 8.0.18, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: db_user_login
-- ------------------------------------------------------
-- Server version	8.0.18

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

CREATE DATABASE db_user_login;
USE db_user_login;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `User_Id` int(11) NOT NULL AUTO_INCREMENT,
  `User_Name` varchar(30) NOT NULL,
  `User_Type` enum('Factory','Depot') NOT NULL,
  `User_Pass` varchar(20) NOT NULL,
  PRIMARY KEY (`User_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'Mehmet Ali','Depot','123456789'),(2,'Taha','Depot','26taha99'),(3,'Eren','Factory','password');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'db_user_login'
--
/*!50003 DROP PROCEDURE IF EXISTS `UserLogin` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `UserLogin`(
_UserName VARCHAR(30),
_UserPass VARCHAR(20))
BEGIN
SELECT
		User_Type,
		User_Name,
        User_Pass
	FROM
		users
	WHERE
		User_Name = _UserName
        AND
        User_Pass = _UserPass
	;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-01-08 19:58:32
