USE inlock_games_tarde;
GO

SELECT * FROM Usuarios;
SELECT * FROM Estudios;
SELECT * FROM Jogos;

SELECT  nomeJogo as [Nome do Jogo] ,descrição as [Descrição do Jogo],dataLancamento as [Data de Lançamento],valor as Preço, nomeEstudio as [Nome do Estudio] FROM Jogos
inner join Estudios
ON Estudios.idEstudio = Jogos.idEstudio;
GO

SELECT nomeEstudio as [Nome do Estudio],nomeJogo as [Nome do Jogo] FROM Estudios E
inner join Jogos J
ON J.idJogo = E.idEstudio;
GO

SELECT email, senha FROM Usuarios;
GO

SELECT idJogo, nomeJogo [Nome do Jogo]FROM Jogos;
GO

SELECT idEstudio, nomeEstudio [Nome do Estudio] FROM Estudios;
GO
















