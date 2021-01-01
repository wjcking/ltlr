SELECT   Row_Number() Over(  order By [ID]) As RowNumber, *
FROM      [EverSource].[dbo].[physical]

Delete T From
(Select Row_Number() Over(Partition By [Name] order By [ID]) As RowNumber,* From [EverSource].[dbo].[physical])T
Where T.RowNumber > 1