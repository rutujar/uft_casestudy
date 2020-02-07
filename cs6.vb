WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("agentName").Set "john"
WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("password").SetSecure "5d7f01e8705412a4a897"
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("OK").Click
WpfWindow("HPE MyFlight Sample Applicatio").WpfComboBox("fromCity").Select "Paris"
a=WpfWindow("HPE MyFlight Sample Applicatio").WpfComboBox("fromCity").GetROProperty("text")
WpfWindow("HPE MyFlight Sample Applicatio").WpfComboBox("toCity").Select "Denver"
b=WpfWindow("HPE MyFlight Sample Applicatio").WpfComboBox("toCity").GetROProperty("text")
WpfWindow("HPE MyFlight Sample Applicatio").WpfCalendar("datePicker").SetDate "19-Sep-2019"
WpfWindow("HPE MyFlight Sample Applicatio").WpfComboBox("Class").Select "Business"
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("FIND FLIGHTS").Click
WpfWindow("HPE MyFlight Sample Applicatio").WpfObject("From: Paris").DblClick 22,5
WpfWindow("HPE MyFlight Sample Applicatio").WpfObject("To: Denver").Click 7,13
c=WpfWindow("HPE MyFlight Sample Applicatio").WpfObject("From: Paris").GetROProperty("text")
d=WpfWindow("HPE MyFlight Sample Applicatio").WpfObject("To: Denver").GetROProperty("text")
If InStr (c,a) Then
If InStr (d,b) Then
 msgbox "correct"
 else
 msgbox "incorrect"
End If
End If
WpfWindow("HPE MyFlight Sample Applicatio").WpfTable("flightsDataGrid").SelectCell 3,2
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("SELECT FLIGHT").Click
WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("passengerName").Set "rutuja"
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("ORDER").Click
WpfWindow("HPE MyFlight Sample Applicatio").Close
