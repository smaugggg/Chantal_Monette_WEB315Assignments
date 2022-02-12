# Chantal_Monette_WEB315Assignments
Repository for assignments for WEB315. fun. 

20220211 2110 <br>
Created initial webapp. <br>
  dotnet new webapp -o Dreamcatcher --no-https<br>
  code -r Dreamcatcher<br>
  
Verified that it ran on my system by changing the word welcome to AAHHHHHHH<br>
  dotnet run
  
It worked!

Add NuGet packages and EF tools<br>
dotnet tool install --global dotnet-ef<br>
dotnet tool install --global dotnet-aspnet-codegenerator<br>
dotnet add package Microsoft.EntityFrameworkCore.Design<br>
dotnet add package Microsoft.EntityFrameworkCore.SQLite<br>
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design<br>
dotnet add package Microsoft.EntityFrameworkCore.SqlServer<br>

the second one wasn't working. I used trusty google and everyone seemed to agree to just download a previous version. 5.0.0 worked. 

dotnet tool install --global dotnet-aspnet-codegenerator --version 5.0.0

dotnet-aspnet-codegenerator razorpage -m Member -dc DreamcatcherMembersContext -udl -outDir Pages/Members --referenceScriptLibraries -sqlite<br>
Building project ...<br>
Scaffolding failed.<br>
Add Microsoft.VisualStudio.Web.CodeGeneration.Design package to the project as a NuGet package reference.<br>
To see more information, enable tracing by setting environment variable 'codegen_trace' = 1.<br>
RunTime 00:00:06.67<br>

Failure. 

Re-added dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design

Found out that because they all failed I had to reinstall all the packages as well using version 5.0.0

dotnet tool install --global dotnet-aspnet-codegenerator --version 5.0.0<br>
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.0<br>
dotnet add package Microsoft.EntityFrameworkCore.SQLite --version 5.0.0<br>
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design--version 5.0.0<br>
dotnet add package Microsoft.EntityFrameworkCore.SqlServer--version 5.0.0<br>

Now the pages for my model were created! Success!
