# BookListRazor
.Net Core MVC Application to perform CRUD operation.

--> Add first nuget package Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation.
	
	Then in Startup.cs file under configuration services cange it to :
	- services.AddRazorPages().AddRazorRuntimeCompilation();
	
--> Add "Model" folder inside that add "Book" class. 

--> Add three nuget package:
	-Microsoft.EntityFramworkCore.SqlServer
	-Microsoft.EntityFramworkCore
	-Microsoft.EntityFramworkCore.Tools