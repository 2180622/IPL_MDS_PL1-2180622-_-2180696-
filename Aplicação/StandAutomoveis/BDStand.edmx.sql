
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/23/2019 22:57:27
-- Generated from EDMX file: C:\IPLeiria - PSI - TeSP - 1ºano\2º Semestre\Desenvolvimento de Aplicações\Projeto\IPL_MDS_PL1-2180622-_-2180696-\Aplicação\StandAutomoveis\BDStand.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BDStand];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ClienteCarroOficina]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Carros_CarroOficina] DROP CONSTRAINT [FK_ClienteCarroOficina];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteVenda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Vendas] DROP CONSTRAINT [FK_ClienteVenda];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteAluguer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Algueres] DROP CONSTRAINT [FK_ClienteAluguer];
GO
IF OBJECT_ID(N'[dbo].[FK_VendaCarroVenda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Vendas] DROP CONSTRAINT [FK_VendaCarroVenda];
GO
IF OBJECT_ID(N'[dbo].[FK_AluguerCarroAluguer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Algueres] DROP CONSTRAINT [FK_AluguerCarroAluguer];
GO
IF OBJECT_ID(N'[dbo].[FK_CarroOficinaServico]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Servicos] DROP CONSTRAINT [FK_CarroOficinaServico];
GO
IF OBJECT_ID(N'[dbo].[FK_ServicoParcela]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Parcelas] DROP CONSTRAINT [FK_ServicoParcela];
GO
IF OBJECT_ID(N'[dbo].[FK_CarroOficina_inherits_Carro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Carros_CarroOficina] DROP CONSTRAINT [FK_CarroOficina_inherits_Carro];
GO
IF OBJECT_ID(N'[dbo].[FK_CarroVenda_inherits_Carro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Carros_CarroVenda] DROP CONSTRAINT [FK_CarroVenda_inherits_Carro];
GO
IF OBJECT_ID(N'[dbo].[FK_CarroAluguer_inherits_Carro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Carros_CarroAluguer] DROP CONSTRAINT [FK_CarroAluguer_inherits_Carro];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Clientes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clientes];
GO
IF OBJECT_ID(N'[dbo].[Algueres]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Algueres];
GO
IF OBJECT_ID(N'[dbo].[Vendas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Vendas];
GO
IF OBJECT_ID(N'[dbo].[Servicos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Servicos];
GO
IF OBJECT_ID(N'[dbo].[Parcelas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Parcelas];
GO
IF OBJECT_ID(N'[dbo].[Carros]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Carros];
GO
IF OBJECT_ID(N'[dbo].[Carros_CarroOficina]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Carros_CarroOficina];
GO
IF OBJECT_ID(N'[dbo].[Carros_CarroVenda]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Carros_CarroVenda];
GO
IF OBJECT_ID(N'[dbo].[Carros_CarroAluguer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Carros_CarroAluguer];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Clientes'
CREATE TABLE [dbo].[Clientes] (
    [IdCliente] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [NIF] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Contacto] int  NOT NULL
);
GO

-- Creating table 'Algueres'
CREATE TABLE [dbo].[Algueres] (
    [IdAluguer] int IDENTITY(1,1) NOT NULL,
    [DataInicio] datetime  NOT NULL,
    [DataFim] datetime  NOT NULL,
    [Valor] decimal(18,0)  NOT NULL,
    [Kms] float  NOT NULL,
    [ClienteIdCliente] int  NOT NULL,
    [CarroAluguer_IdCarro] int  NOT NULL
);
GO

-- Creating table 'Vendas'
CREATE TABLE [dbo].[Vendas] (
    [IdVenda] int IDENTITY(1,1) NOT NULL,
    [Valor] decimal(18,0)  NOT NULL,
    [Estado] nvarchar(max)  NOT NULL,
    [Data] datetime  NOT NULL,
    [ClienteIdCliente] int  NOT NULL,
    [CarroVenda_IdCarro] int  NOT NULL
);
GO

-- Creating table 'Servicos'
CREATE TABLE [dbo].[Servicos] (
    [IdServicos] int IDENTITY(1,1) NOT NULL,
    [DataEntrada] datetime  NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL,
    [DataSaida] datetime  NOT NULL,
    [CarroOficinaIdCarro] int  NOT NULL
);
GO

-- Creating table 'Parcelas'
CREATE TABLE [dbo].[Parcelas] (
    [IdParcela] int IDENTITY(1,1) NOT NULL,
    [Valor] decimal(18,0)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [ServicoIdServicos] int  NOT NULL
);
GO

-- Creating table 'Carros'
CREATE TABLE [dbo].[Carros] (
    [IdCarro] int IDENTITY(1,1) NOT NULL,
    [NumeroChassis] nvarchar(max)  NOT NULL,
    [Marca] nvarchar(max)  NOT NULL,
    [Modelo] nvarchar(max)  NOT NULL,
    [Combustivel] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Carros_CarroOficina'
CREATE TABLE [dbo].[Carros_CarroOficina] (
    [Matricula] nvarchar(max)  NOT NULL,
    [Kms] nvarchar(max)  NOT NULL,
    [ClienteIdCliente] int  NOT NULL,
    [IdCarro] int  NOT NULL
);
GO

-- Creating table 'Carros_CarroVenda'
CREATE TABLE [dbo].[Carros_CarroVenda] (
    [Extras] nvarchar(max)  NOT NULL,
    [IdCarro] int  NOT NULL
);
GO

-- Creating table 'Carros_CarroAluguer'
CREATE TABLE [dbo].[Carros_CarroAluguer] (
    [Estado] nvarchar(max)  NOT NULL,
    [Matricula] nvarchar(max)  NOT NULL,
    [IdCarro] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdCliente] in table 'Clientes'
ALTER TABLE [dbo].[Clientes]
ADD CONSTRAINT [PK_Clientes]
    PRIMARY KEY CLUSTERED ([IdCliente] ASC);
GO

-- Creating primary key on [IdAluguer] in table 'Algueres'
ALTER TABLE [dbo].[Algueres]
ADD CONSTRAINT [PK_Algueres]
    PRIMARY KEY CLUSTERED ([IdAluguer] ASC);
GO

-- Creating primary key on [IdVenda] in table 'Vendas'
ALTER TABLE [dbo].[Vendas]
ADD CONSTRAINT [PK_Vendas]
    PRIMARY KEY CLUSTERED ([IdVenda] ASC);
GO

-- Creating primary key on [IdServicos] in table 'Servicos'
ALTER TABLE [dbo].[Servicos]
ADD CONSTRAINT [PK_Servicos]
    PRIMARY KEY CLUSTERED ([IdServicos] ASC);
GO

-- Creating primary key on [IdParcela] in table 'Parcelas'
ALTER TABLE [dbo].[Parcelas]
ADD CONSTRAINT [PK_Parcelas]
    PRIMARY KEY CLUSTERED ([IdParcela] ASC);
GO

-- Creating primary key on [IdCarro] in table 'Carros'
ALTER TABLE [dbo].[Carros]
ADD CONSTRAINT [PK_Carros]
    PRIMARY KEY CLUSTERED ([IdCarro] ASC);
GO

-- Creating primary key on [IdCarro] in table 'Carros_CarroOficina'
ALTER TABLE [dbo].[Carros_CarroOficina]
ADD CONSTRAINT [PK_Carros_CarroOficina]
    PRIMARY KEY CLUSTERED ([IdCarro] ASC);
GO

-- Creating primary key on [IdCarro] in table 'Carros_CarroVenda'
ALTER TABLE [dbo].[Carros_CarroVenda]
ADD CONSTRAINT [PK_Carros_CarroVenda]
    PRIMARY KEY CLUSTERED ([IdCarro] ASC);
GO

-- Creating primary key on [IdCarro] in table 'Carros_CarroAluguer'
ALTER TABLE [dbo].[Carros_CarroAluguer]
ADD CONSTRAINT [PK_Carros_CarroAluguer]
    PRIMARY KEY CLUSTERED ([IdCarro] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ClienteIdCliente] in table 'Carros_CarroOficina'
ALTER TABLE [dbo].[Carros_CarroOficina]
ADD CONSTRAINT [FK_ClienteCarroOficina]
    FOREIGN KEY ([ClienteIdCliente])
    REFERENCES [dbo].[Clientes]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteCarroOficina'
CREATE INDEX [IX_FK_ClienteCarroOficina]
ON [dbo].[Carros_CarroOficina]
    ([ClienteIdCliente]);
GO

-- Creating foreign key on [ClienteIdCliente] in table 'Vendas'
ALTER TABLE [dbo].[Vendas]
ADD CONSTRAINT [FK_ClienteVenda]
    FOREIGN KEY ([ClienteIdCliente])
    REFERENCES [dbo].[Clientes]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteVenda'
CREATE INDEX [IX_FK_ClienteVenda]
ON [dbo].[Vendas]
    ([ClienteIdCliente]);
GO

-- Creating foreign key on [ClienteIdCliente] in table 'Algueres'
ALTER TABLE [dbo].[Algueres]
ADD CONSTRAINT [FK_ClienteAluguer]
    FOREIGN KEY ([ClienteIdCliente])
    REFERENCES [dbo].[Clientes]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteAluguer'
CREATE INDEX [IX_FK_ClienteAluguer]
ON [dbo].[Algueres]
    ([ClienteIdCliente]);
GO

-- Creating foreign key on [CarroVenda_IdCarro] in table 'Vendas'
ALTER TABLE [dbo].[Vendas]
ADD CONSTRAINT [FK_VendaCarroVenda]
    FOREIGN KEY ([CarroVenda_IdCarro])
    REFERENCES [dbo].[Carros_CarroVenda]
        ([IdCarro])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VendaCarroVenda'
CREATE INDEX [IX_FK_VendaCarroVenda]
ON [dbo].[Vendas]
    ([CarroVenda_IdCarro]);
GO

-- Creating foreign key on [CarroAluguer_IdCarro] in table 'Algueres'
ALTER TABLE [dbo].[Algueres]
ADD CONSTRAINT [FK_AluguerCarroAluguer]
    FOREIGN KEY ([CarroAluguer_IdCarro])
    REFERENCES [dbo].[Carros_CarroAluguer]
        ([IdCarro])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AluguerCarroAluguer'
CREATE INDEX [IX_FK_AluguerCarroAluguer]
ON [dbo].[Algueres]
    ([CarroAluguer_IdCarro]);
GO

-- Creating foreign key on [ServicoIdServicos] in table 'Parcelas'
ALTER TABLE [dbo].[Parcelas]
ADD CONSTRAINT [FK_ServicoParcela]
    FOREIGN KEY ([ServicoIdServicos])
    REFERENCES [dbo].[Servicos]
        ([IdServicos])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ServicoParcela'
CREATE INDEX [IX_FK_ServicoParcela]
ON [dbo].[Parcelas]
    ([ServicoIdServicos]);
GO

-- Creating foreign key on [CarroOficinaIdCarro] in table 'Servicos'
ALTER TABLE [dbo].[Servicos]
ADD CONSTRAINT [FK_CarroOficinaServico]
    FOREIGN KEY ([CarroOficinaIdCarro])
    REFERENCES [dbo].[Carros_CarroOficina]
        ([IdCarro])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CarroOficinaServico'
CREATE INDEX [IX_FK_CarroOficinaServico]
ON [dbo].[Servicos]
    ([CarroOficinaIdCarro]);
GO

-- Creating foreign key on [IdCarro] in table 'Carros_CarroOficina'
ALTER TABLE [dbo].[Carros_CarroOficina]
ADD CONSTRAINT [FK_CarroOficina_inherits_Carro]
    FOREIGN KEY ([IdCarro])
    REFERENCES [dbo].[Carros]
        ([IdCarro])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdCarro] in table 'Carros_CarroVenda'
ALTER TABLE [dbo].[Carros_CarroVenda]
ADD CONSTRAINT [FK_CarroVenda_inherits_Carro]
    FOREIGN KEY ([IdCarro])
    REFERENCES [dbo].[Carros]
        ([IdCarro])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdCarro] in table 'Carros_CarroAluguer'
ALTER TABLE [dbo].[Carros_CarroAluguer]
ADD CONSTRAINT [FK_CarroAluguer_inherits_Carro]
    FOREIGN KEY ([IdCarro])
    REFERENCES [dbo].[Carros]
        ([IdCarro])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------