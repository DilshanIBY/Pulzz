CREATE TABLE [dbo].[Employee_details](
	[EmployeeID] [int] NOT NULL,
	[EmployeeName] [nvarchar](250) NULL,
	[DateOfBirth] [datetime] NULL,
	[Gender] [nvarchar](50) NULL,
	[Address] [nvarchar](250) NULL,
	[Post] [nvarchar](50) NULL,
	[ContactNo] [int] NULL,
	[Email] [nvarchar](100) NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[ConfirmPassword] [nvarchar](50) NULL
 );

 INSERT INTO [dbo].[Employee_details]([EmployeeID],[EmployeeName],[DateOfBirth],[Gender],[Address],[Post],[ContactNo],[Email],[UserName],[Password],[ConfirmPassword])
     VALUES
           (1, N'Sachini', N'2001-04-16', N'Female', N'23/5, rathwatta mawatha, Badulla', N'Nurse', 702158021, N'sachini@gmail.com', N'sachini', N'sachi123', N'sachi123')
		   INSERT INTO [dbo].[Employee_details]([EmployeeID],[EmployeeName],[DateOfBirth],[Gender],[Address],[Post],[ContactNo],[Email],[UserName],[Password],[ConfirmPassword])
     VALUES
           (2, N'chamathka', N'2003-11-12', N'Female', N'Anuradhapura', N'Nurse', 712503482, N'chamathka@gmail.com', N'chamathka', N'chama123', N'chama123')
		   INSERT INTO [dbo].[Employee_details]([EmployeeID],[EmployeeName],[DateOfBirth],[Gender],[Address],[Post],[ContactNo],[Email],[UserName],[Password],[ConfirmPassword])
     VALUES
           (3, N'Kasun', N'2000-05-31', N'Male', N'Colombo', N'Doctor', 774124576, N'kasun@gmail.com', N'kasun', N'kasun123', N'kasun123')
		   INSERT INTO [dbo].[Employee_details]([EmployeeID],[EmployeeName],[DateOfBirth],[Gender],[Address],[Post],[ContactNo],[Email],[UserName],[Password],[ConfirmPassword])
     VALUES
           (4, N'Lahiru', N'1998-06-04', N'Male', N'Badulla', N'Doctor', 707940531, N'lahiru@gmail.com', N'lahiru', N'lahiru123', N'lahiru123')
		   