SET NOCOUNT ON;

DECLARE @StartDate DATE = GETDATE();
DECLARE @EndDate DATE = '2027-12-31';
DECLARE @CurrentDate DATE = @StartDate;

-- Temporary table for holding generated appointments
DECLARE @Appointments TABLE (Id INT IDENTITY(1,1), Capacity INT, StartTime DATETIME);

WHILE @CurrentDate <= @EndDate
BEGIN
    -- Only insert if the day is Monday to Friday (1=Monday, 5=Friday)
    IF DATEPART(WEEKDAY, @CurrentDate) BETWEEN 2 AND 6
    BEGIN
        INSERT INTO @Appointments (Capacity, StartTime)
        SELECT 
            ABS(CHECKSUM(NEWID())) % 10 + 1 AS Capacity,  -- Random capacity between 1 and 10
            DATEADD(MINUTE, (7 + (ABS(CHECKSUM(NEWID())) % 21) * 0.5) * 60, CAST(@CurrentDate AS DATETIME)) 
        FROM (
            SELECT TOP 10 ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS n FROM sys.all_objects
        ) AS Numbers;
    END

    -- Move to the next day
    SET @CurrentDate = DATEADD(DAY, 1, @CurrentDate);
END

-- Insert into the actual Appointments table
INSERT INTO Appointments (Capacity, StartTime)
SELECT Capacity, StartTime FROM @Appointments;

-- Insert into AppointmentServiceTypeDurationCosts with random ServiceTypeDurationCostId (1-6)
INSERT INTO AppointmentServiceTypeDurationCosts (AppointmentId, ServiceTypeDurationCostId)
SELECT 
    A.Id, 
    (ABS(CHECKSUM(NEWID())) % 6) + 1  -- Random STDC Id from 1 to 6
FROM Appointments A;

-- Optional: Delete all inserted records
-- DELETE FROM AppointmentServiceTypeDurationCosts;
-- DELETE FROM Appointments;
