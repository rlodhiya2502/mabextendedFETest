-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 22, 2022 at 11:59 AM
-- Server version: 10.4.18-MariaDB
-- PHP Version: 7.4.16

START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `mabtest`
--
CREATE DATABASE IF NOT EXISTS `mabtest` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE mabtest;

-- --------------------------------------------------------

--
-- Table structure for table `games`
--

CREATE TABLE IF NOT EXISTS `games` (
  `gamesid` int(11) NOT NULL AUTO_INCREMENT,
  `playerid` int(11) NOT NULL,
  `score` int(11) NOT NULL,
  `gamedatetime` date NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`gamesid`),
  KEY `playerid` (`playerid`)
) ;

--
-- Dumping data for table `games`
--

INSERT INTO `games` (`gamesid`, `playerid`, `score`, `gamedatetime`) VALUES
(1, 5, 15, '0000-00-00'),
(2, 2, 40, '0000-00-00'),
(3, 6, 20, '0000-00-00'),
(4, 1, 70, '0000-00-00'),
(5, 4, 15, '0000-00-00'),
(6, 3, 5, '0000-00-00'),
(7, 1, 0, '0000-00-00'),
(8, 1, 0, '0000-00-00'),
(9, 1, 0, '0000-00-00'),
(10, 1, 0, '0000-00-00'),
(11, 1, 0, '0000-00-00'),
(12, 1, 0, '0000-00-00'),
(13, 1, 0, '0000-00-00'),
(14, 1, 0, '0000-00-00'),
(15, 1, 0, '0000-00-00'),
(16, 1, 0, '0000-00-00'),
(17, 1, 0, '0000-00-00'),
(18, 1, 0, '0000-00-00'),
(19, 1, 0, '0000-00-00'),
(20, 1, 0, '0000-00-00'),
(21, 1, 0, '0000-00-00'),
(22, 1, 0, '0000-00-00'),
(23, 1, 0, '0000-00-00'),
(24, 1, 0, '0000-00-00'),
(25, 2, 0, '0000-00-00'),
(26, 2, 0, '0000-00-00'),
(27, 2, 0, '0000-00-00'),
(28, 2, 0, '0000-00-00'),
(29, 2, 0, '0000-00-00'),
(30, 2, 0, '0000-00-00'),
(31, 2, 0, '0000-00-00'),
(32, 2, 0, '0000-00-00'),
(33, 2, 0, '0000-00-00'),
(34, 2, 0, '0000-00-00'),
(35, 2, 0, '0000-00-00'),
(36, 2, 0, '0000-00-00'),
(37, 2, 0, '0000-00-00'),
(38, 2, 0, '0000-00-00'),
(39, 2, 0, '0000-00-00'),
(40, 2, 0, '0000-00-00'),
(41, 2, 0, '0000-00-00'),
(42, 2, 0, '0000-00-00'),
(43, 2, 0, '0000-00-00'),
(44, 3, 0, '0000-00-00'),
(45, 3, 0, '0000-00-00'),
(46, 3, 0, '0000-00-00'),
(47, 3, 0, '0000-00-00'),
(48, 3, 0, '0000-00-00'),
(49, 3, 0, '0000-00-00'),
(50, 3, 0, '0000-00-00'),
(51, 3, 0, '0000-00-00'),
(52, 3, 0, '0000-00-00'),
(53, 3, 0, '0000-00-00'),
(54, 3, 0, '0000-00-00'),
(55, 3, 0, '0000-00-00'),
(56, 4, 0, '0000-00-00'),
(57, 4, 0, '0000-00-00'),
(58, 4, 0, '0000-00-00'),
(59, 4, 0, '0000-00-00'),
(60, 4, 0, '0000-00-00'),
(61, 4, 0, '0000-00-00'),
(62, 4, 0, '0000-00-00'),
(63, 4, 0, '0000-00-00'),
(64, 4, 0, '0000-00-00'),
(65, 4, 0, '0000-00-00'),
(66, 4, 0, '0000-00-00'),
(67, 4, 0, '0000-00-00'),
(68, 4, 0, '0000-00-00'),
(69, 5, 0, '0000-00-00'),
(70, 5, 0, '0000-00-00'),
(71, 5, 0, '0000-00-00'),
(72, 5, 0, '0000-00-00'),
(73, 5, 0, '0000-00-00'),
(74, 5, 0, '0000-00-00'),
(75, 5, 0, '0000-00-00'),
(76, 5, 0, '0000-00-00'),
(77, 5, 0, '0000-00-00'),
(78, 5, 0, '0000-00-00'),
(79, 5, 0, '0000-00-00'),
(80, 5, 0, '0000-00-00'),
(81, 5, 0, '0000-00-00'),
(82, 5, 0, '0000-00-00'),
(83, 6, 0, '0000-00-00'),
(84, 6, 0, '0000-00-00'),
(85, 6, 0, '0000-00-00'),
(86, 6, 0, '0000-00-00'),
(87, 6, 0, '0000-00-00'),
(88, 6, 0, '0000-00-00');

-- --------------------------------------------------------

--
-- Table structure for table `players`
--

CREATE TABLE IF NOT EXISTS `players` (
  `playerid` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  PRIMARY KEY (`playerid`)
) ;

--
-- Dumping data for table `players`
--

INSERT INTO `players` (`playerid`, `name`) VALUES
(1, 'Carl Kreger'),
(2, 'Nik Asworth'),
(3, 'Nisha Earnhaw'),
(4, 'Tom Toy'),
(5, 'Sam Smit'),
(6, 'Rayan Brnson');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `games`
--
ALTER TABLE `games`
  ADD CONSTRAINT `games_ibfk_1` FOREIGN KEY (`playerid`) REFERENCES `players` (`playerid`) ON DELETE CASCADE ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
