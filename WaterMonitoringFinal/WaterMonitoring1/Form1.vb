Imports System.Windows.Forms

Public Class Form1
    Dim member As New DatabaseClass
    Dim setup As New SetupClass

    Dim myPort As String = ""
    Dim readData As String = ""
    Dim strArr() As String
    Dim count As Integer
    Dim tempFahrenheit As Decimal
    Dim turbVal As Decimal
    Dim phValue As Decimal
    Dim isEdit As Boolean = False
    Dim dateTimeVal As Date

    Dim tempDesc As String = ""
    Dim turbDesc As String = ""
    Dim phValDesc As String = ""

    Dim myCulture As System.Globalization.CultureInfo = Globalization.CultureInfo.CurrentCulture
    Dim dayOfWeek As DayOfWeek = myCulture.Calendar.GetDayOfWeek(Date.Today)
    Dim dayName As String = myCulture.DateTimeFormat.GetDayName(DayOfWeek)

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PortSetup()
        dateTime.Start()
        Timer1.Start()
        DGV_WaterData.AutoGenerateColumns = False
        DGV_WaterData.DataSource = member.getdata("TB_WaterMonitoring", "system_id")
    End Sub

    Sub PortSetup()

        Dim portAvailable As String() = System.IO.Ports.SerialPort.GetPortNames
        Dim portConnected As String
        For Each portConnected In portAvailable
            myPort = portConnected
        Next
        Try
            With SerialPort1
                .PortName = myPort
                .BaudRate = 9600
                .Parity = IO.Ports.Parity.None
                .DataBits = 8
                .StopBits = IO.Ports.StopBits.One
                .Handshake = IO.Ports.Handshake.None
                .RtsEnable = True
                .ReceivedBytesThreshold = 1
                .NewLine = vbCr
                .ReadTimeout = 1000
                .Open()
            End With

            If SerialPort1.IsOpen Then
                Me.Text = "Device Connected on: " & myPort
            End If
        Catch ex As Exception
            Me.Text = "No Device Found"
            MsgBox(ex.ToString)
        End Try

    End Sub

    Sub Monitoring()
        readData = SerialPort1.ReadExisting()

        If readData <> "" Then

            If readData.Chars(0) = "X" Then
                splitString(readData)
            End If
        End If

    End Sub

    Sub splitString(ByVal dataSplit As String)
        strArr = dataSplit.Split(";")

        Try
            tempFahrenheit = Decimal.Parse(strArr(1))
            turbVal = Decimal.Parse(strArr(2))
            phValue = Decimal.Parse(strArr(3))
            With member

                .clearItems()
                .setColumn("temp_read")
                .setColumn("phlev_read")
                .setColumn("turb_read")
                .setColumn("temp_desc")
                .setColumn("phlev_desc")
                .setColumn("turb_desc")
                .setColumn("date_read")
                .setColumn("is_clean")

                .setValues(tempFahrenheit)
                .setValues(phValue)
                .setValues(turbVal)
                .setValues(getTempDesc(tempFahrenheit))
                .setValues(getPHvalDesc(phValue))
                .setValues(getTurbDsc(turbVal))
                .setValues(dateTimeVal)

                If phValue < 7 Or turbVal < 2.5 Then
                    .setValues(0)
                Else
                    .setValues(1)
                End If

                .AddRecord("TB_WaterMonitoring")

            End With

            DGV_WaterData.DataSource = member.getdata("TB_WaterMonitoring", "system_id")

        Catch ex As Exception
            ' MsgBox(ex.ToString)
            'Console.WriteLine(ex)
        End Try

    End Sub

    Function getTempDesc(ByVal tempVal As Decimal) As String

        Dim tempValDesc As String = ""

        If tempVal < 26 Then
            tempValDesc = "LOW"
        ElseIf tempVal >= 26 And tempVal <= 32 Then
            tempValDesc = "NORMAL"
        ElseIf tempVal >= 33 Then
            tempValDesc = "HIGH"
        End If

        Return tempValDesc
    End Function

    Function getTurbDsc(ByVal turbVal As Decimal) As String

        Dim turbValDesc As String = ""
        If turbVal < 2.5 Then
            turbValDesc = "HIGH TURBIDITY"
        ElseIf turbVal >= 2.5 Then
            turbValDesc = "LOW TURBIDITY"
        End If



        Return turbValDesc
    End Function

    Function getPHvalDesc(ByVal phLevVal As Decimal) As String

        Dim phLevDesc As String = ""

        If phLevVal > 7 Then
            phLevDesc = "ALKALINE"
        ElseIf phLevVal = 7 Then
            phLevDesc = "NEUTRAL"
        ElseIf phLevVal < 7 Then
            phLevDesc = "ACIDIC"
        End If

        Return phLevDesc
    End Function


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Monitoring()
    End Sub


    Private Sub dateTime_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles DateTime.Tick

        ' txtDateTime.Text = Date.Now.ToString("MMMM dd,yyyy ") & Date.Now.ToString("HH:mm:ss")
        dateTimeVal = Date.Now.ToString("MMMM dd,yyyy HH:mm:ss")

        Label1.Text = dateTimeVal & " " & dayName
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        printForm.ShowDialog()

    End Sub


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub DGV_WaterData_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_WaterData.CellContentClick

    End Sub
End Class