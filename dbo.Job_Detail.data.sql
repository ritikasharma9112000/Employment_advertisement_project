SET IDENTITY_INSERT [dbo].[Job_Detail] ON
INSERT INTO [dbo].[Job_Detail] ([Id], [Job_role], [Job_type], [Job_salary], [Job_description], [Employer_DetailId]) VALUES (1, N'Front Desk', N'Restaurant', CAST(3000.00 AS Decimal(18, 2)), N'Handle all of the front work', 1)
INSERT INTO [dbo].[Job_Detail] ([Id], [Job_role], [Job_type], [Job_salary], [Job_description], [Employer_DetailId]) VALUES (2, N'Teacher', N'Teaching in school', CAST(2500.00 AS Decimal(18, 2)), N'Teaching software development course to level6', 2)
INSERT INTO [dbo].[Job_Detail] ([Id], [Job_role], [Job_type], [Job_salary], [Job_description], [Employer_DetailId]) VALUES (3, N'Security Guard', N'Security', CAST(1500.00 AS Decimal(18, 2)), N'Doing security in hospitals and companies', 3)
INSERT INTO [dbo].[Job_Detail] ([Id], [Job_role], [Job_type], [Job_salary], [Job_description], [Employer_DetailId]) VALUES (4, N'Barista', N'Cafe', CAST(2100.00 AS Decimal(18, 2)), N'Making coffee''s in café', 4)
INSERT INTO [dbo].[Job_Detail] ([Id], [Job_role], [Job_type], [Job_salary], [Job_description], [Employer_DetailId]) VALUES (5, N'Bar Tender', N'Restaurant', CAST(2200.00 AS Decimal(18, 2)), N'Making drinks in bar', 5)
SET IDENTITY_INSERT [dbo].[Job_Detail] OFF
