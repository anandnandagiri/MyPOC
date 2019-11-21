#### Dynamic Scripts Generate for Select top 1, Drop, Delete in a Table
```
select 'SELECT top 1 * from ' + name from sys.tables order by name
select 'DROP TABLE [dbo].[' + name + ']'  from sys.tables order by name
select 'DELETE from [dbo].[' + name + ']'  from sys.tables order by name
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

