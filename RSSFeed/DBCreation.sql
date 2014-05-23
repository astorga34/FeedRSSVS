CREATE TABLE RSS(
	ID int NOT NULL IDENTITY(1,1),
	Nombre nvarchar(200) NOT NULL,
	Link nvarchar(600) NOT NULL,
	Palabras nvarchar(600) NULL,
	Operador bit NOT NULL,
	CONSTRAINT PK_RSS PRIMARY KEY(ID)
)
CREATE TABLE ENLACES(
	Id int NOT NULL,
	Descripcion nvarchar(510) NULL,
	Categoria nvarchar(200) NULL,
	Link nvarchar(400) NULL,
	NotasAdicionales nvarchar(200) NULL,
	RSS int NOT NULL,
	Leido bit NOT NULL,
	Fecha datetime NULL,
	CONSTRAINT PK_ENLACES PRIMARY KEY(Id),
	CONSTRAINT FK_ENLACES_RSS FOREIGN KEY (RSS) REFERENCES RSS(ID)
)