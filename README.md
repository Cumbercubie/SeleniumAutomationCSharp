# SeleniumAutomationCSharp
[UNI PROJECT] A CSharp project uses Selenium to Automate the crawling progress from Jomashop

# SETUP VSCODE

*1. Prerequisite<sup>[1]</sup>*
  -Install Visual Studio Code.
  -Install the .NET Core SDK.
  
 *2.Extensions*
  - NuGet Package Manager
 
 *3.Instructrion*
  - After installing NuGet, press ```Ctrl+Shift+P``` to open command. Type
      > Nuget Package Manager: Add Package
  - Find Selenium > Hit Enter > Choose Selenium.WebDriver > Choose Version ```3.141.0```.
  - Find Selenium > Hit Enter > Choose Selenium.ChromeDriver > Choose Newest Version ```81.0..```.
 
 You should see the chromedriver.exe in your folder. Your folder may look like this: 
 
<pre><code>├───bin<br/>
│     └───Debug<br/>
│       └───netcoreapp2.1<br/>
|         |─── chromedriver.exe<br/>
└───obj<br/>
    └───Debug<br/>
        └───netcoreapp2.1<br/>
 </code><pre>
