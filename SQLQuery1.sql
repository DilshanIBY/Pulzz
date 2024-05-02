CREATE TABLE [dbo].[BasicSalary](
	[PositionID] [int] NOT NULL,
	[Position] [nvarchar](50) NULL,
	[BasicSalary] [decimal](18, 0) NULL,
 
);

INSERT INTO[dbo].[BasicSalary] ([PositionID],[Position],[BasicSalary])VALUES(1,N'Doctor',150000)
INSERT INTO[dbo].[BasicSalary] ([PositionID],[Position],[BasicSalary])VALUES(2,N'Nurse',80000)
INSERT INTO[dbo].[BasicSalary] ([PositionID],[Position],[BasicSalary])VALUES(3,N'Attendent',50000)