-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jul 03, 2021 at 03:49 PM
-- Server version: 5.7.24
-- PHP Version: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hotelres`
--

-- --------------------------------------------------------

--
-- Table structure for table `chambre`
--

DROP TABLE IF EXISTS `chambre`;
CREATE TABLE IF NOT EXISTS `chambre` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `type_id` int(11) NOT NULL,
  `Numero` varchar(20) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `chambre_type_id_fk` (`type_id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `chambre`
--

INSERT INTO `chambre` (`id`, `type_id`, `Numero`) VALUES
(1, 2, '01'),
(2, 2, '02'),
(3, 1, '03'),
(4, 1, '04'),
(5, 3, '05'),
(6, 3, '06'),
(7, 4, '07'),
(8, 5, '08');

-- --------------------------------------------------------

--
-- Table structure for table `client`
--

DROP TABLE IF EXISTS `client`;
CREATE TABLE IF NOT EXISTS `client` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `client`
--

INSERT INTO `client` (`id`, `nom`) VALUES
(1, 'Maryem'),
(2, 'Mouad'),
(3, 'ferdaous'),
(4, 'aymane'),
(5, 'aymane'),
(6, 'test'),
(7, 'aymane'),
(8, 'newuser'),
(9, 'akzjehajkze'),
(10, 'lkajze'),
(11, 'aymen');

-- --------------------------------------------------------

--
-- Table structure for table `reservation`
--

DROP TABLE IF EXISTS `reservation`;
CREATE TABLE IF NOT EXISTS `reservation` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `client_id` int(11) NOT NULL,
  `chambre_id` int(11) NOT NULL,
  `dateReservation` date NOT NULL,
  `duree` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `reservation_client_id_fk` (`client_id`),
  KEY `reservation_chambre_id_fk` (`chambre_id`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `reservation`
--

INSERT INTO `reservation` (`id`, `client_id`, `chambre_id`, `dateReservation`, `duree`) VALUES
(8, 3, 7, '2021-07-08', 4),
(10, 3, 4, '2021-07-03', 2),
(14, 11, 8, '2021-07-24', 3),
(15, 4, 6, '2021-07-03', 3),
(16, 3, 8, '2021-07-03', 5),
(17, 4, 6, '2021-07-15', 5);

-- --------------------------------------------------------

--
-- Table structure for table `type`
--

DROP TABLE IF EXISTS `type`;
CREATE TABLE IF NOT EXISTS `type` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Classe` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `type`
--

INSERT INTO `type` (`id`, `Classe`) VALUES
(1, 'Simple'),
(2, 'Double'),
(3, 'Triple'),
(4, 'Familiale'),
(5, 'Suite');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `chambre`
--
ALTER TABLE `chambre`
  ADD CONSTRAINT `chambre_type_id_fk` FOREIGN KEY (`type_id`) REFERENCES `type` (`id`);

--
-- Constraints for table `reservation`
--
ALTER TABLE `reservation`
  ADD CONSTRAINT `reservation_chambre_id_fk` FOREIGN KEY (`chambre_id`) REFERENCES `chambre` (`id`),
  ADD CONSTRAINT `reservation_client_id_fk` FOREIGN KEY (`client_id`) REFERENCES `client` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
