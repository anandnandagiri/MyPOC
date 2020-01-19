from dto.clsQuestion import clsQuestion
import lib.libcommon as cmn

#NOTE: This will Load Only Once And Used for Rest of the Application Life Cycle Process
myJson = cmn.getJson()

def getQuestions():
	return myJson

def getQuestion(node):
    return myJson['Questions'][node] 

def getclsQuestion(node):
	question = getQuestion(node)
	return clsQuestion(node,question['Title'],question['Type'],question['Answer'],question['Node'],question['Branch'],question['Script'])

def getFirstQuestion():
	return getclsQuestion("G0").QNode[0]

def getNextQuestion(node,inputval):
	question = getclsQuestion(node)
	return question.QNode[inputval]

def getBeginTitle():
    return getclsQuestion("G0").QTitle

def getEndTitle():
    return getclsQuestion("G10").QTitle

def getBranchNodes(node):
	return getclsQuestion(node).QBranch


