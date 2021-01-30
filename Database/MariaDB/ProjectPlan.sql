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
CREATE DATABASE IF NOT EXISTS `projectplan` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `projectplan`;

-- Dumping structure for table projectplan.projects
CREATE TABLE IF NOT EXISTS `projects` (
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

-- Dumping data for table projectplan.projects: ~0 rows (approximately)
/*!40000 ALTER TABLE `projects` DISABLE KEYS */;
/*!40000 ALTER TABLE `projects` ENABLE KEYS */;

-- Dumping structure for table projectplan.projectsmembers
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
	(7, 4, 'Cristian', 'Hasler', b'1', b'0');
/*!40000 ALTER TABLE `projectsmembers` ENABLE KEYS */;

-- Dumping structure for table projectplan.tasks
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

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
