USE inlock_games_tarde;
GO

INSERT INTO TiposUsuarios(titulo)
VALUES		('ADMINISTRADROR'),
			('CLIENTE');
GO

INSERT INTO Usuarios(idTipoUsuario,email,senha)
VALUES		(1,'admin@admin.com','admin'),
			(2,'cliente@cliente.com','cliente');
GO

INSERT INTO Estudios(nomeEstudio)
VALUES		('Blizzard'),
			('Rockstar Studios'),
			('Square Enix');
GO

INSERT INTO Jogos(nomeJogo,dataLancamento,descri��o,idEstudio,valor)
VALUES		('Diablo 3,','15/05/2012','� um jogo que cont�m bastante a��o e � viciante, seja voc� um novato ou um f�.',1,'R$:99,00'),
			('Red Dead Redemption II','26/10/2018','jogo eletr�nico de a��o-aventura western',2,'R$:120,00');
GO




















