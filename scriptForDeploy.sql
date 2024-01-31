Build started...
Build succeeded.
The Entity Framework tools version '8.0.0' is older than that of the runtime '8.0.1'. Update the tools for the latest features and bug fixes. See https://aka.ms/AAc1fbw for more information.
warn: Microsoft.EntityFrameworkCore.Model.Validation[30000]
      No store type was specified for the decimal property 'Cost' on entity type 'ActivityType'. This will cause values to be silently truncated if they do not fit in the default precision and scale. Explicitly specify the SQL server column type that can accommodate all the values in 'OnModelCreating' using 'HasColumnType', specify precision and scale using 'HasPrecision', or configure a value converter using 'HasConversion'.
warn: Microsoft.EntityFrameworkCore.Model.Validation[30000]
      No store type was specified for the decimal property 'Salary' on entity type 'Employee'. This will cause values to be silently truncated if they do not fit in the default precision and scale. Explicitly specify the SQL server column type that can accommodate all the values in 'OnModelCreating' using 'HasColumnType', specify precision and scale using 'HasPrecision', or configure a value converter using 'HasConversion'.
warn: Microsoft.EntityFrameworkCore.Model.Validation[30000]
      No store type was specified for the decimal property 'Amount' on entity type 'Payment'. This will cause values to be silently truncated if they do not fit in the default precision and scale. Explicitly specify the SQL server column type that can accommodate all the values in 'OnModelCreating' using 'HasColumnType', specify precision and scale using 'HasPrecision', or configure a value converter using 'HasConversion'.
BEGIN TRANSACTION;
GO

ALTER TABLE [Patient] DROP CONSTRAINT [FK_Patient_Person_PersonId];
GO

ALTER TABLE [PatientDiagnosis] DROP CONSTRAINT [FK_PatientDiagnosis_Patient_PatientId];
GO

ALTER TABLE [Reservation] DROP CONSTRAINT [FK_Reservation_Patient_PatientId];
GO

ALTER TABLE [Patient] DROP CONSTRAINT [PK_Patient];
GO

DROP INDEX [IX_Patient_PersonId] ON [Patient];
GO

DROP INDEX [IX_AspNetUsers_PersonId] ON [AspNetUsers];
GO

DELETE FROM [AspNetUserRoles]
WHERE [RoleId] = N'C7D20194-9C7E-40DB-9C63-F71D20116529' AND [UserId] = N'a5d9a70f-c8fa-4e1d-8d93-c46afa657f9b';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetUserRoles]
WHERE [RoleId] = N'8036F52A-701F-4AA4-8639-D9C8123FD8C6' AND [UserId] = N'a737762e-b7b3-4333-ad6a-47684bd2d01d';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetUserRoles]
WHERE [RoleId] = N'545BBA82-840A-4446-BFF6-64834A8DA52F' AND [UserId] = N'ef67c72c-c548-41ca-af20-8ddab55acfbe';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AvailableReservationActivityType]
WHERE [ActivityTypeId] = 1 AND [AvailableReservationId] = 3;
SELECT @@ROWCOUNT;

GO

DELETE FROM [AvailableReservationActivityType]
WHERE [ActivityTypeId] = 1 AND [AvailableReservationId] = 5;
SELECT @@ROWCOUNT;

GO

DELETE FROM [AvailableReservationActivityType]
WHERE [ActivityTypeId] = 1 AND [AvailableReservationId] = 6;
SELECT @@ROWCOUNT;

GO

DELETE FROM [AvailableReservationActivityType]
WHERE [ActivityTypeId] = 1 AND [AvailableReservationId] = 10;
SELECT @@ROWCOUNT;

GO

DELETE FROM [AvailableReservationActivityType]
WHERE [ActivityTypeId] = 1 AND [AvailableReservationId] = 14;
SELECT @@ROWCOUNT;

GO

DELETE FROM [AvailableReservationActivityType]
WHERE [ActivityTypeId] = 1 AND [AvailableReservationId] = 16;
SELECT @@ROWCOUNT;

GO

DELETE FROM [AvailableReservationActivityType]
WHERE [ActivityTypeId] = 2 AND [AvailableReservationId] = 4;
SELECT @@ROWCOUNT;

GO

DELETE FROM [AvailableReservationActivityType]
WHERE [ActivityTypeId] = 2 AND [AvailableReservationId] = 5;
SELECT @@ROWCOUNT;

GO

DELETE FROM [AvailableReservationActivityType]
WHERE [ActivityTypeId] = 2 AND [AvailableReservationId] = 6;
SELECT @@ROWCOUNT;

GO

DELETE FROM [AvailableReservationActivityType]
WHERE [ActivityTypeId] = 2 AND [AvailableReservationId] = 12;
SELECT @@ROWCOUNT;

GO

DELETE FROM [AvailableReservationActivityType]
WHERE [ActivityTypeId] = 3 AND [AvailableReservationId] = 2;
SELECT @@ROWCOUNT;

GO

DELETE FROM [AvailableReservationActivityType]
WHERE [ActivityTypeId] = 3 AND [AvailableReservationId] = 7;
SELECT @@ROWCOUNT;

GO

DELETE FROM [AvailableReservationActivityType]
WHERE [ActivityTypeId] = 3 AND [AvailableReservationId] = 9;
SELECT @@ROWCOUNT;

GO

DELETE FROM [AvailableReservationActivityType]
WHERE [ActivityTypeId] = 3 AND [AvailableReservationId] = 11;
SELECT @@ROWCOUNT;

GO

DELETE FROM [AvailableReservationActivityType]
WHERE [ActivityTypeId] = 3 AND [AvailableReservationId] = 15;
SELECT @@ROWCOUNT;

GO

DELETE FROM [AvailableReservationActivityType]
WHERE [ActivityTypeId] = 4 AND [AvailableReservationId] = 1;
SELECT @@ROWCOUNT;

GO

DELETE FROM [AvailableReservationActivityType]
WHERE [ActivityTypeId] = 4 AND [AvailableReservationId] = 5;
SELECT @@ROWCOUNT;

GO

DELETE FROM [AvailableReservationActivityType]
WHERE [ActivityTypeId] = 4 AND [AvailableReservationId] = 14;
SELECT @@ROWCOUNT;

GO

DELETE FROM [AvailableReservationActivityType]
WHERE [ActivityTypeId] = 4 AND [AvailableReservationId] = 17;
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetUsers]
WHERE [Id] = N'a5d9a70f-c8fa-4e1d-8d93-c46afa657f9b';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetUsers]
WHERE [Id] = N'a737762e-b7b3-4333-ad6a-47684bd2d01d';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetUsers]
WHERE [Id] = N'ef67c72c-c548-41ca-af20-8ddab55acfbe';
SELECT @@ROWCOUNT;

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Patient]') AND [c].[name] = N'Id');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Patient] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Patient] DROP COLUMN [Id];
GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Person]') AND [c].[name] = N'LastName');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Person] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [Person] ALTER COLUMN [LastName] nvarchar(max) NULL;
GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Person]') AND [c].[name] = N'FirstName');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Person] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [Person] ALTER COLUMN [FirstName] nvarchar(max) NULL;
GO

DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Patient]') AND [c].[name] = N'PersonId');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Patient] DROP CONSTRAINT [' + @var3 + '];');
UPDATE [Patient] SET [PersonId] = 0 WHERE [PersonId] IS NULL;
ALTER TABLE [Patient] ALTER COLUMN [PersonId] int NOT NULL;
ALTER TABLE [Patient] ADD DEFAULT 0 FOR [PersonId];
GO

ALTER TABLE [Patient] ADD CONSTRAINT [PK_Patient] PRIMARY KEY ([PersonId]);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'AddressId', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PersonId', N'PhoneNumber', N'PhoneNumberConfirmed', N'RefreshToken', N'RefreshTokenExpiryTime', N'RegisteredDate', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[AspNetUsers]'))
    SET IDENTITY_INSERT [AspNetUsers] ON;
INSERT INTO [AspNetUsers] ([Id], [AccessFailedCount], [AddressId], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PersonId], [PhoneNumber], [PhoneNumberConfirmed], [RefreshToken], [RefreshTokenExpiryTime], [RegisteredDate], [SecurityStamp], [TwoFactorEnabled], [UserName])
VALUES (N'08b24183-96e5-4dcc-ae6d-defe3757cc7b', 0, NULL, N'4dbe9bce-1580-46c9-ba1a-2dbef8237ca5', N'patient@example.com', CAST(1 AS bit), CAST(0 AS bit), NULL, N'PATIENT@EXAMPLE.COM', N'PATIENT@EXAMPLE.COM', N'AQAAAAIAAYagAAAAECTqxV6OY83OSkqTjtvcujTlIVATDCaAQRPfsBW1lBI6m+6PAyhVmVcTDZkDSgoRZg==', 3, NULL, CAST(0 AS bit), NULL, '0001-01-01T00:00:00.0000000', '0001-01-01T00:00:00.0000000', N'3d2a96af-11ca-4323-89ec-6a5a816060a9', CAST(0 AS bit), N'patient@example.com'),
(N'0cbe3858-14ba-4abe-9e4f-705c2a811b56', 0, NULL, N'2af40260-1d3b-4abf-8d95-8f1eddde937f', N'admin@example.com', CAST(1 AS bit), CAST(0 AS bit), NULL, N'ADMIN@EXAMPLE.COM', N'ADMIN@EXAMPLE.COM', N'AQAAAAIAAYagAAAAEMuDqEe+H6tVVERyhl1A8Eup2VWvlFm7x1aJ2tLTL0DGk1dyALHgfGnyjUmEDW+laA==', 1, NULL, CAST(0 AS bit), NULL, '0001-01-01T00:00:00.0000000', '0001-01-01T00:00:00.0000000', N'3aead33b-f591-4480-8f92-c865629d6712', CAST(0 AS bit), N'admin@example.com'),
(N'6379d698-6fd3-4056-9432-74fc8addc250', 0, NULL, N'd6ad9310-9a85-4bde-97d2-8af72c9c8b31', N'physiotherapist@example.com', CAST(1 AS bit), CAST(0 AS bit), NULL, N'PHYSIOTHERAPIST@EXAMPLE.COM', N'PHYSIOTHERAPIST@EXAMPLE.COM', N'AQAAAAIAAYagAAAAEFV87yihEyDXQWwekUY/Ob0pmPkMGnT0JiM3ejcs5/rjOm8iFvieijq3sb+bnv+QUw==', 2, NULL, CAST(0 AS bit), NULL, '0001-01-01T00:00:00.0000000', '0001-01-01T00:00:00.0000000', N'2f97b418-d5c9-436b-909c-534a8ab57bed', CAST(0 AS bit), N'physiotherapist@example.com');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'AddressId', N'ConcurrencyStamp', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PersonId', N'PhoneNumber', N'PhoneNumberConfirmed', N'RefreshToken', N'RefreshTokenExpiryTime', N'RegisteredDate', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[AspNetUsers]'))
    SET IDENTITY_INSERT [AspNetUsers] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ActivityTypeId', N'AvailableReservationId') AND [object_id] = OBJECT_ID(N'[AvailableReservationActivityType]'))
    SET IDENTITY_INSERT [AvailableReservationActivityType] ON;
INSERT INTO [AvailableReservationActivityType] ([ActivityTypeId], [AvailableReservationId])
VALUES (1, 2),
(1, 11),
(1, 12),
(1, 15),
(1, 17),
(2, 8),
(2, 13),
(2, 15),
(3, 4),
(3, 5),
(3, 12),
(3, 13),
(4, 4),
(4, 10),
(4, 11);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ActivityTypeId', N'AvailableReservationId') AND [object_id] = OBJECT_ID(N'[AvailableReservationActivityType]'))
    SET IDENTITY_INSERT [AvailableReservationActivityType] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[AspNetUserRoles]'))
    SET IDENTITY_INSERT [AspNetUserRoles] ON;
INSERT INTO [AspNetUserRoles] ([RoleId], [UserId])
VALUES (N'C7D20194-9C7E-40DB-9C63-F71D20116529', N'08b24183-96e5-4dcc-ae6d-defe3757cc7b'),
(N'8036F52A-701F-4AA4-8639-D9C8123FD8C6', N'0cbe3858-14ba-4abe-9e4f-705c2a811b56'),
(N'545BBA82-840A-4446-BFF6-64834A8DA52F', N'6379d698-6fd3-4056-9432-74fc8addc250');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RoleId', N'UserId') AND [object_id] = OBJECT_ID(N'[AspNetUserRoles]'))
    SET IDENTITY_INSERT [AspNetUserRoles] OFF;
GO

CREATE UNIQUE INDEX [IX_AspNetUsers_PersonId] ON [AspNetUsers] ([PersonId]);
GO

ALTER TABLE [Patient] ADD CONSTRAINT [FK_Patient_Person_PersonId] FOREIGN KEY ([PersonId]) REFERENCES [Person] ([Id]) ON DELETE CASCADE;
GO

ALTER TABLE [PatientDiagnosis] ADD CONSTRAINT [FK_PatientDiagnosis_Patient_PatientId] FOREIGN KEY ([PatientId]) REFERENCES [Patient] ([PersonId]) ON DELETE CASCADE;
GO

ALTER TABLE [Reservation] ADD CONSTRAINT [FK_Reservation_Patient_PatientId] FOREIGN KEY ([PatientId]) REFERENCES [Patient] ([PersonId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240131084734_PersonRelationshipChanges', N'8.0.1');
GO

COMMIT;
GO


