-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 28-Fev-2020 às 01:42
-- Versão do servidor: 10.1.37-MariaDB
-- versão do PHP: 7.3.0



SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `escola`
--
CREATE DATABASE `escola`; 
-- --------------------------------------------------------

--
-- Estrutura da tabela `alunos`
--


CREATE TABLE `alunos` (
  `nome` varchar(50) DEFAULT NULL,
  `numero` int(11) DEFAULT NULL,
  `ra` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `alunos`
--

INSERT INTO `alunos` (`nome`, `numero`, `ra`) VALUES
('João', 1, 123456),
('Pedro', 2, 321456),
('Maria', 3, 322134),
('Ana', 4, 432145),
('José', 5, 654321);

-- --------------------------------------------------------

--
-- Estrutura da tabela `aulas`
--

CREATE TABLE `aulas` (
  `idAula` int(11) NOT NULL,
  `idMateria` int(11) NOT NULL,
  `rm` int(11) NOT NULL,
  `faltas` int(11) NOT NULL,
  `data_aula` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `aulas`
--

INSERT INTO `aulas` (`idAula`, `idMateria`, `rm`, `faltas`, `data_aula`) VALUES
(1, 2, 1234567, 1, '2020-03-11'),
(2, 1, 2335678, 0, '2020-03-11'),
(3, 3, 3456789, 1, '2020-03-12'),
(4, 2, 1456789, 0, '2020-03-13'),
(5, 1, 2345678, 0, '2020-03-15');

-- --------------------------------------------------------

--
-- Estrutura da tabela `materias`
--

CREATE TABLE `materias` (
  `idMateria` int(11) NOT NULL,
  `nomeMatéria` varchar(50) DEFAULT NULL,
  `idTurma` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `materias`
--

INSERT INTO `materias` (`idMateria`, `nomeMatéria`, `idTurma`) VALUES
(1, 'Programação', 1),
(2, 'Desenho', 2),
(3, 'Contabilidade', 3);

-- --------------------------------------------------------

--
-- Estrutura da tabela `matricula`
--

CREATE TABLE `matricula` (
  `rm` int(11) NOT NULL,
  `idTurma` int(11) NOT NULL,
  `ra` int(11) NOT NULL,
  `data_matricula` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `matricula`
--

INSERT INTO `matricula` (`rm`, `idTurma`, `ra`, `data_matricula`) VALUES
(1234567, 2, 432145, '2018-02-10'),
(1456789, 2, 322134, '2018-02-11'),
(2335678, 1, 654321, '2018-02-11'),
(2345678, 1, 321456, '2018-02-10'),
(3456789, 3, 123456, '2018-02-10');

-- --------------------------------------------------------

--
-- Estrutura da tabela `turma`
--

CREATE TABLE `turma` (
  `IdTurma` int(11) NOT NULL,
  `nomeTurma` varchar(30) DEFAULT NULL,
  `curso` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `turma`
--

INSERT INTO `turma` (`IdTurma`, `nomeTurma`, `curso`) VALUES
(1, '3C', 'Informática'),
(2, '3A', 'Design'),
(3, '3E', 'Logística');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `alunos`
--
ALTER TABLE `alunos`
  ADD PRIMARY KEY (`ra`);

--
-- Indexes for table `aulas`
--
ALTER TABLE `aulas`
  ADD PRIMARY KEY (`idAula`),
  ADD KEY `idMateria` (`idMateria`),
  ADD KEY `rm` (`rm`);

--
-- Indexes for table `materias`
--
ALTER TABLE `materias`
  ADD PRIMARY KEY (`idMateria`),
  ADD KEY `idTurma` (`idTurma`);

--
-- Indexes for table `matricula`
--
ALTER TABLE `matricula`
  ADD PRIMARY KEY (`rm`),
  ADD KEY `idTurma` (`idTurma`),
  ADD KEY `ra` (`ra`);

--
-- Indexes for table `turma`
--
ALTER TABLE `turma`
  ADD PRIMARY KEY (`IdTurma`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `alunos`
--
ALTER TABLE `alunos`
  MODIFY `ra` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=654322;

--
-- AUTO_INCREMENT for table `matricula`
--
ALTER TABLE `matricula`
  MODIFY `rm` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3456790;

--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `aulas`
--
ALTER TABLE `aulas`
  ADD CONSTRAINT `aulas_ibfk_1` FOREIGN KEY (`idMateria`) REFERENCES `materias` (`idMateria`),
  ADD CONSTRAINT `aulas_ibfk_2` FOREIGN KEY (`rm`) REFERENCES `matricula` (`rm`);

--
-- Limitadores para a tabela `materias`
--
ALTER TABLE `materias`
  ADD CONSTRAINT `materias_ibfk_1` FOREIGN KEY (`idTurma`) REFERENCES `turma` (`IdTurma`);

--
-- Limitadores para a tabela `matricula`
--
ALTER TABLE `matricula`
  ADD CONSTRAINT `matricula_ibfk_1` FOREIGN KEY (`idTurma`) REFERENCES `turma` (`IdTurma`),
  ADD CONSTRAINT `matricula_ibfk_2` FOREIGN KEY (`ra`) REFERENCES `alunos` (`ra`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;


-- EXERCÍCIOS --
--1) Insira mais um registro na tabela aluno--
INSERT INTO `alunos` (`nome`, `numero`, `ra`) VALUES
('Bruno', 6, 666443);

--2)Edite esse registro (nome)--
UPDATE 'alunos'
SET nome = 'Antônio'
WHERE numero = 6;

--3)Apague esse registro
DELETE FROM 'alunos'
WHERE numero = 6;
