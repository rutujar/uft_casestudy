WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("agentName").Set "john"
WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("password").SetSecure "5d7f11b3fbbf93c31d35"
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("OK").Click
WpfWindow("HPE MyFlight Sample Applicatio").WpfComboBox("fromCity").Select "San Francisco"
WpfWindow("HPE MyFlight Sample Applicatio").WpfComboBox("toCity").Select "Los Angeles"
WpfWindow("HPE MyFlight Sample Applicatio").WpfComboBox("numOfTickets").Select "3"

WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("FIND FLIGHTS").Click
WpfWindow("HPE MyFlight Sample Applicatio").WpfTable("flightsDataGrid").SelectCell 3,0
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("SELECT FLIGHT").Click
WpfWindow("HPE MyFlight Sample Applicatio").WpfObject("$167.20").Click 23,9
WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("passengerName").Set "r"
WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("passengerName").Set "rutuja"
WpfWindow("HPE MyFlight Sample Applicatio").WpfObject("$167.20").Click 25,16
WpfWindow("HPE MyFlight Sample Applicatio").WpfObject("$367.20").Click 15,21
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("ORDER").Click
WpfWindow("HPE MyFlight Sample Applicatio").Close
