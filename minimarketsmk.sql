-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 14 Apr 2022 pada 12.37
-- Versi server: 10.4.20-MariaDB
-- Versi PHP: 8.0.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `minimarketsmk`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_barang`
--

CREATE TABLE `tbl_barang` (
  `id_barang` int(11) NOT NULL,
  `kode_barang` varchar(20) NOT NULL,
  `nama_barang` varchar(20) NOT NULL,
  `nama_kategori` varchar(20) NOT NULL,
  `nama_satuan` varchar(20) NOT NULL,
  `harga_beli` int(20) NOT NULL,
  `harga_jual` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_barang`
--

INSERT INTO `tbl_barang` (`id_barang`, `kode_barang`, `nama_barang`, `nama_kategori`, `nama_satuan`, `harga_beli`, `harga_jual`) VALUES
(18, 'BRG001', 'Lenovo S145', 'elektronik', 'Buah', 6000000, 6000000),
(22, 'BRG002', 'Gamis', 'Pakaian', 'Unit', 100000, 150000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_kategori`
--

CREATE TABLE `tbl_kategori` (
  `id_kategori` int(11) NOT NULL,
  `nama_kategori` varchar(20) NOT NULL,
  `keterangan` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_kategori`
--

INSERT INTO `tbl_kategori` (`id_kategori`, `nama_kategori`, `keterangan`) VALUES
(5, 'elektronik', 'elektronik'),
(6, 'laptop', 'laptop'),
(7, 'Pakaian', 'Pakaian');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_level`
--

CREATE TABLE `tbl_level` (
  `id` int(11) NOT NULL,
  `level` varchar(20) NOT NULL,
  `keterangan` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_level`
--

INSERT INTO `tbl_level` (`id`, `level`, `keterangan`) VALUES
(1, 'admin', 'akses semua'),
(2, 'operator', 'pembelian dan supplier');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_pembelian`
--

CREATE TABLE `tbl_pembelian` (
  `id_pembelian` varchar(11) NOT NULL,
  `nama_supplier` varchar(20) NOT NULL,
  `nama_barang` varchar(20) NOT NULL,
  `no_transaksi` int(20) NOT NULL,
  `tanggal` varchar(20) NOT NULL,
  `jumlah_barang` int(10) NOT NULL,
  `harga` int(15) NOT NULL,
  `diskon` int(10) NOT NULL,
  `status` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_pembelian`
--

INSERT INTO `tbl_pembelian` (`id_pembelian`, `nama_supplier`, `nama_barang`, `no_transaksi`, `tanggal`, `jumlah_barang`, `harga`, `diskon`, `status`) VALUES
('PMB001', 'BTC', 'Lenovo S145', 123456789, '15/03/2022', 50, 60000000, 20, 'Lunas'),
('PMB002', 'BTC', 'Gamis', 12345678, '16/03/2022', 10, 100000, 5, 'Lunas');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_satuan`
--

CREATE TABLE `tbl_satuan` (
  `id_satuan` int(11) NOT NULL,
  `nama_satuan` varchar(20) NOT NULL,
  `keterangan` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_satuan`
--

INSERT INTO `tbl_satuan` (`id_satuan`, `nama_satuan`, `keterangan`) VALUES
(7, 'PCS', 'PCS'),
(8, 'Buah', 'Buah'),
(9, 'Unit', 'Unit');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_status`
--

CREATE TABLE `tbl_status` (
  `id` int(11) NOT NULL,
  `status` varchar(20) NOT NULL,
  `keterangan` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_status`
--

INSERT INTO `tbl_status` (`id`, `status`, `keterangan`) VALUES
(1, 'Aktif', 'Aktif'),
(2, 'Tidak Aktif', 'Tidak Aktif');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_supplier`
--

CREATE TABLE `tbl_supplier` (
  `id_supplier` int(11) NOT NULL,
  `nama_supplier` varchar(20) NOT NULL,
  `alamat` varchar(50) NOT NULL,
  `no_tlp` varchar(20) NOT NULL,
  `nama_bank` varchar(10) NOT NULL,
  `no_rekening` int(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_supplier`
--

INSERT INTO `tbl_supplier` (`id_supplier`, `nama_supplier`, `alamat`, `no_tlp`, `nama_bank`, `no_rekening`) VALUES
(2, 'BTC', 'Solo', '0812345', 'BCA', 12345678);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_user`
--

CREATE TABLE `tbl_user` (
  `id_user` int(11) NOT NULL,
  `nama_user` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `status` varchar(10) NOT NULL,
  `level` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_user`
--

INSERT INTO `tbl_user` (`id_user`, `nama_user`, `password`, `status`, `level`) VALUES
(5, 'admin', 'admin', 'Aktif', 'admin'),
(9, 'karyawan biasa', 'karyawan', 'Aktif', 'operator');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbl_barang`
--
ALTER TABLE `tbl_barang`
  ADD PRIMARY KEY (`id_barang`);

--
-- Indeks untuk tabel `tbl_kategori`
--
ALTER TABLE `tbl_kategori`
  ADD PRIMARY KEY (`id_kategori`),
  ADD UNIQUE KEY `nama_kategori` (`nama_kategori`);

--
-- Indeks untuk tabel `tbl_level`
--
ALTER TABLE `tbl_level`
  ADD PRIMARY KEY (`id`);

--
-- Indeks untuk tabel `tbl_pembelian`
--
ALTER TABLE `tbl_pembelian`
  ADD PRIMARY KEY (`id_pembelian`);

--
-- Indeks untuk tabel `tbl_satuan`
--
ALTER TABLE `tbl_satuan`
  ADD PRIMARY KEY (`id_satuan`),
  ADD UNIQUE KEY `nama_satuan` (`nama_satuan`);

--
-- Indeks untuk tabel `tbl_status`
--
ALTER TABLE `tbl_status`
  ADD PRIMARY KEY (`id`);

--
-- Indeks untuk tabel `tbl_supplier`
--
ALTER TABLE `tbl_supplier`
  ADD PRIMARY KEY (`id_supplier`);

--
-- Indeks untuk tabel `tbl_user`
--
ALTER TABLE `tbl_user`
  ADD PRIMARY KEY (`id_user`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `tbl_barang`
--
ALTER TABLE `tbl_barang`
  MODIFY `id_barang` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT untuk tabel `tbl_kategori`
--
ALTER TABLE `tbl_kategori`
  MODIFY `id_kategori` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT untuk tabel `tbl_level`
--
ALTER TABLE `tbl_level`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT untuk tabel `tbl_satuan`
--
ALTER TABLE `tbl_satuan`
  MODIFY `id_satuan` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT untuk tabel `tbl_status`
--
ALTER TABLE `tbl_status`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT untuk tabel `tbl_supplier`
--
ALTER TABLE `tbl_supplier`
  MODIFY `id_supplier` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT untuk tabel `tbl_user`
--
ALTER TABLE `tbl_user`
  MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
