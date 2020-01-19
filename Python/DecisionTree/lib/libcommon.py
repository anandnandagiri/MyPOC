from colorama import Fore, Back, Style
from dto.clsQuestion import clsQuestion
import lib.libglobalvariables as gv
import lib.libEnv as env
import json

#TODO Need Implement Json Validation as mentioned in Todo.txt
def validateJson():
	questions = getJson()['Questions']
	i=1
	while i<=5:
		goto = "G%d"%i
		print(goto)
		question = questions[goto] 
		c = clsQuestion(goto,question['Title'],question['Type'],question['Answer'],question['Node'],question['Branch'],question['Script'])
		c.cPrint()
		i=i+1

def getJson():
	with open(gv.DT_JSON_FILE) as f:
		data = json.load(f)
	return data

def getJson_variable():
	#Anand
	#json.dumps convert to string
	#json.loads convert to dict
	#data = json.loads('{"lat":444, "lon":555}')
	#print(data['lat'])
	return json.loads(json.dumps(gv.DT_JSON_VARIABLE))	

def InputYN(msg):
	inputval = input(" " + msg + " (Y/N) : ").lower()
	retval = 0
	while True:
		if(inputval =='y'):
			retval = 1
			break
		if(inputval=='n'):
			break
		inputval = input(" Please press (Y/N)").lower()
	#print(retval)
	return retval


def greeting(name):
	print("Hello, " + name)
	
def clearscreen():
	env.clear_screen()

def about():
	#TODO ValidateJson Need Rewrite AS Per JSON
	#validateJson() #NOTE: Uncomment This Statement Once Done With Project
	newline()	
	starline()
	print(Fore.LIGHTGREEN_EX)  
	for x in gv.DT_ABOUT:
		print( " "  + x + " : " + gv.DT_ABOUT[x])	  
	#for x, y in gv.DT_ABOUT.items():
	#	print("  " + x + " : " + y)	
	print(Style.RESET_ALL)
	starline()
	  

def cPrint(myobj):
	print(type(myobj),myobj)

def newline():
	print("")

def starline():
	print("********************************************")
	
def readdtjson():	
	file = open(gv.DT_JSON_FILE, "r")
	f = file.read()
	return json.loads(json.dumps(f))

def readdtjson_old():
	file = open(gv.DT_JSON_FILE, "r")
	f = file.read()	
	return json.dumps(" ".join(f.split()).replace("\\",""))