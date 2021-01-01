
--ALTER DATABASE  [Beautiful] SET OFFLINE WITH ROLLBACK IMMEDIATE

 
--ALTER  database  [Beautiful]  set   online 
DECLARE @json NVARCHAR(MAX);
SET @json = N'[
  {"id": 2, "info": {"name": "John", "surname": "Smith"}, "age": 25},
  {"id": 5, "info": {"name": "Jane", "surname": "Smith"}, "dob": "2005-11-04T12:00:00"}
]';

SELECT *
FROM OPENJSON(@json)
  WITH (
    id INT 'strict $.id',
    firstName NVARCHAR(50) '$.info.name',
    lastName NVARCHAR(50) '$.info.surname',
    age INT,
    dateOfBirth DATETIME2 '$.dob'
  );
 
 
 --------------------------------
 update   [Beautiful].[dbo].incidents   set [Beautiful].[dbo].incidents.[cid] = c.id 
	FROM [Beautiful].[dbo].[characters] as  c
  INNER JOIN [Beautiful].[dbo].incidents  as i
  ON c.[Name] = i.[Name]


  update   [Beautiful].[dbo].[role] set [Beautiful].[dbo].[role].category_id =  rc.id
	FROM [Beautiful].[dbo].[role] as  r
  INNER JOIN [Beautiful].[dbo].[role_category]  as rc
  ON r.category_id = rc.[Name]
------------------------------
SELECT * FROM sysobjects where xtype='u' 
SELECT COLUMN_NAME,DATA_TYPE FROM INFORMATION_SCHEMA.columns WHERE TABLE_NAME='trace'


exec sp_rename 'dbo.incidents.inserttime', 'insert_time','column'
exec sp_rename 'dbo.incidents.updatetime', 'update_time','column'

exec sp_configure 'show advanced options',1
reconfigure
exec sp_configure 'Ad Hoc Distributed Queries',1
reconfigure
USE [master] 
GO
EXEC master.dbo.sp_MSset_oledb_prop N'Microsoft.ACE.OLEDB.12.0', N'AllowInProcess', 1 
GO 
EXEC master.dbo.sp_MSset_oledb_prop N'Microsoft.ACE.OLEDB.12.0', N'DynamicParameters', 1     

select * from OpenDataSource('Microsoft.ACE.OLEDB.12.0',
'Excel 12.0;HDR=Yes;IMEX=1;Database=e:\附体记录\beautiful.xlsx')...[category$]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	 for inserting records via excels
-- =============================================
CREATE FUNCTION fn_opendatasource
(
	@sourcePath AS NVARCHAR(MAX) = 'e:\附体记录\beautiful.xlsx'
	, @sheetName AS  NVARCHAR(MAX) = 'characters' -- 不用[$]
)
RETURNS  TABLE
AS
BEGIN
(
	DECLARE @sql AS NVARCHAR(MAX) 
	SET @sql = 'RETURN SELECT * FROM OPENDATASOURCE(''Microsoft.ACE.OLEDB.12.0'',''Excel 12.0;HDR=Yes;IMEX=1; Database=' + @sourcePath + ''')...[' + @sheetName+'$]'
	EXECUTE(@sql)
	RETURN 0
	)
END
GO

