SET CSCPATH=%SYSTEMROOT%\Microsoft.NET\Framework\v4.0.30319
%CSCPATH%\csc /reference:bin/Newtonsoft.Json.dll /target:library /out:bin/Com.Evapi.Client.dll /recurse:src\*.cs /doc:bin/Com.Evapi.Client.xml /nowarn:1591,429
