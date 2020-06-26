Disable debugging  
```
<compilation debug="false" targetFramework="4.5" />   
```

Disable directory browsing 
```
<directoryBrowse enabled="false" /> 
```

Disable database files
```
<add name="voxmdb" verb="*" path="*.mdb" type="System.Web.HttpForbiddenHandler" />
```

Disable encrypted files
```
<add  name="voxrem" verb="*" path="*.rem" type="System.Web.HttpForbiddenHandler"/>
```

Disable files of type .csv and .asmx
```
<add  name="voxcsv" verb="*" path="*.csv" type="System.Web.HttpForbiddenHandler" />
<add  name="voxasmx" verb="*" path="*.asmx" type="System.Web.HttpForbiddenHandler"/>
```

Disables SOAP files
```
<add  name="voxsoap" verb="*" path="*.soap" type="System.Web.HttpForbiddenHandler"/>
```

Disables encoded files
```
<add  name="voxprivate" verb="*" path="*.private" type="System.Web.HttpForbiddenHandler" />
```

Remove indicates that the website is powered by ASP.NET
```
<remove name="X-Powered-By" /> 
```

Remove Server Response Header IIS10
```
<security>
    <requestFiltering removeServerHeader ="true" /> 
</security>
```

IIS 10.0 Version 1709 HTTP Strict Transport Security (HSTS) Support
```
    <system.webServer>
        <httpRedirect enabled="true" destination="https://contoso.com" httpResponseStatus="Permanent" />
        <httpProtocol>
            <customHeaders>
                <add name="Strict-Transport-Security" value="max-age=31536000" />
            </customHeaders>
        </httpProtocol>
    </system.webServer>
```

Specifies whether configuration validation is enabled when it runs in Integrated mode
```
<validation validateIntegratedModeConfiguration="false" /> 
```

Avoid click jack attack
``` 
<add name="X-FRAME-OPTIONS" value="DENY" /> 
```

Prevents the client from "sniffing" the asset to try and determine if the file type is something other than what is declared by the server
```
<add name="X-Content-Type-Options" value="nosniff" />
```

Stops pages from loading when they detect reflected cross-site scripting (XSS) attacks
```
<remove name="X-Content-Type-Options" /> 
```

Prevents XSS attacks
```
<add name="X-XSS-Protection" value="1; mode=block" />
```

Prevent the client from caching the response
```
<add name="pragma" value="no-cache" />
```

Indicates that once a resource becomes stale, caches must not use their stale copy without successful validation on the origin server.
```
<add name="Cache-Control" value="no-cache, no-store, must-revalidate" />
```





