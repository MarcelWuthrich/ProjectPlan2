/*
SQLyog Trial v13.1.6 (64 bit)
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

/*Table structure for table `projects` */

DROP TABLE IF EXISTS `projects`;

CREATE TABLE `projects` (
  `ID_Project` int(11) NOT NULL,
  `CE_ID_Key` int(11) DEFAULT NULL,
  `CE_ID_Status` int(11) DEFAULT NULL,
  `CE_ID_ProjectManager` int(11) DEFAULT NULL,
  `CE_ID_Priority` int(11) DEFAULT NULL,
  `CE_ID_Category` int(11) DEFAULT NULL,
  `CE_ID_Customer` int(11) DEFAULT NULL,
  `CE_ID_Urgency` int(11) DEFAULT NULL,
  `Title` text CHARACTER SET latin1 COLLATE latin1_general_ci DEFAULT NULL,
  `Description` text CHARACTER SET latin1 COLLATE latin1_general_ci DEFAULT NULL,
  `BeginDate` datetime DEFAULT NULL,
  `Deadline` datetime DEFAULT NULL,
  `EstimatedResources` int(11) DEFAULT NULL,
  `ImplementationRate` decimal(6,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `projects` */

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

/*Table structure for table `projectsmembers` */

DROP TABLE IF EXISTS `projectsmembers`;

CREATE TABLE `projectsmembers` (
  `ID_ProjectMember` int(11) NOT NULL,
  `CE_ID_Task` int(11) NOT NULL,
  `FirstName` text CHARACTER SET latin1 NOT NULL DEFAULT '',
  `LastName` text CHARACTER SET latin1 NOT NULL DEFAULT '',
  `Enable` bit(1) NOT NULL DEFAULT b'0',
  `IsDelete` bit(1) NOT NULL DEFAULT b'0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*Data for the table `projectsmembers` */

insert  into `projectsmembers`(`ID_ProjectMember`,`CE_ID_Task`,`FirstName`,`LastName`,`Enable`,`IsDelete`) values 
(1,2,'Marcel','Wüthrich','','\0'),
(2,1,'Jean-Luc','Gyger','','\0'),
(3,1,'Andres','Delgado','','\0'),
(4,1,'Julien','Stadler','','\0'),
(5,3,'Patrick','Léchot','','\0'),
(6,4,'Sébastien','Charmillot','','\0'),
(7,4,'Cristian','Hasler','','\0');

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
(1,'Développement','',1),
(2,'Consulting','',2),
(3,'Vente','',3),
(4,'Direction','',4);

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

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
