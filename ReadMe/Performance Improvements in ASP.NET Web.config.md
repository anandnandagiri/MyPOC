* #### Cache Specific Static Files and Directories on IIS
```
<configuration>
...
  <location path="favicon.ico">
    <system.webServer>
      <staticContent>
        <clientCache cacheControlCustom="public" cacheControlMode="UseMaxAge" cacheControlMaxAge="365.00:00:00" />
      </staticContent>
    </system.webServer>
  </location>
  <location path="js">
    <system.webServer>
      <staticContent>
        <clientCache cacheControlCustom="public" cacheControlMode="UseMaxAge" cacheControlMaxAge="60.00:00:00" />
      </staticContent>
    </system.webServer>
  </location>
  <location path="images">
    <system.webServer>
      <staticContent>
        <clientCache cacheControlCustom="public" cacheControlMode="UseMaxAge" cacheControlMaxAge="30.00:00:00" />
      </staticContent>
    </system.webServer>
  </location>
</configuration>
```
