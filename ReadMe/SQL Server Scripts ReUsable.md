#### Complete SQL Server Details
```
xp_msver
```

#### Default SQL Instances
```
(localdb)\MSSQLLocalDB
.\SQLEXPRESS
localhost\SQLEXPRESS
.\MSSQLSERVER
localhost\MSSQLSERVER
```

#### Dynamic Scripts Generate for Select top 1, Drop, Delete in a Table
```
select 'SELECT  * from ' + name from sys.tables order by name
select 'SELECT top 1 * from ' + name from sys.tables order by name
select 'DROP TABLE [dbo].[' + name + ']'  from sys.tables order by name
select 'DELETE from [dbo].[' + name + ']'  from sys.tables order by name
select 'DROP PROC [dbo].[' + name + ']' from sysobjects where xtype='P'
```

#### List All Database Tables Based On Column Name employeeID
```
select   tab.name, col.name
from sys.columns col
inner join sys.tables tab
on col.object_id = tab.object_id
where col.name like '%employeeID%'
```

#### List All Database Table Name along with Column Name, Data Type, Identity, Nullable, Default Value etc
```
SELECT 
	tab.name 'Table Name',
    c.name 'Column Name',
    t.Name 'Data type',
	Case 
		When  i.is_primary_key is null then ''
		else 'Yes'
	End 'Primary Key',
	Case
		When c.is_identity=1 then 'Yes'
		else ''
	End 'Identity',
	Case
		When c.is_nullable=1 then 'Yes'
		else ''
	End 'Nullable',
	Case
		When object_definition(c.default_object_id) is null then ''
		else object_definition(c.default_object_id)
	End 'Default Value',
    c.max_length 'Max Length',
    c.precision ,
    c.scale 
FROM    
    sys.columns c
inner join sys.tables tab
	on c.object_id = tab.object_id
INNER JOIN 
    sys.types t ON c.user_type_id = t.user_type_id
LEFT OUTER JOIN 
    sys.index_columns ic ON ic.object_id = c.object_id AND ic.column_id = c.column_id
LEFT OUTER JOIN 
    sys.indexes i ON ic.object_id = i.object_id AND ic.index_id = i.index_id
```

#### DROP foreign keys CONSTRAINT
```
SELECT 
    'ALTER TABLE ' +  OBJECT_SCHEMA_NAME(parent_object_id) +
    '.[' + OBJECT_NAME(parent_object_id) + 
    '] DROP CONSTRAINT ' + name
FROM sys.foreign_keys
WHERE referenced_object_id = object_id('APPUser')
```

#### RENAME COLUMN Name Foreign Key CONSTRAINT
```
select  'EXEC sp_rename ''dbo.' + tab.name + '.' + col.name + ''',''AcademicID'',''COLUMN''',tab.name, col.name
from sys.columns col inner join sys.tables tab
on col.object_id = tab.object_id where col.name='ACID'
```

#### List All Tables with Zero(0) Records
```
SELECT t.NAME AS TableName, p.rows AS RowCounts
FROM sys.tables t
INNER JOIN sys.partitions p ON t.object_id = p.OBJECT_ID 
WHERE t.is_ms_shipped = 0 AND p.rows = 0
GROUP BY t.Name, p.Rows
ORDER BY t.Name
```

#### List All Tables With No of Record
```
SELECT 
    t.NAME AS TableName,
    p.[Rows]
FROM 
    sys.tables t
INNER JOIN      
    sys.indexes i ON t.OBJECT_ID = i.object_id
INNER JOIN 
    sys.partitions p ON i.object_id = p.OBJECT_ID AND i.index_id = p.index_id
where t.name not like '%%'
order by 1 desc
```

#### Most Used Table Based On No of Times Accessed
```
SELECT 
  db_name(ius.database_id) AS DatabaseName,
  t.NAME AS TableName,
  t.create_date As create_date,t.modify_date As modify_date,ius.last_user_update
  SUM(ius.user_seeks + ius.user_scans + ius.user_lookups) AS NbrTimesAccessed
FROM sys.dm_db_index_usage_stats ius
INNER JOIN sys.tables t ON t.OBJECT_ID = ius.object_id
WHERE database_id = DB_ID('AdventureWorks')
GROUP BY database_id, t.name,t.create_date,t.modify_date
ORDER BY SUM(ius.user_seeks + ius.user_scans + ius.user_lookups) desc
```
#### Sys View
```
SELECT DB_NAME(dbid) as DBName,COUNT(dbid) as NumberOfConnections,loginame as LoginName,program_name,hostname,status,lastwaittype,cpu,physical_io,memusage,cmd FROM sys.sysprocesses
WHERE dbid > 0 GROUP BY dbid, loginame,program_name,hostname,status,lastwaittype,cpu,physical_io,memusage,cmd

SELECT max_workers_count,socket_count,cores_per_socket,numa_node_count,cpu_count FROM sys.dm_os_sys_info
select * from sys.sysprocesses WHERE dbid > 0

```
