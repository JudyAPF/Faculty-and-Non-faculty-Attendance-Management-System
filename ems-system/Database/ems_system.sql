-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 19, 2024 at 01:10 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ems_system`
--

-- --------------------------------------------------------

--
-- Table structure for table `attendance_table`
--

CREATE TABLE `attendance_table` (
  `ID` int(50) DEFAULT NULL,
  `Name` varchar(50) DEFAULT NULL,
  `Address` varchar(50) DEFAULT NULL,
  `Department` varchar(50) DEFAULT NULL,
  `Phone` varchar(50) DEFAULT NULL,
  `Edu` varchar(50) DEFAULT NULL,
  `Gender` varchar(50) DEFAULT NULL,
  `DateOfBirth` varchar(50) DEFAULT NULL,
  `IN_Time` time(5) DEFAULT NULL,
  `Out_Time` time(5) DEFAULT NULL,
  `Status` int(50) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `attendance_table`
--

INSERT INTO `attendance_table` (`ID`, `Name`, `Address`, `Department`, `Phone`, `Edu`, `Gender`, `DateOfBirth`, `IN_Time`, `Out_Time`, `Status`) VALUES
(10008, 'Bryan Lapitan', 'Dagupan, Pangasinan', 'IT', '+630857348926', 'Ph.D. in Information Technology', 'Male', '20/01/1994', '01:31:18.00000', '01:32:26.00000', 0);

-- --------------------------------------------------------

--
-- Table structure for table `employee_tb`
--

CREATE TABLE `employee_tb` (
  `ID` int(50) NOT NULL,
  `Name` varchar(50) DEFAULT NULL,
  `Address` varchar(50) DEFAULT NULL,
  `Department` varchar(50) DEFAULT NULL,
  `Phone` varchar(50) DEFAULT NULL,
  `Edu` varchar(50) DEFAULT NULL,
  `DateOfBirth` varchar(50) DEFAULT NULL,
  `Gender` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `employee_tb`
--

INSERT INTO `employee_tb` (`ID`, `Name`, `Address`, `Department`, `Phone`, `Edu`, `DateOfBirth`, `Gender`) VALUES
(1111, 'Ivan Smith', 'Urdaneta City, Pangasinan', 'IT', '+639776986298', 'Ph.D. in Computer Science', '12/08/1985', 'Male'),
(2222, 'Emily Rodriguez', 'Dagupan City, Pangasinan', 'BECEd', '+639794564578', 'M.S. in Information Technology', '10/07/1998', 'Female'),
(3333, 'Alex Thompson', 'Lingayen, Pangasinan', 'CE', '+639345234543', 'Ph.D. in Civil Engineering', '22/03/1980', 'Male'),
(4444, 'Olivia Cruz', 'Calasiao, Pangasinan', 'CE', '+639345289375', 'M.S. in Structural Engineering', '05/01/1983', 'Female'),
(5555, 'Monica Ave', 'Urdaneta City, Pangasinan', 'CoE', '+634352433254', 'BSIT', '03/02/2003', 'Male'),
(6666, 'Anderson Gomez', 'Sta. Maria, Pangasinan', 'ME', '+639345345223', 'Master of Science in Mechanical Engineering', '09/01/2024', 'Male'),
(7777, 'Kathryn Bernardo', 'Sual, Pangasinan', 'EE', '+639524532452', 'BS in Electronics Engineering', '14/10/1995', 'Female'),
(8888, 'Ivan Gomez', 'Sison, Pangasinan', 'BS Math', '+635646346168', 'BS in Mathematics Education', '09/01/1991', 'Male'),
(9999, 'Carla Rivera', 'Mangaldan, Pangasinan', 'ABEL', '+639634645637', 'Ph.D.  in English Language Studies', '11/01/1989', 'Female'),
(10000, 'Beatriz Santos', 'Binmaley, Pangasinan', 'Architecture', '+639567463453', 'Ph.D. in Architecture', '12/01/1979', 'Female'),
(10002, 'Amy Portodo', 'San Fabian, Pangasinan', 'BSEd-Science', '+639789673456', 'Ph.D. in Science Education', '12/01/1980', 'Female'),
(10005, 'Judy Flores', 'Santa Barbara, Pangasinan', 'IT', '+639776986298', 'MS in Information Tec', '31/01/2002', 'Female'),
(10006, 'Jessica Llego', 'Binalonan, Pangasinan', 'IT', '+639756745634', 'MS in Information Technology', '04/12/2002', 'Female'),
(10007, 'Kathleen Sison', 'San Jacinto, Pangasinan', 'IT', '+639653643654', 'MS in Information Technology', '28/03/2003', 'Female'),
(10008, 'Bryan Lapitan', 'Dagupan, Pangasinan', 'IT', '+630857348926', 'Ph.D. in Information Technology', '20/01/1994', 'Male');

-- --------------------------------------------------------

--
-- Table structure for table `login_tb`
--

CREATE TABLE `login_tb` (
  `Username` varchar(50) DEFAULT NULL,
  `Password` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `login_tb`
--

INSERT INTO `login_tb` (`Username`, `Password`) VALUES
('admin', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `employee_tb`
--
ALTER TABLE `employee_tb`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `employee_tb`
--
ALTER TABLE `employee_tb`
  MODIFY `ID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10009;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
