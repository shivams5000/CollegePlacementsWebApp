SET IDENTITY_INSERT [dbo].[Branches] ON 
GO
INSERT [dbo].[Branches] ([BranchID], [BranchName]) VALUES (1, N'Computer Science')
GO
INSERT [dbo].[Branches] ([BranchID], [BranchName]) VALUES (2, N'Information Technology')
GO
SET IDENTITY_INSERT [dbo].[Branches] OFF
GO
SET IDENTITY_INSERT [dbo].[Students] ON 
GO
INSERT [dbo].[Students] ([StudentID], [StudentName], [FatherName], [Dob], [BranchID], [Percentage]) VALUES (1, N'John Smith', N'Mr Bishop Smith', CAST(N'2005-06-17T02:59:00.0000000' AS DateTime2), 1, 45.52)
GO
INSERT [dbo].[Students] ([StudentID], [StudentName], [FatherName], [Dob], [BranchID], [Percentage]) VALUES (2, N'Aman Mehra', N'Mr Amit Sharma', CAST(N'2000-06-14T23:00:00.0000000' AS DateTime2), 1, 63.36)
GO
SET IDENTITY_INSERT [dbo].[Students] OFF
GO
SET IDENTITY_INSERT [dbo].[Companies] ON 
GO
INSERT [dbo].[Companies] ([CompanyID], [CompanyName], [Address], [FoundedYear], [NoOfBranches]) VALUES (1, N'SPEC INDIA', N'Hillsborough, New Zealand', 1990, 5)
GO
INSERT [dbo].[Companies] ([CompanyID], [CompanyName], [Address], [FoundedYear], [NoOfBranches]) VALUES (2, N'Zealous System', N'Auckland, New Zealand', 2000, 3)
GO
INSERT [dbo].[Companies] ([CompanyID], [CompanyName], [Address], [FoundedYear], [NoOfBranches]) VALUES (3, N'DOIT Software', N'Helensville, New Zealand', 2005, 1)
GO
SET IDENTITY_INSERT [dbo].[Companies] OFF
GO
SET IDENTITY_INSERT [dbo].[Jobs] ON 
GO
INSERT [dbo].[Jobs] ([JobID], [JobTitle], [Package], [CompanyID]) VALUES (1, N'IOS Developer', N'50K to 70K ', 1)
GO
INSERT [dbo].[Jobs] ([JobID], [JobTitle], [Package], [CompanyID]) VALUES (2, N'React Native Developer', N'75K to 100K', 2)
GO
SET IDENTITY_INSERT [dbo].[Jobs] OFF
GO