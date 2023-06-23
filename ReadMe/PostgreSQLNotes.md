
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
