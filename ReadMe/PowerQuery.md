
#### Conditional Statement for each row
```
= Table.AddColumn(#"Added Custom", "SA", each if (Date.Month([DOJ])=Date.Month(DateTime.LocalNow()) and Date.Day([DOJ])>=(Date.Day(DateTime.LocalNow())-3) ) then "Service Anniversary" else null)
= Table.AddColumn(#"Added Custom1", "Custom", each if([TentiveDayRemainingDays]<> null or [HB]<> null or [SA]<> null) then "Yes" else "No")
```

#### String Concatenation - Day and Month from DOB
```
= Table.AddColumn(#"Removed Columns", "Custom", each Date.MonthName([Date Of Birth]) & " " & Number.ToText(Date.Day([Date Of Birth])))
```


