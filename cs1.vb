Browser("Welcome: Mercury Tours").Page("Home").Link("SignIn").Click
Browser("Welcome: Mercury Tours").Page("Login").WebEdit("userName").Set "Lalitha"
Browser("Welcome: Mercury Tours").Page("Login").WebEdit("password").SetSecure "5d7b3b87f116f99806446bb0eb919d266f435ee9ab8792fd59e4a814"
Browser("Welcome: Mercury Tours").Page("Login").WebButton("Login").Click
Browser("Welcome: Mercury Tours").Page("Home").Link("SignOut").Click
If Browser("Welcome: Mercury Tours").Page("Home").Link("SignIn").Exist(10) Then
Browser("Welcome: Mercury Tours").CloseAllTabs
else
Reporter.ReportEvent micFail, "home page", "home page does not exists"
End If
