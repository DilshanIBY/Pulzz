CREATE TABLE [dbo].[leavesTbl] (
    [Id]      INT          NOT NULL,
    [EmpId]   INT          NULL,
    [EmpName] VARCHAR (50) NULL,
    [Type]    VARCHAR (50) NULL,
    [Start]   DATE         NULL,
    [End]     DATE         NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

INSERT INTO [dbo].[leavesTbl] ([Id], [EmpId], [EmpName], [Type], [Start], [End]) VALUES (1, 1, N'Sanduni', N'Annual       ', N'2024-04-26', N'2024-04-28')
INSERT INTO [dbo].[leavesTbl] ([Id], [EmpId], [EmpName], [Type], [Start], [End]) VALUES (2, 2, N'Sachini', N'Sick       ', N'2024-04-29', N'2024-05-03')
