/*
SQLyog Community v13.1.9 (64 bit)
MySQL - 10.4.22-MariaDB : Database - stand_minuman
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`stand_minuman` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;

USE `stand_minuman`;

/*Table structure for table `dtrans` */

DROP TABLE IF EXISTS `dtrans`;

CREATE TABLE `dtrans` (
  `no_nota` varchar(50) NOT NULL,
  `id_minuman` double NOT NULL,
  `id_topping` double NOT NULL DEFAULT 1,
  `jumlah` double NOT NULL,
  `subtotal` double NOT NULL,
  `status` int(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (`no_nota`,`id_minuman`,`id_topping`),
  KEY `id_minuman` (`id_minuman`),
  KEY `id_topping` (`id_topping`),
  CONSTRAINT `dtrans_ibfk_1` FOREIGN KEY (`no_nota`) REFERENCES `htrans` (`no_nota`),
  CONSTRAINT `dtrans_ibfk_2` FOREIGN KEY (`id_minuman`) REFERENCES `minuman` (`id_minuman`),
  CONSTRAINT `dtrans_ibfk_3` FOREIGN KEY (`id_topping`) REFERENCES `topping` (`id_topping`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `dtrans` */

insert  into `dtrans`(`no_nota`,`id_minuman`,`id_topping`,`jumlah`,`subtotal`,`status`) values 
('H2205120001',1,1,2,20000,1),
('H2205120002',2,2,1,14000,1),
('H2205120003',2,1,2,24000,1),
('H2205120003',2,2,1,14000,1),
('H2205120003',3,3,1,18000,1),
('H2205140001',1,1,2,20000,1),
('H2205140001',2,2,1,14000,1),
('H2205140001',3,1,1,15000,1),
('H2205140002',2,2,1,14000,1),
('H2205140003',3,1,1,15000,1),
('H2205140003',3,3,1,18000,1),
('H2205140004',1,1,1,10000,1);

/*Table structure for table `htrans` */

DROP TABLE IF EXISTS `htrans`;

CREATE TABLE `htrans` (
  `no_nota` varchar(50) NOT NULL,
  `tanggal` datetime NOT NULL DEFAULT current_timestamp(),
  `total` double NOT NULL,
  `id_users` double NOT NULL,
  `status` int(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (`no_nota`),
  KEY `id_users` (`id_users`),
  CONSTRAINT `htrans_ibfk_1` FOREIGN KEY (`id_users`) REFERENCES `users` (`id_users`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `htrans` */

insert  into `htrans`(`no_nota`,`tanggal`,`total`,`id_users`,`status`) values 
('H2205120001','2022-05-12 14:01:58',20000,2,1),
('H2205120002','2022-05-12 14:04:45',14000,3,1),
('H2205120003','2022-05-12 14:07:27',56000,2,1),
('H2205140001','2022-05-14 09:01:40',49000,2,1),
('H2205140002','2022-05-14 09:08:17',14000,2,1),
('H2205140003','2022-05-14 09:08:53',33000,2,1),
('H2205140004','2022-05-14 20:23:31',10000,3,1);

/*Table structure for table `minuman` */

DROP TABLE IF EXISTS `minuman`;

CREATE TABLE `minuman` (
  `id_minuman` double NOT NULL AUTO_INCREMENT,
  `nama` varchar(100) NOT NULL,
  `stok` double NOT NULL,
  `harga` double NOT NULL,
  `status` int(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (`id_minuman`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

/*Data for the table `minuman` */

insert  into `minuman`(`id_minuman`,`nama`,`stok`,`harga`,`status`) values 
(1,'Es Teh Manis',197,10000,1),
(2,'Jus Jeruk',498,12000,1),
(3,'Milkshake',27,15000,1);

/*Table structure for table `topping` */

DROP TABLE IF EXISTS `topping`;

CREATE TABLE `topping` (
  `id_topping` double NOT NULL AUTO_INCREMENT,
  `nama` varchar(100) NOT NULL,
  `harga` double NOT NULL,
  `status` int(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (`id_topping`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

/*Data for the table `topping` */

insert  into `topping`(`id_topping`,`nama`,`harga`,`status`) values 
(1,'No Topping',0,1),
(2,'Gula',2000,1),
(3,'Chocolate Chip',3000,1),
(4,'Jeruk Nipis',2500,1);

/*Table structure for table `users` */

DROP TABLE IF EXISTS `users`;

CREATE TABLE `users` (
  `id_users` double NOT NULL AUTO_INCREMENT,
  `username` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `privilege` int(1) NOT NULL DEFAULT 1,
  `status` int(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (`id_users`),
  UNIQUE KEY `Username` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

/*Data for the table `users` */

insert  into `users`(`id_users`,`username`,`password`,`nama`,`privilege`,`status`) values 
(1,'admin','admin','admin',2,1),
(2,'Azhure','Raven','Azhure Raven',1,1),
(3,'Kevin','Jon','Kevin Jonathan',1,1);

/* Function  structure for function  `genNoNota` */

/*!50003 DROP FUNCTION IF EXISTS `genNoNota` */;
DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` FUNCTION `genNoNota`() RETURNS varchar(100) CHARSET utf8mb4
BEGIN
 DECLARE hasil VARCHAR(100) DEFAULT ''; 
 DECLARE counted INT; 			
 
 SELECT IFNULL(COUNT(*),0) INTO counted FROM htrans
 WHERE no_nota LIKE CONCAT('%H',DATE_FORMAT(NOW(), '%y%m%d'),'%');
 SET counted = counted + 1;
 
 SET hasil = CONCAT('H',DATE_FORMAT(NOW(),'%y%m%d'),LPAD(counted,4,'0'));
 RETURN hasil;
END */$$
DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
