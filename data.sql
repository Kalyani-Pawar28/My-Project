-- MySQL dump 10.13  Distrib 5.5.62, for Win64 (AMD64)
--
-- Host: localhost    Database: health
-- ------------------------------------------------------
-- Server version	5.5.62

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `doctor`
--

DROP TABLE IF EXISTS `doctor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `doctor` (
  `doctorid` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(200) DEFAULT NULL,
  `passwordhash` varchar(200) DEFAULT NULL,
  `name` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`doctorid`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `doctor`
--

LOCK TABLES `doctor` WRITE;
/*!40000 ALTER TABLE `doctor` DISABLE KEYS */;
INSERT INTO `doctor` VALUES (1,'doctor1','*0FBE0D6792F0AE70274988BC01947F55E35917D9','Doctor One');
/*!40000 ALTER TABLE `doctor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patient`
--

DROP TABLE IF EXISTS `patient`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `patient` (
  `patientid` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(200) DEFAULT NULL,
  `passwordhash` varchar(200) DEFAULT NULL,
  `minbpm` int(11) DEFAULT NULL,
  `maxbpm` int(11) DEFAULT NULL,
  `mintemp` float DEFAULT NULL,
  `maxtemp` float DEFAULT NULL,
  `token` varchar(200) DEFAULT NULL,
  `name` varchar(200) DEFAULT NULL,
  `email` varchar(200) DEFAULT NULL,
  `dob` varchar(200) DEFAULT NULL,
  `contact` varchar(200) DEFAULT NULL,
  `address` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`patientid`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patient`
--

LOCK TABLES `patient` WRITE;
/*!40000 ALTER TABLE `patient` DISABLE KEYS */;
INSERT INTO `patient` VALUES (1,'patient1','*B0AEDAC591F0CFB4F0E8D013BCB290AB204BF2F3',60,100,95,100,'s1Xruk000T','Patient One','patient1@gmail.com','1/1/2000','9822000000','Solapur'),(2,'patient1','*B0AEDAC591F0CFB4F0E8D013BCB290AB204BF2F3',80,110,97,101,NULL,'Patient Two','patient2@gmail.com','1/1/2001','9822000001','Solapur');
/*!40000 ALTER TABLE `patient` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patientdata`
--

DROP TABLE IF EXISTS `patientdata`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `patientdata` (
  `patientdataid` int(11) NOT NULL AUTO_INCREMENT,
  `patientid` int(11) DEFAULT NULL,
  `datetime` datetime DEFAULT NULL,
  `pulse` int(11) DEFAULT NULL,
  `temp` float DEFAULT NULL,
  `isnormal` int(11) DEFAULT NULL,
  PRIMARY KEY (`patientdataid`)
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patientdata`
--

LOCK TABLES `patientdata` WRITE;
/*!40000 ALTER TABLE `patientdata` DISABLE KEYS */;
INSERT INTO `patientdata` VALUES (10,1,'2021-04-10 11:13:36',62,98.74,1),(11,1,'2021-04-10 11:13:37',82,98.57,1),(12,1,'2021-04-10 11:13:38',75,95.69,1),(13,1,'2021-04-10 11:13:39',61,100.6,0),(14,1,'2021-04-10 11:13:40',91,99.39,1),(15,1,'2021-04-10 11:13:41',97,98.68,1),(16,1,'2021-04-10 11:13:42',85,95.1,1),(17,1,'2021-04-10 11:13:43',68,95.25,1),(18,1,'2021-04-10 11:13:44',78,100.86,0),(19,1,'2021-04-10 11:13:45',84,99.72,1),(20,1,'2021-04-10 11:13:46',70,95.76,1),(21,1,'2021-04-10 11:13:47',97,95.15,1),(22,1,'2021-04-10 11:13:48',85,99.82,1),(23,1,'2021-04-10 11:13:49',83,95.09,1),(24,1,'2021-04-10 11:13:50',67,96.09,1),(25,1,'2021-04-10 11:13:51',83,99.04,1),(26,1,'2021-04-10 11:13:52',97,97.19,1),(27,1,'2021-04-10 11:13:54',84,97.16,1),(28,1,'2021-04-10 11:13:55',69,99.61,1),(29,1,'2021-04-10 11:13:56',65,98.12,1),(30,1,'2021-04-10 11:13:57',68,97.97,1),(31,1,'2021-04-10 11:13:58',80,99.32,1),(32,1,'2021-04-10 11:13:59',93,96.46,1),(33,1,'2021-04-10 11:14:00',62,97.81,1),(34,1,'2021-04-10 11:14:01',63,99.86,1);
/*!40000 ALTER TABLE `patientdata` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-04-10 19:03:23
