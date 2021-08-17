CREATE TABLE [dbo].[TBFuncionario] (
    [Id]           INT          IDENTITY (1, 1) NOT NULL,
    [Nome]         VARCHAR (80) NOT NULL,
    [Usuario]      VARCHAR (80) NOT NULL,
    [Senha]        VARCHAR (80) NOT NULL,
    [DataAdmissao] DATE         NOT NULL,
    [Salario]      NUMERIC (18) NOT NULL,
    CONSTRAINT [PK_TBFuncionario] PRIMARY KEY CLUSTERED ([Id] ASC)
);

