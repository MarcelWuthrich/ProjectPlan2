-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.2.36-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             11.0.0.5919
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Dumping database structure for projectplan
DROP DATABASE IF EXISTS `projectplan`;
CREATE DATABASE IF NOT EXISTS `projectplan` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `projectplan`;

-- Dumping structure for table projectplan.adminresources
DROP TABLE IF EXISTS `adminresources`;
CREATE TABLE IF NOT EXISTS `adminresources` (
  `ID_AdminResource` int(11) NOT NULL,
  `AdminResource` text DEFAULT NULL,
  `Enable` bit(1) DEFAULT NULL,
  `Symbol` varchar(5) DEFAULT NULL,
  `DisplayOrder` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID_AdminResource`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping data for table projectplan.adminresources: ~0 rows (approximately)
/*!40000 ALTER TABLE `adminresources` DISABLE KEYS */;
/*!40000 ALTER TABLE `adminresources` ENABLE KEYS */;

-- Dumping structure for table projectplan.customers
DROP TABLE IF EXISTS `customers`;
CREATE TABLE IF NOT EXISTS `customers` (
  `ID_Customer` int(11) NOT NULL,
  `FirstName` text DEFAULT NULL,
  `LastName` text DEFAULT NULL,
  `Enable` bit(1) DEFAULT NULL,
  `DisplayOrder` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID_Customer`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping data for table projectplan.customers: ~2 rows (approximately)
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
INSERT INTO `customers` (`ID_Customer`, `FirstName`, `LastName`, `Enable`, `DisplayOrder`) VALUES
	(1, 'Sébastien', 'Charmillot', b'1', 1),
	(2, 'Cristian', 'Hasler', b'1', 2),
	(3, 'Jean-Luc', 'Gyger', b'1', 3);
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;

-- Dumping structure for table projectplan.executedresources
DROP TABLE IF EXISTS `executedresources`;
CREATE TABLE IF NOT EXISTS `executedresources` (
  `ID_Resource` int(11) NOT NULL,
  `CE_ID_ProjectMember` int(11) DEFAULT NULL,
  `CE_ID_Project` int(11) DEFAULT NULL,
  `CE_ID_AdminResource` int(11) DEFAULT NULL,
  `PlanDate` date DEFAULT NULL,
  `HalfDay` int(11) DEFAULT NULL,
  `Timestamp` datetime DEFAULT NULL,
  PRIMARY KEY (`ID_Resource`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping data for table projectplan.executedresources: ~0 rows (approximately)
/*!40000 ALTER TABLE `executedresources` DISABLE KEYS */;
/*!40000 ALTER TABLE `executedresources` ENABLE KEYS */;

-- Dumping structure for table projectplan.planresources
DROP TABLE IF EXISTS `planresources`;
CREATE TABLE IF NOT EXISTS `planresources` (
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

-- Dumping data for table projectplan.planresources: ~0 rows (approximately)
/*!40000 ALTER TABLE `planresources` DISABLE KEYS */;
/*!40000 ALTER TABLE `planresources` ENABLE KEYS */;

-- Dumping structure for table projectplan.projectcategories
DROP TABLE IF EXISTS `projectcategories`;
CREATE TABLE IF NOT EXISTS `projectcategories` (
  `ID_Category` int(11) NOT NULL,
  `Category` text DEFAULT NULL,
  `Enable` bit(1) DEFAULT NULL,
  `DisplayOrder` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID_Category`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping data for table projectplan.projectcategories: ~2 rows (approximately)
/*!40000 ALTER TABLE `projectcategories` DISABLE KEYS */;
INSERT INTO `projectcategories` (`ID_Category`, `Category`, `Enable`, `DisplayOrder`) VALUES
	(1, 'Développement', b'1', 1),
	(2, 'Consulting', b'1', 2),
	(3, 'Vente', b'1', 3);
/*!40000 ALTER TABLE `projectcategories` ENABLE KEYS */;

-- Dumping structure for table projectplan.projectestimatedresources
DROP TABLE IF EXISTS `projectestimatedresources`;
CREATE TABLE IF NOT EXISTS `projectestimatedresources` (
  `ID_Resource` int(11) NOT NULL,
  `CE_ID_Project` int(11) DEFAULT NULL,
  `CE_ID_Task` int(11) DEFAULT NULL,
  `EstimatedResource` int(11) DEFAULT NULL,
  `CreationDate` datetime NOT NULL,
  `LastModifyDate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table projectplan.projectestimatedresources: ~0 rows (approximately)
/*!40000 ALTER TABLE `projectestimatedresources` DISABLE KEYS */;
INSERT INTO `projectestimatedresources` (`ID_Resource`, `CE_ID_Project`, `CE_ID_Task`, `EstimatedResource`, `CreationDate`, `LastModifyDate`) VALUES
	(1, 7, 2, 7, '2020-11-22 13:28:42', '2020-11-22 14:44:04'),
	(2, 7, 1, 3, '2020-11-22 13:29:43', '2020-11-22 14:19:43'),
	(3, 7, 4, 2, '2020-11-22 13:39:18', '2020-11-22 14:46:34'),
	(4, 7, 3, 1, '2020-11-22 14:47:32', '2020-11-22 14:47:32');
/*!40000 ALTER TABLE `projectestimatedresources` ENABLE KEYS */;

-- Dumping structure for table projectplan.projectmanagers
DROP TABLE IF EXISTS `projectmanagers`;
CREATE TABLE IF NOT EXISTS `projectmanagers` (
  `ID_ProjectManager` int(11) NOT NULL,
  `FirstName` text DEFAULT NULL,
  `LastName` text DEFAULT NULL,
  `Enable` bit(1) DEFAULT NULL,
  PRIMARY KEY (`ID_ProjectManager`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping data for table projectplan.projectmanagers: ~2 rows (approximately)
/*!40000 ALTER TABLE `projectmanagers` DISABLE KEYS */;
INSERT INTO `projectmanagers` (`ID_ProjectManager`, `FirstName`, `LastName`, `Enable`) VALUES
	(1, 'Marcel', 'Wüthrich', b'1'),
	(2, 'Jean-Luc', 'Gyger', b'1');
/*!40000 ALTER TABLE `projectmanagers` ENABLE KEYS */;

-- Dumping structure for table projectplan.projectpriority
DROP TABLE IF EXISTS `projectpriority`;
CREATE TABLE IF NOT EXISTS `projectpriority` (
  `ID_Priority` int(11) NOT NULL,
  `Priority` text DEFAULT NULL,
  `Enable` bit(1) DEFAULT NULL,
  `DisplayOrder` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID_Priority`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping data for table projectplan.projectpriority: ~5 rows (approximately)
/*!40000 ALTER TABLE `projectpriority` DISABLE KEYS */;
INSERT INTO `projectpriority` (`ID_Priority`, `Priority`, `Enable`, `DisplayOrder`) VALUES
	(1, 'Urgent', b'1', 1),
	(2, 'Important', b'1', 2),
	(3, 'Moyen', b'1', 3),
	(4, 'Basse', b'1', 4),
	(5, 'Très basse', b'1', 5);
/*!40000 ALTER TABLE `projectpriority` ENABLE KEYS */;

-- Dumping structure for table projectplan.projects
DROP TABLE IF EXISTS `projects`;
CREATE TABLE IF NOT EXISTS `projects` (
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

-- Dumping data for table projectplan.projects: ~9 rows (approximately)
/*!40000 ALTER TABLE `projects` DISABLE KEYS */;
INSERT INTO `projects` (`ID_Project`, `CE_ID_Status`, `CE_ID_ProjectManager`, `CE_ID_Priority`, `CE_ID_Category`, `CE_ID_Customer`, `CE_ID_Urgency`, `Title`, `Description`, `BeginDate`, `Deadline`, `EstimatedResources`, `ImplementationRate`, `EffectiveResources`) VALUES
	(1, 1, 1, 3, 2, 2, 2, 'Windows migration', 'Windows Migration', '2020-11-19', '2020-12-31', 100, 0, 0),
	(2, 3, 2, 1, 1, 1, 2, 'Installation chez Hasler', 'Installation chez Hasler', '2020-11-21', '2020-12-31', 20, 0, 0),
	(3, 1, 1, 3, 1, 3, 2, 'Formation chez AFT', '', '2020-11-16', '2020-12-01', 0, 0, 0),
	(4, 1, 1, 3, 2, 3, 2, 'vysual chez ColorCentre', '', '2020-11-01', '2021-01-01', 0, 0, 0),
	(5, 1, 2, 1, 3, 2, 1, 't43wt43tfr43', '', '2020-11-21', '2020-11-21', 0, 0, 0),
	(6, 1, 2, 1, 1, 3, 1, 'ewfwefewf', '', '2020-11-21', '2020-11-21', 0, 0, 0),
	(7, 1, 1, 2, 1, 1, 1, 'wfewfewfewfew', '', '2020-11-21', '2020-11-21', 13, 0, 0),
	(8, 0, 0, 0, 0, 3, 0, 'wefw', 'fewfewf', '2020-11-21', '2020-11-21', 0, 0, 0),
	(9, 1, 0, 0, 0, 0, 0, 'erg', 'ergerg', '2020-11-21', '2020-11-21', 0, 0, 0),
	(10, 0, 1, 0, 3, 3, 0, 'wfewf', 'fewff', '2020-11-22', '2020-11-22', 0, 0, 0);
/*!40000 ALTER TABLE `projects` ENABLE KEYS */;

-- Dumping structure for table projectplan.projectshistory
DROP TABLE IF EXISTS `projectshistory`;
CREATE TABLE IF NOT EXISTS `projectshistory` (
  `ID_History` int(11) NOT NULL,
  `CE_ID_Project` int(11) DEFAULT NULL,
  `ModifyBy` text DEFAULT NULL,
  `ModifyDate` datetime DEFAULT NULL,
  `Modification` text DEFAULT NULL,
  PRIMARY KEY (`ID_History`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping data for table projectplan.projectshistory: ~2 rows (approximately)
/*!40000 ALTER TABLE `projectshistory` DISABLE KEYS */;
INSERT INTO `projectshistory` (`ID_History`, `CE_ID_Project`, `ModifyBy`, `ModifyDate`, `Modification`) VALUES
	(0, 7, '', '2020-11-22 14:47:49', 'old estimated resources <12> new estimated resources <13> ; '),
	(1, 1, 'wum', '2020-11-21 16:34:00', 'wfwefewfewf');
/*!40000 ALTER TABLE `projectshistory` ENABLE KEYS */;

-- Dumping structure for table projectplan.projectsmembers
DROP TABLE IF EXISTS `projectsmembers`;
CREATE TABLE IF NOT EXISTS `projectsmembers` (
  `ID_ProjectMember` int(11) NOT NULL,
  `CE_ID_Task` int(11) NOT NULL,
  `FirstName` text CHARACTER SET latin1 NOT NULL DEFAULT '',
  `LastName` text CHARACTER SET latin1 NOT NULL DEFAULT '',
  `Enable` bit(1) NOT NULL DEFAULT b'0',
  `IsDelete` bit(1) NOT NULL DEFAULT b'0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping data for table projectplan.projectsmembers: ~7 rows (approximately)
/*!40000 ALTER TABLE `projectsmembers` DISABLE KEYS */;
INSERT INTO `projectsmembers` (`ID_ProjectMember`, `CE_ID_Task`, `FirstName`, `LastName`, `Enable`, `IsDelete`) VALUES
	(1, 2, 'Marcel', 'Wüthrich', b'1', b'0'),
	(2, 1, 'Jean-Luc', 'Gyger', b'1', b'0'),
	(3, 1, 'Andres', 'Delgado', b'1', b'0'),
	(4, 1, 'Julien', 'Stadler', b'1', b'0'),
	(5, 3, 'Patrick', 'Léchot', b'1', b'0'),
	(6, 4, 'Sébastien', 'Charmillot', b'1', b'0'),
	(7, 4, 'Cristian', 'Hasler', b'1', b'0'),
	(8, 2, 'Roger', 'Moore', b'1', b'0');
/*!40000 ALTER TABLE `projectsmembers` ENABLE KEYS */;

-- Dumping structure for table projectplan.projectsremarks
DROP TABLE IF EXISTS `projectsremarks`;
CREATE TABLE IF NOT EXISTS `projectsremarks` (
  `ID_Remark` int(11) NOT NULL,
  `CE_ID_Project` int(11) DEFAULT NULL,
  `CreationDate` datetime DEFAULT NULL,
  `LastModifyDate` datetime DEFAULT NULL,
  `Remark` text DEFAULT NULL,
  PRIMARY KEY (`ID_Remark`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping data for table projectplan.projectsremarks: ~0 rows (approximately)
/*!40000 ALTER TABLE `projectsremarks` DISABLE KEYS */;
/*!40000 ALTER TABLE `projectsremarks` ENABLE KEYS */;

-- Dumping structure for table projectplan.status
DROP TABLE IF EXISTS `status`;
CREATE TABLE IF NOT EXISTS `status` (
  `ID_Status` int(11) NOT NULL,
  `Status` text DEFAULT NULL,
  `Enable` bit(1) DEFAULT NULL,
  `DisplayOrder` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID_Status`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping data for table projectplan.status: ~2 rows (approximately)
/*!40000 ALTER TABLE `status` DISABLE KEYS */;
INSERT INTO `status` (`ID_Status`, `Status`, `Enable`, `DisplayOrder`) VALUES
	(1, 'Saisi', b'1', 1),
	(2, 'Abandonné', b'0', 2),
	(3, 'Transmis\r\n', b'1', 3);
/*!40000 ALTER TABLE `status` ENABLE KEYS */;

-- Dumping structure for table projectplan.tasks
DROP TABLE IF EXISTS `tasks`;
CREATE TABLE IF NOT EXISTS `tasks` (
  `ID_Task` int(11) NOT NULL,
  `Task` varchar(100) CHARACTER SET utf8 DEFAULT NULL,
  `Enable` bit(1) DEFAULT NULL,
  `DisplayOrder` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table projectplan.tasks: ~3 rows (approximately)
/*!40000 ALTER TABLE `tasks` DISABLE KEYS */;
INSERT INTO `tasks` (`ID_Task`, `Task`, `Enable`, `DisplayOrder`) VALUES
	(1, 'Développement', b'1', 1),
	(2, 'Consulting', b'1', 2),
	(3, 'Vente', b'1', 3),
	(4, 'Direction', b'1', 4);
/*!40000 ALTER TABLE `tasks` ENABLE KEYS */;

-- Dumping structure for table projectplan.urgencies
DROP TABLE IF EXISTS `urgencies`;
CREATE TABLE IF NOT EXISTS `urgencies` (
  `ID_Urgency` int(11) NOT NULL,
  `Urgency` text DEFAULT NULL,
  `Enable` bit(1) DEFAULT NULL,
  `DisplayOrder` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID_Urgency`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping data for table projectplan.urgencies: ~2 rows (approximately)
/*!40000 ALTER TABLE `urgencies` DISABLE KEYS */;
INSERT INTO `urgencies` (`ID_Urgency`, `Urgency`, `Enable`, `DisplayOrder`) VALUES
	(1, 'Basse', b'1', 1),
	(2, 'Moyenne', b'1', 2),
	(3, 'Haute', b'1', 3);
/*!40000 ALTER TABLE `urgencies` ENABLE KEYS */;

-- Dumping structure for view projectplan.vprojectlist
DROP VIEW IF EXISTS `vprojectlist`;
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `vprojectlist` (
	`ID_Project` INT(11) NOT NULL,
	`CE_ID_Status` INT(11) NULL,
	`Status` TEXT(65535) NULL COLLATE 'utf8_general_ci',
	`CE_ID_ProjectManager` INT(11) NULL,
	`ManagerFirstname` TEXT(65535) NULL COLLATE 'utf8_general_ci',
	`ManagerLastname` TEXT(65535) NULL COLLATE 'utf8_general_ci',
	`CE_ID_Priority` INT(11) NULL,
	`Priority` TEXT(65535) NULL COLLATE 'utf8_general_ci',
	`CE_ID_Category` INT(11) NULL,
	`Category` TEXT(65535) NULL COLLATE 'utf8_general_ci',
	`CE_ID_Customer` INT(11) NULL,
	`CustomerFirstname` TEXT(65535) NULL COLLATE 'utf8_general_ci',
	`CustomerLastname` TEXT(65535) NULL COLLATE 'utf8_general_ci',
	`CE_ID_Urgency` INT(11) NULL,
	`Urgency` TEXT(65535) NULL COLLATE 'utf8_general_ci',
	`Title` VARCHAR(200) NULL COLLATE 'latin1_general_ci',
	`Description` TEXT(65535) NULL COLLATE 'latin1_general_ci',
	`BeginDate` DATE NULL,
	`Deadline` DATE NULL,
	`EstimatedResources` DECIMAL(10,0) NULL,
	`ImplementationRate` DECIMAL(6,0) NULL,
	`EffectiveResources` DECIMAL(10,0) NULL
) ENGINE=MyISAM;

-- Dumping structure for view projectplan.vprojectlist
DROP VIEW IF EXISTS `vprojectlist`;
-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `vprojectlist`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `vprojectlist` AS SELECT
    `projects`.`ID_Project`
    , `projects`.`CE_ID_Status`
    , `status`.`Status`
    , `projects`.`CE_ID_ProjectManager`
    , `projectmanagers`.`FirstName` AS `ManagerFirstname`
    , `projectmanagers`.`LastName` AS `ManagerLastname`
    , `projects`.`CE_ID_Priority`
    , `projectpriority`.`Priority`
    , `projects`.`CE_ID_Category`
    , `projectcategories`.`Category`
    , `projects`.`CE_ID_Customer`
    , `customers`.`FirstName` AS `CustomerFirstname`
    , `customers`.`LastName` AS `CustomerLastname`
    , `projects`.`CE_ID_Urgency`
    , `urgencies`.`Urgency`
    , `projects`.`Title`
    , `projects`.`Description`
    , `projects`.`BeginDate`
    , `projects`.`Deadline`
    , `projects`.`EstimatedResources`
    , `projects`.`ImplementationRate`
    , `projects`.`EffectiveResources`
FROM
    `ProjectPlan`.`projects`
    LEFT JOIN `ProjectPlan`.`status` 
        ON (`projects`.`CE_ID_Status` = `status`.`ID_Status`)
    LEFT JOIN `ProjectPlan`.`projectmanagers` 
        ON (`projects`.`CE_ID_ProjectManager` = `projectmanagers`.`ID_ProjectManager`)
    LEFT JOIN `ProjectPlan`.`projectpriority` 
        ON (`projects`.`CE_ID_Priority` = `projectpriority`.`ID_Priority`)
    LEFT JOIN `ProjectPlan`.`projectcategories` 
        ON (`projects`.`CE_ID_Category` = `projectcategories`.`ID_Category`)
    LEFT JOIN `ProjectPlan`.`customers` 
        ON (`projects`.`CE_ID_Customer` = `customers`.`ID_Customer`)
    LEFT JOIN `ProjectPlan`.`urgencies` 
        ON (`projects`.`CE_ID_Urgency` = `urgencies`.`ID_Urgency`) ;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
