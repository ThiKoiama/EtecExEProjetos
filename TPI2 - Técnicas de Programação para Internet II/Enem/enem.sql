-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 07, 2019 at 11:54 PM
-- Server version: 10.4.6-MariaDB
-- PHP Version: 7.3.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `enem`
--

-- --------------------------------------------------------

--
-- Table structure for table `pontuacao`
--

CREATE TABLE `pontuacao` (
  `id` int(11) NOT NULL,
  `id_usu` int(11) DEFAULT NULL,
  `pontuacao` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `pontuacao`
--

INSERT INTO `pontuacao` (`id`, `id_usu`, `pontuacao`) VALUES
(1, 3, 2),
(2, 4, 6);

-- --------------------------------------------------------

--
-- Table structure for table `questoes`
--

CREATE TABLE `questoes` (
  `id` int(11) NOT NULL,
  `enunciado` varchar(1000) NOT NULL,
  `imagem` varchar(30) NOT NULL,
  `alternativaA` varchar(100) NOT NULL,
  `alternativaB` varchar(100) NOT NULL,
  `alternativaC` varchar(100) NOT NULL,
  `alternativaD` varchar(100) NOT NULL,
  `alternativaE` varchar(100) NOT NULL,
  `alternativaCorreta` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `questoes`
--

INSERT INTO `questoes` (`id`, `enunciado`, `imagem`, `alternativaA`, `alternativaB`, `alternativaC`, `alternativaD`, `alternativaE`, `alternativaCorreta`) VALUES
(1, 'A memÃ³ria recuperada entre a autora representa a relaÃ§Ã£o entre:', '2019.11.03-20.58.21.jpg', 'conflito trabalhista e engajamento sindical', 'organizaÃ§Ã£o familiar e proteÃ§Ã£o Ã  infÃ¢ncia', 'centralizaÃ§Ã£o econÃ´mica e pregaÃ§Ã£o religiosa', 'estrutura educacional e desigualdade de renda', 'transformaÃ§Ã£o polÃ­tica e modificaÃ§Ã£o de costumes', 'transformaÃ§Ã£o polÃ­tica e modificaÃ§Ã£o de costumes'),
(2, 'Um exemplo de tal processo Ã© o:', '2019.11.03-21.40.56.jpg', 'desenvolvimento embrionÃ¡rio', 'reproduÃ§Ã£o sexuada', 'respiraÃ§Ã£o aerÃ³bica', 'excreÃ§Ã£o urinÃ¡ria', 'sÃ­ntese proteica', 'sÃ­ntese proteica'),
(3, 'Nesse contexto, a qualidade nutricional do grÃ£o de trigo serÃ¡ modificada primariamente pela reduÃ§Ã£o de', '2019.11.03-22.40.16.jpg', 'amido', 'frutose', 'lipÃ­deos', 'celulose', 'proteÃ­nas', 'proteÃ­nas'),
(4, 'No texto, evidencia-se que a construÃ§Ã£o do significado da palavra mandinga resulta de um(a)', '2019.11.03-22.43.28.jpg', 'contexto sÃ³cio-histÃ³rico', 'diversidade Ã©tnica', 'descoberta geogrÃ¡fica', 'apropriaÃ§Ã£o religiosa', 'contraste cultural', 'contexto sÃ³cio-histÃ³rico'),
(5, 'Uma caracterÃ­stica do gÃªnero diÃ¡rio que aparece na letra de Chico Buarque Ã© o:', '2019.11.03-22.47.03.jpg', 'recorrÃªncia de verbos no infinitivo', 'predominÃ¢ncia de tom poÃ©tico', 'uso de rimas na composiÃ§Ã£o', 'narrativa autorreflexiva', 'n.d.a', 'narrativa autorreflexiva'),
(6, 'Considerando os princÃ­pios expostos no texto, o drible no handebol caracteriza o princÃ­pio de:', '2019.11.03-22.50.49.jpg', 'recuperaÃ§Ã£o da bola', 'progressÃ£o da equipe', 'finalizaÃ§Ã£o da jogada', 'proteÃ§Ã£o do prÃ³prio alvo', 'impedimento do avanÃ§o adversÃ¡rio', 'progressÃ£o da equipe'),
(7, 'Nos prÃ³ximos dois meses essa empresa deverÃ¡ comprar a mesma quantidade de matÃ©ria-prima comprada no mÃªs', '2019.11.03-22.54.45.jpg', 'I', 'II', 'IV', 'V', 'VII', 'V'),
(8, 'A marca a ser escolhida Ã©:', '2019.11.03-23.05.32.jpg', 'A', 'B', 'C', 'D', 'E', 'B'),
(9, 'Com base no quadro, qual Ã© a moda do nÃºmero de pessoas no elevador durante a subida do tÃ©rreo ao quinto andar?', '2019.11.03-23.08.08.jpg', '2', '3', '4', '5', '6', '5'),
(10, 'A tÃ©cnica de dataÃ§Ã£o apresentada no texto sÃ³ Ã© possÃ­vel devido a:', '2019.11.03-23.13.06.jpg', 'proporÃ§Ã£o conhecida entre carbono-14 e carbono-12 na atmosfera ao longo dos anos', 'decomposiÃ§Ã£o de todo o carbono-12 presente no organismo apÃ³s a morte', 'fixaÃ§Ã£o maior de carbono-14 nos tecidos de organismos apÃ³s a morte', 'emissÃ£o de carbono-12 pelos tecidos de organismos apÃ³s a morte', 'transformaÃ§Ã£o do carbono-12 em carbono-14 ao longo dos anos', 'proporÃ§Ã£o conhecida entre carbono-14 e carbono-12 na atmosfera ao longo dos anos');

-- --------------------------------------------------------

--
-- Table structure for table `respostas`
--

CREATE TABLE `respostas` (
  `id` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `id_questao` int(11) NOT NULL,
  `Data` date NOT NULL,
  `Hora` time DEFAULT NULL,
  `alternativaResp` char(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `respostas`
--

INSERT INTO `respostas` (`id`, `id_usuario`, `id_questao`, `Data`, `Hora`, `alternativaResp`) VALUES
(1, 3, 1, '0000-00-00', '15:15:00', 'A'),
(2, 3, 2, '0000-00-00', '15:15:00', 'B'),
(3, 3, 3, '0000-00-00', '15:15:00', 'D'),
(4, 3, 4, '0000-00-00', '15:15:00', 'C'),
(5, 3, 5, '0000-00-00', '15:15:00', 'C'),
(6, 3, 6, '0000-00-00', '15:15:00', 'D'),
(7, 3, 7, '0000-00-00', '15:15:00', 'D'),
(8, 3, 8, '0000-00-00', '15:15:00', 'C'),
(9, 3, 9, '0000-00-00', '15:15:00', 'C'),
(10, 3, 10, '0000-00-00', '15:15:00', 'A'),
(11, 3, 1, '0000-00-00', '21:23:00', 'A'),
(12, 3, 2, '0000-00-00', '21:23:00', 'A'),
(13, 3, 3, '0000-00-00', '21:23:00', 'A'),
(14, 3, 4, '0000-00-00', '21:23:00', 'A'),
(15, 3, 5, '0000-00-00', '21:23:00', 'A'),
(16, 3, 6, '0000-00-00', '21:23:00', 'C'),
(17, 3, 7, '0000-00-00', '21:23:00', 'B'),
(18, 3, 8, '0000-00-00', '21:23:00', 'B'),
(19, 3, 9, '0000-00-00', '21:23:00', 'B'),
(20, 3, 10, '0000-00-00', '21:23:00', 'A'),
(21, 4, 1, '0000-00-00', '21:33:00', 'E'),
(22, 4, 2, '0000-00-00', '21:33:00', 'E'),
(23, 4, 3, '0000-00-00', '21:33:00', 'E'),
(24, 4, 4, '0000-00-00', '21:33:00', 'E'),
(25, 4, 5, '0000-00-00', '21:33:00', 'D'),
(26, 4, 6, '0000-00-00', '21:33:00', 'C'),
(27, 4, 7, '0000-00-00', '21:33:00', 'B'),
(28, 4, 8, '0000-00-00', '21:33:00', 'B'),
(29, 4, 9, '0000-00-00', '21:33:00', 'C'),
(30, 4, 10, '0000-00-00', '21:33:00', 'A');

-- --------------------------------------------------------

--
-- Table structure for table `usuarios`
--

CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `login` varchar(50) NOT NULL,
  `senha` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `usuarios`
--

INSERT INTO `usuarios` (`id`, `nome`, `login`, `senha`) VALUES
(1, 'Admin', 'admin', '21232f297a57a5a743894a0e4a801fc3'),
(2, 'Joao', 'jota', '85ad902286ae933575ca51ab45f60399'),
(3, 'Irresponsavel', 'morre', '5a676e74614c4003397cc974d054cead'),
(4, 'Gilson', 'gilsinho', '099dff9b900c68c6fcec6dcd8e1437ca');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `pontuacao`
--
ALTER TABLE `pontuacao`
  ADD PRIMARY KEY (`id`),
  ADD KEY `pontuacao_ibfk_1` (`id_usu`);

--
-- Indexes for table `questoes`
--
ALTER TABLE `questoes`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `respostas`
--
ALTER TABLE `respostas`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_usuario` (`id_usuario`),
  ADD KEY `id_questao` (`id_questao`);

--
-- Indexes for table `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `pontuacao`
--
ALTER TABLE `pontuacao`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `questoes`
--
ALTER TABLE `questoes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `respostas`
--
ALTER TABLE `respostas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT for table `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `pontuacao`
--
ALTER TABLE `pontuacao`
  ADD CONSTRAINT `pontuacao_ibfk_1` FOREIGN KEY (`id_usu`) REFERENCES `usuarios` (`id`) ON DELETE CASCADE;

--
-- Constraints for table `respostas`
--
ALTER TABLE `respostas`
  ADD CONSTRAINT `respostas_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `usuarios` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `respostas_ibfk_2` FOREIGN KEY (`id_questao`) REFERENCES `questoes` (`id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
