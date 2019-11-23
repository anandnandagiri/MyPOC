Note: Install MongoDB in C:\mongodb\  Instead of <<programfiles>> path
URL to Download: 

List of Below Commands Need to execute after Installing
-------------------------------------------------------
1.	Create Folder 
		1. c:\mongodb\data\db
		2. c:\mongodb\log\

2.	Create DBPath and Log. Run MongoDB Services
		Run cmd (Run AS Adminstrator) 
		cd c:\mongodb\bin
		mongod --directoryperdb -dbpath c:\mongodb\data\db --logpath c:\mongodb\log\mongo.log --logappend --rest --install
		net start MongoDB
3. 	Create DB, Collection & User
	Run Mongo
	show dbs
	use DBProduct
	db.createCollection('tblProduct');

	db.createUser(
	   {
		 user: "Anand",
		 pwd: "Pavan123",
		 roles: [ "readWrite", "dbAdmin" ]
	   }
	);

4.	Run Instert Query to Verify
	db.createCollection('tblProducts');
	db.tblProducts.insert({ProductName:"test",UnitPrice:100,CategoryID:1,SupplierID:1,_id:1});
	db.tblProducts.find().pretty();

db.tblProducts.drop();
db.tblProducts.remove({ProductName:"test",UnitPrice:100,CategoryID:1,SupplierID:1,ProductID:1});


List Commands
--------------------
use <<Your DBName>>
show dbs
db

collection
	db.getCollectionNames();
	
	
users
	db.getUsers();
	db.dropAllUsers();

	

Key Highlights
--------------------------------
Loosely Coupled between Assembly references
Implement repository pattern using entity framework
Self Host Web API Based On Microservice Architecture
Took full advantage of TASK Library in .NET 4.5


Tools to Implement Minification



DROP TABLE tblProducts
CREATE TABLE [dbo].[tblProducts](
	[_id] [int] NOT NULL,
	[ProductName] [varchar](50) NOT NULL,
	[UnitPrice] [DECIMAL] NOT NULL,
	[CategoryID] [int] NOT NULL,
	[SupplierID] [int] NOT NULL
) 

INSERT INTO tblProducts vALUES (1,'TEST',9.99,1,1) 