class clsQuestion:
    def __init__(self,QID, QTitle, QType,QAnswer, QNode,QBranch, QScript):
        self.QID = QID
        self.QTitle = QTitle
        self.QAnswer = QAnswer
        self.QType = QType
        self.QNode = QNode
        self.QBranch = QBranch
        self.QScript = QScript
    
    def cPrint(self):
        print(self.QID,self.QTitle,self.QAnswer, self.QType,self.QNode,self.QBranch,self.QScript)
        print(type(self.QID),type(self.QTitle),type(self.QAnswer),type(self.QType),type(self.QNode),type(self.QBranch),type(self.QScript))
        print()