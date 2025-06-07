-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 07, 2025 at 03:14 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `student_record_system`
--

-- --------------------------------------------------------

--
-- Table structure for table `student_information`
--

CREATE TABLE `student_information` (
  `student_no` int(11) NOT NULL,
  `full_name` varchar(300) NOT NULL,
  `age` int(11) NOT NULL,
  `birth_date` date NOT NULL,
  `address` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `student_information`
--

INSERT INTO `student_information` (`student_no`, `full_name`, `age`, `birth_date`, `address`) VALUES
(1001, 'John Doe', 21, '2004-04-15', '1234 Elm Street'),
(1002, 'Jane Smith', 23, '2001-09-02', '5678 Oak Avenue'),
(1003, 'Michael Johnson', 22, '2002-12-12', '9101 Pine Road'),
(1004, 'Emily Davis', 20, '2003-05-07', '2345 Maple Drive'),
(1005, 'David Brown', 24, '2000-03-23', '6789 Birch Lane'),
(1006, 'Sarah Wilson', 25, '1999-07-19', '1357 Cedar Boulevard'),
(1007, 'James Moore', 22, '2002-01-10', '2468 Willow Court'),
(1008, 'Linda Taylor', 21, '2004-11-11', '1234 Spruce Street'),
(1009, 'Robert Anderson', 26, '1998-06-22', '3210 Redwood Circle'),
(1010, 'Elizabeth Thomas', 23, '2001-02-05', '4321 Aspen Way'),
(1011, 'William Jackson', 24, '2000-08-13', '5432 Cherry Hill'),
(1012, 'Sophia Harris', 21, '2004-03-30', '6543 Magnolia Parkway'),
(1013, 'Benjamin Martin', 27, '1997-10-17', '7654 Palm Ridge'),
(1014, 'Isabella Thompson', 22, '2002-02-28', '8765 Maplewood Drive'),
(1015, 'Mason White', 25, '1999-04-05', '9876 Oak Street'),
(1016, 'Charlotte Walker', 23, '2001-06-25', '1234 Cedar Lane'),
(1017, 'Daniel Lee', 28, '1996-07-14', '4321 Birch Grove'),
(1018, 'Ava Allen', 21, '2004-05-03', '5678 Pine Valley'),
(1019, 'Lucas Young', 22, '2002-09-20', '9876 Elm Circle'),
(1020, 'Grace King', 23, '2001-03-17', '8765 Oak Grove'),
(1021, 'Henry Scott', 21, '2004-01-25', '6543 Maple Ridge'),
(1022, 'Chloe Adams', 24, '2000-11-09', '3210 Redwood Street'),
(1023, 'Elijah Nelson', 22, '2002-05-21', '4321 Spruce Avenue'),
(1024, 'Mia Carter', 27, '1997-08-14', '1357 Willow Lane'),
(1025, 'Alexander Mitchell', 25, '1999-12-18', '2468 Birch Ridge'),
(1026, 'Zoe Perez', 21, '2004-07-11', '9101 Cedar Grove'),
(1027, 'Daniel Rodriguez', 23, '2001-05-13', '1234 Pine Street'),
(1028, 'Ethan Gonzalez', 22, '2002-11-06', '5678 Elm Court'),
(1029, 'Madison Martinez', 21, '2004-12-02', '6789 Maplewood Street'),
(1030, 'James Wilson', 25, '1999-02-14', '9876 Birch Parkway'),
(1100, 'Sophia Moore', 24, '2000-10-01', '1357 Redwood Circle');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `username` varchar(200) NOT NULL,
  `password` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`username`, `password`) VALUES
('User', '$2a$11$xoQL6RfaObfCJRxTkWQu2.5H5fbVYmY8gqZSnLpeMBVqFF10yfmMK');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
