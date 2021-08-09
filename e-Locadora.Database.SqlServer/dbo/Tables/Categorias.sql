CREATE TABLE [dbo].[Categorias] (
    [Id]                      INT           NOT NULL,
    [Categoria]               VARCHAR (100) NOT NULL,
    [valorDiarioKM]           NUMERIC (18)  NOT NULL,
    [ValorDiario]             NUMERIC (18)  NOT NULL,
    [ValorControladoDiarioKm] NUMERIC (18)  NOT NULL,
    [ValorControladoDiario]   NUMERIC (18)  NOT NULL,
    [ValorLivre]              NUMERIC (18)  NOT NULL,
    CONSTRAINT [PK_Categorias] PRIMARY KEY CLUSTERED ([Id] ASC)
);





