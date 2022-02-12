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

the second one wasn't working. 
