-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 23, 2022 at 07:39 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_sipeka`
--

-- --------------------------------------------------------

--
-- Table structure for table `detail_resep`
--

CREATE TABLE `detail_resep` (
  `kode_resep` varchar(50) NOT NULL,
  `kode_obat` varchar(50) NOT NULL,
  `aturan_pakai` text NOT NULL,
  `jumlah_obat` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Triggers `detail_resep`
--
DELIMITER $$
CREATE TRIGGER `KurangStokBarang` AFTER INSERT ON `detail_resep` FOR EACH ROW BEGIN
	UPDATE obat 
	SET stok = stok-new.jumlah_obat
	WHERE kode_obat = new.kode_obat;
    END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `dokter`
--

CREATE TABLE `dokter` (
  `kode_dokter` varchar(10) NOT NULL,
  `nama_dokter` varchar(100) NOT NULL,
  `kode_poli` varchar(10) NOT NULL,
  `no_telepon` varchar(15) NOT NULL,
  `jadwal` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `dokter`
--

INSERT INTO `dokter` (`kode_dokter`, `nama_dokter`, `kode_poli`, `no_telepon`, `jadwal`) VALUES
('D001', 'Dr.Joko', 'P002', '08123145123', 'Senin'),
('D002', 'Dr.Michel', 'P003', '081424131324', 'Selasa'),
('D003', 'Dr.Robert', 'P003', '0813215423', 'Jumat'),
('D004', 'Dr.Sergio', 'P004', '081321421', 'Minggu'),
('D005', 'Dr.Richard', 'P001', '0813241231', 'Minggu'),
('D006', 'Dr.Santoso', 'P003', '085452421431', 'Senin'),
('D007', 'Dr. Tresno', 'P005', '0814341231', 'Rabu'),
('D008', 'Dr.Renggo', 'P003', '08132412313', 'Kamis');

-- --------------------------------------------------------

--
-- Table structure for table `obat`
--

CREATE TABLE `obat` (
  `kode_obat` varchar(10) NOT NULL,
  `jenis_obat` varchar(20) NOT NULL,
  `nama_obat` varchar(30) NOT NULL,
  `ex_date` date NOT NULL,
  `stok` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `obat`
--

INSERT INTO `obat` (`kode_obat`, `jenis_obat`, `nama_obat`, `ex_date`, `stok`) VALUES
('O001', 'Obat Cair', 'OBH', '2025-03-03', 84),
('O002', 'Tablet', 'Paracetamol', '2024-06-17', 39),
('O003', 'Obat Tetes', 'Timol', '2023-07-18', 52),
('O004', 'Kapsul', 'Promagh', '2024-08-05', 40);

-- --------------------------------------------------------

--
-- Table structure for table `pasien`
--

CREATE TABLE `pasien` (
  `no_kartu_berobat` varchar(13) NOT NULL,
  `no_identitas` varchar(16) NOT NULL,
  `no_bpjs` varchar(11) DEFAULT NULL,
  `nama` varchar(30) NOT NULL,
  `ttl` date NOT NULL,
  `jk` varchar(11) NOT NULL,
  `umur` int(11) NOT NULL,
  `agama` varchar(25) NOT NULL,
  `no_telepon` varchar(15) NOT NULL,
  `alamat` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pasien`
--

INSERT INTO `pasien` (`no_kartu_berobat`, `no_identitas`, `no_bpjs`, `nama`, `ttl`, `jk`, `umur`, `agama`, `no_telepon`, `alamat`) VALUES
('A001', 'B001', '00015678098', 'Latifah Ayu', '2003-02-04', 'Perempuan', 23, 'Islam', '089768900888', 'Jalan Mawar'),
('A002', 'B002', '00015678889', 'Fakih A.', '2007-06-20', 'Laki-Laki', 14, 'Islam', '085679444678', 'Jalan Kelinci'),
('A003', 'B003', '00012354478', 'Salsabila P.', '2007-07-30', 'Perempuan', 20, 'Kristen', '089007654332', 'Jalan Belimbing'),
('A004', 'B004', '00016668905', 'Diki Saputra', '2008-06-17', 'Laki-Laki', 13, 'Islam', '081234678999', 'Jalan Lombok'),
('A005', 'B005', '', 'Ferdy Sam', '1965-11-25', 'Laki-Laki', 57, 'Kriten', '08124124123', 'Jl. Nangka 12');

-- --------------------------------------------------------

--
-- Table structure for table `pendaftaran`
--

CREATE TABLE `pendaftaran` (
  `kode_pendaftaran` varchar(10) NOT NULL,
  `no_kartu_berobat` varchar(13) NOT NULL,
  `kode_poli` varchar(10) NOT NULL,
  `kode_dokter` varchar(10) NOT NULL,
  `tanggal_daftar` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `poli`
--

CREATE TABLE `poli` (
  `kode_poli` varchar(10) NOT NULL,
  `nama_poli` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `poli`
--

INSERT INTO `poli` (`kode_poli`, `nama_poli`) VALUES
('P001', 'Poli Anak'),
('P002', 'Poli Jantung'),
('P003', 'Poli Dalam'),
('P004', 'Poli Mata'),
('P005', 'Poli Gigi');

-- --------------------------------------------------------

--
-- Table structure for table `resep`
--

CREATE TABLE `resep` (
  `kode_resep` varchar(50) NOT NULL,
  `kode_dokter` varchar(10) NOT NULL,
  `kode_pendaftaran` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Stand-in structure for view `searchpasien`
-- (See below for the actual view)
--
CREATE TABLE `searchpasien` (
`no_kartu_berobat` varchar(13)
,`no_bpjs` varchar(11)
,`nama` varchar(30)
,`nama_poli` varchar(50)
,`nama_dokter` varchar(100)
,`tanggal_daftar` date
);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `nama_user` varchar(50) NOT NULL,
  `level` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`username`, `password`, `nama_user`, `level`) VALUES
('abyan', '12345', 'Abyan Putra Bangsawan', 'Admin'),
('hendri', '12345', 'Hendri Wahyu Perdana', 'Admin'),
('poppy', '12345', 'Poppy Jesica Avanoes', 'Admin'),
('utami', '12345', 'Utami Septiana', 'Admin'),
('tresno', '12345', 'Dr.Tresno Wongso', 'Dokter');

-- --------------------------------------------------------

--
-- Structure for view `searchpasien`
--
DROP TABLE IF EXISTS `searchpasien`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `searchpasien`  AS   (select `p`.`no_kartu_berobat` AS `no_kartu_berobat`,`p`.`no_bpjs` AS `no_bpjs`,`p`.`nama` AS `nama`,`pol`.`nama_poli` AS `nama_poli`,`d`.`nama_dokter` AS `nama_dokter`,`pen`.`tanggal_daftar` AS `tanggal_daftar` from (((`pasien` `p` join `pendaftaran` `pen` on(`p`.`no_kartu_berobat` = `pen`.`no_kartu_berobat`)) join `poli` `pol` on(`pol`.`kode_poli` = `pen`.`kode_poli`)) join `dokter` `d` on(`pen`.`kode_dokter` = `d`.`kode_dokter`)) order by `p`.`no_kartu_berobat`)  ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `dokter`
--
ALTER TABLE `dokter`
  ADD KEY `kode_poli` (`kode_poli`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
