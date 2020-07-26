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
<remove name="X-Content-Type-Options" />
<add name="X-Content-Type-Options" value="nosniff" />
```

Prevents XSS attacks
```
<add name="X-XSS-Protection" value="1; mode=block" />
```

There are enhancements added to request validation starting with ASP.NET 4.5 that include deferred ("lazy") validation, the ability to opt-out at the server control level, and the ability to access unvalidated data. In order to leverage these enhancements you will need to ensure that requestValidationMode has been set to "4.5" in web.config:
```
<httpRuntime requestValidationMode="4.5" targetFramework="4.5" />
```

Starting with ASP.NET 4.5 you can disable request validation at the individual server control level by setting ValidateRequestMode to “Disabled”.
```
<@ Page ValidateRequest="false" %>
<asp:TextBox ID="txtASPNet" ValidateRequestMode="Disabled" runat="server" />
```
Prevent the client from caching the response
```
<add name="pragma" value="no-cache" />
```

Indicates that once a resource becomes stale, caches must not use their stale copy without successful validation on the origin server.
```
<add name="Cache-Control" value="no-cache, no-store, must-revalidate" />
```

Time Out, also play other way security
```
<sessionState timeout="15" mode="InProc"></sessionState> //In Minutes
<httpRuntime executionTimeout="90" enableVersionHeader="false" /> //In Seconds
```



