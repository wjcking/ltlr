

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

