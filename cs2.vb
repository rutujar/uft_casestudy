Browser("Home").Page("Home").Link("SignIn").Click
Browser("Home").Page("Login").WebEdit("userName").Set "Lalitha"
Browser("Home").Page("Login").WebEdit("password").SetSecure "5d7b45b1b565c31118b3bc18b8f514e128f8df633b8b3dc38fa58179"
If Browser("Home").Page("Login").WebButton("Login").Exist Then
Browser("Home").Page("Login").WebButton("Login").Click
Reporter.ReportEvent micPass,"Login button","succesfully"
else
Reporter.ReportEvent micFail,"login button","unsuccessfully"
End If
If Browser("Home").Page("Home").Link("SignOut").Exist(5) Then
Reporter.ReportEvent micPass,"sign out","succesfully"
else
Reporter.ReportEvent micFail,"sign out","unsuccessfully"
End If
