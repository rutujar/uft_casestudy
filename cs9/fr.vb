WpfWindow("HPE MyFlight Sample Applicatio").WpfComboBox("fromCity").Select "Paris"
WpfWindow("HPE MyFlight Sample Applicatio").WpfComboBox("toCity").Select "Los Angeles"
WpfWindow("HPE MyFlight Sample Applicatio").WpfImage("WpfImage").Click 5,12
WpfWindow("HPE MyFlight Sample Applicatio").WpfCalendar("Su").SetDate DataTable("p_Date", dtLocalSheet)
WpfWindow("HPE MyFlight Sample Applicatio").WpfComboBox("Class").Select "Business"
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("FIND FLIGHTS").Click
WpfWindow("HPE MyFlight Sample Applicatio").WpfTable("flightsDataGrid").SelectCell 0,0
N=WpfWindow("HPE MyFlight Sample Applicatio").WpfTable("flightsDataGrid").RowCount
DataTable.Value("no_flights","flight reservation")=N
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("BACK").Click
