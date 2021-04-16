-- phpMyAdmin SQL Dump
-- version 3.4.5
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Nov 29, 2019 at 02:45 AM
-- Server version: 5.5.16
-- PHP Version: 5.3.8

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `dbcollegeattendance`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbladmin`
--

CREATE TABLE IF NOT EXISTS `tbladmin` (
  `id` int(50) NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `admin_fname` int(11) NOT NULL,
  `admin_lname` int(11) NOT NULL,
  `position` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `tbladmin`
--

INSERT INTO `tbladmin` (`id`, `username`, `password`, `admin_fname`, `admin_lname`, `position`) VALUES
(1, 'pogi', 'glenn', 0, 0, 0),
(2, 'admin', 'admin', 0, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `tblevents`
--

CREATE TABLE IF NOT EXISTS `tblevents` (
  `eventid` int(50) NOT NULL AUTO_INCREMENT,
  `event` varchar(50) NOT NULL,
  `date` varchar(50) NOT NULL,
  `venue` varchar(50) NOT NULL,
  `Description` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`eventid`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `tblevents`
--

INSERT INTO `tblevents` (`eventid`, `event`, `date`, `venue`, `Description`) VALUES
(1, 'Xmas Party', 'Thursday, 5 December 2019', 'ISU_Gymnasium', '');

-- --------------------------------------------------------

--
-- Table structure for table `tblstudents`
--

CREATE TABLE IF NOT EXISTS `tblstudents` (
  `stud_id` int(50) NOT NULL AUTO_INCREMENT,
  `f_name` varchar(50) NOT NULL,
  `m_name` varchar(50) DEFAULT NULL,
  `l_name` varchar(50) NOT NULL,
  `dep` varchar(50) NOT NULL,
  `yr_level` varchar(50) NOT NULL,
  `course` varchar(50) NOT NULL,
  `section` varchar(50) NOT NULL,
  PRIMARY KEY (`stud_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `tblstudents`
--

INSERT INTO `tblstudents` (`stud_id`, `f_name`, `m_name`, `l_name`, `dep`, `yr_level`, `course`, `section`) VALUES
(1, 'Glenn Mathew', 'Sawit', 'Garma', 'CCSICT', '2nd Year', 'BSCS', '2-1'),
(2, 'Jake ', 'Vosotros', 'Catembung', 'CCSICT', '2nd Year', 'BSCS', '2-1'),
(3, 'Angelo', 'Queja', 'Inocencio', 'CCSICT', '2nd Year', 'BSCS', '2-1'),
(4, 'Miguel', 'Pogi', 'Ablao', 'CCSICT', '2nd Year', 'BSCS', '15');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_attendance`
--

CREATE TABLE IF NOT EXISTS `tbl_attendance` (
  `att_id` int(50) NOT NULL AUTO_INCREMENT,
  `event` int(50) NOT NULL,
  `stud_name` int(50) NOT NULL,
  `department` int(50) NOT NULL,
  `course_section` int(50) NOT NULL,
  `time_in_am` int(50) DEFAULT NULL,
  `time_out_am` int(50) DEFAULT NULL,
  `time_in_pm` int(50) DEFAULT NULL,
  `time_out_pm` int(50) DEFAULT NULL,
  PRIMARY KEY (`att_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
