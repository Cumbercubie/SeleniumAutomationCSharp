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
 ├───bin
│   └───Debug
│       └───netcoreapp2.1
|           |─── chromedriver.exe
└───obj
    └───Debug
        └───netcoreapp2.1
        
├── app
│   ├── css
│   │   ├── **/*.css
│   ├── favicon.ico
│   ├── images
│   ├── index.html
│   ├── js
│   │   ├── **/*.js
│   └── partials/template
├── dist (or build)
├── node_modules
├── bower_components (if using bower)
├── test
├── Gruntfile.js/gulpfile.js
├── README.md
├── package.json
├── bower.json (if using bower)
└── .gitignore
