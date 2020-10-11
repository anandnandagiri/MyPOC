GET
	http://localhost:9000/api/Product/GetProducts
	
	User-Agent: Fiddler
	Host: localhost:9000

	
	
POST

	http://localhost:9000/api/Product/AddProduct

	User-Agent: Fiddler
	Host: localhost:9000
	Content-Type: application/json
	Content-Length: 84
	
	{"ProductID":2,"ProductName":"TEST1","UnitPrice":10.0,"CategoryID":1,"SupplierID":1}
	
	
	
Bearer Token

	Step 1:	Get Bearer Token
			POST 

			http://localhost:50122/token HTTP/1.1
			
			User-Agent: Fiddler
			Host: localhost:50122
			Content-Type: application/x-www-form-urlencoded

			grant_type=password&username=anand&password=anandpassword
			
	Step 2:	Get Values
			GET
			
			http://localhost:50122/api/values HTTP/1.1
			
			User-Agent: Fiddler
			Host: localhost:50122
			Content-Type: application/json
			Authorization: bearer cSx0My_lLAR9fFJlIfy_QqMqpTlSCGg3wShEhC9ZEwC_adNGBec04CGauWled8gqYJp7tuz4iJ46lE_ODYBuSlztDutMXG-QLdKDJp4eJnhgCJ31ZyFz3DNFiosM0ZBmFJa1hQOrQGXA1eB4Igh4FbfLhYoXcO4o5VjFcP1Od9XV5YB50HLLcR_mX2J8UWMBLiyPYJiJgbyc4nPcLMb1AuB3c3JwFCQT6j8A8DWwjjg
			Content-Length: 57
	
	
Identity Server
	http://localhost:9001/.well-known/openid-configuration

	POST http://localhost:9001/connect/token HTTP/1.1
	Host: localhost:9001
	Connection: keep-alive
	Content-Length: 108
	User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/62.0.3202.94 Safari/537.36
	Cache-Control: no-cache
	Origin: chrome-extension://fhbjgbiflinjbdggehcddcbncdddomop
	Postman-Token: 552ea60e-0ca7-5f5c-c302-af62b95544e1
	Content-Type: application/x-www-form-urlencoded
	Accept: */*
	Accept-Encoding: gzip, deflate, br
	Accept-Language: en-US,en;q=0.9,fr-FR;q=0.8,fr;q=0.7,vi-VN;q=0.6,vi;q=0.5,en-IN;q=0.4

	grant_type=password&client_id=Next.AngularJS&client_secret=1KoOpICR4TNW&username=test&password=testss	
		
	
	
