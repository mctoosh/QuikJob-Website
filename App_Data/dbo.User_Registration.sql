CREATE TABLE [dbo].[User_Registration] (
    [UserId]        INT           IDENTITY (1, 1) NOT NULL,
    [First_Name]    VARCHAR (22)  NULL,
    [Last_Name]     VARCHAR (22)  NULL,
    [Email]         VARCHAR (200) NULL,
    [Address]       VARCHAR (100) NULL,
    [Postcode]      VARCHAR (50)  NULL,
    [Password]      VARCHAR (100) NULL,
    [Date_Of_Birth] DATE          NULL,
    [Phone_Number]  VARCHAR (100) NULL,
    [User_CV]       VARCHAR(MAX)         NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);

