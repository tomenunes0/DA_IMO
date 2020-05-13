
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/13/2020 13:00:52
-- Generated from EDMX file: D:\WORKS\ESTG-PSI\Desenvolvimento de Aplicações\DA_IMO\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [master];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Clientes'
CREATE TABLE [dbo].[Clientes] (
    [IdCliente] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Nif] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Contacto] nvarchar(max)  NOT NULL,
    [CasaIdCasa] int  NOT NULL,
    [VendaIdVenda] int  NOT NULL
);
GO

-- Creating table 'Arrendamentos'
CREATE TABLE [dbo].[Arrendamentos] (
    [IdArrendamento] int IDENTITY(1,1) NOT NULL,
    [InicioContrado] nvarchar(max)  NOT NULL,
    [DuracaoMeses] datetime  NOT NULL,
    [Renovavel] nvarchar(max)  NOT NULL,
    [ClienteIdCliente] int  NOT NULL,
    [ClienteIdCliente1] int  NOT NULL,
    [CasaArrendavel_IdCasa] int  NULL
);
GO

-- Creating table 'Servicos'
CREATE TABLE [dbo].[Servicos] (
    [IdServico] int IDENTITY(1,1) NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Valor] decimal(18,0)  NOT NULL,
    [Unidades] int  NOT NULL,
    [Limpeza_IdLimpeza] int  NULL
);
GO

-- Creating table 'Limpezas'
CREATE TABLE [dbo].[Limpezas] (
    [IdLimpeza] int IDENTITY(1,1) NOT NULL,
    [Data] datetime  NOT NULL,
    [ServicoIdServico] int  NOT NULL,
    [Casa_IdCasa] int  NULL
);
GO

-- Creating table 'Vendas'
CREATE TABLE [dbo].[Vendas] (
    [IdVenda] int IDENTITY(1,1) NOT NULL,
    [DataVenda] datetime  NOT NULL,
    [ValorNegociado] decimal(18,0)  NOT NULL,
    [ComissaoNegocio] decimal(18,0)  NOT NULL,
    [CasaVendavelIdCasaVendavel] int  NOT NULL,
    [ClienteIdCliente] int  NOT NULL,
    [CasaVendavel_IdCasa] int  NOT NULL
);
GO

-- Creating table 'Casas'
CREATE TABLE [dbo].[Casas] (
    [IdCasa] int IDENTITY(1,1) NOT NULL,
    [Localidade] nvarchar(max)  NOT NULL,
    [Rua] nvarchar(max)  NOT NULL,
    [Numero] decimal(18,0)  NOT NULL,
    [Andar] int  NOT NULL,
    [Area] nvarchar(max)  NOT NULL,
    [NumeroAssoalhada] int  NOT NULL,
    [NumeroWC] int  NOT NULL,
    [NumerosPisos] int  NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL,
    [LimpezaIdLimpeza] int  NOT NULL,
    [ClienteIdCliente] int  NOT NULL
);
GO

-- Creating table 'Casas_CasaArrendavel'
CREATE TABLE [dbo].[Casas_CasaArrendavel] (
    [ValorBaseMes] decimal(18,0)  NOT NULL,
    [Comissao] decimal(18,0)  NOT NULL,
    [ArrendamentoIdArrendamento] int  NOT NULL,
    [IdCasa] int  NOT NULL
);
GO

-- Creating table 'Casas_CasaVendavel'
CREATE TABLE [dbo].[Casas_CasaVendavel] (
    [ValorBaseVenda] decimal(18,0)  NOT NULL,
    [ValorComissao] decimal(18,0)  NOT NULL,
    [IdCasa] int  NOT NULL
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

-- Creating primary key on [IdArrendamento] in table 'Arrendamentos'
ALTER TABLE [dbo].[Arrendamentos]
ADD CONSTRAINT [PK_Arrendamentos]
    PRIMARY KEY CLUSTERED ([IdArrendamento] ASC);
GO

-- Creating primary key on [IdServico] in table 'Servicos'
ALTER TABLE [dbo].[Servicos]
ADD CONSTRAINT [PK_Servicos]
    PRIMARY KEY CLUSTERED ([IdServico] ASC);
GO

-- Creating primary key on [IdLimpeza] in table 'Limpezas'
ALTER TABLE [dbo].[Limpezas]
ADD CONSTRAINT [PK_Limpezas]
    PRIMARY KEY CLUSTERED ([IdLimpeza] ASC);
GO

-- Creating primary key on [IdVenda] in table 'Vendas'
ALTER TABLE [dbo].[Vendas]
ADD CONSTRAINT [PK_Vendas]
    PRIMARY KEY CLUSTERED ([IdVenda] ASC);
GO

-- Creating primary key on [IdCasa] in table 'Casas'
ALTER TABLE [dbo].[Casas]
ADD CONSTRAINT [PK_Casas]
    PRIMARY KEY CLUSTERED ([IdCasa] ASC);
GO

-- Creating primary key on [IdCasa] in table 'Casas_CasaArrendavel'
ALTER TABLE [dbo].[Casas_CasaArrendavel]
ADD CONSTRAINT [PK_Casas_CasaArrendavel]
    PRIMARY KEY CLUSTERED ([IdCasa] ASC);
GO

-- Creating primary key on [IdCasa] in table 'Casas_CasaVendavel'
ALTER TABLE [dbo].[Casas_CasaVendavel]
ADD CONSTRAINT [PK_Casas_CasaVendavel]
    PRIMARY KEY CLUSTERED ([IdCasa] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ClienteIdCliente1] in table 'Arrendamentos'
ALTER TABLE [dbo].[Arrendamentos]
ADD CONSTRAINT [FK_ClienteArrendamento]
    FOREIGN KEY ([ClienteIdCliente1])
    REFERENCES [dbo].[Clientes]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteArrendamento'
CREATE INDEX [IX_FK_ClienteArrendamento]
ON [dbo].[Arrendamentos]
    ([ClienteIdCliente1]);
GO

-- Creating foreign key on [CasaArrendavel_IdCasa] in table 'Arrendamentos'
ALTER TABLE [dbo].[Arrendamentos]
ADD CONSTRAINT [FK_ArrendamentoCasaArrendavel]
    FOREIGN KEY ([CasaArrendavel_IdCasa])
    REFERENCES [dbo].[Casas_CasaArrendavel]
        ([IdCasa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArrendamentoCasaArrendavel'
CREATE INDEX [IX_FK_ArrendamentoCasaArrendavel]
ON [dbo].[Arrendamentos]
    ([CasaArrendavel_IdCasa]);
GO

-- Creating foreign key on [ClienteIdCliente] in table 'Casas'
ALTER TABLE [dbo].[Casas]
ADD CONSTRAINT [FK_ClienteCasa]
    FOREIGN KEY ([ClienteIdCliente])
    REFERENCES [dbo].[Clientes]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteCasa'
CREATE INDEX [IX_FK_ClienteCasa]
ON [dbo].[Casas]
    ([ClienteIdCliente]);
GO

-- Creating foreign key on [Limpeza_IdLimpeza] in table 'Servicos'
ALTER TABLE [dbo].[Servicos]
ADD CONSTRAINT [FK_ServicoLimpeza]
    FOREIGN KEY ([Limpeza_IdLimpeza])
    REFERENCES [dbo].[Limpezas]
        ([IdLimpeza])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ServicoLimpeza'
CREATE INDEX [IX_FK_ServicoLimpeza]
ON [dbo].[Servicos]
    ([Limpeza_IdLimpeza]);
GO

-- Creating foreign key on [Casa_IdCasa] in table 'Limpezas'
ALTER TABLE [dbo].[Limpezas]
ADD CONSTRAINT [FK_LimpezaCasa]
    FOREIGN KEY ([Casa_IdCasa])
    REFERENCES [dbo].[Casas]
        ([IdCasa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LimpezaCasa'
CREATE INDEX [IX_FK_LimpezaCasa]
ON [dbo].[Limpezas]
    ([Casa_IdCasa]);
GO

-- Creating foreign key on [CasaVendavel_IdCasa] in table 'Vendas'
ALTER TABLE [dbo].[Vendas]
ADD CONSTRAINT [FK_VendaCasaVendavel]
    FOREIGN KEY ([CasaVendavel_IdCasa])
    REFERENCES [dbo].[Casas_CasaVendavel]
        ([IdCasa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VendaCasaVendavel'
CREATE INDEX [IX_FK_VendaCasaVendavel]
ON [dbo].[Vendas]
    ([CasaVendavel_IdCasa]);
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

-- Creating foreign key on [IdCasa] in table 'Casas_CasaArrendavel'
ALTER TABLE [dbo].[Casas_CasaArrendavel]
ADD CONSTRAINT [FK_CasaArrendavel_inherits_Casa]
    FOREIGN KEY ([IdCasa])
    REFERENCES [dbo].[Casas]
        ([IdCasa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdCasa] in table 'Casas_CasaVendavel'
ALTER TABLE [dbo].[Casas_CasaVendavel]
ADD CONSTRAINT [FK_CasaVendavel_inherits_Casa]
    FOREIGN KEY ([IdCasa])
    REFERENCES [dbo].[Casas]
        ([IdCasa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------