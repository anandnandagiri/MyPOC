DT_ABOUT = {
"AppName     " : "Decision Tree Application",
"AppType     " : "Library",
"Version     " : "1.0",
"Author      " : "Anand",
"Email       " : "pavan.anand.n@gmail.com",
"Powered By  " : "Python"
}

DT_JSON_FILE = "./json/decisiontree.json"

DT_JSON_VARIABLE = {
"Questions" : {
		"G0":{
			"Title" : "",
			"Type" : 0,
			"Node" :["G1"],	
			"Script" : ""	
		},
		"G1":{
				"Title" : "Do You Migrate To Public Cloud(Y/N)",
				"Type" : 1,
				"Node" :["G2","G1000"],
				"Script" : ""
			},
		"G2":{
				"Title" : "Do You Want Below GCP Services Created",
				"Type" : 2,
				"Answer" : ["1. Create VM","2. Create APP Engine","3. Create Kubernete Engine"],
				"Node" :["G3","G4","G5"],
				"Script" : ""
			},
		"G3":{
				"Title" : "Name The VM",
				"Type" : 3,
				"Node" : ["G4"],
				"script" : "gcp script for VM {0}"				
			},
		"G4":{
				"Title" : "Name The Zone",
				"Type" : 3,
				"Node" : ["G5"],
				"script" : "zone {0}"				
			},
		"G5":{
				"Title" : "Generating Script below",
				"Type" : 5,
				"Node" : ["G5"],
				"script" : ""
			},
		"G1000":{
			"Title" : "Thank You For Using Decision Tree Application",
			"Type" : 5,
			"Node" :["",""],
			"Script" : ""	
		}
	},
	
"Type" : {
		"1" : "Y/N",
		"2" : "Option",
		"3" : "Input Text",
		"4"	: "Message On Console",
		"5" : "Start Questions",
		"6" : "End Questions"
	},
	
"About" : {
		"AppName" : "Decision Tree Application",
		"AppType" : "Library",
		"Version" : "1.0",
		"Author" : "Anand",
		"Email" : "pavan.anand.n@gmail",
		"Powered By" : "Python"
	}
}