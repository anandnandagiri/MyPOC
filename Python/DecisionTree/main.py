import lib.libcommon as cmn
import lib.libdt as dt

def main():
    cmn.clearscreen()

    dt.about() #NOTE: Make Sure You Have Uncomment This Once Done With Project
    #dt.dtLogQuestion() #NOTE: his is debug purpose
    #Below Statement will validate Json file as mentioned in Todo.txt
    #TODO NOTE: UnComment below line Once Done With Project
    #dt.dtValidateJson()

    dt.Begin()
    dt.execute_tree()
    dt.decisionTree_result()
    dt.End()

main()


#while i<len(myinput):
#    print(myinput[i])
#    i=i+1


#print(type(questions['Questions']['G0']))
#print(questions['Questions']['G0'])
#print(questions['Questions']['G2']["Node"])
#node = questions['Questions']['G0']["Node"][0]
#print(type(node),node)
#print(questions['Questions']['G3'])
#dt.getQuestion(node)
#print(questions['Questions']['G100']['Title'])
#print(questions['Questions'])
#questionItems = questions['Questions']
#print(questionItems)