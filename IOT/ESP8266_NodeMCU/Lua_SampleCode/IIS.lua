tping=5
vpin = 4
gpio.mode(vpin,gpio.OUTPUT)
val = gpio.read( vpin)
srv=net.createServer(net.TCP) 
srv:listen(80,function(conn) 

	conn:on("connection",function(conn,payload)
		print("Connection Established...")
		print("....")
	end)

	conn:on("reconnection",function(conn,payload)
		print("reconnection Established...")
		print("....")
	end)
	
	conn:on("disconnection",function(conn,payload)
		print("Disconnected...")
		print("....")
	end)

	conn:on("receive",function(conn,payload) 

		-- GET /set?v=1 HTTP/1.1 --
		vCmd= string.sub(payload, 6,8)
		if vCmd =="set" then
			print("Detected Set is ...")
			vStatus =string.sub(payload, 12,12)
			if vStatus =="1" then
				print("Anand Led is on")
				gpio.write(vpin,gpio.HIGH)     
			else
				print("Anand Led is off")
				gpio.write(vpin,gpio.LOW) 
			end
		end	
		
		--Read Status of GPIO Pin
		vReadStatus = gpio.read(vpin)

		vSend = "LED Status : " ..tostring(vReadStatus)		
		print(vSend)  
		print("....")
		print(payload)
		
		conn:send(vSend)
		print("....")
	end) 
	
	conn:on("sent",function(conn)		
		print("Closing Connection...")
		conn:close()
		print("...")
	end)
end)