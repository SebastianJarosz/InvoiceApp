CREATE DATABASE DPSInvoiceAppDB;
GO
USE DPSInvoiceAppDB;
CREATE LOGIN invoiceAppUser4
    WITH PASSWORD = '340$Uuxwp7Mcxo7Khy'; 
GO
USE DPSInvoiceAppDB;
CREATE USER invoiceAppUser4 FOR LOGIN invoiceAppUser4;
GO
USE DPSInvoiceAppDB;
GRANT CONTROL ON DATABASE::DPSInvoiceAppDB TO invoiceAppUser4;
GO
USE DPSInvoiceAppDB;
CREATE TABLE [dbo].[Buyer] (
    [NIP]          NVARCHAR (10) NOT NULL,
    [Name]         NVARCHAR (MAX) NOT NULL,
    [Street]       NVARCHAR (MAX) NOT NULL,
    [StreetNumber] NVARCHAR (MAX) NOT NULL,
    [FlatNumber]   INT            NULL,
    CONSTRAINT [PK_Buyer] PRIMARY KEY CLUSTERED ([NIP] ASC)
);
GO
USE DPSInvoiceAppDB;
CREATE TABLE [dbo].[__EFMigrationsHistory] (
    [MigrationId]    NVARCHAR (150) NOT NULL,
    [ProductVersion] NVARCHAR (32)  NOT NULL,
    CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED ([MigrationId] ASC)
);
GO
CREATE TABLE [dbo].[Seller] (
    [NIP]          NVARCHAR (10) NOT NULL,
    [Name]         NVARCHAR (MAX) NOT NULL,
    [Street]       NVARCHAR (MAX) NOT NULL,
    [StreetNumber] NVARCHAR (MAX) NOT NULL,
    [FlatNumber]   INT            NULL,
    CONSTRAINT [PK_Seller] PRIMARY KEY CLUSTERED ([NIP] ASC)
);
GO
USE DPSInvoiceAppDB;
CREATE TABLE [dbo].[Product] (
    [Code]        NVARCHAR (450) NOT NULL,
    [IsActive]    BIT            DEFAULT (CONVERT([bit],(0))) NOT NULL,
    [MeasureUnit] INT            DEFAULT ((0)) NOT NULL,
    [Name]        NVARCHAR (128) DEFAULT (N'') NOT NULL,
    CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([Code] ASC)
);
USE DPSInvoiceAppDB;
CREATE TABLE [dbo].[Invoice] (
    [InvoiceNumber]    NVARCHAR (450)  NOT NULL,
    [CreationTime]     DATETIME2 (7)  NOT NULL,
    [ModyficationTime] DATETIME2 (7)  NOT NULL,
    [BuyerNIP]         NVARCHAR (MAX) NOT NULL,
    [SellerNIP]        NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED ([InvoiceNumber] ASC)
);
GO
USE DPSInvoiceAppDB;
CREATE TABLE [dbo].[DailyInvoiceCounter] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [CreationTime] DATETIME2 (7) NOT NULL,
    [Count]        INT           NOT NULL,
    CONSTRAINT [PK_DailyInvoiceCounter] PRIMARY KEY CLUSTERED ([Id] ASC)
);
USE DPSInvoiceAppDB;
CREATE TABLE [dbo].[ProductsOnInvoice] (
    [ID]                INT            IDENTITY (1, 1) NOT NULL,
    [InvoiceNumber]     NVARCHAR (450)  NULL,
    [ProductCode]       NVARCHAR (450) NULL,
    [QuantityOfProduct] REAL           NOT NULL,
    CONSTRAINT [PK_ProductsOnInvoice] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_ProductsOnInvoice_Invoice_InvoiceNumber] FOREIGN KEY ([InvoiceNumber]) REFERENCES [dbo].[Invoice] ([InvoiceNumber]),
    CONSTRAINT [FK_ProductsOnInvoice_Product_ProductCode] FOREIGN KEY ([ProductCode]) REFERENCES [dbo].[Product] ([Code])
);


GO
USE DPSInvoiceAppDB;
CREATE NONCLUSTERED INDEX [IX_ProductsOnInvoice_InvoiceNumber]
    ON [dbo].[ProductsOnInvoice]([InvoiceNumber] ASC);


GO
USE DPSInvoiceAppDB;
CREATE NONCLUSTERED INDEX [IX_ProductsOnInvoice_ProductCode]
    ON [dbo].[ProductsOnInvoice]([ProductCode] ASC);
GO

USE DPSInvoiceAppDB;
INSERT [dbo].Product VALUES ('P01', 'true', 0, 'test1');
INSERT [dbo].Product VALUES ('P02', 'true', 0, 'test2');
INSERT [dbo].Product VALUES ('P03', 'true', 0, 'test3');
INSERT [dbo].Product VALUES ('P04', 'true', 2, 'test4');
INSERT [dbo].Product VALUES ('P05', 'true', 1, 'test5');
GO