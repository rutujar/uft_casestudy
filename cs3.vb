Browser("Home").Page("Home").Link("SignIn").Click
Browser("Home").Page("Login").WebEdit("userName").Set "Lalitha"
Browser("Home").Page("Login").WebEdit("password").SetSecure "5d7b7b5fe01f090022533cd7b73b80ab672ba072efcb5eb78dd7da2b"
Browser("Home").Page("Login").WebButton("Login").Click
