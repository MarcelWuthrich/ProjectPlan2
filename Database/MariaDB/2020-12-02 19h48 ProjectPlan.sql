/*
SQLyog Ultimate v13.1.7 (64 bit)
MySQL - 10.2.36-MariaDB : Database - ProjectPlan
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`ProjectPlan` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `ProjectPlan`;

/*Table structure for table `adminresources` */

DROP TABLE IF EXISTS `adminresources`;

CREATE TABLE `adminresources` (
  `ID_AdminResource` int(11) NOT NULL,
  `AdminResource` text DEFAULT NULL,
  `Enable` bit(1) DEFAULT NULL,
  `Symbol` varchar(5) DEFAULT NULL,
  `DisplayOrder` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID_AdminResource`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `adminresources` */

/*Table structure for table `customers` */

DROP TABLE IF EXISTS `customers`;

CREATE TABLE `customers` (
  `ID_Customer` int(11) NOT NULL,
  `FirstName` text DEFAULT NULL,
  `LastName` text DEFAULT NULL,
  `Enable` bit(1) DEFAULT NULL,
  `DisplayOrder` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID_Customer`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `customers` */

insert  into `customers`(`ID_Customer`,`FirstName`,`LastName`,`Enable`,`DisplayOrder`) values 
(1,'Sébastien','Charmillot','',1),
(2,'Cristian','Hasler','',2),
(3,'Jean-Luc','Gyger','',3);

/*Table structure for table `executedresources` */

DROP TABLE IF EXISTS `executedresources`;

CREATE TABLE `executedresources` (
  `ID_Resource` int(11) NOT NULL,
  `CE_ID_ProjectMember` int(11) DEFAULT NULL,
  `CE_ID_Project` int(11) DEFAULT NULL,
  `CE_ID_AdminResource` int(11) DEFAULT NULL,
  `PlanDate` date DEFAULT NULL,
  `HalfDay` int(11) DEFAULT NULL,
  `Timestamp` datetime DEFAULT NULL,
  PRIMARY KEY (`ID_Resource`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `executedresources` */

/*Table structure for table `planresources` */

DROP TABLE IF EXISTS `planresources`;

CREATE TABLE `planresources` (
  `ID_Resource` int(11) NOT NULL,
  `CE_ID_ProjectMember` int(11) DEFAULT NULL,
  `CE_ID_Project` int(11) DEFAULT NULL,
  `CE_ID_AdminResource` int(11) DEFAULT NULL,
  `PlanDate` date DEFAULT NULL,
  `HalfDay` int(11) DEFAULT NULL,
  `Blocked` bit(1) DEFAULT NULL,
  `Remark` text DEFAULT NULL,
  PRIMARY KEY (`ID_Resource`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `planresources` */

/*Table structure for table `projectcategories` */

DROP TABLE IF EXISTS `projectcategories`;

CREATE TABLE `projectcategories` (
  `ID_Category` int(11) NOT NULL,
  `Category` text DEFAULT NULL,
  `Enable` bit(1) DEFAULT NULL,
  `DisplayOrder` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID_Category`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `projectcategories` */

insert  into `projectcategories`(`ID_Category`,`Category`,`Enable`,`DisplayOrder`) values 
(1,'Développement','',1),
(2,'Consulting','',2),
(3,'Vente','',3);

/*Table structure for table `projectestimatedresources` */

DROP TABLE IF EXISTS `projectestimatedresources`;

CREATE TABLE `projectestimatedresources` (
  `ID_Resource` int(11) NOT NULL,
  `CE_ID_Project` int(11) DEFAULT NULL,
  `CE_ID_Task` int(11) DEFAULT NULL,
  `EstimatedResource` int(11) DEFAULT NULL,
  `CreationDate` datetime NOT NULL,
  `LastModifyDate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `projectestimatedresources` */

insert  into `projectestimatedresources`(`ID_Resource`,`CE_ID_Project`,`CE_ID_Task`,`EstimatedResource`,`CreationDate`,`LastModifyDate`) values 
(1,7,2,7,'2020-11-22 13:28:42','2020-11-22 14:44:04'),
(2,7,1,3,'2020-11-22 13:29:43','2020-11-22 14:19:43'),
(3,7,4,2,'2020-11-22 13:39:18','2020-11-22 14:46:34'),
(4,7,3,1,'2020-11-22 14:47:32','2020-11-22 14:47:32');

/*Table structure for table `projectmanagers` */

DROP TABLE IF EXISTS `projectmanagers`;

CREATE TABLE `projectmanagers` (
  `ID_ProjectManager` int(11) NOT NULL,
  `FirstName` text DEFAULT NULL,
  `LastName` text DEFAULT NULL,
  `Enable` bit(1) DEFAULT NULL,
  PRIMARY KEY (`ID_ProjectManager`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `projectmanagers` */

insert  into `projectmanagers`(`ID_ProjectManager`,`FirstName`,`LastName`,`Enable`) values 
(1,'Marcel','Wüthrich',''),
(2,'Jean-Luc','Gyger','');

/*Table structure for table `projectpriority` */

DROP TABLE IF EXISTS `projectpriority`;

CREATE TABLE `projectpriority` (
  `ID_Priority` int(11) NOT NULL,
  `Priority` text DEFAULT NULL,
  `Enable` bit(1) DEFAULT NULL,
  `DisplayOrder` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID_Priority`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `projectpriority` */

insert  into `projectpriority`(`ID_Priority`,`Priority`,`Enable`,`DisplayOrder`) values 
(1,'Urgent','',1),
(2,'Important','',2),
(3,'Moyen','',3),
(4,'Basse','',4),
(5,'Très basse','',5);

/*Table structure for table `projects` */

DROP TABLE IF EXISTS `projects`;

CREATE TABLE `projects` (
  `ID_Project` int(11) NOT NULL,
  `CE_ID_Status` int(11) DEFAULT NULL,
  `CE_ID_ProjectManager` int(11) DEFAULT NULL,
  `CE_ID_Priority` int(11) DEFAULT NULL,
  `CE_ID_Category` int(11) DEFAULT NULL,
  `CE_ID_Customer` int(11) DEFAULT NULL,
  `CE_ID_Urgency` int(11) DEFAULT NULL,
  `Title` varchar(200) CHARACTER SET latin1 COLLATE latin1_general_ci DEFAULT NULL,
  `Description` text CHARACTER SET latin1 COLLATE latin1_general_ci DEFAULT NULL,
  `BeginDate` date DEFAULT NULL,
  `Deadline` date DEFAULT NULL,
  `EstimatedResources` decimal(10,0) DEFAULT NULL,
  `ImplementationRate` decimal(6,0) DEFAULT NULL,
  `EffectiveResources` decimal(10,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `projects` */

insert  into `projects`(`ID_Project`,`CE_ID_Status`,`CE_ID_ProjectManager`,`CE_ID_Priority`,`CE_ID_Category`,`CE_ID_Customer`,`CE_ID_Urgency`,`Title`,`Description`,`BeginDate`,`Deadline`,`EstimatedResources`,`ImplementationRate`,`EffectiveResources`) values 
(1,1,1,3,2,2,2,'Windows migration','Windows Migration','2020-11-19','2020-12-31',100,0,0),
(2,3,2,1,1,1,2,'Installation chez Hasler','Installation chez Hasler','2020-11-21','2020-12-31',20,0,0),
(3,1,1,3,1,3,2,'Formation chez AFT','','2020-11-16','2020-12-01',0,0,0),
(4,1,1,3,2,3,2,'vysual chez ColorCentre','','2020-11-01','2021-01-01',0,0,0),
(5,1,2,1,3,2,1,'t43wt43tfr43','','2020-11-21','2020-11-21',0,0,0),
(6,1,2,1,1,3,1,'ewfwefewf','','2020-11-21','2020-11-21',0,0,0),
(7,1,1,2,1,1,1,'wfewfewfewfew','','2020-11-21','2020-11-21',13,0,0),
(8,0,0,0,0,3,0,'wefw','fewfewf','2020-11-21','2020-11-21',0,0,0),
(9,1,0,0,0,0,0,'erg','ergerg','2020-11-21','2020-11-21',0,0,0),
(10,0,1,0,3,3,0,'wfewf','fewff','2020-11-22','2020-11-22',0,0,0);

/*Table structure for table `projectshistory` */

DROP TABLE IF EXISTS `projectshistory`;

CREATE TABLE `projectshistory` (
  `ID_History` int(11) NOT NULL,
  `CE_ID_Project` int(11) DEFAULT NULL,
  `ModifyBy` text DEFAULT NULL,
  `ModifyDate` datetime DEFAULT NULL,
  `Modification` text DEFAULT NULL,
  PRIMARY KEY (`ID_History`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `projectshistory` */

insert  into `projectshistory`(`ID_History`,`CE_ID_Project`,`ModifyBy`,`ModifyDate`,`Modification`) values 
(0,7,'','2020-11-22 14:47:49','old estimated resources <12> new estimated resources <13> ; '),
(1,1,'wum','2020-11-21 16:34:00','wfwefewfewf');

/*Table structure for table `projectsmembers` */

DROP TABLE IF EXISTS `projectsmembers`;

CREATE TABLE `projectsmembers` (
  `ID_ProjectMember` int(11) NOT NULL,
  `CE_ID_Task` int(11) DEFAULT NULL,
  `FirstName` text CHARACTER SET latin1 DEFAULT NULL,
  `LastName` text CHARACTER SET latin1 DEFAULT NULL,
  `Enable` bit(1) DEFAULT NULL,
  `IsDelete` bit(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `projectsmembers` */

insert  into `projectsmembers`(`ID_ProjectMember`,`CE_ID_Task`,`FirstName`,`LastName`,`Enable`,`IsDelete`) values 
(1,2,'Marcel','Wüthrich','','\0'),
(2,2,'Jean-Luc','Gyger','\0','\0'),
(3,1,'Andres','Delgado','','\0'),
(4,4,'Julien','Stadler','\0','\0'),
(5,3,'Patrick','Léchot','','\0'),
(6,4,'Sébastien','Charmillot','','\0'),
(7,4,'Cristian','Hasler','','\0'),
(8,3,'Roger','Moore','','\0');

/*Table structure for table `projectsremarks` */

DROP TABLE IF EXISTS `projectsremarks`;

CREATE TABLE `projectsremarks` (
  `ID_Remark` int(11) NOT NULL,
  `CE_ID_Project` int(11) DEFAULT NULL,
  `CreationDate` datetime DEFAULT NULL,
  `LastModifyDate` datetime DEFAULT NULL,
  `Remark` text DEFAULT NULL,
  PRIMARY KEY (`ID_Remark`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `projectsremarks` */

/*Table structure for table `status` */

DROP TABLE IF EXISTS `status`;

CREATE TABLE `status` (
  `ID_Status` int(11) NOT NULL,
  `Status` text DEFAULT NULL,
  `Enable` bit(1) DEFAULT NULL,
  `DisplayOrder` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID_Status`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `status` */

insert  into `status`(`ID_Status`,`Status`,`Enable`,`DisplayOrder`) values 
(1,'Saisi','',1),
(2,'Abandonné','\0',2),
(3,'Transmis\r\n','',3);

/*Table structure for table `tasks` */

DROP TABLE IF EXISTS `tasks`;

CREATE TABLE `tasks` (
  `ID_Task` int(11) NOT NULL,
  `Task` varchar(100) CHARACTER SET utf8 DEFAULT NULL,
  `Enable` bit(1) DEFAULT NULL,
  `DisplayOrder` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tasks` */

insert  into `tasks`(`ID_Task`,`Task`,`Enable`,`DisplayOrder`) values 
(1,'Développement','',2),
(2,'Consulting','',1),
(3,'Vente','',4),
(4,'Direction','',3),
(5,'Partenariat','\0',99);

/*Table structure for table `urgencies` */

DROP TABLE IF EXISTS `urgencies`;

CREATE TABLE `urgencies` (
  `ID_Urgency` int(11) NOT NULL,
  `Urgency` text DEFAULT NULL,
  `Enable` bit(1) DEFAULT NULL,
  `DisplayOrder` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID_Urgency`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `urgencies` */

insert  into `urgencies`(`ID_Urgency`,`Urgency`,`Enable`,`DisplayOrder`) values 
(1,'Basse','',1),
(2,'Moyenne','',2),
(3,'Haute','',3);

/*Table structure for table `vprojectestimatedresources` */

DROP TABLE IF EXISTS `vprojectestimatedresources`;

/*!50001 DROP VIEW IF EXISTS `vprojectestimatedresources` */;
/*!50001 DROP TABLE IF EXISTS `vprojectestimatedresources` */;

/*!50001 CREATE TABLE  `vprojectestimatedresources`(
 `ID_Resource` int(11) ,
 `CE_ID_Project` int(11) ,
 `CE_ID_Task` int(11) ,
 `Task` varchar(100) ,
 `EstimatedResource` int(11) ,
 `CreationDate` datetime ,
 `LastModifyDate` datetime 
)*/;

/*Table structure for table `vprojectlist` */

DROP TABLE IF EXISTS `vprojectlist`;

/*!50001 DROP VIEW IF EXISTS `vprojectlist` */;
/*!50001 DROP TABLE IF EXISTS `vprojectlist` */;

/*!50001 CREATE TABLE  `vprojectlist`(
 `ID_Project` int(11) ,
 `CE_ID_Status` int(11) ,
 `Status` text ,
 `CE_ID_ProjectManager` int(11) ,
 `ManagerFirstname` text ,
 `ManagerLastname` text ,
 `CE_ID_Priority` int(11) ,
 `Priority` text ,
 `CE_ID_Category` int(11) ,
 `Category` text ,
 `CE_ID_Customer` int(11) ,
 `CustomerFirstname` text ,
 `CustomerLastname` text ,
 `CE_ID_Urgency` int(11) ,
 `Urgency` text ,
 `Title` varchar(200) ,
 `Description` text ,
 `BeginDate` date ,
 `Deadline` date ,
 `EstimatedResources` decimal(10,0) ,
 `ImplementationRate` decimal(6,0) ,
 `EffectiveResources` decimal(10,0) 
)*/;

/*Table structure for table `vprojectmanagers` */

DROP TABLE IF EXISTS `vprojectmanagers`;

/*!50001 DROP VIEW IF EXISTS `vprojectmanagers` */;
/*!50001 DROP TABLE IF EXISTS `vprojectmanagers` */;

/*!50001 CREATE TABLE  `vprojectmanagers`(
 `ID_ProjectManager` int(11) ,
 `FirstName` text ,
 `LastName` text ,
 `Enable` bit(1) 
)*/;

/*Table structure for table `vprojectmembers` */

DROP TABLE IF EXISTS `vprojectmembers`;

/*!50001 DROP VIEW IF EXISTS `vprojectmembers` */;
/*!50001 DROP TABLE IF EXISTS `vprojectmembers` */;

/*!50001 CREATE TABLE  `vprojectmembers`(
 `ID_ProjectMember` int(11) ,
 `CE_ID_Task` int(11) ,
 `Task` varchar(100) ,
 `FirstName` text ,
 `LastName` text ,
 `Enable` bit(1) 
)*/;

/*Table structure for table `vtasks` */

DROP TABLE IF EXISTS `vtasks`;

/*!50001 DROP VIEW IF EXISTS `vtasks` */;
/*!50001 DROP TABLE IF EXISTS `vtasks` */;

/*!50001 CREATE TABLE  `vtasks`(
 `ID_Task` int(11) ,
 `Task` varchar(100) ,
 `Enable` bit(1) ,
 `DisplayOrder` int(11) 
)*/;

/*View structure for view vprojectestimatedresources */

/*!50001 DROP TABLE IF EXISTS `vprojectestimatedresources` */;
/*!50001 DROP VIEW IF EXISTS `vprojectestimatedresources` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vprojectestimatedresources` AS select `projectestimatedresources`.`ID_Resource` AS `ID_Resource`,`projectestimatedresources`.`CE_ID_Project` AS `CE_ID_Project`,`projectestimatedresources`.`CE_ID_Task` AS `CE_ID_Task`,`tasks`.`Task` AS `Task`,`projectestimatedresources`.`EstimatedResource` AS `EstimatedResource`,`projectestimatedresources`.`CreationDate` AS `CreationDate`,`projectestimatedresources`.`LastModifyDate` AS `LastModifyDate` from (`projectestimatedresources` left join `tasks` on(`projectestimatedresources`.`CE_ID_Task` = `tasks`.`ID_Task`)) */;

/*View structure for view vprojectlist */

/*!50001 DROP TABLE IF EXISTS `vprojectlist` */;
/*!50001 DROP VIEW IF EXISTS `vprojectlist` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vprojectlist` AS select `projects`.`ID_Project` AS `ID_Project`,`projects`.`CE_ID_Status` AS `CE_ID_Status`,`status`.`Status` AS `Status`,`projects`.`CE_ID_ProjectManager` AS `CE_ID_ProjectManager`,`projectmanagers`.`FirstName` AS `ManagerFirstname`,`projectmanagers`.`LastName` AS `ManagerLastname`,`projects`.`CE_ID_Priority` AS `CE_ID_Priority`,`projectpriority`.`Priority` AS `Priority`,`projects`.`CE_ID_Category` AS `CE_ID_Category`,`projectcategories`.`Category` AS `Category`,`projects`.`CE_ID_Customer` AS `CE_ID_Customer`,`customers`.`FirstName` AS `CustomerFirstname`,`customers`.`LastName` AS `CustomerLastname`,`projects`.`CE_ID_Urgency` AS `CE_ID_Urgency`,`urgencies`.`Urgency` AS `Urgency`,`projects`.`Title` AS `Title`,`projects`.`Description` AS `Description`,`projects`.`BeginDate` AS `BeginDate`,`projects`.`Deadline` AS `Deadline`,`projects`.`EstimatedResources` AS `EstimatedResources`,`projects`.`ImplementationRate` AS `ImplementationRate`,`projects`.`EffectiveResources` AS `EffectiveResources` from ((((((`projects` left join `status` on(`projects`.`CE_ID_Status` = `status`.`ID_Status`)) left join `projectmanagers` on(`projects`.`CE_ID_ProjectManager` = `projectmanagers`.`ID_ProjectManager`)) left join `projectpriority` on(`projects`.`CE_ID_Priority` = `projectpriority`.`ID_Priority`)) left join `projectcategories` on(`projects`.`CE_ID_Category` = `projectcategories`.`ID_Category`)) left join `customers` on(`projects`.`CE_ID_Customer` = `customers`.`ID_Customer`)) left join `urgencies` on(`projects`.`CE_ID_Urgency` = `urgencies`.`ID_Urgency`)) */;

/*View structure for view vprojectmanagers */

/*!50001 DROP TABLE IF EXISTS `vprojectmanagers` */;
/*!50001 DROP VIEW IF EXISTS `vprojectmanagers` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vprojectmanagers` AS select `projectmanagers`.`ID_ProjectManager` AS `ID_ProjectManager`,`projectmanagers`.`FirstName` AS `FirstName`,`projectmanagers`.`LastName` AS `LastName`,`projectmanagers`.`Enable` AS `Enable` from `projectmanagers` */;

/*View structure for view vprojectmembers */

/*!50001 DROP TABLE IF EXISTS `vprojectmembers` */;
/*!50001 DROP VIEW IF EXISTS `vprojectmembers` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vprojectmembers` AS select `projectsmembers`.`ID_ProjectMember` AS `ID_ProjectMember`,`projectsmembers`.`CE_ID_Task` AS `CE_ID_Task`,`tasks`.`Task` AS `Task`,`projectsmembers`.`FirstName` AS `FirstName`,`projectsmembers`.`LastName` AS `LastName`,`projectsmembers`.`Enable` AS `Enable` from (`projectsmembers` left join `tasks` on(`projectsmembers`.`CE_ID_Task` = `tasks`.`ID_Task`)) */;

/*View structure for view vtasks */

/*!50001 DROP TABLE IF EXISTS `vtasks` */;
/*!50001 DROP VIEW IF EXISTS `vtasks` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vtasks` AS select `tasks`.`ID_Task` AS `ID_Task`,`tasks`.`Task` AS `Task`,`tasks`.`Enable` AS `Enable`,`tasks`.`DisplayOrder` AS `DisplayOrder` from `tasks` order by `tasks`.`DisplayOrder` */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
