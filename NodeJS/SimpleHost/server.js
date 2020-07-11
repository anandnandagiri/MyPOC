var http = require("http");
var os = require("os");
os.hostname();
var server = http.createServer(function(request, response) {

	function TableBegin()
	{ 
		response.write("<br/><table>");
	};
	function TableHead(headData)
	{
		response.write("<th>" + headData + "</th>");
	}
	function TableData(colHead,colData)
	{
		response.write("<tr><td>" +colHead+ "</td>" + "<td>" + colData + "</td></tr>");
	};
	function TableFoot(headData)
	{
		response.write("<tr></tr><th>" + headData + "</th>");
	}
	function TableEnd()
	{
		response.write("</table><br/>");
	};	
	
	response.writeHead(200, {"Content-Type": "text/html"});	
	TableBegin();
	TableHead("OS Details:");
	TableData("Host Name",os.hostname());
	TableData("Type: ", os.type()); 
	TableData("Architecture: " , os.arch());
	TableData("Platform: " , os.platform());
	TableData("Release " , os.release());
	TableData("CPU Model: " , os.cpus()[0].model);  
	TableData("CPU Speed: " , os.cpus()[0].speed ); 
	TableData("Total Memory: " , os.totalmem()/(1024*1024) + " MB"); 
	TableData("Free Memory: " , os.freemem()/(1024*1024) + " MB");
	TableFoot((new Date(Date.now())).toString() );	
	TableEnd();
	response.end();
});

server.listen(8080);
console.log("Server is listening....");