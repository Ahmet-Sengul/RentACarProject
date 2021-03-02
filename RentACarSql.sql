CREATE TABLE [dbo].[Users] (
    [UserId]       INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]     NVARCHAR (50) NULL,
    [LastName] NVARCHAR (50) NULL,
    [Email]    NVARCHAR (30) NULL,
    [Password] NVARCHAR (30) NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([UserId] ASC)
);



------------------

CREATE TABLE [dbo].[Rentals] (
    [RentalId]   INT  IDENTITY (1, 1) NOT NULL,
    [CarId]      INT  NOT NULL,
    [CustomerId] INT  NOT NULL,
    [RentDate]   DATE NULL,
    [ReturnDate] DATE NULL,
    CONSTRAINT [PK_Rentals] PRIMARY KEY CLUSTERED ([RentalId] ASC),
    CONSTRAINT [FK_Rentals_Customers] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([CustomerId]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_Cars_Rentals] FOREIGN KEY ([CarId]) REFERENCES [dbo].[Cars] ([CarId]) ON DELETE CASCADE ON UPDATE CASCADE
);



-------------------------------

CREATE TABLE [dbo].[Customers] (
    [CustomerId]  INT           IDENTITY (1, 1) NOT NULL,
    [UserID]      INT           NOT NULL,
    [CompanyName] NVARCHAR (50) NULL,
    CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED ([CustomerId] ASC),
    CONSTRAINT [FK_Customers_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId]) ON DELETE CASCADE ON UPDATE CASCADE
);

----------------------------------

CREATE TABLE [dbo].[Colors] (
    [ColorId]   INT        IDENTITY (1, 1) NOT NULL,
    [ColorName] NCHAR (30) NULL,
    CONSTRAINT [PK_Colors] PRIMARY KEY CLUSTERED ([ColorId] ASC)
);

------------------------------------
CREATE TABLE [dbo].[Cars] (
    [CarId]       INT           IDENTITY (1, 1) NOT NULL,
    [BrandId]     INT           NOT NULL,
    [ColorId]     INT           NOT NULL,
    [ModelYear]   INT      NULL,
    [DailyPrice]  DECIMAL (18)  NULL,
    [Description] NVARCHAR (50) NULL,
    CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED ([CarId] ASC),
    CONSTRAINT [FK_Cars_Brands] FOREIGN KEY ([BrandId]) REFERENCES [dbo].[Brands] ([BrandId]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_Cars_Colors] FOREIGN KEY ([ColorId]) REFERENCES [dbo].[Colors] ([ColorId]) ON DELETE CASCADE ON UPDATE CASCADE
);

--------------------------

CREATE TABLE [dbo].[Brands] (
    [BrandId]    INT           IDENTITY (1, 1) NOT NULL,
    [BrandName]  NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Brands] PRIMARY KEY CLUSTERED ([BrandId] ASC)
);

---------------------------

CREATE TABLE [dbo].[CarImages](
    [CarImageId] INT           IDENTITY (1, 1) NOT NULL,
    [CarId] INT                NOT NULL,
    [ImagePath] NVARCHAR (100) NULL,
    [CreationDate]  DATE NULL,
    CONSTRAINT [PK_CarImages] PRIMARY KEY CLUSTERED ([CarImageId] ASC),
    CONSTRAINT [FK_CarImages_Cars] FOREIGN KEY ([CarId]) REFERENCES [dbo].[Cars] ([CarId]) ON DELETE CASCADE ON UPDATE CASCADE
);
