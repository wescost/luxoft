﻿/*
The database must have a MEMORY_OPTIMIZED_DATA filegroup
before the memory optimized object can be created.

The bucket count should be set to about two times the 
maximum expected number of distinct values in the 
index key, rounded up to the nearest power of two.
*/

CREATE TABLE [dbo].[Table1]
(
	[Id] INT NOT NULL PRIMARY KEY NONCLUSTERED HASH WITH (BUCKET_COUNT = 131072), 
    [Name] NCHAR(10) NULL, 
    [Region] NCHAR(10) NULL, 
    [Supplier] NCHAR(10) NULL
) WITH (MEMORY_OPTIMIZED = ON)