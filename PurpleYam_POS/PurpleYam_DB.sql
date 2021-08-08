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
  `Deleted` tinyint(1) DEFAULT 0,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=latin1;

/*Data for the table `rawmaterial` */

insert  into `rawmaterial`(`Id`,`Product`,`CreatedAt`,`Deleted`) values 
(1,'Sugar','2021-07-12 01:04:00',0),
(2,'Egg','2021-07-15 10:30:50',0),
(3,'Dry Premix','2021-07-15 10:53:13',0),
(4,'Wet Premix','2021-07-15 10:53:25',0),
(5,'Oil','2021-07-15 10:58:00',0),
(6,'Yeast','2021-07-15 14:25:15',0),
(7,'Butter','2021-07-17 05:03:10',0),
(8,'Test 1','2021-07-17 05:18:53',0),
(9,'Food Color','2021-07-18 23:50:46',0),
(10,'Ube Powder','2021-07-18 23:51:03',0),
(11,'Condensed Milk','2021-07-18 23:52:59',0),
(12,'Evaporated Milk','2021-07-18 23:53:14',0),
(13,'Box Big','2021-07-18 23:53:21',0),
(14,'Box Small','2021-07-18 23:53:28',0),
(15,'Round Tin Cans','2021-07-18 23:53:38',0),
(16,'Heart Cans','2021-07-18 23:53:53',0),
(17,'Candles','2021-07-18 23:54:02',0),
(18,'News print','2021-07-18 23:54:10',0),
(19,'Ribbon','2021-07-18 23:54:20',0),
(20,'Scotch tape','2021-07-18 23:54:28',0),
(21,'Solane','2021-07-18 23:54:42',0),
(22,'test','2021-07-21 20:19:54',0);

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
  `Product` varchar(200) DEFAULT NULL,
  `Particulars` varchar(100) DEFAULT NULL,
  `Quality` varchar(100) DEFAULT NULL,
  `CreatedAt` datetime DEFAULT current_timestamp(),
  `UpdatedAt` datetime DEFAULT '0000-00-00 00:00:00',
  `Deleted` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbl_product` */

/*Table structure for table `tbl_recipies` */

DROP TABLE IF EXISTS `tbl_recipies`;

CREATE TABLE `tbl_recipies` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `ProductId` int(11) DEFAULT NULL,
  `RawmatId` int(11) DEFAULT NULL,
  `Qty` decimal(10,2) DEFAULT NULL,
  `GrpUnitId` int(11) DEFAULT NULL,
  `Deleted` tinyint(1) DEFAULT 0,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbl_recipies` */

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

/*Table structure for table `tbl_unit` */

DROP TABLE IF EXISTS `tbl_unit`;

CREATE TABLE `tbl_unit` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `UnitCode` varchar(20) DEFAULT NULL,
  `UnitDesc` varchar(20) DEFAULT NULL,
  `Deleted` tinyint(1) DEFAULT 0,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_unit` */

insert  into `tbl_unit`(`Id`,`UnitCode`,`UnitDesc`,`Deleted`) values 
(1,'kg','kilogram',0),
(2,'pc','pieces',0),
(3,'item','Items',0),
(4,'g','grams',0),
(5,'s','s',0),
(6,'asd','asd',0),
(7,'asdq','asdq',0),
(8,'s1','s1',0),
(9,'test1','test1',0),
(10,'123','123',0),
(11,'tyestr','212',0),
(12,'asds','ddd',0),
(13,'test4','test4',0);

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
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_unitgroup` */

insert  into `tbl_unitgroup`(`Id`,`ProductId`,`UnitId`,`Qty`,`BaseUnit`,`DisplayUnit`,`Deleted`) values 
(1,1,1,1000.00,0,1,0),
(2,1,4,1.00,1,0,0),
(8,13,2,1.00,1,0,0),
(9,1,2,1000.00,0,0,1),
(10,1,3,100.00,0,0,1),
(11,13,3,25.00,0,1,0),
(12,14,4,1.00,0,0,0),
(13,14,1,500.00,0,0,0),
(14,14,5,12.00,0,0,0);

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

/*View structure for view units */

/*!50001 DROP TABLE IF EXISTS `units` */;
/*!50001 DROP VIEW IF EXISTS `units` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `units` AS select `gunit`.`Id` AS `Id`,`gunit`.`UnitId` AS `UnitId`,`gunit`.`ProductId` AS `ProductId`,`unit`.`UnitCode` AS `UnitCode`,`gunit`.`DisplayUnit` AS `DisplayUnit`,`gunit`.`BaseUnit` AS `BaseUnit`,`gunit`.`Qty` AS `Qty` from (`tbl_unitgroup` `gunit` left join `tbl_unit` `unit` on(`unit`.`Id` = `gunit`.`UnitId`)) where `gunit`.`Deleted` = 0 */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
