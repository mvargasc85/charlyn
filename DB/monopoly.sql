CREATE DATABASE  IF NOT EXISTS `monopoly` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `monopoly`;
-- MySQL dump 10.13  Distrib 5.5.16, for Win32 (x86)
--
-- Host: localhost    Database: monopoly
-- ------------------------------------------------------
-- Server version	5.0.51b-community-nt

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
-- Not dumping tablespaces as no INFORMATION_SCHEMA.FILES table on this server
--

--
-- Table structure for table `configuracion`
--

DROP TABLE IF EXISTS `configuracion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `configuracion` (
  `pararmetro` varchar(45) NOT NULL,
  `valor` varchar(45) NOT NULL,
  PRIMARY KEY  (`pararmetro`),
  UNIQUE KEY `pararmetro_UNIQUE` (`pararmetro`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `configuracion`
--

LOCK TABLES `configuracion` WRITE;
/*!40000 ALTER TABLE `configuracion` DISABLE KEYS */;
/*!40000 ALTER TABLE `configuracion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `historicopartida`
--

DROP TABLE IF EXISTS `historicopartida`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `historicopartida` (
  `idpartida` int(11) NOT NULL,
  `idjugador` int(11) NOT NULL,
  `Puntuacion` int(11) default NULL,
  `PosicionActual` varchar(45) NOT NULL,
  `color` varchar(45) NOT NULL,
  PRIMARY KEY  (`idpartida`,`idjugador`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `historicopartida`
--

LOCK TABLES `historicopartida` WRITE;
/*!40000 ALTER TABLE `historicopartida` DISABLE KEYS */;
INSERT INTO `historicopartida` VALUES (1,1,40000,'0','Rojo'),(1,2,50000,'0','Azul'),(11,1,13000,'16','Verde'),(11,2,26000,'25','Naranja'),(12,1,36000,'8','Turqueza'),(12,2,35000,'5','Morado');
/*!40000 ALTER TABLE `historicopartida` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jugador`
--

DROP TABLE IF EXISTS `jugador`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `jugador` (
  `idjugador` int(11) NOT NULL auto_increment,
  `nombre` varchar(45) NOT NULL,
  `fecha` datetime default NULL,
  `puntuacion` int(11) NOT NULL,
  `color` varchar(45) NOT NULL,
  PRIMARY KEY  (`idjugador`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jugador`
--

LOCK TABLES `jugador` WRITE;
/*!40000 ALTER TABLE `jugador` DISABLE KEYS */;
INSERT INTO `jugador` VALUES (1,'Charlyn','2016-05-07 22:37:55',0,'Rojo'),(2,'Magaly','2016-05-07 23:01:36',0,'Azul'),(4,'Rocio','2016-05-08 17:46:56',0,'Amarillo'),(5,'felicia','2016-05-08 19:35:56',0,'rojo'),(6,'victor','2016-05-09 19:17:29',0,'Turqueza'),(10,'Efren','2016-05-24 14:31:27',0,'Azul'),(11,'ferch','2016-05-24 15:02:36',0,'Verde'),(12,'Isa','2016-05-24 17:24:33',0,'Naranja'),(13,'felicia','2016-05-27 20:36:15',0,'Morado'),(14,'Milton','2016-06-03 15:27:58',0,'');
/*!40000 ALTER TABLE `jugador` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `partida`
--

DROP TABLE IF EXISTS `partida`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `partida` (
  `idpartida` int(11) NOT NULL auto_increment,
  `nombrePartida` varchar(45) default NULL,
  `ganador` int(11) default '0',
  `fecha` datetime NOT NULL,
  PRIMARY KEY  (`idpartida`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `partida`
--

LOCK TABLES `partida` WRITE;
/*!40000 ALTER TABLE `partida` DISABLE KEYS */;
INSERT INTO `partida` VALUES (1,'pruba1',0,'2016-05-22 14:13:00'),(2,'Partida de prueba',0,'2016-06-08 18:57:33'),(3,'Partida de prueba',0,'2016-06-08 19:46:09'),(4,'Partida de prueba',0,'2016-06-08 20:06:50'),(5,'Partida de prueba',0,'2016-06-08 21:39:21'),(6,'Partida de prueba',0,'2016-06-08 22:27:48'),(7,'Partida de prueba',0,'2016-06-08 22:55:37'),(8,'Partida de prueba',0,'2016-06-08 22:57:50'),(9,'Partida de prueba',0,'2016-06-08 23:00:49'),(10,'Partida de prueba',0,'2016-06-08 23:07:07'),(11,'Partida de prueba',0,'2016-06-08 23:21:40'),(12,'Partida de prueba',0,'2016-06-09 00:30:31'),(13,'Partida de prueba',2,'2016-06-09 03:31:22');
/*!40000 ALTER TABLE `partida` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `propiedad`
--

DROP TABLE IF EXISTS `propiedad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `propiedad` (
  `idpropiedad` int(11) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `valorCompra` float NOT NULL,
  `valorPeaje` float NOT NULL,
  `propietario` int(11) default NULL,
  PRIMARY KEY  (`idpropiedad`),
  UNIQUE KEY `nombre_UNIQUE` (`nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `propiedad`
--

LOCK TABLES `propiedad` WRITE;
/*!40000 ALTER TABLE `propiedad` DISABLE KEYS */;
/*!40000 ALTER TABLE `propiedad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `registropropiedad`
--

DROP TABLE IF EXISTS `registropropiedad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `registropropiedad` (
  `idjugador` int(11) NOT NULL,
  `idpropiedad` int(11) NOT NULL,
  `idpartida` int(11) NOT NULL,
  PRIMARY KEY  (`idjugador`,`idpropiedad`,`idpartida`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `registropropiedad`
--

LOCK TABLES `registropropiedad` WRITE;
/*!40000 ALTER TABLE `registropropiedad` DISABLE KEYS */;
INSERT INTO `registropropiedad` VALUES (1,4,11),(1,5,4),(1,5,8),(1,7,4),(1,7,5),(1,7,7),(1,7,10),(1,8,2),(1,8,12),(1,12,6),(1,12,7),(1,12,9),(1,14,2),(1,15,2),(1,15,7),(1,16,8),(1,16,11),(1,17,5),(1,17,8),(1,22,2),(1,23,6),(1,23,9),(1,24,5),(1,24,10),(1,29,2),(1,30,2),(1,30,6),(1,32,10),(2,2,10),(2,3,9),(2,5,2),(2,5,11),(2,5,12),(2,6,2),(2,7,6),(2,10,4),(2,10,10),(2,12,8),(2,12,11),(2,16,6),(2,19,2),(2,20,6),(2,20,9),(2,21,10),(2,23,8),(2,25,8),(2,25,11),(2,26,2),(2,26,7),(2,29,6),(2,29,10),(2,32,2),(2,35,7);
/*!40000 ALTER TABLE `registropropiedad` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-06-09  8:06:10
