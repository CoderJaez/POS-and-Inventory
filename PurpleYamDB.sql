/*
SQLyog Community v13.1.6 (64 bit)
MySQL - 10.5.5-MariaDB : Database - purpleyam_db
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`purpleyam_db` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `purpleyam_db`;

/*Table structure for table `rawmaterial` */

DROP TABLE IF EXISTS `rawmaterial`;

CREATE TABLE `rawmaterial` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Product` varchar(100) DEFAULT NULL,
  `CreatedAt` datetime DEFAULT current_timestamp(),
  `DaysBeforeExpiry` int(11) DEFAULT 0,
  `HasExpiry` tinyint(4) DEFAULT 0,
  `Deleted` tinyint(1) DEFAULT 0,
  `ReOrder` int(11) DEFAULT 0,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=latin1;

/*Data for the table `rawmaterial` */

insert  into `rawmaterial`(`Id`,`Product`,`CreatedAt`,`DaysBeforeExpiry`,`HasExpiry`,`Deleted`,`ReOrder`) values 
(1,'Sugar','2021-07-12 01:04:00',0,0,0,0),
(2,'Egg','2021-07-15 10:30:50',0,0,0,0),
(3,'Dry Premix','2021-07-15 10:53:13',30,1,0,10),
(4,'Wet Premix','2021-07-15 10:53:25',0,0,0,0),
(5,'Oil','2021-07-15 10:58:00',0,0,0,0),
(6,'Yeast','2021-07-15 14:25:15',0,0,1,0),
(7,'Butter','2021-07-17 05:03:10',0,0,1,0),
(8,'Test 1','2021-07-17 05:18:53',0,0,1,0),
(9,'Food Color','2021-07-18 23:50:46',0,0,0,0),
(10,'Ube Powder','2021-07-18 23:51:03',0,0,0,0),
(11,'Condensed Milk','2021-07-18 23:52:59',20,1,0,10),
(12,'Evaporated Milk','2021-07-18 23:53:14',0,0,0,0),
(13,'Box Big','2021-07-18 23:53:21',0,0,0,12),
(14,'Box Small','2021-07-18 23:53:28',0,0,0,0),
(15,'Round Tin Cans','2021-07-18 23:53:38',0,0,0,0),
(16,'Heart Cans','2021-07-18 23:53:53',0,0,0,0),
(17,'Candles','2021-07-18 23:54:02',0,0,0,0),
(18,'News print','2021-07-18 23:54:10',0,0,1,0),
(19,'Ribbon','2021-07-18 23:54:20',0,0,0,0),
(20,'Scotch tape','2021-07-18 23:54:28',0,0,0,0),
(21,'Solane','2021-07-18 23:54:42',0,0,0,0),
(22,'test','2021-07-21 20:19:54',0,0,1,0),
(23,'test 12','2021-08-11 09:34:38',0,0,1,0),
(24,'Test raw','2021-10-07 14:28:09',0,0,0,200);

/*Table structure for table `tbl_customer` */

DROP TABLE IF EXISTS `tbl_customer`;

CREATE TABLE `tbl_customer` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Firstname` varchar(100) DEFAULT NULL,
  `Middlename` varchar(100) DEFAULT NULL,
  `Lastname` varchar(200) DEFAULT NULL,
  `ContactNo` varchar(12) DEFAULT NULL,
  `DateTimeStamp` datetime DEFAULT current_timestamp(),
  `Deleted` tinyint(1) DEFAULT 0,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_customer` */

insert  into `tbl_customer`(`Id`,`Firstname`,`Middlename`,`Lastname`,`ContactNo`,`DateTimeStamp`,`Deleted`) values 
(1,'dasd','asda','luamayg','09124650157','2021-10-24 04:11:03',0),
(2,'jane','','Cruze','09124650157','2021-10-24 04:13:04',0),
(3,'dasd','asda','Doe','09124650157','2021-10-24 04:17:19',0),
(4,'Alex','','Tan','09124650157','2021-10-24 04:27:00',0),
(5,'Jenn','','Tes','0912456107','2021-10-24 04:32:03',0);

/*Table structure for table `tbl_expenses` */

DROP TABLE IF EXISTS `tbl_expenses`;

CREATE TABLE `tbl_expenses` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `ExpenseId` int(11) DEFAULT NULL,
  `Amount` decimal(10,2) DEFAULT 0.00,
  `DateTimeStamp` date DEFAULT NULL,
  `Deleted` tinyint(1) DEFAULT 0,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_expenses` */

insert  into `tbl_expenses`(`Id`,`ExpenseId`,`Amount`,`DateTimeStamp`,`Deleted`) values 
(4,4,3000.00,'2021-10-26',0),
(5,5,100.00,'2021-10-26',0),
(6,4,300.00,'2021-10-26',0),
(7,3,500.00,'2021-10-26',0),
(8,4,300.00,'2021-10-26',0);

/*Table structure for table `tbl_expenses_cat` */

DROP TABLE IF EXISTS `tbl_expenses_cat`;

CREATE TABLE `tbl_expenses_cat` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Description` varchar(100) DEFAULT NULL,
  `Deleted` tinyint(1) DEFAULT 0,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_expenses_cat` */

insert  into `tbl_expenses_cat`(`Id`,`Description`,`Deleted`) values 
(3,'TRAVEL',0),
(4,'SALARY',0),
(5,'ELECTRICITY',0),
(6,'WATE BILL',0);

/*Table structure for table `tbl_module` */

DROP TABLE IF EXISTS `tbl_module`;

CREATE TABLE `tbl_module` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Module` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_module` */

insert  into `tbl_module`(`Id`,`Module`) values 
(1,'Dashboard'),
(2,'Sales'),
(3,'Settings'),
(4,'Production'),
(5,'Inventory'),
(6,'Expenses'),
(7,'Users'),
(8,'UserRoles'),
(9,'Units');

/*Table structure for table `tbl_position` */

DROP TABLE IF EXISTS `tbl_position`;

CREATE TABLE `tbl_position` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Position` varchar(100) DEFAULT NULL,
  `CreatedAt` datetime DEFAULT current_timestamp(),
  `UpdatedAt` datetime DEFAULT '0000-00-00 00:00:00',
  `Deleted` tinyint(1) DEFAULT 0,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbl_position` */

/*Table structure for table `tbl_product` */

DROP TABLE IF EXISTS `tbl_product`;

CREATE TABLE `tbl_product` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Image` longblob DEFAULT NULL,
  `Product` varchar(200) DEFAULT NULL,
  `WithAddon` tinyint(1) DEFAULT 0,
  `IsAvailable` tinyint(1) DEFAULT 1,
  `Type` varchar(100) DEFAULT NULL,
  `Price` decimal(10,2) DEFAULT 0.00,
  `Particulars` varchar(100) DEFAULT NULL,
  `Quality` varchar(100) DEFAULT NULL,
  `DateTimeStamp` datetime DEFAULT current_timestamp(),
  `DiscountPrice` decimal(10,2) DEFAULT 0.00,
  `DateDiscountEnd` date DEFAULT '0000-00-00',
  `UnitId` int(11) DEFAULT NULL,
  `Deleted` tinyint(1) DEFAULT 0,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_product` */

insert  into `tbl_product`(`Id`,`Image`,`Product`,`WithAddon`,`IsAvailable`,`Type`,`Price`,`Particulars`,`Quality`,`DateTimeStamp`,`DiscountPrice`,`DateDiscountEnd`,`UnitId`,`Deleted`) values 
(14,NULL,'CHOCO SLICE',1,1,'Production',150.00,'SLICE','CHOCO','2021-10-21 08:59:53',0.00,'0000-00-00',NULL,0),
(20,NULL,'SPRINKLES',0,1,'Addon',20.00,NULL,NULL,'2021-10-23 03:18:06',0.00,'0000-00-00',18,0),
(21,NULL,'DEDICATION',0,1,'Addon',30.00,NULL,NULL,'2021-10-23 05:16:43',0.00,'0000-00-00',0,0),
(22,NULL,'TEST 1',0,1,'Addon',100.00,NULL,NULL,'2021-10-23 05:32:35',0.00,'0000-00-00',0,1),
(23,NULL,'CHOCO LARGE',1,1,'Production',500.00,'LARGE','CHOCO','2021-10-23 07:25:40',0.00,'0000-00-00',NULL,0),
(24,NULL,'FOUNTAINS',0,1,'Addon',50.00,NULL,NULL,'2021-10-25 09:08:53',0.00,'0000-00-00',0,0),
(25,NULL,'MANGO JAM',0,1,'Production',20.00,'NONE','NONE','2021-10-25 09:09:59',0.00,'0000-00-00',NULL,0);

/*Table structure for table `tbl_product_sold` */

DROP TABLE IF EXISTS `tbl_product_sold`;

CREATE TABLE `tbl_product_sold` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `TransactionNo` varchar(200) DEFAULT NULL,
  `ProductId` int(11) DEFAULT NULL,
  `Qty` decimal(10,2) DEFAULT NULL,
  `Price` decimal(10,2) DEFAULT NULL,
  `SubTotal` decimal(10,2) DEFAULT NULL,
  `SoldStatus` varchar(10) DEFAULT 'SOLD',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=67 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_product_sold` */

insert  into `tbl_product_sold`(`Id`,`TransactionNo`,`ProductId`,`Qty`,`Price`,`SubTotal`,`SoldStatus`) values 
(25,'202110240505001',23,1.00,500.00,500.00,'CANCELLED'),
(26,'202110240505001',21,1.00,30.00,30.00,'CANCELLED'),
(27,'202110240505001',20,1.00,20.00,20.00,'CANCELLED'),
(28,'202110240652002',14,1.00,150.00,150.00,'CANCELLED'),
(29,'202110240652002',20,1.00,20.00,20.00,'CANCELLED'),
(30,'202110240652002',21,1.00,30.00,30.00,'CANCELLED'),
(31,'202110240652002',23,1.00,500.00,500.00,'CANCELLED'),
(32,'202110240652002',21,1.00,30.00,30.00,'CANCELLED'),
(33,'202110240652002',20,1.00,20.00,20.00,'CANCELLED'),
(34,'202110240715003',14,1.00,150.00,150.00,'CANCELLED'),
(35,'202110240715003',21,2.00,30.00,60.00,'CANCELLED'),
(36,'202110240715003',20,2.00,20.00,40.00,'CANCELLED'),
(37,'202110250826004',23,1.00,500.00,500.00,'SOLD'),
(38,'202110250826004',20,6.00,20.00,120.00,'SOLD'),
(39,'202110250826004',21,1.00,30.00,30.00,'SOLD'),
(40,'202110250829004',23,1.00,500.00,500.00,'SOLD'),
(41,'202110250829004',21,1.00,30.00,30.00,'SOLD'),
(42,'202110250829004',20,5.00,20.00,100.00,'SOLD'),
(43,'202110250833004',23,1.00,500.00,500.00,'SOLD'),
(44,'202110250833004',20,4.00,20.00,80.00,'SOLD'),
(45,'202110250835004',14,1.00,150.00,150.00,'SOLD'),
(46,'202110250835004',20,3.00,20.00,60.00,'SOLD'),
(47,'202110250835004',21,1.00,30.00,30.00,'SOLD'),
(48,'202110250839005',23,1.00,500.00,500.00,'SOLD'),
(49,'202110250839005',20,5.00,20.00,100.00,'SOLD'),
(50,'202110250843006',23,1.00,500.00,500.00,'SOLD'),
(51,'202110250843006',20,1.00,20.00,20.00,'SOLD'),
(52,'202110250856007',14,1.00,150.00,150.00,'CANCELLED'),
(53,'202110250856007',20,2.00,20.00,40.00,'CANCELLED'),
(54,'202110250856007',21,1.00,30.00,30.00,'CANCELLED'),
(55,'202110250857008',14,1.00,150.00,150.00,'CANCELLED'),
(56,'202110250857008',21,1.00,30.00,30.00,'CANCELLED'),
(57,'202110250857008',20,3.00,20.00,60.00,'CANCELLED'),
(58,'202110250912009',23,1.00,500.00,500.00,'CANCELLED'),
(59,'202110250912009',20,1.00,20.00,20.00,'CANCELLED'),
(60,'202110250912009',21,1.00,30.00,30.00,'CANCELLED'),
(61,'202110250912009',24,1.00,50.00,50.00,'CANCELLED'),
(62,'202110250912009',25,1.00,20.00,20.00,'CANCELLED'),
(63,'202110260329010',23,1.00,500.00,500.00,'SOLD'),
(64,'202110260329010',20,1.00,20.00,20.00,'SOLD'),
(65,'202110260329010',21,1.00,30.00,30.00,'SOLD'),
(66,'202110260329010',24,1.00,50.00,50.00,'SOLD');

/*Table structure for table `tbl_production_stockin` */

DROP TABLE IF EXISTS `tbl_production_stockin`;

CREATE TABLE `tbl_production_stockin` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `ProductId` int(11) DEFAULT NULL,
  `Status` varchar(100) DEFAULT 'pending',
  `Qty` decimal(10,2) DEFAULT NULL,
  `QtyDmg` decimal(10,2) DEFAULT 0.00,
  `QtyOnhand` decimal(10,2) DEFAULT 0.00,
  `DateStockin` datetime DEFAULT current_timestamp(),
  `UserId` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=40 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_production_stockin` */

insert  into `tbl_production_stockin`(`Id`,`ProductId`,`Status`,`Qty`,`QtyDmg`,`QtyOnhand`,`DateStockin`,`UserId`) values 
(37,14,'done',15.00,0.00,12.00,'2021-10-23 06:07:44',0),
(38,23,'done',10.00,0.00,6.00,'2021-10-23 07:26:26',0),
(39,25,'done',30.00,0.00,30.00,'2021-10-25 09:10:19',0);

/*Table structure for table `tbl_rawmat_stockin` */

DROP TABLE IF EXISTS `tbl_rawmat_stockin`;

CREATE TABLE `tbl_rawmat_stockin` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `RawmatId` int(11) DEFAULT NULL,
  `GrpUnitId` int(11) DEFAULT NULL,
  `Qty` decimal(10,2) DEFAULT 0.00,
  `QtyDmg` decimal(10,2) DEFAULT 0.00,
  `QtyOnhand` decimal(10,2) DEFAULT 0.00,
  `DateArrival` date DEFAULT '0000-00-00',
  `DateStockin` datetime DEFAULT current_timestamp(),
  `DateExpiry` date DEFAULT NULL,
  `UserId` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=92 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_rawmat_stockin` */

insert  into `tbl_rawmat_stockin`(`Id`,`RawmatId`,`GrpUnitId`,`Qty`,`QtyDmg`,`QtyOnhand`,`DateArrival`,`DateStockin`,`DateExpiry`,`UserId`) values 
(75,13,8,500.00,0.00,470.00,'2021-10-07','2021-10-07 12:15:35',NULL,NULL),
(76,14,12,500.00,0.00,458.00,'2021-10-07','2021-10-07 12:15:35',NULL,NULL),
(77,17,23,300.00,0.00,300.00,'2021-10-07','2021-10-07 12:15:35',NULL,NULL),
(78,11,24,1000.00,0.00,1000.00,'2021-10-07','2021-10-07 12:15:35','2022-10-07',NULL),
(79,12,26,1000.00,0.00,1000.00,'2021-10-07','2021-10-07 12:15:35',NULL,NULL),
(80,2,17,1000.00,0.00,780.00,'2021-10-07','2021-10-07 12:15:36',NULL,NULL),
(81,9,20,100.00,0.00,63.33,'2021-10-07','2021-10-07 12:15:36',NULL,NULL),
(82,16,27,300.00,0.00,300.00,'2021-10-07','2021-10-07 12:15:36',NULL,NULL),
(83,5,18,150.00,0.00,149.00,'2021-10-07','2021-10-07 12:15:36',NULL,NULL),
(84,19,22,153.00,0.00,142.00,'2021-10-07','2021-10-07 12:15:36',NULL,NULL),
(85,15,28,300.00,0.00,300.00,'2021-10-07','2021-10-07 12:15:37',NULL,NULL),
(86,20,32,10.00,0.00,10.00,'2021-10-07','2021-10-07 12:15:37',NULL,NULL),
(87,21,29,5.00,0.00,5.00,'2021-10-07','2021-10-07 12:15:37',NULL,NULL),
(88,1,1,100.00,0.00,11.33,'2021-10-07','2021-10-07 12:15:37',NULL,NULL),
(89,10,30,600.00,0.00,600.00,'2021-10-07','2021-10-07 12:15:37',NULL,NULL),
(90,4,16,600.00,0.00,480.00,'2021-10-07','2021-10-07 12:15:38',NULL,NULL),
(91,1,1,10.00,0.00,10.00,'2021-10-07','2021-10-07 14:29:30',NULL,NULL);

/*Table structure for table `tbl_recipe` */

DROP TABLE IF EXISTS `tbl_recipe`;

CREATE TABLE `tbl_recipe` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `ProductId` int(11) DEFAULT NULL,
  `RawmatId` int(11) DEFAULT NULL,
  `GrpUnitId` int(11) DEFAULT NULL,
  `Qty` decimal(10,2) DEFAULT NULL,
  `Deleted` tinyint(1) DEFAULT 0,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_recipe` */

insert  into `tbl_recipe`(`Id`,`ProductId`,`RawmatId`,`GrpUnitId`,`Qty`,`Deleted`) values 
(16,6,13,8,1.00,0),
(17,6,4,16,12.00,0),
(18,6,1,2,100.00,1),
(19,3,1,2,100.00,0),
(20,4,1,1,1.00,0),
(21,4,19,22,1.00,0),
(22,6,5,19,100.00,0),
(23,3,2,17,20.00,0),
(24,3,3,25,1.00,0),
(25,4,9,21,10.00,0),
(26,11,14,12,1.00,0),
(27,5,13,8,1.00,0),
(28,2,14,12,1.00,0),
(29,12,13,8,1.00,0),
(30,10,14,12,1.00,0),
(31,13,14,12,1.00,0),
(32,13,1,2,100.00,0),
(33,10,1,2,15.00,0);

/*Table structure for table `tbl_roles` */

DROP TABLE IF EXISTS `tbl_roles`;

CREATE TABLE `tbl_roles` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `PositionId` int(11) DEFAULT NULL,
  `ModuleId` int(11) DEFAULT NULL,
  `Read` tinyint(1) DEFAULT 0,
  `Update` tinyint(1) DEFAULT 0,
  `Create` tinyint(1) DEFAULT 0,
  `Delete` tinyint(1) DEFAULT 0,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_roles` */

/*Table structure for table `tbl_sale_transaction` */

DROP TABLE IF EXISTS `tbl_sale_transaction`;

CREATE TABLE `tbl_sale_transaction` (
  `TransactionNo` varchar(200) NOT NULL,
  `CustomerId` int(11) DEFAULT NULL,
  `DownPayment` decimal(10,2) DEFAULT 0.00,
  `Balance` decimal(10,2) DEFAULT 0.00,
  `Vat` decimal(10,2) DEFAULT 0.00,
  `SubTotal` decimal(10,2) DEFAULT 0.00,
  `TotalAmount` decimal(10,2) DEFAULT 0.00,
  `CashTendered` decimal(10,2) DEFAULT 0.00,
  `Change` decimal(10,2) DEFAULT 0.00,
  `TransactionDate` datetime DEFAULT current_timestamp(),
  `ReservationDate` datetime DEFAULT NULL,
  `ClaimStatus` varchar(10) DEFAULT NULL,
  `TransactionType` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`TransactionNo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbl_sale_transaction` */

insert  into `tbl_sale_transaction`(`TransactionNo`,`CustomerId`,`DownPayment`,`Balance`,`Vat`,`SubTotal`,`TotalAmount`,`CashTendered`,`Change`,`TransactionDate`,`ReservationDate`,`ClaimStatus`,`TransactionType`) values 
('202110240505001',3,550.00,0.00,58.93,491.07,550.00,1000.00,450.00,'2021-10-24 05:05:06','2021-10-24 05:04:42',NULL,'CANCELLED'),
('202110240652002',3,500.00,0.00,80.36,669.64,750.00,1250.00,750.00,'2021-10-24 06:52:43','2021-10-24 06:52:26',NULL,'CANCELLED'),
('202110240715003',4,250.00,0.00,26.79,223.21,250.00,500.00,250.00,'2021-10-24 07:15:25','2021-10-25 17:14:58',NULL,'CANCELLED'),
('202110250835004',0,0.00,0.00,25.71,214.29,240.00,500.00,260.00,'2021-10-25 08:35:50','0001-01-01 00:00:00',NULL,'WALK_IN'),
('202110250839005',0,0.00,0.00,64.29,535.71,600.00,550.00,-50.00,'2021-10-25 08:39:41','0001-01-01 00:00:00',NULL,'WALK_IN'),
('202110250843006',0,0.00,0.00,55.71,464.29,520.00,550.00,30.00,'2021-10-25 08:43:52','0001-01-01 00:00:00',NULL,'WALK_IN'),
('202110250856007',5,0.00,0.00,23.57,196.43,220.00,300.00,300.00,'2021-10-25 08:56:33','2021-10-25 10:56:16',NULL,'CANCELLED'),
('202110250857008',3,0.00,0.00,25.71,214.29,240.00,500.00,500.00,'2021-10-25 08:57:59','2021-10-25 08:57:49',NULL,'CANCELLED'),
('202110250912009',2,0.00,0.00,66.43,553.57,620.00,2000.00,1340.00,'2021-10-25 09:12:43','2021-10-25 09:11:44',NULL,'CANCELLED'),
('202110260329010',1,0.00,0.00,64.29,535.71,600.00,1000.00,1000.00,'2021-10-26 03:29:35','2021-10-26 03:28:53','CLAIMED','RESERVATION');

/*Table structure for table `tbl_unit` */

DROP TABLE IF EXISTS `tbl_unit`;

CREATE TABLE `tbl_unit` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `UnitCode` varchar(20) DEFAULT NULL,
  `UnitDesc` varchar(20) DEFAULT NULL,
  `Deleted` tinyint(1) DEFAULT 0,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_unit` */

insert  into `tbl_unit`(`Id`,`UnitCode`,`UnitDesc`,`Deleted`) values 
(1,'kg','kilogram',0),
(2,'pc','pieces',0),
(3,'item','Items',0),
(4,'g','grams',0),
(5,'roll','roll',0),
(6,'asd','asd',1),
(7,'asdq','asdq',1),
(8,'s1','s1',1),
(9,'test1','test1',1),
(10,'123','123',1),
(11,'tyestr','212',1),
(12,'asds','ddd',1),
(13,'test4','test4',1),
(14,'tank','tank',0),
(15,'ml','millilitre',0),
(16,'L','litre',0),
(17,'n/a','Not Applicable',0),
(18,'Scoop','Scoop',0);

/*Table structure for table `tbl_unitgroup` */

DROP TABLE IF EXISTS `tbl_unitgroup`;

CREATE TABLE `tbl_unitgroup` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `ProductId` int(11) DEFAULT NULL,
  `UnitId` int(11) DEFAULT NULL,
  `Qty` decimal(10,2) DEFAULT 0.00,
  `BaseUnit` tinyint(1) DEFAULT 0,
  `DisplayUnit` tinyint(1) DEFAULT 0,
  `Deleted` tinyint(1) DEFAULT 0,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_unitgroup` */

insert  into `tbl_unitgroup`(`Id`,`ProductId`,`UnitId`,`Qty`,`BaseUnit`,`DisplayUnit`,`Deleted`) values 
(1,1,1,1000.00,0,1,0),
(2,1,4,1.00,1,0,0),
(8,13,2,1.00,1,1,0),
(9,1,2,1000.00,0,0,1),
(10,1,3,100.00,0,0,1),
(11,13,3,25.00,0,0,1),
(12,14,2,1.00,1,1,0),
(13,14,1,500.00,0,0,1),
(14,14,5,12.00,0,0,1),
(15,23,4,1.00,0,0,0),
(16,4,3,1.00,1,1,0),
(17,2,2,1.00,1,1,0),
(18,5,16,1000.00,0,1,0),
(19,5,15,1.00,1,0,0),
(20,9,1,1000.00,0,1,0),
(21,9,4,1.00,1,0,0),
(22,19,5,1.00,1,1,0),
(23,17,2,1.00,1,1,0),
(24,11,2,1.00,1,1,0),
(25,3,2,1.00,1,1,0),
(26,12,2,1.00,1,1,0),
(27,16,2,1.00,1,1,0),
(28,15,2,1.00,1,1,0),
(29,21,14,1.00,1,1,0),
(30,10,1,1000.00,0,1,0),
(31,10,4,1.00,1,0,0),
(32,20,5,1.00,1,1,0),
(33,24,2,1.00,1,1,0);

/*Table structure for table `tbl_user` */

DROP TABLE IF EXISTS `tbl_user`;

CREATE TABLE `tbl_user` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `UserId` int(11) DEFAULT NULL,
  `Username` varchar(200) DEFAULT NULL,
  `Password` varchar(200) DEFAULT NULL,
  `DateTimeStamp` datetime DEFAULT current_timestamp(),
  `AccessRole` varchar(100) DEFAULT NULL,
  `Deleted` tinyint(1) DEFAULT 0,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbl_user` */

/* Function  structure for function  `getDisplayUnit` */

/*!50003 DROP FUNCTION IF EXISTS `getDisplayUnit` */;
DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` FUNCTION `getDisplayUnit`(`id` INT
) RETURNS varchar(20) CHARSET latin1
BEGIN
DECLARE unit VARCHAR(20);
SELECT UnitCode FROM units WHERE ProductId = id AND DisplayUnit = TRUE INTO unit;
RETURN(unit);
END */$$
DELIMITER ;

/* Function  structure for function  `stock_onhand` */

/*!50003 DROP FUNCTION IF EXISTS `stock_onhand` */;
DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` FUNCTION `stock_onhand`(`qtyP` decimal,
	`qtyV` DECIMAL,
	`id` integer
) RETURNS double
BEGIN
 DECLARE displayQty double;
 SELECT Qty FROM units WHERE ProductId = id AND DisplayUnit = TRUE INTO displayQty;
 RETURN ((qtyP * qtyV) / displayQty);
 END */$$
DELIMITER ;

/* Procedure structure for procedure `manage_unit` */

/*!50003 DROP PROCEDURE IF EXISTS  `manage_unit` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `manage_unit`(
	IN `transactionType` VARCHAR(50),
	IN `id` INT,
	IN `unitCode` VARCHAR(50),
	IN `unitDesc` VARCHAR(50)
)
BEGIN
	IF transactionType = 'insert' then 
			INSERT INTO tbl_unit (UnitCode, UnitDesc) VALUES (unitCode, unitDesc);
	
	ELSEIF transactionType = 'select' THEN
			IF id = 0 THEN 
				SELECT * FROM tbl_unit WHERE Deleted = false;
			ELSE 
				SELECT * FROM tbl_unit WHERE Id = id;			
			END IF;	
	ELSEIF transactionType = 'delete' THEN
			UPDATE tbl_unit SET Deleted = true WHERE Id = id;
	ELSEIF transactionType = 'update' THEN
			UPDATE tbl_unit SET UnitCode = unitCode, UnitDesc = unitDesc WHERE Id = id;
	END IF;
END */$$
DELIMITER ;

/*Table structure for table `production_stockin` */

DROP TABLE IF EXISTS `production_stockin`;

/*!50001 DROP VIEW IF EXISTS `production_stockin` */;
/*!50001 DROP TABLE IF EXISTS `production_stockin` */;

/*!50001 CREATE TABLE  `production_stockin`(
 `Id` int(11) ,
 `ProductId` int(11) ,
 `Product` varchar(200) ,
 `Image` longblob ,
 `Quality` varchar(100) ,
 `Particulars` varchar(100) ,
 `Qty` decimal(10,2) ,
 `QtyDmg` decimal(10,2) ,
 `QtyOnhand` decimal(10,2) ,
 `DateStockin` datetime ,
 `Status` varchar(100) 
)*/;

/*Table structure for table `product_inventory` */

DROP TABLE IF EXISTS `product_inventory`;

/*!50001 DROP VIEW IF EXISTS `product_inventory` */;
/*!50001 DROP TABLE IF EXISTS `product_inventory` */;

/*!50001 CREATE TABLE  `product_inventory`(
 `Id` int(11) ,
 `ProductId` int(11) ,
 `Product` varchar(200) ,
 `WithAddon` tinyint(1) ,
 `Type` varchar(100) ,
 `Image` longblob ,
 `Particulars` varchar(100) ,
 `Quality` varchar(100) ,
 `Price` decimal(10,2) ,
 `QtyOnhand` decimal(32,2) ,
 `QtyDmg` decimal(32,2) 
)*/;

/*Table structure for table `rawmat_inventory` */

DROP TABLE IF EXISTS `rawmat_inventory`;

/*!50001 DROP VIEW IF EXISTS `rawmat_inventory` */;
/*!50001 DROP TABLE IF EXISTS `rawmat_inventory` */;

/*!50001 CREATE TABLE  `rawmat_inventory`(
 `Id` int(11) ,
 `Product` varchar(100) ,
 `ReOrder` int(11) ,
 `Qty` double ,
 `DisplayUnit` varchar(20) 
)*/;

/*Table structure for table `rawmat_stockin` */

DROP TABLE IF EXISTS `rawmat_stockin`;

/*!50001 DROP VIEW IF EXISTS `rawmat_stockin` */;
/*!50001 DROP TABLE IF EXISTS `rawmat_stockin` */;

/*!50001 CREATE TABLE  `rawmat_stockin`(
 `Id` int(11) ,
 `RawmatId` int(11) ,
 `HasExpiry` tinyint(4) ,
 `Product` varchar(100) ,
 `Qty` decimal(10,2) ,
 `DisplayUnit` varchar(20) ,
 `DateArrival` date ,
 `DateStockin` datetime ,
 `DateExpiry` date 
)*/;

/*Table structure for table `recipes` */

DROP TABLE IF EXISTS `recipes`;

/*!50001 DROP VIEW IF EXISTS `recipes` */;
/*!50001 DROP TABLE IF EXISTS `recipes` */;

/*!50001 CREATE TABLE  `recipes`(
 `Id` int(11) ,
 `ProductId` int(11) ,
 `RawmatId` int(11) ,
 `GrpUnitId` int(11) ,
 `Product` varchar(100) ,
 `Qty` decimal(10,2) ,
 `UnitCode` varchar(20) ,
 `HasExpiry` tinyint(4) ,
 `BaseUnit` tinyint(1) 
)*/;

/*Table structure for table `units` */

DROP TABLE IF EXISTS `units`;

/*!50001 DROP VIEW IF EXISTS `units` */;
/*!50001 DROP TABLE IF EXISTS `units` */;

/*!50001 CREATE TABLE  `units`(
 `Id` int(11) ,
 `UnitId` int(11) ,
 `ProductId` int(11) ,
 `UnitCode` varchar(20) ,
 `DisplayUnit` tinyint(1) ,
 `BaseUnit` tinyint(1) ,
 `Qty` decimal(10,2) 
)*/;

/*View structure for view production_stockin */

/*!50001 DROP TABLE IF EXISTS `production_stockin` */;
/*!50001 DROP VIEW IF EXISTS `production_stockin` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `production_stockin` AS select `pr`.`Id` AS `Id`,`pr`.`ProductId` AS `ProductId`,`p`.`Product` AS `Product`,`p`.`Image` AS `Image`,`p`.`Quality` AS `Quality`,`p`.`Particulars` AS `Particulars`,`pr`.`Qty` AS `Qty`,`pr`.`QtyDmg` AS `QtyDmg`,`pr`.`QtyOnhand` AS `QtyOnhand`,`pr`.`DateStockin` AS `DateStockin`,`pr`.`Status` AS `Status` from (`tbl_production_stockin` `pr` left join `tbl_product` `p` on(`p`.`Id` = `pr`.`ProductId`)) order by `pr`.`DateStockin` desc */;

/*View structure for view product_inventory */

/*!50001 DROP TABLE IF EXISTS `product_inventory` */;
/*!50001 DROP VIEW IF EXISTS `product_inventory` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `product_inventory` AS select `pr`.`Id` AS `Id`,`pr`.`ProductId` AS `ProductId`,`p`.`Product` AS `Product`,`p`.`WithAddon` AS `WithAddon`,`p`.`Type` AS `Type`,`p`.`Image` AS `Image`,`p`.`Particulars` AS `Particulars`,`p`.`Quality` AS `Quality`,`p`.`Price` AS `Price`,sum(`pr`.`QtyOnhand`) AS `QtyOnhand`,sum(`pr`.`QtyDmg`) AS `QtyDmg` from (`tbl_production_stockin` `pr` left join `tbl_product` `p` on(`p`.`Id` = `pr`.`ProductId`)) where `pr`.`Status` = 'done' and `p`.`Type` = 'Production' group by `pr`.`ProductId` order by `p`.`Product` */;

/*View structure for view rawmat_inventory */

/*!50001 DROP TABLE IF EXISTS `rawmat_inventory` */;
/*!50001 DROP VIEW IF EXISTS `rawmat_inventory` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `rawmat_inventory` AS select `rms`.`RawmatId` AS `Id`,`rm`.`Product` AS `Product`,`rm`.`ReOrder` AS `ReOrder`,sum(`stock_onhand`(`rms`.`QtyOnhand`,`units`.`Qty`,`rms`.`RawmatId`)) AS `Qty`,`getDisplayUnit`(`rms`.`RawmatId`) AS `DisplayUnit` from ((`tbl_rawmat_stockin` `rms` left join `rawmaterial` `rm` on(`rm`.`Id` = `rms`.`RawmatId`)) left join `units` on(`units`.`Id` = `rms`.`GrpUnitId`)) group by `rms`.`RawmatId` order by `rm`.`Product` */;

/*View structure for view rawmat_stockin */

/*!50001 DROP TABLE IF EXISTS `rawmat_stockin` */;
/*!50001 DROP VIEW IF EXISTS `rawmat_stockin` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `rawmat_stockin` AS select `rms`.`Id` AS `Id`,`rms`.`RawmatId` AS `RawmatId`,`rm`.`HasExpiry` AS `HasExpiry`,`rm`.`Product` AS `Product`,`rms`.`QtyOnhand` AS `Qty`,`units`.`UnitCode` AS `DisplayUnit`,`rms`.`DateArrival` AS `DateArrival`,`rms`.`DateStockin` AS `DateStockin`,`rms`.`DateExpiry` AS `DateExpiry` from ((`tbl_rawmat_stockin` `rms` left join `rawmaterial` `rm` on(`rm`.`Id` = `rms`.`RawmatId`)) left join `units` on(`units`.`Id` = `rms`.`GrpUnitId`)) */;

/*View structure for view recipes */

/*!50001 DROP TABLE IF EXISTS `recipes` */;
/*!50001 DROP VIEW IF EXISTS `recipes` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `recipes` AS select `rc`.`Id` AS `Id`,`rc`.`ProductId` AS `ProductId`,`rc`.`RawmatId` AS `RawmatId`,`rc`.`GrpUnitId` AS `GrpUnitId`,`rm`.`Product` AS `Product`,`rc`.`Qty` AS `Qty`,`u`.`UnitCode` AS `UnitCode`,`rm`.`HasExpiry` AS `HasExpiry`,`u`.`BaseUnit` AS `BaseUnit` from ((`tbl_recipe` `rc` left join `rawmaterial` `rm` on(`rm`.`Id` = `rc`.`RawmatId`)) left join `units` `u` on(`u`.`Id` = `rc`.`GrpUnitId`)) where `rc`.`Deleted` = 0 */;

/*View structure for view units */

/*!50001 DROP TABLE IF EXISTS `units` */;
/*!50001 DROP VIEW IF EXISTS `units` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `units` AS select `gunit`.`Id` AS `Id`,`gunit`.`UnitId` AS `UnitId`,`gunit`.`ProductId` AS `ProductId`,`unit`.`UnitCode` AS `UnitCode`,`gunit`.`DisplayUnit` AS `DisplayUnit`,`gunit`.`BaseUnit` AS `BaseUnit`,`gunit`.`Qty` AS `Qty` from (`tbl_unitgroup` `gunit` left join `tbl_unit` `unit` on(`unit`.`Id` = `gunit`.`UnitId`)) where `gunit`.`Deleted` = 0 */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
