from colorama import Fore, Back, Style
import lib.libcommon as cmn
import lib.libquestions as que
import json

questions = que.getQuestions()

myinput =[""]
gcpScript = [""]
Branch =[]
inputval=0

def about():
	cmn.about()

def Begin():
	cmn.newline()	
	print(que.getBeginTitle())
	cmn.newline()
	#ab.newline()

def End():
	cmn.newline()	
	print(que.getEndTitle())
	cmn.newline()

def decisionTree_result():	
	if(len(gcpScript)>1):	
		print()
		print(" Decision Tree Application Suggestion as mentioned below")	
		i=0
		while i<len(gcpScript):
			print(Fore.GREEN + gcpScript[i])
			i=i+1
		print(Style.RESET_ALL)


def execute_tree():
	node = que.getFirstQuestion() #Note: Get First Question From JSON FILE
	while True:
        #c=dt.getclsQuestion("G%d"%j)   
		c=que.getclsQuestion(node)
        #print("") 
		inputval = 0 #Making sure inputval is set in loop
        #1. Yes Or No Input Option
		if c.QType == 1:  
			inputval = cmn.InputYN(c.QTitle)
			myinput.append(inputval)
		#2. Multiple Select Option
		if c.QType == 2:
			print(" " + c.QTitle)
			lp=0
			while lp<len(c.QAnswer):
				print( "  " + c.QAnswer[lp])
				lp=lp+1
			print("")
			inputvalue = input("Select the Option: ")
			myinput.append(str(inputvalue))
		#3. Input Option
		#TODO Implement Logic For Multiple Options
		if c.QType == 3:
			print(" " + c.QTitle)
			#inputval = input("")
			#myinput.append(inputval) 
		#Message On Console
		if c.QType ==4:
			print(Fore.LIGHTRED_EX)
			print(" " + c.QTitle)  
			print(Style.RESET_ALL)     
		#5. Branch Logic Implementation
		if c.QType == 5:
			inputval = cmn.InputYN(c.QTitle)
			myinput.append(inputval)
			if inputval == 1: #NOTE: Allow incase of Yes
				branch = que.getBranchNodes(node)
				lp=0
				while lp<len(branch):
					Branch.append(branch[lp])
					lp=lp+1    
			#print(Branch)
		#9. GCP Script
		if c.QType == 9:
			gcpScript.append("    " + c.QTitle)
			inputval=0
		#10. End Decision Tree
		if c.QType == 10:
			#print("End Decision Tree")
			#print(Branch)
			if(len(Branch)>0):
				node = Branch[0]
				Branch.remove(Branch[0])                
				inputval=0
				#print(branch)
			else:
				break   

		if c.QType != 10:
			#print(node)
			node = que.getNextQuestion(node,inputval)
			#print(node)

def dtValidateJson():
	cmn.validateJson()

def dtPrint(myobj):
	print(type(myobj),myobj)

def dtLogQuestion():
	i=1
	while i<=5:
		print("G%d"%i )
		clsq = que.getclsQuestion("G%d"%i )
		dtPrint(clsq.QTitle)
		dtPrint(clsq.QType)
		dtPrint(clsq.QNode)
		dtPrint(clsq.QScript)
		i= i+1
