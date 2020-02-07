WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("agentName").Set "john"
WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("password").SetSecure "5d7b74eda6267cc98570"
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("OK").Click
WpfWindow("HPE MyFlight Sample Applicatio").WpfComboBox("fromCity").Select "Frankfurt"
WpfWindow("HPE MyFlight Sample Applicatio").WpfComboBox("toCity").Select "San Francisco"
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("FIND FLIGHTS").Click
WpfWindow("HPE MyFlight Sample Applicatio").WpfTable("flightsDataGrid").SelectCell 4,0
a=WpfWindow("HPE MyFlight Sample Applicatio").WpfTable("flightsDataGrid").RowCount
c="12562 AF"
y=1
For i = 0 To a-1 Step 1
WpfWindow("HPE MyFlight Sample Applicatio").WpfTable("flightsDataGrid").SelectCell 4,0
If b=c Then
 y=y+1
End If
Next
If y=1 Then
msgbox "nt found"
else
msgbox "found"
End If
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("SELECT FLIGHT").Click
WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("passengerName").Set "rutuja"
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("ORDER").Click
WpfWindow("HPE MyFlight Sample Applicatio").Close
