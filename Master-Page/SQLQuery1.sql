-- User Table

--CREATE TABLE [dbo].[User]
--(
--    [id] INT NOT NULL PRIMARY KEY IDENTITY, 
--    [legalName] NVARCHAR(50) NULL, 
--    [preferredName] NVARCHAR(50) NULL, 
--    [email] NVARCHAR(50) NULL UNIQUE, 
--    [password] NVARCHAR(MAX) NULL, 
--    [role] NVARCHAR(15) NULL, 
--    [emailVerified] TINYINT NULL, 
--    [idVerified] TINYINT NULL, 
--    [idType] NVARCHAR(15) NULL, 
--    [idNo] NVARCHAR(MAX) NULL, 
--    [googleId] NVARCHAR(50) NULL, 
--    [linkedInId] NVARCHAR(50) NULL, 
--    [twoFactorPhone] NVARCHAR(20) NULL, 
--    [twoFactorAuthy] NVARCHAR(50) NULL, 
--    [headerImage] NVARCHAR(MAX) NULL, 
--    [profileImage] NVARCHAR(MAX) NULL, 
--    [headline] NVARCHAR(255) NULL, 
--    [profileVisibility] TINYINT NULL, 
--    [createdAt] DATETIME NULL
--)

---- Education Table

--CREATE TABLE [dbo].[Education]
--(
--    [id] INT NOT NULL PRIMARY KEY IDENTITY, 
--    [qualification] NVARCHAR(50) NULL, 
--    [institution] NVARCHAR(50) NULL, 
--    [nomenclature] NVARCHAR(50) NULL, 
--    [startDate] DATE NULL, 
--    [endDate] DATE NULL, 
--    [issuedDate] DATE NULL, 
--    [verifiedSource] NVARCHAR(50) NULL, 
--    [verifiedDate] DATETIME NULL, 
--    [createdAt] DATETIME NULL, 
--    [userId] INT NULL,
--    FOREIGN KEY (userId) REFERENCES [dbo].[User](id)
--)

-- Listing Table

CREATE TABLE [dbo].[Listing]
(
    [id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [title] NVARCHAR(50) NULL, 
    [location] NVARCHAR(50) NULL, 
    [type] NVARCHAR(20) NULL, 
    [experienceRequired] NVARCHAR(150) NULL, 
    [salaryRange] DECIMAL NULL, 
    [overview] NVARCHAR(50) NULL, 
    [responsibilities] NVARCHAR(50) NULL, 
    [requirements] NVARCHAR(50) NULL, 
    [level] NVARCHAR(50) NULL, 
    [qualificationsRequired] NVARCHAR(50) NULL, 
    [catergories] NVARCHAR(50) NULL, 
    [expiration] DATETIME NULL, 
    [vacancy] INT NULL, 
    [hideOrganisation] NVARCHAR(50) NULL, 
    [createdAt] DATETIME NULL, 
    [oragnisationId] INT NULL,
    FOREIGN KEY (oragnisationId) REFERENCES [dbo].[Oragnisation](id)
)

-- Organisation table

--CREATE TABLE [dbo].[Oragnisation]
--(
--    [id] INT NOT NULL PRIMARY KEY IDENTITY
--)
    