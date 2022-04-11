/*
Navicat MySQL Data Transfer

Source Server         : Konekcija
Source Server Version : 50018
Source Host           : localhost:3306
Source Database       : projektnizadatak

Target Server Type    : MYSQL
Target Server Version : 50018
File Encoding         : 65001

Date: 2021-04-26 15:17:31
*/

SET FOREIGN_KEY_CHECKS=0;
-- ----------------------------
-- Table structure for `artikal`
-- ----------------------------
DROP TABLE IF EXISTS `artikal`;
CREATE TABLE `artikal` (
  `artikal_ID` int(11) NOT NULL auto_increment,
  `naziv_artikla` varchar(50) default NULL,
  `vrsta_artikla` varchar(50) default NULL,
  `cijena` double default NULL,
  PRIMARY KEY  (`artikal_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of artikal
-- ----------------------------
INSERT INTO `artikal` VALUES ('2', 'Acer aspire', 'laptop', '750.5');
INSERT INTO `artikal` VALUES ('3', 'Lenovo', 'Laptop', '600.8');
INSERT INTO `artikal` VALUES ('4', 'Toshiba', 'laptop', '1050');
INSERT INTO `artikal` VALUES ('6', 'Hp', 'laptop', '900');

-- ----------------------------
-- Table structure for `kupac`
-- ----------------------------
DROP TABLE IF EXISTS `kupac`;
CREATE TABLE `kupac` (
  `kupac_ID` int(11) NOT NULL auto_increment,
  `ime` varchar(50) default NULL,
  `prezime` varchar(50) default NULL,
  `grad` varchar(50) default NULL,
  `adresa` varchar(50) default NULL,
  `telefon` varchar(30) default NULL,
  `username` varchar(50) default NULL,
  `password` varchar(50) default NULL,
  PRIMARY KEY  (`kupac_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of kupac
-- ----------------------------
INSERT INTO `kupac` VALUES ('1', 'Admin', 'Admin', 'NY', 'Bronx', '0001112222', 'admin', '1234');
INSERT INTO `kupac` VALUES ('2', 'Samir', 'Samir', 'Sarajevo', 'Dzemala Bijedica 11', '12354546', 'samir', '12345');
INSERT INTO `kupac` VALUES ('5', 'Emir', 'Emir', 'Sarajevo', 'Blazuj 17', '1234234', 'emir', '1111');

-- ----------------------------
-- Table structure for `narudzbenica`
-- ----------------------------
DROP TABLE IF EXISTS `narudzbenica`;
CREATE TABLE `narudzbenica` (
  `narudzbenica_ID` int(11) NOT NULL auto_increment,
  `kupac_ID` int(11) default NULL,
  `datum_narudzbe` date default NULL,
  PRIMARY KEY  (`narudzbenica_ID`),
  KEY `narKup` (`kupac_ID`),
  CONSTRAINT `narKup` FOREIGN KEY (`kupac_ID`) REFERENCES `kupac` (`kupac_ID`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of narudzbenica
-- ----------------------------
INSERT INTO `narudzbenica` VALUES ('38', '2', '2021-04-15');
INSERT INTO `narudzbenica` VALUES ('49', '2', '2021-04-16');
INSERT INTO `narudzbenica` VALUES ('50', '2', '2021-04-24');
INSERT INTO `narudzbenica` VALUES ('57', '2', '2021-04-25');
INSERT INTO `narudzbenica` VALUES ('66', '2', '2021-04-25');
INSERT INTO `narudzbenica` VALUES ('67', '2', '2021-04-25');
INSERT INTO `narudzbenica` VALUES ('70', '5', '2021-04-25');
INSERT INTO `narudzbenica` VALUES ('74', '2', '2021-04-25');
INSERT INTO `narudzbenica` VALUES ('75', '5', '2021-04-26');

-- ----------------------------
-- Table structure for `skladiste`
-- ----------------------------
DROP TABLE IF EXISTS `skladiste`;
CREATE TABLE `skladiste` (
  `skladiste_ID` int(11) NOT NULL auto_increment,
  `artikal_ID` int(11) default NULL,
  `kolicina_stanje` int(11) default NULL,
  PRIMARY KEY  (`skladiste_ID`),
  KEY `sklArt` (`artikal_ID`),
  CONSTRAINT `sklArt` FOREIGN KEY (`artikal_ID`) REFERENCES `artikal` (`artikal_ID`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of skladiste
-- ----------------------------
INSERT INTO `skladiste` VALUES ('4', '2', '4');
INSERT INTO `skladiste` VALUES ('5', '3', '14');
INSERT INTO `skladiste` VALUES ('6', '4', '16');
INSERT INTO `skladiste` VALUES ('8', '6', '14');

-- ----------------------------
-- Table structure for `stavka`
-- ----------------------------
DROP TABLE IF EXISTS `stavka`;
CREATE TABLE `stavka` (
  `stavka_ID` int(11) NOT NULL auto_increment,
  `narudzbenica_ID` int(11) default NULL,
  `artikal_ID` int(11) default NULL,
  `kolicina` int(11) default NULL,
  PRIMARY KEY  (`stavka_ID`),
  KEY `staArt` (`artikal_ID`),
  KEY `staNar` (`narudzbenica_ID`),
  CONSTRAINT `staArt` FOREIGN KEY (`artikal_ID`) REFERENCES `artikal` (`artikal_ID`) ON DELETE CASCADE,
  CONSTRAINT `staNar` FOREIGN KEY (`narudzbenica_ID`) REFERENCES `narudzbenica` (`narudzbenica_ID`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of stavka
-- ----------------------------
INSERT INTO `stavka` VALUES ('33', '38', '2', '1');
INSERT INTO `stavka` VALUES ('44', '49', '4', '2');
INSERT INTO `stavka` VALUES ('46', '50', '2', '5');
INSERT INTO `stavka` VALUES ('56', '57', '2', '1');
INSERT INTO `stavka` VALUES ('57', '57', '3', '1');
INSERT INTO `stavka` VALUES ('58', '57', '6', '1');
INSERT INTO `stavka` VALUES ('75', '66', '2', '1');
INSERT INTO `stavka` VALUES ('77', '67', '4', '2');
INSERT INTO `stavka` VALUES ('82', '70', '4', '2');
INSERT INTO `stavka` VALUES ('83', '70', '3', '1');
INSERT INTO `stavka` VALUES ('86', '74', '4', '1');
INSERT INTO `stavka` VALUES ('87', '75', '3', '1');
INSERT INTO `stavka` VALUES ('88', '75', '6', '2');
