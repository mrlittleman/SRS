-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 17, 2025 at 05:10 AM
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
  `student_no` varchar(20) NOT NULL,
  `full_name` varchar(100) NOT NULL,
  `age` int(11) NOT NULL,
  `birth_date` date NOT NULL,
  `address` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `student_information`
--

INSERT INTO `student_information` (`student_no`, `full_name`, `age`, `birth_date`, `address`) VALUES
('1001', 'John Smith', 20, '2003-05-15', '123 Main St, Anytown, USA'),
('1002', 'Emily Johnson', 21, '2002-08-22', '456 Oak Ave, Somewhere, USA'),
('1003', 'Michael Williams', 19, '2004-02-10', '789 Pine Rd, Nowhere, USA'),
('1004', 'Sarah Brown', 22, '2001-11-30', '321 Elm St, Anywhere, USA'),
('1005', 'David Jones', 20, '2003-07-18', '654 Maple Dr, Everywhere, USA'),
('1006', 'Jessica Garcia', 21, '2002-09-05', '987 Cedar Ln, Somewhere, USA'),
('1007', 'Robert Miller', 19, '2004-01-25', '135 Birch Blvd, Nowhere, USA'),
('1008', 'Jennifer Davis', 22, '2001-12-12', '246 Walnut Ct, Anywhere, USA'),
('1009', 'Thomas Rodriguez', 20, '2003-06-08', '369 Spruce Way, Everywhere, USA'),
('1010', 'Lisa Martinez', 21, '2002-10-17', '482 Ash St, Somewhere, USA'),
('1011', 'Daniel Hernandez', 19, '2004-03-29', '591 Poplar Ave, Nowhere, USA'),
('1012', 'Michelle Lopez', 22, '2001-04-14', '713 Redwood Dr, Anywhere, USA'),
('1013', 'Charles Gonzalez', 20, '2003-08-03', '824 Willow Ln, Everywhere, USA'),
('1014', 'Amanda Wilson', 21, '2002-05-20', '935 Sycamore Rd, Somewhere, USA'),
('1015', 'Joseph Anderson', 19, '2004-07-11', '147 Magnolia Blvd, Nowhere, USA'),
('1016', 'Melissa Thomas', 22, '2001-09-26', '258 Dogwood Ct, Anywhere, USA'),
('1017', 'Christopher Taylor', 20, '2003-10-09', '369 Hickory Way, Everywhere, USA'),
('1018', 'Stephanie Moore', 21, '2002-11-15', '471 Beech St, Somewhere, USA'),
('1019', 'Matthew Jackson', 19, '2004-04-30', '582 Chestnut Ave, Nowhere, USA'),
('1020', 'Laura Martin', 22, '2001-01-07', '693 Cypress Dr, Anywhere, USA'),
('1021', 'Andrew Lee', 20, '2003-12-18', '714 Palm Ln, Everywhere, USA'),
('1022', 'Rebecca Perez', 21, '2002-06-24', '825 Sequoia Rd, Somewhere, USA'),
('1023', 'Joshua Thompson', 19, '2004-08-13', '936 Spruce Blvd, Nowhere, USA'),
('1024', 'Samantha White', 22, '2001-03-05', '147 Fir Ct, Anywhere, USA'),
('1025', 'Kevin Harris', 20, '2003-09-28', '258 Hemlock Way, Everywhere, USA'),
('1026', 'Nicole Sanchez', 21, '2002-07-16', '369 Juniper St, Somewhere, USA'),
('1027', 'Brian Clark', 19, '2004-10-22', '471 Alder Ave, Nowhere, USA'),
('1028', 'Heather Ramirez', 22, '2001-02-11', '582 Aspen Dr, Anywhere, USA'),
('1029', 'Timothy Lewis', 20, '2003-11-19', '693 Redbud Ln, Everywhere, USA'),
('1030', 'Rachel Robinson', 21, '2002-04-08', '714 Sassafras Rd, Somewhere, USA'),
('1031', 'Ryan Walker', 19, '2004-05-17', '825 Sumac Blvd, Nowhere, USA'),
('1032', 'Christina Hall', 22, '2001-08-04', '936 Tamarack Ct, Anywhere, USA'),
('1033', 'Jeffrey Young', 20, '2003-01-23', '147 Yew Way, Everywhere, USA'),
('1034', 'Lauren Allen', 21, '2002-12-31', '258 Zelkova St, Somewhere, USA'),
('1035', 'Gary King', 19, '2004-06-12', '369 Katsura Ave, Nowhere, USA'),
('1036', 'Amber Wright', 22, '2001-07-25', '471 Ginkgo Dr, Anywhere, USA'),
('1037', 'Jacob Scott', 20, '2003-03-14', '582 Hornbeam Ln, Everywhere, USA'),
('1038', 'Megan Green', 21, '2002-09-09', '693 Ironwood Rd, Somewhere, USA'),
('1039', 'Nathan Adams', 19, '2004-11-28', '814 Locust Blvd, Nowhere, USA'),
('1040', 'Kayla Baker', 22, '2001-05-19', '925 Mulberry Ct, Anywhere, USA'),
('1041', 'Jonathan Nelson', 20, '2003-04-06', '136 Olive Way, Everywhere, USA'),
('1042', 'Victoria Hill', 21, '2002-10-13', '247 Pear St, Somewhere, USA'),
('1043', 'Samuel Mitchell', 19, '2004-12-24', '358 Persimmon Ave, Nowhere, USA'),
('1044', 'Olivia Carter', 22, '2001-06-15', '469 Plum Dr, Anywhere, USA'),
('1045', 'Brandon Roberts', 20, '2003-02-27', '570 Quince Ln, Everywhere, USA'),
('1046', 'Hannah Phillips', 21, '2002-01-16', '681 Rowan Rd, Somewhere, USA'),
('1047', 'Justin Campbell', 19, '2004-09-07', '792 Serviceberry Blvd, Nowhere, USA'),
('1048', 'Brittany Parker', 22, '2001-10-30', '803 Snowbell Ct, Anywhere, USA'),
('1049', 'Kyle Evans', 20, '2003-07-04', '914 Tupelo Way, Everywhere, USA'),
('1050', 'Alexis Edwards', 21, '2002-03-21', '125 Viburnum St, Somewhere, USA'),
('1051', 'Xavious Nyx', 23, '2000-12-17', '369 Spruce Way, Everywhere, USA');

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

--
-- Indexes for dumped tables
--

--
-- Indexes for table `student_information`
--
ALTER TABLE `student_information`
  ADD PRIMARY KEY (`student_no`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
