-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 19, 2019 at 03:32 PM
-- Server version: 5.7.14
-- PHP Version: 7.0.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `skola`
--

-- --------------------------------------------------------

--
-- Table structure for table `predmet`
--

CREATE TABLE `predmet` (
  `Naziv_predmeta` varchar(30) DEFAULT NULL,
  `Sifru_predmeta` varchar(30) DEFAULT NULL,
  `Kratak_opis` varchar(50) DEFAULT NULL,
  `Labaratoriske_vezbe` tinyint(1) DEFAULT NULL,
  `Godina` tinyint(8) DEFAULT NULL,
  `id` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `predmet`
--

INSERT INTO `predmet` (`Naziv_predmeta`, `Sifru_predmeta`, `Kratak_opis`, `Labaratoriske_vezbe`, `Godina`, `id`) VALUES
('MYSQL', 'Zoki', 'zabavno', NULL, 1, 1),
('PHP', 'Mare', 'zabavnije', 1, 3, 2),
('ASP .NET', 'objekti', 'najzabavnije', 1, 4, 3),
('JavaScript', 'sveSve', 'konfuzno', NULL, 1, 4),
('CSS', 'smor', 'dosadno', 0, 1, 5),
('XML', 'B', 'neefikasno', 0, 1, 6),
('JSON', 'jj', 'efikasno', 0, 1, 7),
('Ajax', 'Mara', 'zanimljivo', 1, 2, 8),
('JQUERY', 'JQ', 'svestrano', 1, 2, 10),
('KravMaga', 'KM', 'tepanje', NULL, 1, 15),
('WebApi', 'WA', 'komunikacija', NULL, 1, 14);

-- --------------------------------------------------------

--
-- Table structure for table `profesor`
--

CREATE TABLE `profesor` (
  `Ime` varchar(20) DEFAULT NULL,
  `Srednje_ime` varchar(20) DEFAULT NULL,
  `Prezime` varchar(20) DEFAULT NULL,
  `datum_rodjenja` date DEFAULT NULL,
  `datum_postavljanja` date DEFAULT NULL,
  `naziv_predmeta` varchar(30) DEFAULT NULL,
  `id` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `profesor`
--

INSERT INTO `profesor` (`Ime`, `Srednje_ime`, `Prezime`, `datum_rodjenja`, `datum_postavljanja`, `naziv_predmeta`, `id`) VALUES
('xxx', 'ccc', 'zzzz', '2018-02-02', '2014-04-04', 'Fizikazzz', 22),
('Marko', 'Mare', 'Markovic', '2016-04-04', '2014-04-04', 'PHP', 12),
('Nikola', 'Nidza', 'Nikolic', '2015-05-05', '2014-04-04', 'ASP .NET', 13),
('Stanko', 'S', 'Stankovic', '2013-03-03', '2014-04-04', 'JavaScript', 14),
('Sasa', 'ST', 'Prptic', '2012-02-02', '2014-04-04', 'CSS', 15),
('Lela', 'B', 'Lalatovic', '1999-05-05', '2014-04-04', 'XML', 16),
('Brankica', 'Baki', 'Stojanovic', '1990-07-13', '2014-04-04', 'JSON', 17),
('Marica', 'Mara', 'Marovic', '2002-02-02', '2014-04-04', 'Ajax', 18),
('Sara', 'S', 'Saric', '1988-08-08', '2014-04-04', 'JQUERY', 20);

-- --------------------------------------------------------

--
-- Table structure for table `slusa`
--

CREATE TABLE `slusa` (
  `id` int(11) NOT NULL,
  `Naziv_predmeta` varchar(30) NOT NULL,
  `br_indexa` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `slusa`
--

INSERT INTO `slusa` (`id`, `Naziv_predmeta`, `br_indexa`) VALUES
(1, 'MYSQL', 4956),
(2, 'MYSQL', 4596),
(3, 'MYSQL', 4956),
(4, 'MYSQL', 4596),
(5, 'PHP', 4999),
(6, 'PHP', 4696),
(7, 'PHP', 4999),
(8, 'PHP', 4696),
(9, 'ASP .NET', 4956),
(10, 'ASP .NET', 4776),
(11, 'ASP .NET', 4956),
(12, 'ASP .NET', 4776),
(13, 'JavaScript', 4956),
(14, 'JavaScript', 4776),
(15, 'JavaScript', 4956),
(16, 'JavaScript', 4776),
(17, 'CSS', 4596),
(18, 'XML', 4696),
(19, 'CSS', 4596),
(20, 'XML', 4696),
(21, 'JSON', 4666),
(22, 'Ajax', 4956),
(23, 'JSON', 4666),
(24, 'Ajax', 4956),
(25, 'JQUERY', 4696),
(26, 'KravMaga', 4696),
(27, 'JQUERY', 4696),
(28, 'KravMaga', 4696),
(29, 'WebApi', 4696),
(30, 'WebApi', 4596),
(31, 'WebApi', 4696),
(32, 'WebApi', 4596);

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE `student` (
  `id` int(11) NOT NULL,
  `ime` varchar(20) DEFAULT NULL,
  `srednje_ime` varchar(20) DEFAULT NULL,
  `datum_rodjenja` date DEFAULT NULL,
  `br_indexa` varchar(11) DEFAULT NULL,
  `jmbg` varchar(13) DEFAULT NULL,
  `prezime` varchar(20) DEFAULT NULL,
  `studentcol` varchar(45) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`id`, `ime`, `srednje_ime`, `datum_rodjenja`, `br_indexa`, `jmbg`, `prezime`, `studentcol`) VALUES
(3, 'Katarina', 'Kaca', '1998-04-04', '4956', '15134431', 'Mladenovic', NULL),
(4, 'Saska', 'Saka', '1991-02-02', '4596', '12136431', 'Savic', NULL),
(5, 'Milica', 'Mica', '1888-02-02', '4999', '55134431', 'Micic', NULL),
(7, 'Brankica', 'Branka', '1977-06-06', '4696', '12136631', 'Brankovic', NULL),
(8, 'Marica', 'Mara', '1994-07-07', '4776', '12774431', 'Maric', NULL),
(9, 'Jovana', 'Joka', '1989-02-02', '4196', '11134431', 'Jovanovic', NULL),
(10, 'Aleksandra', 'Saska', '1982-04-06', '4666', '66634431', 'Stankovic', NULL);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `predmet`
--
ALTER TABLE `predmet`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `Naziv_predmeta` (`Naziv_predmeta`),
  ADD UNIQUE KEY `Sifru_predmeta` (`Sifru_predmeta`);

--
-- Indexes for table `profesor`
--
ALTER TABLE `profesor`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `slusa`
--
ALTER TABLE `slusa`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `jmbg` (`jmbg`),
  ADD UNIQUE KEY `br_indexa_UNIQUE` (`br_indexa`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `predmet`
--
ALTER TABLE `predmet`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;
--
-- AUTO_INCREMENT for table `profesor`
--
ALTER TABLE `profesor`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;
--
-- AUTO_INCREMENT for table `slusa`
--
ALTER TABLE `slusa`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;
--
-- AUTO_INCREMENT for table `student`
--
ALTER TABLE `student`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
