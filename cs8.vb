WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("agentName").Set "john"
WpfWindow("HPE MyFlight Sample Applicatio").WpfEdit("password").SetSecure "5d7f12dfd930289fbb1c"
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("OK").Click
WpfWindow("HPE MyFlight Sample Applicatio").WpfButton("FIND FLIGHTS").Click
WpfWindow("HPE MyFlight Sample Applicatio").WpfTable("flightsDataGrid").SelectCell 1,0
a=WpfWindow("HPE MyFlight Sample Applicatio").WpfTable("flightsDataGrid").RowCount
msgbox a
count=1
For i = 0 To a-1 Step 1
b=WpfWindow("HPE MyFlight Sample Applicatio").WpfTable("flightsDataGrid").GetCellData(i,0)
c=WpfWindow("HPE MyFlight Sample Applicatio").WpfTable("flightsDataGrid").GetCellData(i,4)
DataTable.SetCurrentRow(count)
DataTable.Value("price","Action1")=b
DataTable.Value("flight_number","Action1")=c
count=count+1
Next
WpfWindow("HPE MyFlight Sample Applicatio").Close
