SET IDENTITY_INSERT [dbo].[Destinations] ON
INSERT INTO [dbo].[Destinations] ([Id], [duration], [bestplane], [name]) VALUES (1, N'3 hours', N'Cessna Citation', N'St. Tropez')
INSERT INTO [dbo].[Destinations] ([Id], [duration], [bestplane], [name]) VALUES (2, '2 hours', 'Pilatus PC-24', 'Sicily')
--INSERT INTO [dbo].[Destinations] ([Id], [duration], [bestplane], [name]) VALUES (3, N'2 hours', N'Cessna Citation', N'Bodrum')
SET IDENTITY_INSERT [dbo].[Destinations] OFF
