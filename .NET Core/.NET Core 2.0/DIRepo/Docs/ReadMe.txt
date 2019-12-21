

This Project Is All About Dependency Injections in .NET Core By Layering DB/Repositories/Service

	In MyController.cs we have methods commented with Step1, Step2, Step3.
	Also refer Startup.cs which inject DB Context, Repository and Service with Add Scope

		Step 1: Direct DB call with dependency Injection
		Step 2: Repository call with dependency Injection
		Step 3: Service call with dependeny Injection


Todo
	Probably new project or can embed this below feature in this project
		AddScoped (Done: We used this functionality)
		AddTransient
		AddSingleton

		For more info https://stackoverflow.com/questions/38138100/addtransient-addscoped-and-addsingleton-services-differences







