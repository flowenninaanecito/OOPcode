-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3307
-- Generation Time: Jul 27, 2025 at 09:58 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `crud`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_crud_inventory`
--

CREATE TABLE `tbl_crud_inventory` (
  `ID` int(11) NOT NULL,
  `PRODUCTNO` varchar(50) NOT NULL,
  `PRODUCTNAME` varchar(250) NOT NULL,
  `PRICE` varchar(100) NOT NULL,
  `CATEGORY` varchar(250) NOT NULL,
  `EXPDATE` date NOT NULL,
  `STATUS` varchar(2550) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_crud_inventory`
--

INSERT INTO `tbl_crud_inventory` (`ID`, `PRODUCTNO`, `PRODUCTNAME`, `PRICE`, `CATEGORY`, `EXPDATE`, `STATUS`) VALUES
(21, '1234', 'Fudgee Bar', '90', 'SNACKS', '2024-11-01', '1'),
(25, '0001', 'YAKULT', '10', 'COLD DRINKS', '2025-12-27', '1');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_user`
--

CREATE TABLE `tbl_user` (
  `ID` int(11) NOT NULL,
  `LNAME` varchar(250) NOT NULL,
  `FNAME` varchar(250) NOT NULL,
  `MNAME` varchar(250) NOT NULL,
  `SEX` varchar(10) NOT NULL,
  `CONTACTNUM` int(15) NOT NULL,
  `ADDRESS` varchar(250) NOT NULL,
  `BDATE` date NOT NULL,
  `AGE` int(10) NOT NULL,
  `CIVILSTAT` varchar(20) NOT NULL,
  `DESIGNATION` varchar(250) NOT NULL,
  `EMAILADD` varchar(100) NOT NULL,
  `UNAME` varchar(100) NOT NULL,
  `PASSWORD` varchar(100) NOT NULL,
  `CONPASS` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_user`
--

INSERT INTO `tbl_user` (`ID`, `LNAME`, `FNAME`, `MNAME`, `SEX`, `CONTACTNUM`, `ADDRESS`, `BDATE`, `AGE`, `CIVILSTAT`, `DESIGNATION`, `EMAILADD`, `UNAME`, `PASSWORD`, `CONPASS`) VALUES
(1, 'dsd', 'dsds', 'dsds', '', 77777, 'sddsdd', '2024-10-31', 0, 'dsds', '77777', 'fggfg@gmail.com', 'u', 'p', 'p'),
(15, 'TEST', 'TEST', 'TEST', 'FEMALE', 909, 'PANDAN, ANTIQUE', '1997-01-27', 28, 'S', 'STUDENT', 'TEST@GMAIL.COM', 'TEST', 'TEST', 'TEST');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_crud_inventory`
--
ALTER TABLE `tbl_crud_inventory`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tbl_user`
--
ALTER TABLE `tbl_user`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_crud_inventory`
--
ALTER TABLE `tbl_crud_inventory`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT for table `tbl_user`
--
ALTER TABLE `tbl_user`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
