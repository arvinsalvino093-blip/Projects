CREATE TABLE [dbo].[Table]
(
	[Employee_ID] INT NOT NULL PRIMARY KEY, 
    [Employee_Name] NVARCHAR(250) NOT NULL, 
    [Employee_NIC] NVARCHAR(15) NOT NULL, 
    [Employee_DOB] DATE NOT NULL, 
    [Employee_Type] NVARCHAR(50) NOT NULL, 
    [Employee_Qualification] NVARCHAR(250) NOT NULL, 
    [Employee_Expericence] NVARCHAR(250) NOT NULL, 
    [Employee_Account] INT NOT NULL
)
