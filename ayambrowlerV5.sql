-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 04, 2020 at 12:28 AM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ayambrowler`
--

-- --------------------------------------------------------

--
-- Table structure for table `account`
--

CREATE TABLE `account` (
  `id_account` int(3) NOT NULL,
  `Username` char(18) NOT NULL,
  `password` varchar(32) NOT NULL,
  `firstname` char(32) NOT NULL,
  `lastname` char(32) NOT NULL,
  `level` enum('super_admin','admin','reviewer','input') NOT NULL,
  `email` varchar(70) NOT NULL,
  `last_login` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `account`
--

INSERT INTO `account` (`id_account`, `Username`, `password`, `firstname`, `lastname`, `level`, `email`, `last_login`) VALUES
(1, 'master', 'master', 'Cecilia', 'Williams', 'super_admin', 'arifazizi1212@gmail.com', '2020-04-11'),
(2, 'rajaayam', 'rajaayam', 'Ryukarim', 'Panjaitan', 'admin', 'bootgem1@gmail.com', '2020-04-11'),
(3, 'looking', 'looking', 'Benjamin', 'Linus', 'reviewer', 'bootgem2@gmail.com', '2020-04-11'),
(7, 'input', 'input', 'Jeremia', 'Linus', 'input', 'bootgem@gmail.com', '2020-04-17');

-- --------------------------------------------------------

--
-- Table structure for table `deplesi`
--

CREATE TABLE `deplesi` (
  `id` int(11) NOT NULL,
  `tanggal` date NOT NULL,
  `kandang_id` enum('BR1-K01','BR1-K02','BR1-K03','BR1-K04','BR1-K05','BR1-K06','BR1-K07','BR1-K08','BR1-K09','BR1-K10','BR1-K11','BR1-K12','BR2-K01','BR2-K02','BR2-K03','BR2-K04','BR2-K05','BR2-K06','BR2-K07','BR2-K08','BR2-K09','BR2-K10','BR2-K11','BR2-K12','BR3-K01','BR3-K02','BR3-K03','BR3-K04','BR3-K05','BR3-K06') NOT NULL,
  `jlh_mati` int(6) NOT NULL,
  `jlh_afkir` int(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `deplesi`
--

INSERT INTO `deplesi` (`id`, `tanggal`, `kandang_id`, `jlh_mati`, `jlh_afkir`) VALUES
(1, '2020-02-11', 'BR1-K02', 25, 0),
(2, '2020-02-11', 'BR1-K02', 25, 0),
(3, '2020-02-11', 'BR1-K02', 25, 0),
(4, '2020-02-11', 'BR1-K02', 25, 0),
(5, '2020-02-11', 'BR1-K02', 25, 0),
(6, '2020-02-11', 'BR1-K02', 25, 0),
(7, '2020-02-11', 'BR1-K02', 25, 0),
(8, '2020-02-11', 'BR1-K02', 25, 0),
(9, '2020-02-11', 'BR1-K02', 25, 0),
(10, '2020-02-11', 'BR1-K02', 25, 0),
(11, '2020-02-11', 'BR1-K02', 25, 0),
(12, '2020-02-11', 'BR1-K02', 25, 0),
(13, '2020-02-11', 'BR1-K02', 25, 0),
(14, '2020-02-11', 'BR1-K02', 25, 0),
(15, '2020-02-11', 'BR1-K02', 25, 1),
(16, '2020-02-11', 'BR1-K02', 25, 0),
(17, '2020-02-11', 'BR1-K02', 25, 0),
(18, '2020-02-11', 'BR1-K02', 25, 0),
(19, '2020-02-11', 'BR1-K02', 25, 0),
(20, '2020-02-11', 'BR1-K02', 25, 0),
(21, '2020-02-11', 'BR1-K02', 25, 0),
(22, '2020-02-11', 'BR1-K02', 25, 0),
(23, '2020-02-11', 'BR1-K02', 25, 0),
(24, '2020-02-11', 'BR1-K02', 25, 0),
(25, '2020-02-11', 'BR1-K02', 25, 0),
(26, '2020-02-11', 'BR1-K02', 25, 0),
(27, '2020-02-11', 'BR1-K02', 25, 0),
(28, '2020-02-11', 'BR1-K02', 25, 0),
(29, '2020-02-11', 'BR1-K02', 25, 0),
(32, '2020-05-04', 'BR1-K08', 23, 12);

-- --------------------------------------------------------

--
-- Table structure for table `farm`
--

CREATE TABLE `farm` (
  `farm_id` enum('BR-I Nasuba','BR-II Nasuba','BR-III Nasuba') NOT NULL,
  `kandang_id` enum('BR1-K01','BR1-K02','BR1-K03','BR1-K04','BR1-K05','BR1-K06','BR1-K07','BR1-K08','BR1-K09','BR1-K10','BR1-K11','BR1-K12','BR2-K01','BR2-K02','BR2-K03','BR2-K04','BR2-K05','BR2-K06','BR2-K07','BR2-K08','BR2-K09','BR2-K10','BR2-K11','BR2-K12','BR3-K01','BR3-K02','BR3-K03','BR3-K04','BR3-K05','BR3-K06') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `farm`
--

INSERT INTO `farm` (`farm_id`, `kandang_id`) VALUES
('BR-I Nasuba', 'BR1-K01'),
('BR-I Nasuba', 'BR1-K02'),
('BR-I Nasuba', 'BR1-K03'),
('BR-I Nasuba', 'BR1-K04'),
('BR-I Nasuba', 'BR1-K05'),
('BR-I Nasuba', 'BR1-K06'),
('BR-I Nasuba', 'BR1-K07'),
('BR-I Nasuba', 'BR1-K08'),
('BR-I Nasuba', 'BR1-K09'),
('BR-I Nasuba', 'BR1-K10'),
('BR-I Nasuba', 'BR1-K11'),
('BR-I Nasuba', 'BR1-K12'),
('BR-II Nasuba', 'BR2-K01'),
('BR-II Nasuba', 'BR2-K02'),
('BR-II Nasuba', 'BR2-K03'),
('BR-II Nasuba', 'BR2-K04'),
('BR-II Nasuba', 'BR2-K05'),
('BR-II Nasuba', 'BR2-K06'),
('BR-II Nasuba', 'BR2-K07'),
('BR-II Nasuba', 'BR2-K08'),
('BR-II Nasuba', 'BR2-K09'),
('BR-II Nasuba', 'BR2-K10'),
('BR-II Nasuba', 'BR2-K11'),
('BR-II Nasuba', 'BR2-K12'),
('BR-III Nasuba', 'BR3-K01'),
('BR-III Nasuba', 'BR3-K02'),
('BR-III Nasuba', 'BR3-K03'),
('BR-III Nasuba', 'BR3-K04'),
('BR-III Nasuba', 'BR3-K05'),
('BR-III Nasuba', 'BR3-K06');

-- --------------------------------------------------------

--
-- Table structure for table `mutasi`
--

CREATE TABLE `mutasi` (
  `id` int(11) NOT NULL,
  `tgl_mutasi` date NOT NULL,
  `jlh_mutasi` int(6) NOT NULL,
  `kandang_id` enum('BR1-K01','BR1-K02','BR1-K03','BR1-K04','BR1-K05','BR1-K06','BR1-K07','BR1-K08','BR1-K09','BR1-K10','BR1-K11','BR1-K12','BR2-K01','BR2-K02','BR2-K03','BR2-K04','BR2-K05','BR2-K06','BR2-K07','BR2-K08','BR2-K09','BR2-K10','BR2-K11','BR2-K12','BR3-K01','BR3-K02','BR3-K03','BR3-K04','BR3-K05','BR3-K06') NOT NULL,
  `tujuan_kandang` enum('BR1-K01','BR1-K02','BR1-K03','BR1-K04','BR1-K05','BR1-K06','BR1-K07','BR1-K08','BR1-K09','BR1-K10','BR1-K11','BR1-K12','BR2-K01','BR2-K02','BR2-K03','BR2-K04','BR2-K05','BR2-K06','BR2-K07','BR2-K08','BR2-K09','BR2-K10','BR2-K11','BR2-K12','BR3-K01','BR3-K02','BR3-K03','BR3-K04','BR3-K05','BR3-K06') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `mutasi`
--

INSERT INTO `mutasi` (`id`, `tgl_mutasi`, `jlh_mutasi`, `kandang_id`, `tujuan_kandang`) VALUES
(1, '2020-05-04', 12, 'BR1-K01', 'BR1-K02'),
(2, '2020-05-04', 34, 'BR1-K05', 'BR1-K04');

-- --------------------------------------------------------

--
-- Table structure for table `penangkapan`
--

CREATE TABLE `penangkapan` (
  `id` int(11) NOT NULL,
  `tanggal` date NOT NULL,
  `kandang_id` enum('BR1-K01','BR1-K02','BR1-K03','BR1-K04','BR1-K05','BR1-K06','BR1-K07','BR1-K08','BR1-K09','BR1-K10','BR1-K11','BR1-K12','BR2-K01','BR2-K02','BR2-K03','BR2-K04','BR2-K05','BR2-K06','BR2-K07','BR2-K08','BR2-K09','BR2-K10','BR2-K11','BR2-K12','BR3-K01','BR3-K02','BR3-K03','BR3-K04','BR3-K05','BR3-K06') NOT NULL,
  `jlh_kecil` int(6) NOT NULL,
  `jlh_sedang` int(6) NOT NULL,
  `jlh_besar` int(6) NOT NULL,
  `ttl_berat` decimal(9,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `penangkapan`
--

INSERT INTO `penangkapan` (`id`, `tanggal`, `kandang_id`, `jlh_kecil`, `jlh_sedang`, `jlh_besar`, `ttl_berat`) VALUES
(1, '2020-05-04', 'BR1-K05', 12, 127, 56, '450.00'),
(5, '2020-05-04', 'BR1-K07', 34, 344, 12, '600.00');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`id_account`);

--
-- Indexes for table `deplesi`
--
ALTER TABLE `deplesi`
  ADD PRIMARY KEY (`id`),
  ADD KEY `kandang_id` (`kandang_id`);

--
-- Indexes for table `farm`
--
ALTER TABLE `farm`
  ADD PRIMARY KEY (`kandang_id`);

--
-- Indexes for table `mutasi`
--
ALTER TABLE `mutasi`
  ADD PRIMARY KEY (`id`),
  ADD KEY `kandang_id` (`kandang_id`);

--
-- Indexes for table `penangkapan`
--
ALTER TABLE `penangkapan`
  ADD PRIMARY KEY (`id`),
  ADD KEY `kandang_id` (`kandang_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `account`
--
ALTER TABLE `account`
  MODIFY `id_account` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `deplesi`
--
ALTER TABLE `deplesi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT for table `mutasi`
--
ALTER TABLE `mutasi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `penangkapan`
--
ALTER TABLE `penangkapan`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `deplesi`
--
ALTER TABLE `deplesi`
  ADD CONSTRAINT `deplesi_ibfk_1` FOREIGN KEY (`kandang_id`) REFERENCES `farm` (`kandang_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `deplesi_ibfk_2` FOREIGN KEY (`kandang_id`) REFERENCES `farm` (`kandang_id`) ON UPDATE CASCADE;

--
-- Constraints for table `mutasi`
--
ALTER TABLE `mutasi`
  ADD CONSTRAINT `mutasi_ibfk_1` FOREIGN KEY (`kandang_id`) REFERENCES `farm` (`kandang_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `mutasi_ibfk_2` FOREIGN KEY (`kandang_id`) REFERENCES `farm` (`kandang_id`) ON UPDATE CASCADE;

--
-- Constraints for table `penangkapan`
--
ALTER TABLE `penangkapan`
  ADD CONSTRAINT `penangkapan_ibfk_1` FOREIGN KEY (`kandang_id`) REFERENCES `farm` (`kandang_id`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
