Prerequisite: 
	Install Python 3.4 or above
	execute command pip install colorama

Notes:
1.  In JSON File all Fields such as Title,Type,Node,Branch,Answer,Script 
    Should be specified with values and exact field name as mentioned below
        Title                   : String
        Type                    : Integer
        Answer/Node/Branch      : String List
        Script                  : String

2.  In JSON File, If Node Type 1 (Y/N)  then "NO Should Be Defined First in Node String List Values". 
    This Logic is implemented in libcommon InputYN  

3.  Predefined Node JSON values
        G0                      : Starting Point Of Tree
        G10                     : Stop Point of Tree/Branch/Node Flow
        YTI(Yet To Implement)   : This will help us to show we user yet to implement the logic 

4.  Node Types		
        "0": "Start Questions",
        "1": "Yes/No",
        "2": "Multiple Option",
        "3": "Input Text",
        "4": "Message On Console",
        "5": "Branch",
        "9": "GCP Script",
        "10": "End Questions"

5.  Validation Node Type Rules
        1. if Type=1 (Y/N) then there should be 2 Node
        2. if Type=2 (Multiple Option) then only Answers shoud have 1 or more values
        3. if Type=4 (Message On Console) then there should be 1 Node Option that should be G10
        4. if Type=5 (Branch) This Logic is same as Type 1 But not need to specify Y in Branch. 
                Where You need specify next branch questions root node
        5. if Type=9 (Script)
        6. Validate Node GOTO Travel Thru All Nodes/Branches to make sure no exception at run time



Todo:
1.   Implement First Question With Out Hard Code
10.  Implement JSON Schem for validating JSON