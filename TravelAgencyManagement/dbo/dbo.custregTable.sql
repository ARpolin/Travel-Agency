CREATE TABLE [dbo].[custregTable] (
    [Id]              INT          IDENTITY (1, 1) NOT NULL,
    [firstname]       VARCHAR (50) NOT NULL,
    [lastname]        VARCHAR (50) NOT NULL,
    [username]        VARCHAR (50) NOT NULL,
    [password]        VARCHAR (50) NOT NULL,
    [confirmpassword] VARCHAR (50) NOT NULL,
    [email]           VARCHAR (50) NOT NULL,
    [address]         VARCHAR (50) NOT NULL,
    [age]             INT          NOT NULL,
    [phonenumber]     INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

