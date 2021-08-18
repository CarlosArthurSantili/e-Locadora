CREATE TABLE [dbo].[TBLocacao] (
    [Id]                     INT          NOT NULL,
    [idFuncionario]          INT          NOT NULL,
    [idGrupoVeiculo]         INT          NOT NULL,
    [idVeiculo]              INT          NOT NULL,
    [idCliente]              INT          NOT NULL,
    [idCondutor]             INT          NOT NULL,
    [dataLocacao]            DATE         NOT NULL,
    [dataDevolucao]          DATE         NOT NULL,
    [quilometragemDevolucao] DECIMAL (18) NOT NULL,
    [plano]                  VARCHAR (50) NOT NULL,
    [seguroCliente]          DECIMAL (18) NOT NULL,
    [seguroTerceiro]         DECIMAL (18) NOT NULL,
    [emAberto]               TINYINT      NOT NULL
);

