CREATE TABLE [dbo].[TBVeiculos] (
    [Id]                  INT          IDENTITY (1, 1) NOT NULL,
    [Placa]               VARCHAR (50) NOT NULL,
    [Fabricante]          VARCHAR (50) NOT NULL,
    [QtdLitrosTanque]     INT          NOT NULL,
    [NumeroChassi]        VARCHAR (50) NOT NULL,
    [Cor]                 VARCHAR (50) NOT NULL,
    [CapacidadeOcupantes] INT          NOT NULL,
    [AnoFabricacao]     INT          NOT NULL,
    [TamanhoPortaMalas]   VARCHAR(50)          NOT NULL,
    [TipoCombustivel]     VARCHAR (50) NOT NULL,
    [idGrupoVeiculo]        INT          NOT NULL,
    [Foto] IMAGE NULL, 
    CONSTRAINT [PK_TBVeiculos] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TBVeiculos_Categorias] FOREIGN KEY ([idGrupoVeiculo]) REFERENCES [dbo].[Categorias] ([Id])
);

