# Regular Expression
	/s : matches any whitespace characters such as space and tab
	/S : matches any non-whitespace characters
	/d : matches any digit character
	/D : matches any non-digit characters
	/w : matches any word character (basically alpha-numeric)
	/W : matches any non-word character
	/b : matches any word boundary (this would include spaces, dashes, commas, semi-colons, etc)

### Notepad++ Regex Find & Replace
I have importated my book marks from chrome which will be in below format
```
<A HREF="https://www.amazon.in/" ADD_DATE="1440107359" ICON="data:image/png;base64,iVBORw..."></A>
<A HREF="https://www.amazon.in/" ADD_DATE="1440107359"></A>
SELECT * FROM tblJobType  Where PackId = @PackId AND VersionId = @VersionId and Status  = 1
```

To Take only link part I have used find & replace with below Regex pattern respectively
```
ADD_DATE=\"\w+" ICON=\"\w.+\" \
ADD_DATE=\"\w+"
FROM \w.+ WHERE
```
