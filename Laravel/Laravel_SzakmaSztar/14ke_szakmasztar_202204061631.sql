﻿--
-- Script was generated by Devart dbForge Studio 2020 for MySQL, Version 9.0.688.0
-- Product home page: http://www.devart.com/dbforge/mysql/studio
-- Script date 2022. 04. 06. 16:31:29
-- Server version: 10.4.21
-- Client version: 4.1
--

-- 
-- Disable foreign keys
-- 
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;

-- 
-- Set SQL mode
-- 
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- 
-- Set character set the client will use to send SQL statements to the server
--
SET NAMES 'utf8';

DROP DATABASE IF EXISTS `14ke_szakmasztar`;

CREATE DATABASE `14ke_szakmasztar`
	CHARACTER SET utf8mb4
	COLLATE utf8mb4_hungarian_ci;

--
-- Set default database
--
USE `14ke_szakmasztar`;

--
-- Create table `professions`
--
CREATE TABLE professions (
  id BIGINT(20) UNSIGNED NOT NULL AUTO_INCREMENT,
  name VARCHAR(100) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AUTO_INCREMENT = 6,
AVG_ROW_LENGTH = 3276,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_unicode_ci;

--
-- Create index `professions_name_unique` on table `professions`
--
ALTER TABLE professions 
  ADD UNIQUE INDEX professions_name_unique(name);

--
-- Create table `competitors`
--
CREATE TABLE competitors (
  id BIGINT(20) UNSIGNED NOT NULL AUTO_INCREMENT,
  professionId BIGINT(20) UNSIGNED NOT NULL,
  name VARCHAR(100) NOT NULL,
  schoolName VARCHAR(200) DEFAULT NULL,
  birthDate DATE DEFAULT NULL,
  hostel TINYINT(1) NOT NULL DEFAULT 1,
  avatarurl VARCHAR(100) DEFAULT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AUTO_INCREMENT = 19,
AVG_ROW_LENGTH = 963,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_unicode_ci;

--
-- Create foreign key
--
ALTER TABLE competitors 
  ADD CONSTRAINT competitors_professionid_foreign FOREIGN KEY (professionId)
    REFERENCES professions(id);

-- 
-- Dumping data for table professions
--
INSERT INTO professions VALUES
(5, ''),
(3, 'CAD-CAM informatikus'),
(4, 'Gépgyártástechnológiai technikus'),
(2, 'Informatikai rendszer és -alkalmazás üzemeltető'),
(1, 'Szoftverfejlesztő és -tesztelő');

-- 
-- Dumping data for table competitors
--
INSERT INTO competitors VALUES
(2, 1, 'Lukács Mónika', 'Győri Műszaki SZC Jedlik Ányos Gépipari és Informatikai Szakgimnáziuma, Szakközépiskolája és Kollégiuma', '2002-02-17', 1, 'https://robohash.org/accusamusconsequaturfugit.png?size=300x300&set=set5'),
(3, 1, 'Szűcs Sándor', 'Budapesti Műszaki SZC Puskás Tivadar Távközlési Technikum Infokommunikációs Szakgimnáziuma', '2003-08-09', 1, 'https://robohash.org/eaabsed.png?size=300x300&set=set5'),
(4, 2, 'Varga Imre', 'Szombathelyi Szolgáltatási SZC Horváth Boldizsár Közgazdasági és Informatikai Szakgimnáziuma', '2001-05-13', 1, 'https://robohash.org/mollitiasolutaeum.png?size=300x300&set=set5'),
(5, 2, 'Farkas József', 'Kecskeméti SZC Kandó Kálmán Szakgimnáziuma és Szakközépiskolája', '2002-12-21', 1, 'https://robohash.org/culpaquosvero.png?size=300x300&set=set5'),
(6, 2, 'Deák Eszter', 'Kecskeméti SZC Kandó Kálmán Szakgimnáziuma és Szakközépiskolája', '2002-07-12', 0, 'https://robohash.org/exercitationemdoloremquis.png?size=300x300&set=set5'),
(7, 3, 'Fazekas Norbert', 'Neumann János Gimnázium, Szakgimnázium és Kollégium', '2002-03-17', 1, 'https://robohash.org/voluptatemcommodiveniam.png?size=300x300&set=set5'),
(8, 3, 'Boros Krisztián', 'Békéscsabai SZC Gépészeti és Számítástechnikai Szakgimnáziuma és Kollégiuma', '2002-02-24', 1, 'https://robohash.org/etvelitdistinctio.png?size=300x300&set=set5'),
(9, 3, 'Kiss Károly', 'Budapesti Műszaki SZC Puskás Tivadar Távközlési Technikum Infokommunikációs Szakgimnáziuma', '2001-01-16', 1, 'https://robohash.org/sedconsecteturquae.png?size=300x300&set=set5'),
(10, 4, 'Fülöp Zsuzsanna', 'Győri Műszaki SZC Jedlik Ányos Gépipari és Informatikai Szakgimnáziuma, Szakközépiskolája és Kollégiuma', '2001-05-05', 1, 'https://robohash.org/autemquiaducimus.png?size=300x300&set=set5'),
(11, 4, 'Szilágyi Viktória', 'Nyíregyházi SZC Széchenyi István Közgazdasági, Informatikai Szakgimnáziuma és Kollégiuma', '2002-03-25', 1, 'https://robohash.org/minusinrerum.png?size=300x300&set=set5'),
(12, 4, 'Sipos Tímea', 'Kecskeméti SZC Kandó Kálmán Szakgimnáziuma és Szakközépiskolája', '2003-03-16', 0, 'https://robohash.org/quamautipsum.png?size=300x300&set=set5'),
(13, 5, 'Papp Szabolcs', 'Kecskeméti SZC Kandó Kálmán Szakgimnáziuma és Szakközépiskolája', '2001-02-01', 1, 'https://robohash.org/doloresetvoluptatem.png?size=300x300&set=set5'),
(14, 5, 'Gulyás János', 'Budapesti Műszaki SZC Puskás Tivadar Távközlési Technikum Infokommunikációs Szakgimnáziuma', '2001-09-20', 1, 'https://robohash.org/nequearchitectonihil.png?size=300x300&set=set5'),
(15, 5, 'Fodor Sándor', 'Győri Műszaki SZC Jedlik Ányos Gépipari és Informatikai Szakgimnáziuma, Szakközépiskolája és Kollégiuma', '2003-03-15', 1, 'https://robohash.org/dignissimosdeseruntenim.png?size=300x300&set=set5'),
(16, 1, 'Teszt Elek', 'Jedlik', '2003-02-27', 1, NULL),
(17, 1, 'Teszt Elek', 'Jedlik', '2003-02-27', 1, NULL),
(18, 1, 'Teszt Elek', 'Jedlik', '2003-02-27', 1, NULL);

-- 
-- Restore previous SQL mode
-- 
/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;

-- 
-- Enable foreign keys
-- 
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;