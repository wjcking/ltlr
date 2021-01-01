-- ================================================
-- Template generated from Template Explorer using:
declare @cid as int = 1
select @cid = id  from [dbo].[role_category] where [name] like '%œ…º“%'
select * from [dbo].[role_category] where [name] like '%œ…º“%'
select * from [dbo].[role] where [name]=' Û…Ò'
select * from [dbo].[role] where [name]='∞÷∞÷'
 
 
--[dbo].[add_role_info]   @name   ='¬Ì—ﬁ∆º'  ,@parent_id = 1 @category=@cid
[dbo].[add_incident_info]
 
	@rid  =183
	,@desc  = '—€æµª“œ…”–πÿ'

	,@priority_id   = 3
	
[dbo].[get_incident_list]