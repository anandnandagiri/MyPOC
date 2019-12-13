#Build Angular With NodeJS
FROM node:alpine as build-stage
WORKDIR /app
COPY package*.json /app/
RUN npm install
COPY ./ /app/
ARG configuration=production
RUN npm run build -- --output-path=./dist/out --configuration $configuration

#Copy Build Angular To Nginx alpine Image
FROM nginx:alpine
COPY --from=build-stage /app/dist/out/ /usr/share/nginx/html
COPY --from=build-stage /app/nginx.conf /etc/nginx/nginx.conf
