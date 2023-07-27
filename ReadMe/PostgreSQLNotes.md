#### Important Stats View
```
SELECT * FROM pg_stat_database
```
```
SELECT * FROM pg_statio_user_tables;
SELECT * FROM pg_stat_bgwriter;
SELECT locktype, database, relation::regclass, mode, pid FROM pg_locks;
```
#### Check Setting
```
SELECT setting::float FROM pg_settings WHERE name = 'max_connections';
```
#### List All Tables
```
SELECT table_schema, table_name, table_type, table_catalog FROM information_schema.tables
```
####
```
SELECT pg_size_pretty(pg_database_size('survey')) AS mydbsize;

```

#### Set Max Sequence All Statement
```
SELECT
    c.relname AS table_name,
    a.attname AS column_name,
    s.relname AS sequence_name,
    format('SELECT setval(''%I'', (SELECT MAX(%I) FROM %I));', s.relname, a.attname, c.relname) as test
 FROM
    pg_class c
JOIN
    pg_attribute a ON c.oid = a.attrelid
JOIN
    pg_depend d ON d.refobjid = c.oid AND d.refobjsubid = a.attnum
JOIN
    pg_class s ON s.oid = d.objid
WHERE
    c.relkind = 'r' -- Only fetch regular tables
    AND a.attnum > 0 -- Exclude system columns
    AND NOT a.attisdropped -- Exclude dropped columns
    AND s.relkind = 'S' -- Only fetch sequences
    AND c.relnamespace = 'public'::regnamespace -- Adjust the schema name if necessary
```

#### Database Size on Disk
```
SELECT pg_size_pretty(pg_database_size('My Database Name Here')) AS mydbsize;
```

#### Table Size
```
SELECT 
       relname AS "table_name", 
       pg_size_pretty(pg_table_size(C.oid)) AS "table_size" 
FROM 
       pg_class C 
LEFT JOIN pg_namespace N ON (N.oid = C.relnamespace) 
WHERE nspname NOT IN ('pg_catalog', 'information_schema') AND nspname !~ '^pg_toast' AND relkind IN ('r') 
ORDER BY pg_table_size(C.oid) 
```

