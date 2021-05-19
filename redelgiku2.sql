-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 19, 2021 at 01:28 PM
-- Server version: 10.4.19-MariaDB
-- PHP Version: 8.0.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `redelgiku2`
--

-- --------------------------------------------------------

--
-- Table structure for table `gaji`
--

CREATE TABLE `gaji` (
  `Kode_Slip_Gaji` char(5) NOT NULL,
  `ID_Pegawai` char(10) NOT NULL,
  `Tgl_Gajian` varchar(20) NOT NULL,
  `Total` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `gaji`
--

INSERT INTO `gaji` (`Kode_Slip_Gaji`, `ID_Pegawai`, `Tgl_Gajian`, `Total`) VALUES
('445', '123', '18 mei 2021', '2000000');

-- --------------------------------------------------------

--
-- Table structure for table `mapel`
--

CREATE TABLE `mapel` (
  `Nama_Ruangan` varchar(20) NOT NULL,
  `Nama_Mapel` varchar(20) NOT NULL,
  `ID_Pegawai` char(8) NOT NULL,
  `ID_Mapel` char(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `mapel`
--

INSERT INTO `mapel` (`Nama_Ruangan`, `Nama_Mapel`, `ID_Pegawai`, `ID_Mapel`) VALUES
('mee', 'Biologi', '123', '666'),
('mee', 'Kimia', '124', '667'),
('meet10', 'Fisika', '122', '669'),
('meet45', 'biologi', '122', '67'),
('RFIS12', 'Fisika 12', '123', 'FIS12');

-- --------------------------------------------------------

--
-- Table structure for table `murid`
--

CREATE TABLE `murid` (
  `ID_Murid` char(10) NOT NULL,
  `Nama_Murid` varchar(20) NOT NULL,
  `Tgl_Lahir` varchar(20) NOT NULL,
  `Jenis_Kelamin` char(1) NOT NULL,
  `Alamat` varchar(20) NOT NULL,
  `Kelas` varchar(10) NOT NULL,
  `Jurusan` varchar(30) NOT NULL,
  `No_Telp` varchar(20) NOT NULL,
  `ID_Mapel` char(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `murid`
--

INSERT INTO `murid` (`ID_Murid`, `Nama_Murid`, `Tgl_Lahir`, `Jenis_Kelamin`, `Alamat`, `Kelas`, `Jurusan`, `No_Telp`, `ID_Mapel`) VALUES
('200009', 'Anggie', '7 Juni 2002', 'P', 'Srikaya1', '12', 'IPA', '09876568857', 'FIS12'),
('200028', 'FIS12', '12 September 2002', 'L', 'Jalan Azalea', '12', 'IPA', '081289856576', 'FIS12'),
('20020', 'Andine', '2 januari 2003', 'P', 'Jalan Gunung', '12', 'IPA', '08123445566', 'FIS12');

-- --------------------------------------------------------

--
-- Table structure for table `nilai`
--

CREATE TABLE `nilai` (
  `ID_Murid` char(10) NOT NULL,
  `ID_Mapel` char(10) NOT NULL,
  `Latihan` varchar(3) NOT NULL,
  `Quiz` varchar(3) NOT NULL,
  `TO` varchar(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `nilai`
--

INSERT INTO `nilai` (`ID_Murid`, `ID_Mapel`, `Latihan`, `Quiz`, `TO`) VALUES
('200009', 'FIS12', '90', '80', '100');

-- --------------------------------------------------------

--
-- Table structure for table `pegawai`
--

CREATE TABLE `pegawai` (
  `ID_Pegawai` char(10) NOT NULL,
  `Nama_Pegawai` varchar(100) NOT NULL,
  `Jenis_Kelamin` varchar(10) NOT NULL,
  `Jabatan` varchar(20) NOT NULL,
  `Tgl_Lahir` varchar(20) NOT NULL,
  `Alamat` varchar(20) NOT NULL,
  `No_Telp` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pegawai`
--

INSERT INTO `pegawai` (`ID_Pegawai`, `Nama_Pegawai`, `Jenis_Kelamin`, `Jabatan`, `Tgl_Lahir`, `Alamat`, `No_Telp`) VALUES
('119', 'yusuf', 'P', 'tenaga kebersihan', '9 mei 2000', 'Bandung', '098'),
('120', 'Shaquillw', 'L', 'tenaga kebersihan', '8 juli 2002', 'Jalan mei', '089767546321'),
('122', 'Anan', 'P', 'Tenaga Keamanan', '8 Mei 2000', 'Jalan Sukabumi', '083456789123'),
('123', 'Farell', 'L', 'Guru', '7 Juni 2002', 'Jalan Rambutan', '086482327877'),
('124', 'Della', 'P', 'Guru', '19 April 2002', 'Jalan Sukabumi', '089445667889'),
('150', 'oscar', 'L', 'CS', '14 mei 1996', 'Jalan Braga', '0897653723526');

-- --------------------------------------------------------

--
-- Table structure for table `pilihmapel`
--

CREATE TABLE `pilihmapel` (
  `ID_Murid` char(10) NOT NULL,
  `ID_Mapel` char(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pilihmapel`
--

INSERT INTO `pilihmapel` (`ID_Murid`, `ID_Mapel`) VALUES
('20020', 'FIS12');

-- --------------------------------------------------------

--
-- Table structure for table `tagihan`
--

CREATE TABLE `tagihan` (
  `No_Kwitansi` varchar(10) NOT NULL,
  `ID_Murid` char(10) NOT NULL,
  `Tgl_Pembayaran` varchar(20) NOT NULL,
  `Total` varchar(20) NOT NULL,
  `Ket_Bayar` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `gaji`
--
ALTER TABLE `gaji`
  ADD PRIMARY KEY (`Kode_Slip_Gaji`),
  ADD KEY `ID_Pegawai` (`ID_Pegawai`);

--
-- Indexes for table `mapel`
--
ALTER TABLE `mapel`
  ADD PRIMARY KEY (`ID_Mapel`),
  ADD KEY `ID_Pegawai` (`ID_Pegawai`);

--
-- Indexes for table `murid`
--
ALTER TABLE `murid`
  ADD PRIMARY KEY (`ID_Murid`),
  ADD KEY `ID_Mapel` (`ID_Mapel`);

--
-- Indexes for table `nilai`
--
ALTER TABLE `nilai`
  ADD PRIMARY KEY (`ID_Murid`,`ID_Mapel`),
  ADD KEY `ID_Murid` (`ID_Murid`),
  ADD KEY `ID_Mapel` (`ID_Mapel`);

--
-- Indexes for table `pegawai`
--
ALTER TABLE `pegawai`
  ADD PRIMARY KEY (`ID_Pegawai`);

--
-- Indexes for table `pilihmapel`
--
ALTER TABLE `pilihmapel`
  ADD KEY `ID_Murid` (`ID_Murid`),
  ADD KEY `ID_Mapel` (`ID_Mapel`);

--
-- Indexes for table `tagihan`
--
ALTER TABLE `tagihan`
  ADD PRIMARY KEY (`No_Kwitansi`),
  ADD KEY `ID_Murid` (`ID_Murid`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `gaji`
--
ALTER TABLE `gaji`
  ADD CONSTRAINT `fk_gaji_pegawai` FOREIGN KEY (`ID_Pegawai`) REFERENCES `pegawai` (`ID_Pegawai`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `mapel`
--
ALTER TABLE `mapel`
  ADD CONSTRAINT `fk_mapel_pegawai` FOREIGN KEY (`ID_Pegawai`) REFERENCES `pegawai` (`ID_Pegawai`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `murid`
--
ALTER TABLE `murid`
  ADD CONSTRAINT `fk_murid_mapel` FOREIGN KEY (`ID_Mapel`) REFERENCES `mapel` (`ID_Mapel`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `nilai`
--
ALTER TABLE `nilai`
  ADD CONSTRAINT `fk_nilai_mapel` FOREIGN KEY (`ID_Mapel`) REFERENCES `mapel` (`ID_Mapel`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_nilai_murid` FOREIGN KEY (`ID_Murid`) REFERENCES `murid` (`ID_Murid`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `pilihmapel`
--
ALTER TABLE `pilihmapel`
  ADD CONSTRAINT `fk_mapel_pilihmapel` FOREIGN KEY (`ID_Mapel`) REFERENCES `mapel` (`ID_Mapel`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_murid_pilihmapel` FOREIGN KEY (`ID_Murid`) REFERENCES `murid` (`ID_Murid`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tagihan`
--
ALTER TABLE `tagihan`
  ADD CONSTRAINT `fk_tagihan_murid` FOREIGN KEY (`ID_Murid`) REFERENCES `murid` (`ID_Murid`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
