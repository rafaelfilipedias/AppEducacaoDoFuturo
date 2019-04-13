CREATE DATABASE dbEducacaoDoFuturo
GO
 
USE dbEducacaoDoFuturo
GO

CREATE TABLE Diretor(
	codDiretor		VARCHAR(10)PRIMARY KEY NOT NULL,
	nome			VARCHAR (80) NOT NULL,
	cpf				VARCHAR(13) NOT NULL,
	senha			VARCHAR(80) NOT NULL, 
	usuario			VARCHAR(100) NOT NULL,
	dataNasc		DATE NOT NULL,
	telefone		VARCHAR(14) NOT NULL,
	email			VARCHAR(80) NOT NULL
);
GO

CREATE TABLE CoordenadorCurso(
	codCoordenador VARCHAR(10) PRIMARY KEY NOT NULL,
	Diretor_codDiretor VARCHAR(10) NOT NULL,
	FOREIGN KEY (Diretor_codDiretor) REFERENCES Diretor (codDiretor), 
	nome VARCHAR(80) NOT NULL,
	cpf VARCHAR(13) NOT NULL,
	telefone VARCHAR(14) NOT NULL,
	email VARCHAR(80) NOT NULL,
	dataNasc DATE NOT NULL,
	dataCadastro DATE NOT NULL,
	usuario VARCHAR (70) NOT NULL,
	senha VARCHAR(80) NOT NULL

);
GO

CREATE TABLE Curso(
	codCurso VARCHAR(10)PRIMARY KEY NOT NULL,
	nome VARCHAR (80) NOT NULL,
	planoDeAula VARCHAR (MAX) NOT NULL,
	conteudoCurso VARCHAR (MAX) NOT NULL,
	planoCurso VARCHAR(MAX) NOT NULL,
	Diretor_codDiretor VARCHAR(10) not null,
	FOREIGN KEY (Diretor_codDiretor) REFERENCES Diretor (codDiretor), 
	CoordenadorCurso_codCoordenador VARCHAR(10),
	FOREIGN KEY (CoordenadorCurso_codCoordenador) REFERENCES CoordenadorCurso (CodCoordenador)
);
GO

CREATE TABLE Funcionario(
	codFuncionario VARCHAR(10)PRIMARY KEY NOT NULL,
	Diretor_codDiretor VARCHAR(10) NOT NULL,
	FOREIGN KEY (Diretor_codDiretor) REFERENCES Diretor (codDiretor),
	cpf VARCHAR(13) NOT NULL,
	telefone VARCHAR(14) NOT NULL,
	email VARCHAR(80) NOT NULL,
	dataNasc DATE NOT NULL,
	dataCadastro DATE NOT NULL,
	tipoFunc INT NOT NULL,
	nome VARCHAR(80) NOT NULL,
	senha VARCHAR(80) NOT NULL,
	usuario VARCHAR (70) NOT NULL
);
GO

CREATE TABLE Aluno(
	codAluno VARCHAR(10)PRIMARY KEY NOT NULL,
	codMatricula VARCHAR(10) NOT NULL,
	nome VARCHAR(80) NOT NULL,
	cpf VARCHAR(13) NOT NULL,
	telefone VARCHAR(14) NOT NULL,
	email VARCHAR(80) NOT NULL,
	dataNasc DATE NOT NULL,
	Funcionario_codFuncionario VARCHAR(10) NOT NULL,
	FOREIGN KEY (Funcionario_codFuncionario) REFERENCES Funcionario (codFuncionario),
	Curso_codCurso VARCHAR(10) NOT NULL,
	FOREIGN KEY (Curso_codCurso) REFERENCES Curso (codCurso)
);
GO

CREATE TABLE Professor(
	codProfessor VARCHAR(10)PRIMARY KEY NOT NULL,
	nome VARCHAR(80) NOT NULL,
	cpf VARCHAR(13) NOT NULL,
	telefone VARCHAR(14) NOT NULL,
	email VARCHAR (80) NOT NULL,
	dataNasc DATE NOT NULL,
	dataCadastro DATE NOT NULL,
	usuario VARCHAR(100) NOT NULL,
	senha VARCHAR(80) NOT NULL,
	CoordenadorCurso_codCoordenador VARCHAR(10),
	FOREIGN KEY (CoordenadorCurso_codCoordenador) REFERENCES CoordenadorCurso (CodCoordenador)
);
GO

CREATE TABLE Turma (
	codTurma VARCHAR (10)PRIMARY KEY NOT NULL,
	Profesor_codProfessor VARCHAR(10) NOT NULL,
	FOREIGN KEY (Profesor_codProfessor) REFERENCES Professor (codProfessor),
	nome VARCHAR(80) NOT NULL,
	numAlunos INT NOT NULL,
	distribuicaoDePontos FLOAT NOT NULL
);
GO

CREATE TABLE Nota(
	Aluno_codAluno VARCHAR(10) NOT NULL,
	FOREIGN KEY (Aluno_codAluno) REFERENCES Aluno (codAluno),
	Profesor_codProfessor VARCHAR(10) NOT NULL,
	FOREIGN KEY (Profesor_codProfessor) REFERENCES Professor (codProfessor),
	prova1 FLOAT NOT NULL,
	prova2 FLOAT NOT NULL,
	trabalho FLOAT NOT NULL
);
GO

CREATE TABLE FrequenciaFunc(
	Funcionario_codFuncionario VARCHAR(10) NOT NULL,
	FOREIGN KEY (Funcionario_codFuncionario) REFERENCES Funcionario (codFuncionario),
	saida DATETIME NULL,
	atestadoMedico DATE NULL,
	chegada DATETIME NOT NULL,
	intervalo DATETIME NULL
);
GO

CREATE TABLE FrequenciaProf(
	Professor_codProfessor VARCHAR(10) NOT NULL,
	FOREIGN KEY (Professor_codProfessor) REFERENCES Professor(codProfessor),
	saida DATETIME NULL,
	atestadoMedico DATE NOT NULL,
	chegada DATETIME NULL
);
GO

CREATE TABLE FrequenciaAluno(
	Aluno_codAluno VARCHAR(10) NOT NULL,
	FOREIGN KEY (Aluno_codAluno) REFERENCES Aluno (codAluno),
	presenca DATE NOT NULL
);
GO

INSERT INTO Diretor VALUES ('DIR001','Manoel Diogo','94885099455','manoeldiogo123','mmanoeldiogo','1997/11/11','(86)98642-9872','mmanoeldiogo@gmail.com')

INSERT INTO CoordenadorCurso VALUES ('COOR001','DIR001','Bernardo Antonio','45927009530','(82)98961-3710','bernardoantonio@gmail.com','1997/08/23','2019/04/09','bernardoantonio','bernardo123')

INSERT INTO Curso VALUES ('CUR001','Técnico de Informática','Lógica de Programção','Algebra Booleana','Tabela-Verdade - Funções - Equeções Booleanas','DIR001','COOR001')

INSERT INTO Funcionario VALUES ('FUNC001','DIR001','06239469718','(61)99580-9295','franciscoyago@gmail.com','1997/06/15','2019/04/09',5,'Francisco Yago','francisco123','franciscoyago')
INSERT INTO Funcionario VALUES ('FUNC002','DIR001','78149288937','(69)98708-3827','nataliamarli@gmail.com','1997/08/21','2019/04/09',4,'Natália Marli','natalia123','nataliamarli')
INSERT INTO Funcionario VALUES ('FUNC003','DIR001','36096995667','(92)98840-9582','isabelajulia@gmail.com','1997/07/11','2019/04/09',3,'Isabela Julia','isabela123','isabelajulia')
INSERT INTO Funcionario VALUES ('FUNC004','DIR001','59154106346','(69)99854-4603','carlosaugusto@gmail.com','1997/04/04','2019/04/09',2,'Carlos Augusto','carlos123','carlosaugusto')
INSERT INTO Funcionario VALUES ('FUNC005','DIR001','64748076879','(86)99573-3269','mateusanderson@gmail.com','1997/04/16','2019/04/09',1,'Mateus Anderson','mateus123','mateusanderson')

INSERT INTO Aluno VALUES ('ALUN001','MATRI001','Elias Tiago','04770775288','(67)98346-4245','eliastiago@gmail.com','2001/09/10','FUNC001','CUR001')

INSERT INTO Professor VALUES ('PROF001','Bento Julio','59975399541','(31)99371-9033','bentojulio@gmail.com','1990/02/16','2019/04/09','bentoj123','bentojulio','COOR001')

INSERT INTO Turma VALUES ('TURM001','PROF001','Diogo Carlos',30,100.00)

INSERT INTO Nota VALUES ('ALUN001','PROF001',23,28,40)

INSERT INTO FrequenciaFunc VALUES ('FUNC001','','2012/05/23','','')

INSERT INTO FrequenciaProf VALUES ('PROF001','','2015/08/12','')

INSERT INTO FrequenciaAluno VALUES ('ALUN001','')

-- Relatório de Frequência dos Funcionários
CREATE VIEW RelatorioFuncionario AS
	SELECT F.codFuncionario AS 'CodFuncionario', F.nome AS 'Nome', F.cpf AS 'CPF', FF.chegada AS 'Chegada', FF.intervalo AS 'Intervalo', FF.saida AS 'Saida', FF.atestadoMedico AS 'AtestadoMedico'
	FROM Funcionario AS F INNER JOIN FrequenciaFunc AS FF
	ON (F.codFuncionario = FF.Funcionario_codFuncionario)

CREATE VIEW RelatorioProfesor AS
	SELECT P.codProfessor AS 'CodProfessor', P.nome AS 'Nome', P.cpf AS 'CPF', FP.chegada AS 'Chegada', FP.saida AS 'Saida', FP.atestadoMedico AS 'AtestadoMedico'
	FROM Professor AS P INNER JOIN FrequenciaProf AS FP
	ON (P.codProfessor = FP.Professor_codProfessor)

CREATE VIEW RelatorioAluno AS
	SELECT A.codAluno AS 'CodAluno', A.nome AS 'Nome', A.cpf 'CPF', FA.presenca AS 'Presenca'
	FROM Aluno AS A INNER JOIN FrequenciaAluno AS FA
	ON (A.codAluno = FA.Aluno_codAluno)

CREATE VIEW Boletim AS
	SELECT A.codAluno AS 'CodAluno', A.nome AS 'Nome', A.codMatricula 'CodMatricula', N.prova1 AS 'Prova1', N.prova2 AS 'Prova2', N.trabalho AS 'Trabalho'
	FROM Aluno AS A INNER JOIN Nota AS N
	ON (A.codAluno = N.Aluno_codAluno)

CREATE VIEW CertificadoMatricula AS
	SELECT A.codAluno AS 'CodAluno', A.nome AS 'Nome', A.codMatricula 'CodMatricula', C.codCurso AS 'CodCurso'
	FROM Aluno AS A INNER JOIN Curso AS C
	ON (A.Curso_codCurso = C.codCurso)

CREATE VIEW CertificadoConclusao AS
	SELECT A.codAluno AS 'CodAluno', A.nome AS 'Nome', A.codMatricula 'CodMatricula', C.codCurso AS 'CodCurso'
	FROM Aluno AS A INNER JOIN Curso AS C
	ON (A.Curso_codCurso = C.codCurso)

 -- SELECT para ver as Tabelas
SELECT * FROM Diretor
SELECT * FROM CoordenadorCurso
SELECT * FROM Curso
SELECT * FROM FrequenciaAluno
SELECT * FROM FrequenciaFunc
SELECT * FROM FrequenciaProf
SELECT * FROM Nota
SELECT * FROM Turma
SELECT * FROM Professor
SELECT * FROM Aluno
SELECT * FROM Funcionario

-- SELECT para ver ps CREATE VIEW
SELECT * FROM RelatorioFuncionario
SELECT * FROM RelatorioProfesor
SELECT * FROM RelatorioAluno
SELECT * FROM Boletim
SELECT * FROM CertificadoMatricula
SELECT * FROM CertificadoConclusao

-- DROP VIEW RelatorioAluno
--use master 
--drop database dbEducacaoDoFuturo