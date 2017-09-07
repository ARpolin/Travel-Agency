CREATE TABLE [dbo].[AddToursTable] (
    [Id]               INT          IDENTITY (1, 1) NOT NULL,
    [AddTour]          VARCHAR (50) NOT NULL,
    [AddHotel]         VARCHAR (50) NOT NULL,
    [AddHotelCost]     VARCHAR (50) NOT NULL,
    [AddLocation]      VARCHAR (50) NOT NULL,
    [AddDestination]   VARCHAR (50) NOT NULL,
    [Selecttransport]  VARCHAR (50) NOT NULL,
    [AddTransportCost] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_AddToursTable] PRIMARY KEY CLUSTERED ([Id] ASC)
);

