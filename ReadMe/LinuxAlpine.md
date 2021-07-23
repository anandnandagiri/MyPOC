#### Important Install Packages
```
apk add --no-cache wkhtmltopdf
```

#### In Docker file you can use
```
RUN apk --no-cache update \
    && apk --no-cache upgrade \
    && apk add --no-cache wkhtmltopdf
```
