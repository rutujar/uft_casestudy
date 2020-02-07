WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("agentName").Set "john"
WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("password").SetSecure "5d7b5fc62746e8ccd33a"
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("OK").Click
a=WpfWindow("HPE MyFlight Sample Applicatio").WpfComboBox("fromCity").GetItemsCount
msgbox a
b=WpfWindow("HPE MyFlight Sample Applicatio").WpfComboBox("toCity").GetItemsCount
msgbox b
c=1
For i = 0 To a-1 Step 1
WpfWindow("HPE MyFlight Sample Applicatio").WpfComboBox("fromCity").Select i
flyfrom=WpfWindow("HPE MyFlight Sample Applicatio").WpfComboBox("fromCity").GetROProperty("text")
For j = 0 To b-1 Step 1
 WpfWindow("HPE MyFlight Sample Applicatio").WpfComboBox("toCity").Select j
 flyto=WpfWindow("HPE MyFlight Sample Applicatio").WpfComboBox("toCity").GetROProperty("text")
 If flyfrom=flyto Then
  DataTable.SetCurrentRow(c)
  DataTable.Value("Fly_From","Action1")=fly_from
  DataTable.Value("Fly_to","Action1")=fly_to
  c=c+1
 End If
Next
Next
